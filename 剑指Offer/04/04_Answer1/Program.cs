using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            if (matrix.Length == 0)
            {
                return false;
            }
            int row = 0;
            int col = matrix[0].Length - 1;
            while (true)
            {
                if (row > matrix.Length - 1)
                {
                    return false;
                }
                else if (col < 0)
                {
                    return false;
                }

                if (target == matrix[row][col])
                {
                    return true;
                }
                else if (target < matrix[row][col])
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }
        }
    }
}
