using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;    //Keyleri tutan liste.
        TKey[] tempArrayKeys;   //keylere ekleme yaparken kullanilan yardimci key listesi.

        TValue[] values;    //Valueleri tutan liste.
        TValue[] tempArrayValues;   //Valuelere ekleme yapilirken kullanilan yardimci value listesi.

        public MyDictionary()
        {
            keys = new TKey[0]; //Heapte yeni liste olusturuldu
            values = new TValue[0]; //Heapte yeni liste olusturuldu
        }

        public void Add(TKey key, TValue value) //Parametre olarak, generic yapida girilen tipli key ve value aliniyor.
        {
            int flag = 0;   //Girilen key'in daha once eklenmis olup olmadigini kontrol etmemizi saglayan bayrak.
            foreach (TKey k in keys)
            {
                if (k.Equals(key)){ //keys listesini dolasarak, girilen key'in varligini kontrol ediyoruz.
                    flag = 1; //Eger ayni key var ise bayrak = 1 yapildi.
                }
            }
            if(flag == 0) { //keys listesi dolasildiktan sonra bayrak ifademiz hala 0 ise yani degismemis ise, artik ekleme yapilabilir.
                tempArrayKeys = keys;   //keys listesinde bulunan eski degerleri kaybetmemek icin yapiliyor.
                keys = new TKey[keys.Length + 1];   //heapte keys adinda ve boyutu 1 fazla olan yeni liste olusturuldu.

                tempArrayValues = values;   //keys ile ayni islem value icin yapiliyor.
                values = new TValue[values.Length + 1]; //keys ile ayni islem value icin yapiliyor.

                for (int i = 0; i < tempArrayKeys.Length; i++)  //artik eski listedeki degerleri geri aliyoruz.
                {
                    keys[i] = tempArrayKeys[i];
                }
                keys[keys.Length - 1] = key;    //eski degerler alindiktan sonra son indekse eklenmek istenen key ekleniyor.

                for (int i = 0; i < tempArrayValues.Length; i++)    //artik eski listedeki degerleri geri aliyoruz.
                {
                    values[i] = tempArrayValues[i];
                }
                values[values.Length - 1] = value; //eski degerler alindiktan sonra son indekse eklenmek istenen value ekleniyor.
            }
            else    //Eklenmek istenen key zaten mevcuttur. Bu yuzden uyari mesaji ekrana basiliyor. Bu kisim try-ex ile yapilabilir ama kolaylik olmasi acisindan ekrana mesaj yaziyoruz.
            {
                Console.WriteLine("Ayni key zaten girilmis..");
            }

        }

        public void Listele()   
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + ", " + values[i]);
            }
        }
    }
}
