using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 4 values:");
            double x1, x2, y1, y2, A;
            Console.WriteLine("X1 is");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("X2 is");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1 is");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2 is");
            y2 = Convert.ToDouble(Console.ReadLine());
            A = (x1 - x2) * (x1 - x2) + (y2 - y1) * (y2 - y1);
            Console.WriteLine("The distance is");
            Console.WriteLine(Math.Sqrt(A));
            Console.ReadKey();
        }
    }
}
