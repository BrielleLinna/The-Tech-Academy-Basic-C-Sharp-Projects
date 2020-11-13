using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeIteration
{
    class Program

    {
        private static string searchstring;

        static void Main(string[] args)

        {

            //Assignment Part 1 of Iterations
            string[] animals = { "cats", "dogs", "tigers" };
            Console.WriteLine("Write some text:");
            string animalInput = Console.ReadLine();

            string newAnimal;
            foreach (string b in animals)
            {
                newAnimal = b + animalInput;
                Console.WriteLine(newAnimal);
                foreach (var p in newAnimal)
                {
                    Console.WriteLine(p);
                    Console.ReadLine();
                }

            }



            //Assignment 2 in Iteration Assignment
            // How the first line would read to be an infinite loop: for (int b = 0; b < 10; b--)
            //The below code is a fix to make the loop not continue on forever

            for (int c = 0; c <= 20; c++)
            {
                Console.WriteLine("value: {0}", c);
            }
            Console.ReadLine();

            //Assignment 3 in Iteration, similar as above, representing how to make a loop using < and <=

            for (int n = 0; n < 2; n++)
            {
                Console.WriteLine("We are couting up from zero as long as we are less than 2: {0}", n);
            }
            Console.ReadLine();

            for (int m = 0; m <= 5; m++)
            {
                Console.WriteLine("We are counting up from zero until we equal 5:{0}", m);
            }
            Console.ReadLine();


            //Part 4 of Iteraton Assignment

            List<string> intlist = new List<string>();
            intlist.Add("Red");
            intlist.Add("Blue");
            intlist.Add("Green");
            bool z = false;

            do

            {
                Console.WriteLine("Please enter a color:");
                string color = Console.ReadLine();
                if (intlist.Contains(color))
                {
                    Console.WriteLine(intlist.IndexOf(color));
                    z = true;
                }
                else if (!intlist.Contains(color))
                {
                    Console.WriteLine("This is not a valid color in list.");
                }
                Console.ReadLine();
            }

            while (z == false);

            //Assignment 5 in Iteration
            List<string> identical = new List<string>();
            identical.Add("cat");
            identical.Add("dog");
            identical.Add("cat");
            identical.Add("monkey");

            Console.WriteLine("Please write a type of animal:");
            string animal = Console.ReadLine();

            if(identical.Contains(animal))
            {
                    Console.WriteLine("You chose" + animal);
                    Console.ReadLine();

                for (int i = 0; i < identical.Count(); i++)
                {
                        if (animal == [i])
                        Console.WriteLine()
                }
            else
            {
                Console.WriteLine("User input is not in the string.");
                Console.ReadLine();
            }

            for(int i = 0; i < identical.Count(); i++)
            {
                Console.WriteLine(identical.Contains(animal));

            if (animal = identical[i])
            {
                    Console.WriteLine(IndexOf(animal));
                    Console.ReadLine();
            }

            }

            //Assignment Part 6

            List<string> six = new List<string>();
            six.Add("Hello");
            six.Add("Goodmorning");
            six.Add("Goodnight");
            six.Add("Hello");
            string saying = "Hello";

            Console.WriteLine(six);

            foreach (string w in six)
            {
                Console.WriteLine(w);
                Console.ReadLine();
            }

            List<string> newSix = new List<string>();

            if (six.Contains(saying))
            {
                newSix.Add(saying);
                Console.WriteLine(newSix);
                Console.ReadLine();
                //Not displaying a new list with just matching saying variable
            }
        }

            

           

        //Other attempts at how to add data from one list into an empty list using online research
        //    var myList = new List<string>[] { new List<string>(), new List<string>() };

           
        //        if private static object firstlist;

        //(string i.Contains("Hello"))
        //            myList.Last().Add(i.ToString());
        //        else
        //            myList.First().Add(i.ToString());
        //            Console.WriteLine(myList);
        //            Console.ReadLine();

        
    }
}
