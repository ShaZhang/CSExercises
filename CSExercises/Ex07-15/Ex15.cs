using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a three-digit number:");
            double A,a,b,c;
            A = Convert.ToInt32(Console.ReadLine());
            if (100 <= A && A <= 999)
            {
                a = Math.Floor(A / 100);
                b = Math.Floor(A/10-a*10);
                c = A-a*100-b*10;
                if (A == a * a * a + b * b * b + c * c * c)
                    Console.WriteLine("This is an Armstrong number.");
                else
                    Console.WriteLine("This is not an Armstrong number");
            }
            else
                Console.WriteLine("This is not a three-digit numer.");
            Console.ReadKey();
        }
    }
}