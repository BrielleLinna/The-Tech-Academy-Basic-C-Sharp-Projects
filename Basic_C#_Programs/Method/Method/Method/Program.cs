using System;

namespace Method
{
    public class Program
    { 

        public static void Main(string[] args)
        {
            //instantiating the class
             MyClass myClassObject = new MyClass();

            //Calling user input
            //Calling method1 from inside the class
            Console.WriteLine("Please input a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You can choose to enter another number.");
            string o= Console.ReadLine();
            if (o == "")
            {
                Console.WriteLine(MyClass.Method1(number));
            }
            else
            {
                int numberTwo = Convert.ToInt32(o);
                Console.WriteLine(MyClass.Method1(number, numberTwo));
            }
                Console.ReadLine();
        }

    }
}
