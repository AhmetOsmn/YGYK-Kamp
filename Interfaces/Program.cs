using System;

namespace Interfaces
{

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName +" Eklendi");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //    PersonManager personManager = new PersonManager();
            //    personManager.Add(new Customer { Id = 1, FirstName = "Ahmet", LastName = "Sezgin", Address = "Bursa"});
            //    personManager.Add(new Student { Id = 2, FirstName = "Osman", LastName = "Sezgin", Departmant = "IT" });

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());
            //customerManager.Add(new OracleCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3] { new SqlServerCustomerDal(), new OracleCustomerDal(), new MySqlCustomerDal()};
            foreach (ICustomerDal customerDal in customerDals)
            {
                customerDal.Add();
            }



        }
    }
}
