using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            for (int x = 5; 5 <= x && x <= 10000; x++)
            {
              int i=2;
              while (x % i != 0 && 2 <= i && i <= x / 2)
                {
                    i++;
                }
              if (i > x / 2)
                    Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
