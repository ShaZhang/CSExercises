
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a number (1-25):");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square of {0} is {1}", y, SQT(y));
            Console.ReadKey();
        }

        public static double SQT(int y)
        {
            int M = y;
            double S = Math.Sqrt(M);
            return S;
        }
    }
}
