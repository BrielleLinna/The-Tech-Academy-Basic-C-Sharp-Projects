using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    public class Employee : Person, IQuittable
    {


        public override void sayName()
        {
            base.sayName();
        }


        public void Quit(Employee employee)
        {
            Console.WriteLine(employee.firstName + "" + employee.lastName + "has quit.");
        }
    }
}
