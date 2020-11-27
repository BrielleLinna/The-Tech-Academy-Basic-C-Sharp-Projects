using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    public class Program
    {

        static void Main(string[] args)
        {
            //defining two objects of employee class to assign ID int to
            Employee employee = new Employee();
            employee.firstName = "Brielle";
            employee.lastName = "Linna";
            employee.Id = 21;

            Employee employee2 = new Employee();
            employee2.firstName = "John";
            employee2.lastName = "Smith";
            employee.Id = 22;

            //need to call the method/ overloaded operator to return the value as true or false
            Console.WriteLine(employee == employee2);
            Console.ReadLine();

         
        }
    }
}
