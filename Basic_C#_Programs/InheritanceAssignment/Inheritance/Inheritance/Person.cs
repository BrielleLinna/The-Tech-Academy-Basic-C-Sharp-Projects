using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
       

        public void SayName(string firstName, string lastName)
            {
                string fullName = firstName + lastName;
                Console.WriteLine(fullName);
            }




        //public void FullName(string firstname, string lastname)
        //{
        //    Console.WriteLine(firstname + lastname);
        //}

        //public void SayName()
        //{
        //    foreach (name in firstName)
        //    {

        //    }

    }
}
