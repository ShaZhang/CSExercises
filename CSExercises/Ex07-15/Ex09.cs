using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value:");
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = 2 * x * x - 4 * x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
