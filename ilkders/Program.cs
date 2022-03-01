using System;

namespace ilkders
{
    class program
    { 
    static void Main(string[]args)
    {

            //type safety-tip güvenliği ?
            // değişken kullan kendini tekrarlama

            string KategoriEtiketi = "kategori";  // sözel değişken1
     
            int ogrecisayisi = 1500;  //sayısal değişken1
            double faizorani = 1;  //virgüllü değişken1
            bool sistemeGirisYapmismi = false;
            double dolardun = 17.35;
            double dolarbugun = 13.58;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolardun<dolarbugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }



            if (sistemeGirisYapmismi=true)
            {
                Console.WriteLine("Kullanıcı Ayarlar butonu");


            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(KategoriEtiketi);

        }
    }

}
