using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classıntro
{
    class @class
    {
        static void Main(string[] args)
        {
            urun urunum = new urun();
            urunum.urunad = "tişört";
            urunum.urunadet = 5;
            urunum.urunfiyat = 3;
            urunum.urunmarka = "polo";
            urun urunum2 = new urun();
            urunum2.urunad = "tişört";
            urunum2.urunadet = 5;
            urunum2.urunfiyat = 3;
            urunum2.urunmarka = "polo";


            urun[] urunler = new urun[] { urunum, urunum2 };

            foreach (var urunu in urunler)
            {
                Console.WriteLine(urunu.urunad+"başarılı"+urunu.urunmarka);


            }








        }

    }


    class urun
    {
        public string urunad { get; set; }
        public int urunfiyat { get; set; }
        public int urunadet { get; set; }
        public string urunmarka { get; set; }


    }


}
