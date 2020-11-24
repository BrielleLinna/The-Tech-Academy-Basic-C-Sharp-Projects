using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Instantiating the classes inside our program
            Person person = new Person();

            //creating an object of Employee using properties from Person class
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            //Calling the void method to apply to employee properties
            employee.SayName(employee.firstName, employee.lastName);
            


            //Calling void method to display FullName
            person.SayName("Brielle", "Linna");
            Console.ReadLine();
        }
    }
}
