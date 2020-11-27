using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    public class Employee
    {
        
        public int Id  { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }


        public static bool operator == (Employee x, Employee y)
        {
            if (x.Id == y.Id)
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee x, Employee y)
        {
            if (x.Id != y.Id)
                return true;
            else
                return false;
        }
    }
}
