using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Employee
    {
        public Employee(string name) : this(name, 12)
        {

        }

        public Employee(string name, int Id)
        {
            EmployeeId = Id;
            Name = name;
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
    }
}
