using System;

namespace Interfaces3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler new'lenemez
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(new InternManager());


        }
    }

    //inherits - clas
    //implements - interface

    interface IPersonManager
    {
        //uniplamented operation
        void Add(); //default olarak publictir.
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //musteri ekleme kodlari
            Console.WriteLine("Musteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Musteri Guncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodlari
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Calisan Guncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Stajyer Guncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }




}
