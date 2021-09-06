using System;

namespace kamppintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği  demek
            string kategoriEtiketi = "kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun =7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");


            }
            else if (dolarDun<dolarBugun)

            {
                Console.WriteLine("artış butonu");
            }

            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);




        }
    }
}
