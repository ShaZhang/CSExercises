using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] num = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int green,red,temp,i;
            for (green = 0; green <= num.Length-2; green++)
            {
                Console.WriteLine("Progress {0}", green+1);
                for (red = green + 1; red <= num.Length-1; red++)
                {
                    if (num[red] >= num[green])
                    {
                        temp = num[green];
                        num[green] = num[red];
                        num[red] = temp;
                    }
                }
                for (i = 0; i <= num.Length - 1; i++)
                {
                    Console.Write("{0}\t", num[i]);
                }
            }
           Console.ReadKey();
        }
    }
}
