using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int a = 1;
            for (a = 1; 1 <= a && a <= 1000; a++)
            {
                int i = 1, d = 0;
                for (i = 1; i <= a / 2; i++)
                {
                    if (a % i == 0)
                        d = d + i;
                }
                if (d == a)
                    Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
