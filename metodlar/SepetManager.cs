using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar
{
    class SepetManager
    {

        // naming convention
        public void Ekle(Product product)    //product classını burada metoduma paremetre olarak gösteriyorum  bu metod product classı üzerinde çalışacak. 
        {


            Console.WriteLine("sepete eklendi"+product.UrunAd);


        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat)  //bu şekilde bir kullanım code tekrarlanmasına nbeden olur ekleyeceğim ek bir paremetre diğer
                                                                        ////  diğer paremetreleri patlattı bbunun yerine bir class'daki bir metoda başka bir cllası paremetre olarak gösterebilirm.
                                                                        ////  diğer paremetreleri patlattı bbunun yerine bir class'daki bir metoda başka bir cllası paremetre olarak gösterebilirm.
        {
            Console.WriteLine("sepete eklendi" + urunAdi);

        }
        //bir class içerinde birden çok metdo olabbilir.
 



    }
}
