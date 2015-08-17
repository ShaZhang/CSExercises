using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string Name;
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter your gender using M or F:");
            string Gender;
            Gender = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter your age");
            int Age;
            Age = Convert.ToInt32(Console.ReadLine());
            if (Gender == "M")
                if (Age >= 40)
                    Console.WriteLine("Good Morning Uncle " + Name);
                else
                    Console.WriteLine("Good Morning Mr. " + Name);
            else
                if (Age >= 40)
                    Console.WriteLine("Good Morning Lady " + Name);
                else
                    Console.WriteLine("Good Morning Ms. " + Name);
            Console.ReadKey();
        }
    }
}