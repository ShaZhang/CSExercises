using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your salary:");
            double Salary,HA,TA,Income;
            Salary = Convert.ToDouble(Console.ReadLine());
            HA = Salary*0.1;
            TA = Salary*0.03;
            Income = Salary + HA +TA;
            Console.WriteLine("Your total salary is {0:c}",Income);
            Console.ReadKey();

            

            
        }
    }
}
