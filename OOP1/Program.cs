using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //Mobilya demek olsun
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInSock = 3; //stokta 3 adet kalmis olsun.

            Product product2 = new Product {Id = 2, CategoryId = 5,
                UnitsInSock = 5, ProductName = "Kalem", UnitPrice = 35};

            ProductManager productManeger = new ProductManager();
            productManeger.Add(product1);
            productManeger.Update(product1);
        }
    }
}
