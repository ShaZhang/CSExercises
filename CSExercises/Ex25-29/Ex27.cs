
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            int x, y;
            for (x = -5; -5 <= x && x <= 5; x++)
            {
                y = 2 * x * x - 4 * x + 3;
                Console.WriteLine("{0:0.0},{1:0.0}", x, y);
            }
            Console.ReadLine();

            int i=0;
            for (x=1; x<=5;x++)
            {
                Console.Write("{0}\t", x);
                y = 2 * x * x - 4 * x + 3;
                for(i=1;i<= y;i++)
                {
                    Console.Write("*");
                }
                Console.ReadKey();
            }
        }
    }
}
