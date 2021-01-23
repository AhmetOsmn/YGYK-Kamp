using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ahmet");
            myDictionary.Add(3, "Osman");

            myDictionary.Listele();
            Console.WriteLine("----------------------");

            myDictionary.Add(3, "Ali"); //Ayni key ile ekleme yapiliyor, --> 'Ayni key zaten girilmis' yazisi ekrana basiliyor ve ekleme yapilmiyor.

        }
    }
}
