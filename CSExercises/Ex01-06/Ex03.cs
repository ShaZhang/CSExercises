using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a double precision number:");
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x*x);
            Console.ReadKey();
        }
    }
}
