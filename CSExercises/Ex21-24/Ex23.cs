
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random Secretnumber = new Random();
            int a = Secretnumber.Next(0, 10), b, step = 1;
             Console.WriteLine("Guess an integer:");
            b = Convert.ToInt32(Console.ReadLine());
            while(a!=b)
            {
                Console.WriteLine("Try again");
                b = Convert.ToInt32(Console.ReadLine());
                step++;
            }
            if (step <= 2)
                Console.WriteLine("You are a Wizard!");
            else if (2 < step && step <= 5)
                Console.WriteLine("You are a good guess");
            else if (5 < step && step <= 10)
                Console.WriteLine("You are lousy!");
            Console.ReadKey();
        }
    }
}
