using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id = 1, FirstName = "Ahmet", LastName = "Sezgin", City = "Bursa" };
            Customer customer2 = new Customer(2,"Osman","Sezgin","Bursa");
            Console.WriteLine(customer2.FirstName);

        }

    }

    class Customer
    {   
        //default constructor
        public Customer(int id, string fname, string lname, string cty)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.City = cty;
        }
        public Customer()
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
