using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence/phrase:");
            string a = Convert.ToString(Console.ReadLine());
            string []b = a.Split(' ');
            string c="";
            for(int i=0;i<b.Length;i++)
            {
                string a1 = b[i];
                if(a1.Length>1)
                {
                    a1 = a1.ToUpper().Substring(0, 1) + a1.Substring(1, a1.Length - 1);
                    c = c + a1 + " ";
                }
            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
