using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "John";
            employee.lastName = "Snow";
           

            employee.sayName();
            Console.ReadLine();

            IQuittable quitEmp = new Employee();
            quitEmp.Quit(employee);
            Console.ReadLine();
        }
    }
}
