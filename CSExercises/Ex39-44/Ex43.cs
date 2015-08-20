
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input an integer:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Hex(i));
            Console.ReadKey();
        }
        public static string Hex(int i)
        {
            if (1 <= i && i <= 15)
            {
                Console.WriteLine(i);
                string m = Console.ReadLine();
                return m;
            }
            else
            {
                int x = i % 16;
                int a = (i - x) / 16;
                if (0 <= x && x <= 9)
                {
                    Console.WriteLine("{0}" + "{1}", a, x);
                    string y = Console.ReadLine();
                    return y;
                }
                else
                {
                    string[] C = new string[] { "A", "B", "C", "D", "E", "F" };
                    int b = x - 9;
                    Console.WriteLine("{0}" + "{1}", a, C[b-1]);
                    string D = Console.ReadLine();
                    return D;
                }
            }
        }
    }
}
