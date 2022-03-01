using System;


namespace metodlar
{
    class @metodlar
    {
        static void Main(string[] args) // metod
        {

            Product urun1=new Product(); //classı çağırıp değikene verşyorum.   // class
            urun1.UrunAd = "elma";
            urun1.UrunFiyat = 15;
            urun1.UrunDetay = "ısparta elmnası";  // değişkene veri basmaya başladım.
             
            Product urun2=new Product();
            urun2.UrunAd = "kiraz";
            urun2.UrunFiyat = 15;
            urun2.UrunDetay = "afyon kirazı";  // değişkene veri basmaya başladım.
            Product[] urunler = new Product[] { urun1, urun2 };   // değişkenlere gelen verileri dizeliyorum.
            foreach (var urunum in urunler)   //dizideki  her elemanı tek tek gez tek bir değişken çatıusı altına al.
            {
                Console.WriteLine(urunum.UrunAd + " " + urunum.UrunFiyat + " " + urunum.UrunDetay);

            }

            Console.WriteLine("--------metodlar-------");

            //encapsulation

            SepetManager sepetManager = new SepetManager();   //sepet manager classı nı çağırdım ve onu bir değişkene atadım.


            sepetManager.Ekle(urun1);  //class içindeki metodu getirdim. onun içerisindeki parametreye veri bastım.

            sepetManager.Ekle2("armut", "yeşillik", 12);
            sepetManager.Ekle2("kiraz", "yeşillik", 12);


            //classın içindeki propertleri çağırıp değer basabilirim ,classın içindeki metodu çalıştırabilirim. classler kolaylık sağlar


        }
    }
}

// Metodlar;  tekrar tekara kullanılabilriği sağlayan code bloklarıdır