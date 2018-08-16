using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Step120
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee();
            Employee1.FirstName = "Sample";
            Employee1.LastName = "Student";
            Console.WriteLine(Employee1);
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class Employee : Person
    {
        public List<int> ID { get; set; }
    }
}
