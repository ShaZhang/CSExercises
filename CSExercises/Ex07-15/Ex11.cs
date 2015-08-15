using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a distane:");
            double x, Fare;
            x = Convert.ToDouble(Console.ReadLine());
            Fare = 2.4 + 3.2 * x;
            Console.WriteLine("The total fare is {0:c}", Fare);
            Console.ReadKey();
        }
    }
}
