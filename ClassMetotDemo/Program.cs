using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri m1 = new Musteri();
            m1.Ad = "Ahmet";
            m1.Soyad = "Sezgin";
            m1.Yas = 20;

            Musteri m2 = new Musteri();
            m2.Ad = "Kursat";
            m2.Soyad = "Gurler";
            m2.Yas = 20;

            Musteri m3 = new Musteri();
            m3.Ad = "Mert";
            m3.Soyad = "Altin";
            m3.Yas = 20;

            Musteri m4 = new Musteri();
            m4.Ad = "Ulas";
            m4.Soyad = "Avil";
            m4.Yas = 20;

            Musteri m5 = new Musteri();
            m5.Ad = "Emre";
            m5.Soyad = "Doran";
            m5.Yas = 20;

            Musteri m6 = new Musteri();
            m6.Ad = "Burak";
            m6.Soyad = "Guney";
            m6.Yas = 20;


            Musteri[] musteriler = new Musteri[] {m2, m4, m3, m5, m6, m1};

            MusteriManager musteriManager = new MusteriManager();

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.MusteriEkle(musteri);
                Console.WriteLine("-------------------------------------");
            }

            Console.WriteLine("-----------Listele-----------");
            musteriManager.MusterileriListele(musteriler);
            Console.WriteLine("-----------Listele-----------");

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.MusteriSil(musteri);
                Console.WriteLine("-------------------------------------");
            }



        }
    }
}
