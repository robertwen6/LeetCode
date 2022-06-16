using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Answer1
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
            string str = s.Replace(" ", "%20");
            return str;
        }
    }
}
