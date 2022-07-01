using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Answer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public bool VerifyPostorder(int[] postorder)
        {
            if (postorder.Length == 0)
            {
                return true;
            }

            int start, end;

            start = 0;
            end = postorder.Length - 1;
            return Judge(postorder, start, end);
        }

        public bool Judge(int[] postorder, int start, int end)
        {
            if (end - start < 2)
            {
                return true;
            }

            int leftStart, leftEnd, rightStart, rightEnd;
            int rootNum = postorder[end];

            for (int i = start; i <= end; i++)
            {
                if (i == end)
                {
                    return Judge(postorder, start, end - 1);
                }
                else if (postorder[i] > rootNum && i == start)
                {
                    for (int j = i + 1; j <= end - 1; j++)
                    {
                        if (postorder[j] < rootNum)
                        {
                            return false;
                        }
                    }
                    return Judge(postorder, start, end - 1);
                }
                else
                {
                    if (postorder[i] > rootNum)
                    {
                        for (int j = i + 1; j <= end - 1; j++)
                        {
                            if (postorder[j] < rootNum)
                            {
                                return false;
                            }
                        }
                        leftStart = start;
                        leftEnd = i - 1;
                        rightStart = i;
                        rightEnd = end - 1;
                        return Judge(postorder, leftStart, leftEnd)
                            && Judge(postorder, rightStart, rightEnd);
                    }
                }
            }

            return false;
        }
    }
}
