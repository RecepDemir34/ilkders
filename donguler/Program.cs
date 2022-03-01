using System;

namespace donguler
{
    class program   //Döngüler
    {
        static void Main(string[] args)   // 1 sınıf içerisinde çalışan 1 komut bloğu  public olmadığından diğer sınıflarda göremem
        {
            string kurs1 = "yazılım";
            string kurs2 = "programlama";
            string kurs3 = "java";

            //array-dizi 

            string[] kurslar = new string[] { "yazılım", "programlama", "java" }; //çoğul değişkenleri tek bir dizide tutuyorum,yada db den çekicem. ör.sebzeler
           
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                //kurslar dizisindeki verileri kurslar dizisinin veri uzunluğuna göre  döndürerek yazdırdım (veri değeri 0 dan başlar).
            }

            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar) //kursları dolaş,foreach dizileri tek tek dolaşmamızı sağlar  tüm dizi elemanları tek tek dolaşılıp basıldı
            {
                Console.WriteLine(kurs); //kurs burada dizi içerisindeki verilerin takma adıdır.
            }



        }
    }
}