using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Muhammed";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Muhammed Fidan";
            kurs2.IzlenmeOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Kerem Varış";
            kurs3.IzlenmeOrani = 89;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "c++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
             

        }
    }
    //property=özellik (prop)
    class Kurs
    {
        
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
