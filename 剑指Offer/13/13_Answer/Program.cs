using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int Counter { get; set; }
        Queue<Position> q = new Queue<Position>();

        public int MovingCount(int m, int n, int k)
        {
            bool[,] isFilled = new bool[m, n];
            Position position = new Position();
            position.X = 0;
            position.Y = 0;
            q.Enqueue(position);
            BFS(k, isFilled, m, n);
            return Counter;
        }

        public void BFS(int k, bool[,] isFilled, int m, int n)
        {
            while(q.Count() > 0)
            {
                Position position = new Position();
                position = q.Dequeue();
                int x = position.X;
                int y = position.Y;
                int xSum = x % 10 + (x / 10) % 10 + x / 100;
                int ySum = y % 10 + (y / 10) % 10 + y / 100;
                if (xSum + ySum > k || isFilled[x, y] == true)
                {
                    continue;
                }
                else
                {
                    isFilled[x, y] = true;
                    Counter++;

                    if(x + 1 < m)
                    {
                        Position positionRight = new Position();
                        positionRight.X = x + 1;
                        positionRight.Y = y;
                        q.Enqueue(positionRight);
                    }
                    if(y + 1 < n)
                    {
                        Position positionDown = new Position();
                        positionDown.X = x;
                        positionDown.Y = y + 1;
                        q.Enqueue(positionDown);
                    }
                }
            }
        }
    }

    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
