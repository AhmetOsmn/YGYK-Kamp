using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)  //birden fazla logger yollaniyor
        {
            //Basvuran bilgilerini degerlendirme
            //
            //
            //
            krediManager.Hesapla();
            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
