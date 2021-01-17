using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ctrl + enter: bulunulan satirin bir ustune yeni satir eklenir.



            */


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------------------------------------");

            }

            Console.WriteLine("-------------------------Metotlar---------------------------------");

            //instance - ornek
            SepetManager sepetManager = new SepetManager();
            //encapsulation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil Armut", 12);
            sepetManager.Ekle2("Elma", "Yesil Elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);
        }
    }
}
