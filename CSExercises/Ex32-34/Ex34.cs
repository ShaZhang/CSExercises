
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            //横学科 竖学生名字 
            int[,] Marks = new int[12, 4];
            Marks[0, 0] = 56; Marks[0, 1] = 84; Marks[0, 2] = 68; Marks[0,3] = 29;
            Marks[1, 0] = 94; Marks[1, 1] = 73; Marks[1, 2] = 31; Marks[1,3] = 89;
            Marks[2, 0] = 41; Marks[2, 1] = 63; Marks[2, 2] = 36; Marks[2, 3] = 90;
            Marks[3, 0] = 99; Marks[3, 1] = 9; Marks[3, 2] = 18; Marks[3, 3] = 17;
            Marks[4, 0] = 62; Marks[4, 1] = 3; Marks[4, 2] = 65; Marks[4, 3] = 75;
            Marks[5, 0] = 40; Marks[5, 1] = 96; Marks[5, 2] = 53; Marks[5, 3] = 23;
            Marks[6, 0] = 81; Marks[6, 1] = 15; Marks[6, 2] = 27; Marks[6, 3] = 30;
            Marks[7, 0] = 21; Marks[7, 1] = 70; Marks[7, 2] = 100; Marks[7, 3] = 22;
            Marks[8, 0] = 88; Marks[8, 1] = 50; Marks[8, 2] = 13; Marks[8, 3] = 12;
            Marks[9, 0] = 48; Marks[9, 1] = 54; Marks[9, 2] = 52; Marks[9, 3] = 78;
            Marks[10, 0] = 64; Marks[10, 1] = 71; Marks[10, 2] = 67; Marks[10, 3] = 25;
            Marks[11, 0] = 16; Marks[11, 1] = 93; Marks[11, 2] = 46; Marks[11, 3] = 72;
            int i = 0, j = 0;
            for(i=0; i<12;i++)
            {
                for(j=0;j<4;j++)
                {
                    Console.Write("{0}\t", Marks[i, j]);
                }
                Console.WriteLine();
            }
            int a, b=0,sum1=0,sum3=0;
            for(b=0;b<4;b++)
            {
                for(a=0;a<12;a++)
                {
                    sum1 = sum1 + Marks[a, b];
                    sum3 = (Marks[a, b] - sum1/12) * (Marks[a, b] - sum1/12)+sum3;
                } 
            Console.WriteLine("The average marks of No. {0} subject is {1},the variance is {2}.", b, sum1/12,Math.Sqrt(sum3 / 12));
            sum1 = 0;sum3 = 0;
            }
            int k,l,sum4=0;
            for (k=0;k<12;k++)
            {
                for (l=0;l<4;l++)
                {
                    sum4 = Marks[k, l] + sum4;
                }
            }
            Console.WriteLine("The average marks for the whole class for all subjects is {0}", sum4 / 48);
            Console.ReadKey();
        }
    }
}
