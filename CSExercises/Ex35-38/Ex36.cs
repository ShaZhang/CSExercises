using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word:");
            string s = Convert.ToString(Console.ReadLine());
            int m;
            string t = s;
            for (m =s.Length-1; m >= 0 ; m--)
            {
                string r = s.Substring(m, 1);
                t = t + r;
            }
            string u = t.Substring(s.Length, s.Length);
            if (s.Equals(u))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
            Console.ReadKey();

            Console.WriteLine("Please enter a sentence");
            int k;
            string a = Convert.ToString(Console.ReadLine());
            string d = a.ToLower();
            string[] b = a.Split(' ');
            char[] e = new char[] { '.', ',' };
            string c="None";
            for (k = 0; k <= b.Length - 1; k++)
                c = c + b[k];
            int g;
            string h = c;
            for (g= c.Length - 1; g>= 0; g--)
            {
                string r = c.Substring(g, 1);
                h = h + r;
            }
            string z = h.Substring(c.Length, c.Length);
            if (c.Equals(z))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
            Console.ReadKey();
        }
    }
}
