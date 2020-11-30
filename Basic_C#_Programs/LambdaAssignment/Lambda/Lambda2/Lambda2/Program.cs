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

            var myList = new List<Tuple<string, string, int>>();
            myList.Add(Tuple.Create(firstName = "Joe", lastName = "Smith", Id = 212));
            myList.Add(Tuple.Create("Joe", "Sam", 212));
            myList.Add(Tuple.Create("Sally", "White", 212));
            myList.Add(Tuple.Create("Jose", "Stein", 212));
            myList.Add(Tuple.Create("Abby", "Brown", 212));
            myList.Add(Tuple.Create("Anne", "Lane", 212));
            myList.Add(Tuple.Create("Layla", "Johnson", 212));
            myList.Add(Tuple.Create("Mark", "Wu", 212));
            myList.Add(Tuple.Create("Jesse", "Doe", 212));
            myList.Add(Tuple.Create("James", "Joseph", 212));


            foreach (firstName in myList)
            {
                if (firstName == "Joe")
                    Console.WriteLine(firstName);
            }

                             Console.ReadLine();
        }


        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }
    }
}
