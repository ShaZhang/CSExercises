using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name\t" + "Mark");
            string[] Name = new string[] { "John", "Venkat", "Mary", "Victor", "Betty " };
            int[] Mark = new int[] { 63, 29, 75, 82, 55 };
            int i;
            for(i=0;i<=4;i++)
            {
                Console.WriteLine("{0}\t{1}", Name[i], Mark[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Name\t" + "Mark");
            int green, red, temp = 0; string name;
            for(green=0;green<4; green++)
            {
                for(red=green+1;red<5;red++)
                {
                    if (Mark[red] > Mark[green])
                    {
                        temp = Mark[green];
                        Mark[green] = Mark[red];
                        Mark[red] = temp;
                        name = Name[green];
                        Name[green] = Name[red];
                        Name[red] = name;
                    }
                }
            }
            for (int m = 0; m <= 4; m++)
            {
                Console.WriteLine("{0}\t{1}", Name[m], Mark[m]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Name\t" + "Mark");
            int green1, red1=0, temp1,j;string name1="";
            for (green1=0;green1<4;green1++)
            {
                for(red1=green1+1;red1<5;red1++)
                {
                   j= Name[green1].CompareTo(Name[red1]);
                   if(j==1)
                   {
                        temp1 = Mark[green1];
                        Mark[green1] = Mark[red1];
                        Mark[red1] = temp1;
                        name1 = Name[green1];
                        Name[green1] = Name[red1];
                        Name[red1] = name1;
                    }
                }
            }
            int v;
            for(v=0;v<=4;v++)
            {
                Console.WriteLine("{0}\t" + "{1}", Name[v], Mark[v]);
            }
            Console.ReadKey();
        }
    }
}
