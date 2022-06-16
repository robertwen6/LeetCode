using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public bool IsNumber(string s)
        {
            bool result = false;
            int pointCounter = 0;
            int eCounter = 0;
            int numCounter = 0;
            List<char> l = new List<char>() {'0', '1', '2', '3', '4', '5',
            '6', '7', '8', '9', '+', '-', 'e', 'E', '.', ' '};

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == '.')
                {
                    pointCounter++;
                }
                else if(s[i] == 'e' || s[i] == 'E')
                {
                    eCounter++;
                }
                else if(s[i] >= '0' && s[i] <= '9')
                {
                    numCounter++;
                }
            }
            if(numCounter == 0)
            {
                return false;
            }
            if(s[s.Length - 1] == '+' || s[s.Length - 1] == '-' ||
                s[s.Length - 1] == 'e' || s[s.Length - 1] == 'E')
            {
                return false;
            }
            if (pointCounter > 1 || eCounter > 1)
            {
                return false;
            }
            if(pointCounter == 1)
            {
                int pointIndex = s.IndexOf('.');
                bool left = false;
                bool right = false;
                if(pointIndex > 0)
                {
                    if(s[pointIndex - 1] >= '0' && s[pointIndex - 1] <= '9')
                    {
                        left = true;
                    }
                }
                if (pointIndex < s.Length - 1)
                {
                    if (s[pointIndex + 1] >= '0' && s[pointIndex + 1] <= '9')
                    {
                        right = true;
                    }
                }
                if(left == false && right == false)
                {
                    return false;
                }
            }

            int index = 0;
            MyEnum step = MyEnum.Space1;
            while (index < s.Length)
            {
                switch (step)
                {
                    case MyEnum.Space1:
                        {
                            if (s[index] == ' ')
                            {
                                step = MyEnum.Space1;
                            }
                            else if (s[index] == '+' || s[index] == '-' || s[index] == '.'
                                || (s[index] >= '0' && s[index] <= '9'))
                            {
                                step = MyEnum.Num1;
                                result = true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;
                    case MyEnum.Num1:
                        {
                            if (s[index] == '.' || (s[index] >= '0' && s[index] <= '9'))
                            {
                                step = MyEnum.Num1;
                            }
                            else if(s[index] == 'e' || s[index] == 'E')
                            {
                                if(s[index - 1] == '+' || s[index - 1] == '-')
                                {
                                    return false;
                                }
                                step = MyEnum.E;
                            }
                            else if(s[index] == ' ')
                            {
                                step = MyEnum.Space2;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;
                    case MyEnum.E:
                        {
                            if (s[index] == '+' || s[index] == '-'
                                || (s[index] >= '0' && s[index] <= '9'))
                            {
                                step = MyEnum.Num2;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;
                    case MyEnum.Num2:
                        {
                            if (s[index] >= '0' && s[index] <= '9')
                            {
                                step = MyEnum.Num2;
                            }
                            else if(s[index] == ' ')
                            {
                                step = MyEnum.Space2;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;
                    case MyEnum.Space2:
                        {
                            if (s[index] == ' ')
                            {
                                step = MyEnum.Space2;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;
                    default:
                        break;
                }
                index++;
            }
            return result;
        }

        public enum MyEnum : int
        {
            Space1,
            Num1,
            E,
            Num2,
            Space2
        }
    }
}
