using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Answer2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public string ReplaceSpace(string s)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == ' ')
                {
                    str.Append("%20");
                }
                else
                {
                    str.Append(s[i]);
                }
            }
            return str.ToString();
        }
    }
}
