using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            double Q1, Q2, Q3,amount;
            Console.WriteLine("Enter quantity for TV:");
            Q1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter quantity for DVD:");
            Q2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter quantity for MP3:");
            Q3 = Convert.ToDouble(Console.ReadLine());
            amount = 900 * Q1 + 500 * Q2 + 700 * Q3;
            if (amount >= 0)
            {
                if (0 <= amount && amount <= 5000)
                    Console.WriteLine("Total price for this order is ${0:000.00}", 900 * Q1 + 500 * Q2 + 700 * Q3);
                else if (amount < 10000 && amount > 5000)
                    Console.WriteLine("Total price for this order is ${0:000.00}", (900 * Q1 + 500 * Q2) * 0.1 + 700 * Q3);
                else if (amount >10000)
                    Console.WriteLine("Total price for this order is ${0:000.00}", (900 * Q1 + 500 * Q2) * 0.15 + 700 * Q3);
            }
            else
                Console.WriteLine("**Error**");
            Console.ReadKey();

        }
    }
}