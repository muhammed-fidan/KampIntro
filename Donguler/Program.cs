using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüleri birbirini tekrar eden durumlar için kullanırız.
         
            //static yazmak el ile yazmak. Dinamik yazmak dizi ile yazdırmak.
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java Kursu";

            //array-dizi (Liste şeklindeki verilerimizi dizilerde tutarız.

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java Kursu", "Phyton Kursu", "C++", "C#" };


            //for (int i = 0; i < kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}

            //Foreach: Dizi temelli yapıları tek tek dönmeye yarıyor.

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu - footer");
            

        }
    }
}
