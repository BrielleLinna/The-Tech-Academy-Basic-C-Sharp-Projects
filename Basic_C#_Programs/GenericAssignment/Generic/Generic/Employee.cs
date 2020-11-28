using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Employee<T>
    {
        //Adding a property to Employee Class with generic list matching generic type 
        public List<T> Things { get; set; }

    }
}
