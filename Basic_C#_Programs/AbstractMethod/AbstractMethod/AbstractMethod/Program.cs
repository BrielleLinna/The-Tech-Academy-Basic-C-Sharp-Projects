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
            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.sayName();
            Console.ReadLine();


            //employee.ID = 21;
            //employee.Quit();
            //Console.ReadLine();




        }
    }
}
