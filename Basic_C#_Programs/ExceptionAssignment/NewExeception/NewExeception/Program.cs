using System;
using System.Collections.Generic;

namespace ExceptionsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            numbers.Add(20);
            numbers.Add(40);
            numbers.Add(60);
            numbers.Add(80);

            try
            {

                Console.WriteLine("Pick a number:");
                int numberOne = Convert.ToInt32(Console.ReadLine());

                foreach (int v in numbers)
                {
                    int numberThree = v / numberOne;
                    Console.WriteLine(numberThree);
                    Console.ReadLine();
                }
            }



            catch (FormatException ex)
            {
                Console.WriteLine("please write a whole number, not text");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("you cannot divide by zero.");

            }

            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine("You are now moving on in the program from this try/catch code.");
            Console.ReadLine();
            //Errors we are trying to exception handle
            // DivideByZeroException
            // system.formatexception

            }
        }
    }
