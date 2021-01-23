using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual
    class GercekMusteri : Musteri   //miras - inheritance
    {
        public string TcNo { get; set; }    //sayidan olusan bir degiskeni tanimlarken, eger o degisken uzerinde aritmatik islem yapilmayacaksa string tanimlamamiz daha avantajlidir.
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
