﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeAssignment
{
    class Program
    {


        public static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
       

            Console.WriteLine("Please pick a number.");
            int answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("It will be", now + answer);
            Console.ReadLine();

        }
    }
}