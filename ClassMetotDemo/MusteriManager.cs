using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musterinin Ad: "+musteri.Ad+"\n"+
                "Musterinin Soyad: "+musteri.Soyad+"\n"+
                "Musterinin Yasi: "+musteri.Yas+"\n"+
                "Ekleme Durumu: Basarili! ");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musterinin Ad: " + musteri.Ad + "\n" +
                "Musterinin Soyad: " + musteri.Soyad + "\n" +
                "Musterinin Yasi: " + musteri.Yas + "\n" +
                "Silme Durumu: Basarili! ");
        }
        public void MusterileriListele(Musteri[] musteriler)
        {
            foreach  (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad+" "+musteri.Soyad);
            }
        }

    }
}
