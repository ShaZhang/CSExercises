using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            int a;
            for (a = 1; a <= 10; a++)
            {
                Console.WriteLine("{0} {1} {2} {3}", a, 1 / a, Math.Sqrt(a), a * a);
            }
            Console.ReadKey();
        }
    }
}
