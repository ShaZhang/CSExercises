using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] Sale = new int[12];
            string[] NameOfMonth = new string[]
            {
            "January","Feburary","March","April","May","June","July","August","September","October","November","December"
            };
            for (int i = 0; i <= 11; i++)
            {
                Console.Write("Enter sales for month {0}:", NameOfMonth[i]);
                Sale[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j <= 11; j++)
            {
                for (int m = 0; m <= 11; m++)
                {
                    if (Sale[m] <= Sale[j])
                    {
                        int m1 = Sale[m];
                        Sale[m] = Sale[j];
                        Sale[j] = m1;
                        string mon = NameOfMonth[m];
                        NameOfMonth[m] = NameOfMonth[j];
                        NameOfMonth[j] = mon;
                    }
                }
            }
            Console.WriteLine("Maximum Sales:{0}", NameOfMonth[11]);
            Console.WriteLine("Minimum Sales:{0}",NameOfMonth[0]);
            Console.WriteLine("Average Sales:{0}", (Sale[0] + Sale[1] + Sale[2] + Sale[3] + Sale[4] + Sale[5] + Sale[6] + Sale[7] + Sale[8] + Sale[9] + Sale[10] + Sale[11]) / 4);
            Console.ReadKey();
        }
    }
}
