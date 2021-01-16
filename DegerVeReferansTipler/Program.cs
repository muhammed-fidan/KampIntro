using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1= 30 olur.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300};
            sayilar1 = sayilar2;//sayilar1'in referans numarasi esittir sayilar2'nin referans numarasidir.
            sayilar2[0] = 999;
            //sayilar1[0] = 999 olur.

            //int - decimal - float - double - bool = deger tip

            //array - class - interface= referans tip


            //Bellekte iki tipimiz var. Değer tipler sadece  Stack'ta gerceklesir.   Referans tipler ise Heap'ta gerçekleşir.

            // sayi1=10;  sayi1' in degeri eşittir 10.


        }
    }
}
