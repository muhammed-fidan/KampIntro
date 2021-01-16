using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {

        //naming convention
        //syntax

        //parametre = urun..
        public void Ekle(Urun urun) //bu satıra imza deniyor.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi + " : " + urun.StokAdedi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler sepete eklendi : " + urunAdi);
        }
            
    }
}
