using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();  //Classın örneği denir.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 120;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 150;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe -- tip guvenli
            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("--------------Metotlar----------");

            //encapsulation
            SepetManager sepetManager = new SepetManager();  //instance - örnek (Class örneği)
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);






        }
    }
}

//Metotlar, tekrar tekrar kullanılabilecek kodları tek satırda yazmaya yardımcı olur. 
//Don't repeat yourself (Kendini tekrar etme) - DRY - Clean Code(Temiz Kod) - Best Practice.
//c#, java gibi program dilleri classlar icerisinde olur.
