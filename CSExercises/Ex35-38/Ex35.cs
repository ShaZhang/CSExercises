using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase:");
            string s = Console.ReadLine();
            int m=0,n=0;
            for (m=0; m <= s.Length-1; m++)
            {
                string r = s.Substring(m, 1);
                if (r=="a"||r=="e"||r=="i"||r=="o"||r=="u")
                    n= n + 1;
            }
            Console.WriteLine("Total number of vowel:{0}",n);
            int m1 = 0, n1 = 0;
            for (m1 = 0; m1 <= s.Length - 1; m1++)
            {
                string r = s.Substring(m1, 1);
                if (r == "a" )
                    n1 = n1 + 1;
            }
            Console.WriteLine("Number of a:{0}", n1);
            int m2 = 0, n2 = 0;
            for (m2 = 0; m2 <= s.Length - 1; m2++)
            {
                string r = s.Substring(m2, 1);
                if (r == "e")
                    n2 = n2 + 1;
            }
            Console.WriteLine("Number of e:{0}", n2);
            int m3 = 0, n3 = 0;
            for (m3 = 0; m3 <= s.Length - 1; m3++)
            {
                string r = s.Substring(m3, 1);
                if (r == "i")
                    n3 = n3 + 1;
            }
            Console.WriteLine("Number of i:{0}", n3);
            int m4 = 0, n4 = 0;
            for (m4 = 0; m4 <= s.Length - 1; m4++)
            {
                string r = s.Substring(m4, 1);
                if (r == "o")
                    n4 = n4 + 1;
            }
            Console.WriteLine("Number of o:{0}", n4);
            int m5 = 0, n5 = 0;
            for (m5 = 0; m5 <= s.Length - 1; m5++)
            {
                string r = s.Substring(m5, 1);
                if (r == "u")
                    n5 = n5 + 1;
            }
            Console.WriteLine("Number of u:{0}", n5);
            Console.ReadKey();
        }       
    }
}
