﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a distane:");
            double x, Fare, Fare1;
            x = Convert.ToDouble(Console.ReadLine());
            Fare = 2.4 + 3.2 * x;
            Fare1 = Math.Ceiling(Fare);
            Console.WriteLine("The total fare is {0:c}", Fare1);
            Console.ReadKey();
        }
    }
}
