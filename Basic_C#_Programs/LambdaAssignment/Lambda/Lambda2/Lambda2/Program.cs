using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employeeNew = new Employee();

            List<Employee> empList = new List<Employee>();

            Employee empObj1 = new Employee();
            empObj1.firstName = "Joe";
            empObj1.lastName = "Smith";
            empObj1.Id = 212;
            empList.Add(empObj1);

            Employee empObj2 = new Employee();
            empObj2.firstName = "Joe";
            empObj2.lastName = "Stein";
            empObj2.Id = 4;
            empList.Add(empObj2);

            Employee empObj3 = new Employee();
            empObj3.firstName = "Sally";
            empObj3.lastName = "Johnson";
            empObj3.Id = 3;
            empList.Add(empObj3);

            Employee empObj4 = new Employee();
            empObj4.firstName = "Abby";
            empObj4.lastName = "White";
            empObj4.Id = 22;
            empList.Add(empObj4);

            Employee empObj5 = new Employee();
            empObj5.firstName = "Kevin";
            empObj5.lastName = "Glass";
            empObj5.Id = 21;
            empList.Add(empObj5);

            Employee empObj6 = new Employee();
            empObj6.firstName = "Layla";
            empObj6.lastName = "White";
            empObj6.Id = 12;
            empList.Add(empObj6);

            Employee empObj7 = new Employee();
            empObj7.firstName = "Mark";
            empObj7.lastName = "Wu";
            empObj7.Id = 2;
            empList.Add(empObj7);

            Employee empObj8 = new Employee();
            empObj8.firstName = "Sam";
            empObj8.lastName = "Grey";
            empObj8.Id = 14;
            empList.Add(empObj8);

            Employee empObj9 = new Employee();
            empObj9.firstName = "Joel";
            empObj9.lastName = "Hazel";
            empObj9.Id = 19;
            empList.Add(empObj9);

            Employee empObj10 = new Employee();
            empObj10.firstName = "Annie";
            empObj10.lastName = "Howard";
            empObj10.Id = 6;
            empList.Add(empObj10);

            var employee = new List<Employee>();

            foreach (Employee employees in empList)
            {
                if (employees.firstName == "Joe")
                {
                    Console.WriteLine(employees.firstName);
                }
                Console.ReadLine();
            }

            //Attempt at creating new list with lambda to pull all firstname with Joe

            List<Employee> newEmpList = empList.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee employee1 in newEmpList)
            {
                Console.WriteLine(employee1.firstName);
            }

            //Attempt at using lambda to make a new int list 
            List<Employee> newIdList = empList.Where(x => x.Id > 5).ToList();
            foreach (Employee employee2 in newIdList)
            {
                Console.WriteLine(employee2.Id);
            }
            Console.ReadLine();
        }
                            
        }

    }

