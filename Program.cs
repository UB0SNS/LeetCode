using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Linq;

namespace ConsoleApp1
{
    public class ProgramLeetcode
    {

        public class LeetcodeProblems
        {
            public char[] ReverseString(char[] s)
            {
                int lengthArr = s.Length - 1;
                char iCh;
                for (int i = lengthArr; i > (lengthArr / 2); i--)
                {
                    iCh = s[i];
                    s[i] = s[lengthArr - i];
                    s[lengthArr - i] = iCh;
                }
                return s;
                for (int i = 0; i <= (s.Length - 1); i++)
                {
                    Console.WriteLine(s[i]);
                }
                Console.WriteLine("Hello World!");
            }
            public int SingleNumber(int[] nums)
            {
                int s = 1;
                return s;
            }

            public bool IsPalindrome(string s)
            {
                //Console.WriteLine(s);
                if (s == "") return true;
                s = s.ToLower();
                //Console.WriteLine(s);
                //s = s.Replace(" ", "");
                for (int i = 0; i <= s.Length - 1; i++)
                {
                    if ((!char.IsLetterOrDigit(s, i)) || (s[i] == ' '))
                    {
                        s = s.Remove(i, 1);
                        i--;
                    }
                }
                //Console.WriteLine(s);
                for (int i = 0; i <= s.Length - 1; i++)
                {
                    if (s[i] != s[s.Length - 1 - i])
                    {
                        //Console.WriteLine("false");
                        return false;
                    }
                }
                //Console.WriteLine("true");
                return true;

                //return false;
            }

        }

        static void Main(string[] args) // tests
        {

            // char[] inputCh = new char[] { 'h', 'e', 'l', 'l', 'o', 'o' };
            LeetcodeProblems object1 = new LeetcodeProblems();
            // object1.ReverseString(inputCh);
            object1.IsPalindrome("2A man, a plan,     +++ a canal: Panama2");

            // Console.WriteLine("Hello...!");
            // for (int i = 0; i <= (inputCh.Length - 1); i++)
            // {
            //
            // }

        }
    }
}
