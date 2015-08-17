using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the marks (interger):");
            int Marks;
            Marks = Convert.ToInt32(Console.ReadLine());
            if (0 <= Marks && Marks <=100)
            {
                if (0 <= Marks && Marks <= 40)
                    Console.WriteLine("Your scored {0:#0} " + Marks + " which is F grade.", Marks);
                else if (40 < Marks && Marks <= 59)
                    Console.WriteLine("Your scored {0:#0} " + Marks + " which is C grade.", Marks);
                else if (60 <= Marks && Marks <= 79)
                    Console.WriteLine("Your scored {0:#0} " + Marks + " which is B grade.", Marks);
                else if (80 <= Marks && Marks <= 100)
                    Console.WriteLine("Your scored {0:#0} " + Marks + " which is A grade.", Marks);
            }
            else
                Console.WriteLine("**Error**");
            Console.ReadKey();
        }
    }
}