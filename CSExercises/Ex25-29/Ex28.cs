
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an interger:");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            if (x==1)
               Console.WriteLine("Not Prime");
            else if (x==2)
               Console.WriteLine("Prime");
            else
            {
                while (x % i != 0 && i <= x / 2)
                    i++;
                if (i <= x / 2)
                    Console.WriteLine("Not Prime");
                else
                    Console.WriteLine("Prime");
            }
            Console.ReadKey();    
        }
    }
}
