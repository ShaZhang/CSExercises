using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Please enter A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter B:");
            B = Convert.ToInt32(Console.ReadLine());
            while (A!=B)
            {
                if (A > B)
                    A = A - B;
                else
                    B = B - A;
            }
            Console.WriteLine("HCF={0}", B);
            Console.WriteLine("LCM={0}", A * B / A);
            Console.ReadKey();
        }
    }
}
