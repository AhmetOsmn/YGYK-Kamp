using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            //class larin tek basina anlami vardir, fakat interfacelerin tek basina anlami yoktur.

            Person[] persons = new Person[3] { new Customer {FirstName = "Ahmet"}, new Student {FirstName = "Osman"}, new Person {FirstName = "Mert" } };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }


}
