using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            double N = Convert.ToDouble(Console.ReadLine());
            Random Secretnumber= new Random();
            double G = Secretnumber.Next(1, (int)N);
            while (G*G!=N||Math.Round(G*G,5)!= N)
            { 
                G=(G + N / G) /2 ;
            }
            Console.WriteLine(G+ "is the correct number.");
            Console.ReadKey();
        }
    }
}
