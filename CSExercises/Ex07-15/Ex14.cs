using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please give lengths of a triangle's 3 sides:");
            double a, b, c,s,A,Area;
            Console.WriteLine("Please give lengths of a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give lengths of b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give lengths of c:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c&&a + c > b&&c + b > a)
            {
                        s = (a + b + c) / 2;
                        A = s * (s - a) * (s - b) * (s - c);
                        Area = Convert.ToDouble(Math.Sqrt(A));
                        Console.WriteLine("The are is {0:0}", Area);
            }
            else
                        Console.WriteLine("This is not a triangle.");
            Console.ReadKey();




        }
    }
}