
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input a phrase:");
            string s1 = Console.ReadLine();
            Console.WriteLine("input another phrase:");
            string s2 = Console.ReadLine();
            int position = FindWord(s1, s2);
            Console.WriteLine("The starting point is {0}",position);
            Console.ReadKey();
        }
        public static int FindWord(string s1, string s2)
        {
            if (s2.Length < s1.Length)
            {
                int i;
                string s3, s4, s5;
                int k= 0;
                for (i = 0; i < s1.Length; i++) 
                { 
                    s3 = s2.Substring(0, 1); 
                    s4 = s1.Substring(i, 1); 
                    if (s3.Equals(s4))
                    {
                        if (s1.Length - i >= s2.Length)
                        {
                            s5 = s1.Substring(i, s2.Length);
                            if (s5.Equals(s2))
                            {
                                k = i;
                                return k;
                            }
                            else
                            {
                                k = -1;
                                return k;
                            }
                        }
                        else
                        {
                            k = -1;
                            return k;
                        }
                    }
                }
                k= -1;
                return k;
            }
            else if (s1.Length == s2.Length)
            {
                int p;
                if (s1.Equals(s2))
                {
                    p = 0;
                    return p;
                }
                else
                {
                    p = -1;
                    return p;
                }
            }
            else
            {
                int x;
                x = -1;
                return x;
            }
        }
    }
  }
