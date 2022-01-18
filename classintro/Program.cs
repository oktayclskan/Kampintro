using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "oktay";
            int yas = 36;

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.Eğitmen = "Oktay Çalışkan";
            kurs1.izlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "Java";
            kurs2.Eğitmen = "Engin Demirog";
            kurs2.izlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "python";
            kurs3.Eğitmen = "Berkay Bilgin";
            kurs3.izlenmeOrani = 80;

            //Console.WriteLine(kurs1.kursAdı + " : " + kurs1.Eğitmen);

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Eğitmen);
            }



            //Console.WriteLine("Hello World!");
        }
    }

    class kurs
    {

        public string kursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
