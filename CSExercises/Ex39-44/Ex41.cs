
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input a phrase:");
            string s1 = Console.ReadLine();
            Console.WriteLine("input another phrase:");
            string s2 = Console.ReadLine();
            bool result = InString(s1, s2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static bool InString(string s1, string s2)
        {
            if (s2.Length < s1.Length)
            {
                int i;
                string s3, s4, s5;
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
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
            else if (s1.Length == s2.Length)
            {
                if (s1.Equals(s2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

