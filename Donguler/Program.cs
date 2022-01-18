using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazılım geliştirici yerleştrime kampı";
            string kurs2 = "proglamlamaya başlangıc için temel kurs";
            string kurs3 = "java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            


            //array - dizi

            string[] kurslar = new string[] { "yazılım geliştirici yerleştrime kampı", "proglamlamaya başlangıc için temel kurs", "java", "C#"};


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
