using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            Console.WriteLine(sehirler.Count); // --> 5

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            Console.WriteLine(sehirler2.Count); // --> 9

        }
    }

    class MyList<T> //T: type
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;    //_array'in icerisindeki degerleri kaybetmemek icin yapildi.
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];  //_tempArray'deki eski elemanlari geri aliyoruz.
            }

            _array[_array.Length - 1] = item;   //son indekse gelen itemi yerlestiriyoruz.

        }

        public int Count
        {
            get { return _array.Length; }
        }

    }
}
