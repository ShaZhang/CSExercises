
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input:");
            string m = Convert.ToString(Console.ReadLine());
            string[] s3 = new string[m.Length];
            s3 = m.Split();
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
