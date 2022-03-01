using System;


namespace classs
{
    class @class
    {
        static void Main(string[] args)
        {
            string adi = "recep";
            int yas = 24;
            kurs kurs1=new kurs(); //kurs adlı classımı kurs1 adlı bir değişken ile getiroyurm ç
            kurs1.KursAdi = "ccna";
            kurs1.egitmen = "recep demir";
            kurs1.izlenmeorani = 35;   //oluşturduğum classlara  veri girişi yapıyorum
            kurs kurs2 = new kurs();
            kurs2.KursAdi = "php";
            kurs2.egitmen = "hasan vural";
            kurs2.izlenmeorani = 35;
            kurs kurs3 = new kurs();
            kurs2.KursAdi = "php";
            kurs2.egitmen = "hasan vural";
            kurs2.izlenmeorani = 35;


        

            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3 };  //gelen classları dizi hale getrorum 

            foreach (var kurs in kurslar) // bu diziden de kurs adlı bir değişken oluşturup bu dizinin içerisinde dönüyorum.
            {
                Console.WriteLine(kurs.KursAdi+""+kurs.egitmen);   // çektiğim dizi ile tek tek class  verilerinin içine giriyoorum  ve bu verilerden 
                //kurs adı ve kurs eğitmenini getirip ekrana basıyorum.
                    

            }
          



        }
    }

    class kurs //kurs adlı bir sınıf oluşturuyorum.
	{
        public string KursAdi { get; set; }  //kurs adloı bir sınıf oluşturuyorum ve bu sınıfta değişkenler tanımlıyorum.
        public string egitmen { get; set; }

        public int izlenmeorani { get; set; }





    }


   

}