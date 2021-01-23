using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;
            ////int, decimal, float, enum, boolean : value types
            //Console.WriteLine("Sayi1 = " + sayi1); //sonuc = 20 olur


            ////arrays, class, interface...: reference types
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 = sayilar2; // sayilar1 in adresine, sayilar2 nin adresi atandi.
            //                     // artik sayilar1, sayilar2 nin gosterdigi yeri gosteriyor.
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayilar1[0] = " + sayilar1[0]);//sonuc = 1000 olur

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Ahmet";
            
            person2 = person1;
            //Console.WriteLine(person2.FirstName);   // --> Ahmet
            
            person1.FirstName = "Derin";
            //person1 i degistirsek te person2 de degisti.Cunku ikisi ayni adresi gosteriyor.
            //Console.WriteLine(person2.FirstName);   // --> Derin

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "123456789";

            Employee employee = new Employee();

            Person person3 = customer;
            //Console.WriteLine(person3.FirstName);   // --> salih

            //customer'in kredi kart numarasina, person3 ile ulastik.
            //Console.WriteLine(((Customer)person3).CreditCardNumber); // --> 123456789

            PersonManager personManager = new PersonManager();
            //Add() metodu, parametre olarak person nesnesi aldigi icin,
            //Person sinifindan turemis alt siniflarin nesneleri ile de calistirilabilir.
            personManager.Add(person1);
            personManager.Add(customer);
            personManager.Add(employee);
            personManager.Add(person3);

        }
    }

    class Person
    {
        public int Id{ get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

}
