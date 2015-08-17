using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string Name;
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter your gender using M or F:");
            string Gender;
            Gender = Convert.ToString(Console.ReadLine());
            if (Gender == "F")
                Console.WriteLine("Good Morning Ms." + Name);
            else
                Console.WriteLine("Good Morning Mr." + Name);
            Console.ReadKey(); 
        }
    }
}