
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer");
            int a = Convert.ToInt32(Console.ReadLine());
            int i=1,d=0;
            for (i = 1;i <= a / 2; i++)
            {
                if (a % i == 0)
                    d = d + i;
            }
            if (d == a)
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not Perfect Number");
            Console.ReadLine();



                   
            }
    }
}
