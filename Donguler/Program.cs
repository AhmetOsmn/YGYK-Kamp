using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim gelistirici yetistirme kampi";
            string kurs2 = "programlamaya baslangic icin temel kurs";
            string kurs3 = "Java gelistirme";

            string[] kurslar = new string[] { "Yazilim gelistirici yetistirme kampi",
                "programlamaya baslangic icin temel kurs",
                "Java" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("----------------------------------------------");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa sonu");
        }
    }
}
