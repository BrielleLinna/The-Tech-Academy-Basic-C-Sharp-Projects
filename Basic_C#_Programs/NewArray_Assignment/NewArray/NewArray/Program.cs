using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NewArray
{
    class Program
    {
        static void Main()
        {
            string[] food = {"turkey", "stuffing", "salad", "pie" };
            int item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(food[item]);
            Console.ReadLine();

            int[] numArray = new int[] { 2020, 2021, 2022, 2023 };
            Console.WriteLine("Please select the index that represents the current year:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numArray[year]);
            //bool correctYear = true;

           // while (!correctYear)
            //{
               // switch (year)
                {
                 //   case 1:
                   //     Console.WriteLine("The year is not yet 2021.");
                //        Console.ReadLine();
                //        int year = Convert.ToInt32(Console.ReadLine());
                //        break;

                //    case 2:
                //        Console.WriteLine("The year is not yet 2022.");
                //        Console.ReadLine();
                //        Console.WriteLine("Please select the index that represents the current year:");
                //        int year = Convert.ToInt32(Console.ReadLine());
                //        break;

                //    case 3:
                //        Console.WriteLine("The year is not yet 2023.");
                //        Console.ReadLine();
                //        Console.WriteLine("Please select the index that represents the current year:");
                //        int year = Convert.ToInt32(Console.ReadLine());
                //        break;

                //    case 0:
                //        Console.WriteLine("You selected that index that represents this year, 2020!");
                //        Console.ReadLine();
                //        correctYear = true;
                //        break;

                //    default:
                //        Console.WriteLine("You selected an index that does not exist in this array, try again.");
                //        Console.ReadLine();
                //        Console.WriteLine("Please select the index that represents the current year:");
                //        int year = Convert.ToInt32(Console.ReadLine());
                //        break;

                //}
                //Console.ReadLine();
            }


            List<string> stringList = new List<string>();
            stringList.Add("Milk");
            stringList.Add("Bread");
            stringList.Add("Eggs");
            stringList.Add("Coffee");

            Console.WriteLine("Please select an idex between 0-3:");
            int grocery = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You will need to pick up" + grocery + "at the store.");
            Console.ReadLine();
                
        }
    }
}

