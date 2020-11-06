using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PracticeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] food = { "turkey", "stuffing", "salad", "pie" };
                Console.WriteLine("Please enter an index between 0 - 3 to see which item you need to bring to the party:");
                int item = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(food[item]);
                Console.ReadLine();

                int[] numArray = { 2020, 2021, 2022, 2023 };
                Console.WriteLine("Please enter the index to guess the current year.");
                int year = Convert.ToInt32(Console.ReadLine());
                bool yearTrue = false;

                while (yearTrue == false)
                {
                    switch (year)
                    {
                        case 0:
                            Console.WriteLine("It is 2020! Good job!");
                            yearTrue = true;
                            break;

                        case 1:
                            Console.WriteLine("It is not 2021.");
                            Console.WriteLine("Please enter the index that represents the current year.");
                            year = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 2:
                            Console.WriteLine("It is not 2022.");
                            Console.WriteLine("Please enter the index that represents the current year.");
                            year = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 3:
                            Console.WriteLine("It is not 2023.");
                            Console.WriteLine("Please enter the index that represents the current year.");
                            year = Convert.ToInt32(Console.ReadLine());
                            break;

                        default:
                            Console.WriteLine("No such index exists, try again.");
                            Console.WriteLine("Please enter the index that represents the current year.");
                            year = Convert.ToInt32(Console.ReadLine());
                            break;
                    }

                    Console.ReadLine();
                }


                List<string> stringList = new List<string>();
                stringList.Add("Milk");
                stringList.Add("Bread");
                stringList.Add("Eggs");
                stringList.Add("Coffee");

                Console.WriteLine("Please select an idex between 0-3:");
                int grocery = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You will need to pick up" + stringList[grocery] + "at the store.");
                Console.ReadLine();
            }
        }
    }
}


