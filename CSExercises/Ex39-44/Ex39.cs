using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex39
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("The factorial of {0} is {1}", n, Factorial(n));
            Console.ReadKey();
        }
        public static long Factorial(long n)
        {
            int N;
            long M=n;
            if (n != 0)
            {
                for (N = 0; N < n; N++)
                {
                    M = M * (M - 1);
                }
                return M;
            }
            else
                return 0;
            }
        }
    }
