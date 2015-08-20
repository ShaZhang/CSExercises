
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input a character1:");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input a character2:");
            char c2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input a pharse:");
            string s = Convert.ToString(Console.ReadLine());
            string y = Substitute(s, c1, c2);
            Console.WriteLine("The new word is {0}",y);
            Console.ReadKey();
        }
        public static string Substitute(string s, char c1, char c2)
        {
            string[]s1 =s.Split(c1);
            string s2;
            if (s1.Length == 1)
                s2 = "There is no "+c1+" existing in this string.";
            else
            {
                int i;string s3="";
                for(i=0;i<s.Length;i++)
                {
                    s3 = s3 + s1[i] + c2;
                }
                return s3;
            }
        }
    }
}
