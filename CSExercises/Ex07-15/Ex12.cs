using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a distane:");
            double x, Fare;
            x = Convert.ToDouble(Console.ReadLine());
            Fare = 2.4 + 3.2 * x;
            Math.Round(Fare, 1);
            Console.WriteLine("The total fare is {0:c}", Fare);
            Console.ReadKey();
        }
    }
}
