using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYapmışmı = true;
            double dolarDün = 7.55;
            double dolarBugün = 7.55;

            if (dolarDün > dolarBugün)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDün < dolarBugün)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }




            if (sistemeGirişYapmışmı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
        }
    }
}
