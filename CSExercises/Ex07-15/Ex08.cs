using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a temperature(Centigrade scale):");
            double C, F;
            C = Convert.ToDouble(Console.ReadLine());
            F=1.8*C + 32;
            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}
