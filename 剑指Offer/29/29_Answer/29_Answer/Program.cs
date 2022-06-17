using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Answer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[] SpiralOrder(int[][] matrix)
        {
            if(matrix.Length == 0)
            {
                return (new int[0]);
            }
            List<int> list = new List<int>();
            int rowStart = 0;
            int colStart = 0;
            int rowEnd = matrix.Length - 1;
            int colEnd = matrix[0].Length - 1;
            Console.WriteLine("{0},{1},{2},{3}",rowStart, rowEnd, colStart, colEnd);

            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                for(int col = colStart; col <= colEnd; col++)
                {
                    list.Add(matrix[rowStart][col]);
                }
                for(int row = rowStart + 1; row < rowEnd; row++)
                {
                    list.Add(matrix[row][colEnd]);
                }
                if (rowStart == rowEnd) break;
                for (int col = colEnd; col >= colStart; col--)
                {
                    list.Add(matrix[rowEnd][col]);
                }
                if (colStart == colEnd) break;
                for (int row = rowEnd - 1; row > rowStart; row--)
                {
                    list.Add(matrix[row][colStart]);
                }

                rowStart++;
                rowEnd--;
                colStart++;
                colEnd--;
            }
            return list.ToArray();
        }
    }
}
