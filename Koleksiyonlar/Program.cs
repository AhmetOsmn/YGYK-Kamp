using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"ahmet","osman","enes","utku"};
            Console.WriteLine();

            List<string> isimler2 = new List<string> { "ahmet", "osman", "enes", "utku" };
            isimler2.Add("Mert");
            Console.WriteLine(isimler2[4]);

        }
    }
}
