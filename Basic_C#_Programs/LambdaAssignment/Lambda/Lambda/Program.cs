using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<t> employeeList = new List<t>();
            //{
            //    employeeList.Add(Id = 1, firstName = "Joe", lastName = "Smith");

                 public static string firstName { get; set; }

                 public static string lastName { get; set; }

                 public static int Id { get; private set; }

        //var employees = new List<Tuple<string, int>>();
        //employeeList.Add(Tuple.Create("Joe", "Smith", 2));
        //{
        //    new employee() { Id= 212, firstName ="Joe", lastName = "Smith"},

        //}

            var employees = new List<Employee>()
                {
                    new Employee() {Id = 52, firstName = "Joe", lastName = "Smith"},
                    new Employee() {Id = 52, firstName = "Kim", lastName = "Apple"},
                    new Employee() {Id = 52, firstName = "Sally", lastName = "White"},
                    new Employee() {Id = 52, firstName = "Joe", lastName = "Johnson"},
                    new Employee() {Id = 52, firstName = "Mark", lastName = "Nu"},
                    new Employee() {Id = 52, firstName = "Layla", lastName = "Black"},
                    new Employee() {Id = 52, firstName = "Karen", lastName = "Jameson"},
                    new Employee() {Id = 52, firstName = "Jesse", lastName = "Samual"},
                    new Employee() {Id = 52, firstName = "Jose", lastName = "Fredmen"},
                    new Employee() {Id = 52, firstName = "Abby", lastName = "Steinson"},
                };


            
        }
    }
}

