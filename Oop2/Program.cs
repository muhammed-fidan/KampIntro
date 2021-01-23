using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsa, o alan o  nesneye ait değilmiş 
            //gibi duruyorsa orada soyutlama hatası yapıyoruzdur.

            //Muhammed Fidan
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.CustomerNo = "12345";
            musteri1.CustomerName = "Muhammed";
            musteri1.CustomerLastName = "Fidan";
            musteri1.IdentityNo = "12345678910";


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CustomerNo = "54321";
            musteri2.CompanyName = "Kodlama.io";
            musteri2.TaxNo = "1515";

            Musteri musteri3 = new GercekMusteri(); //bellekteki bir referans No'su.
            Musteri musteri4 = new TuzelMusteri();  //bellekteki bir referans No'su.

            //Musteri hem GercekMusteri'nin hemde TuzelMusteri'nin referans değerini tutabiliyor.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);

            

            
            //Gerçek Müşteri - Tüzel Müşteri   birbirine benzemeleri birbirinin yerine kullanılacağı manasına gelmez.
            //Tekniğin Söyleyeni "SOLID" yazılım dilinin L harfi ile ilişkilendirilir.
        }
    }
}
