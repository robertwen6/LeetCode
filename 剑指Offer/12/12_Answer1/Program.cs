using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            char[][] board =
            {
                new char[] {'a'},
                new char[] {'a'}
            };
            string s = "aaa";
            Console.WriteLine(solution.Exist(board, s));
        }
    }

    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            bool isExist = false;
            bool[,] boardFilled = new bool[board.Length, board[0].Length];
            int startRow = 0;
            int startCol = 0;
            int wordIndex = 0;
            for (int i = 0; i < board.Length; i++)
            {
                startRow = i;
                for (int j = 0; j < board[i].Length; j++)
                {
                    startCol = j;
                    wordIndex = 0;
                    isExist = DFS(board, boardFilled, startRow, startCol, wordIndex, word);
                    if (isExist == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool DFS(char[][] board, bool[,] boardFilled,
            int rowIndex, int colIndex, int wordIndex, string word)
        {
            if (board[rowIndex][colIndex] != word[wordIndex])
            {
                return false;
            }
            else if (wordIndex == word.Length - 1)
            {
                return true;
            }

            boardFilled[rowIndex, colIndex] = true;
            char c = word[wordIndex];

            if (rowIndex > 0 && boardFilled[rowIndex - 1, colIndex] == false)
            {
                bool result = DFS(board, boardFilled, rowIndex - 1, colIndex, wordIndex + 1, word);
                if (result == true)
                {
                    return result;
                }
            }
            if (rowIndex < boardFilled.GetLength(0) - 1 && boardFilled[rowIndex + 1, colIndex] == false)
            {
                bool result = DFS(board, boardFilled, rowIndex + 1, colIndex, wordIndex + 1, word);
                if (result == true)
                {
                    return result;
                }
            }
            if (colIndex > 0 && boardFilled[rowIndex, colIndex - 1] == false)
            {
                bool result = DFS(board, boardFilled, rowIndex, colIndex - 1, wordIndex + 1, word);
                if (result == true)
                {
                    return result;
                }
            }
            if (colIndex < boardFilled.GetLength(1) - 1 && boardFilled[rowIndex, colIndex + 1] == false)
            {
                bool result = DFS(board, boardFilled, rowIndex, colIndex + 1, wordIndex + 1, word);
                if (result == true)
                {
                    return result;
                }
            }

            boardFilled[rowIndex, colIndex] = false;
            return false;
        }
    }
}
