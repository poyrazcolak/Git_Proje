using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class Program
    {
        
        static void Main(string[] args)
        {//Dont repeat yourself-DRY-Clean code-best practice
           
            string urunAdi = "Elma";
            string fiyati = "15";
            string aciklama = "Amasya";//biz burda tanımlıyoruz ama ilişkilendiremiyoruz...

            string urunAdi2 = "Elma";
            string fiyati2 = "15";
            string aciklama2 = "Amasya";

            string[] meyveler = new string[] { };//burda sadece strigleri tuttabilirsin int tutmazsın bir ortak olmalı veri tipleri
          
            //clas bu üçünüün beraber tuttan yapıdır.

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

           Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 90;
            urun2.Aciklama = "Diyarbakır karpuzu";

           Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)//urun sayısı kadar döner urun takma ismi
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("*****************");

            }
            //claslar 1.özellik tutuyorlarr
    


            Console.WriteLine("**********************");
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("armut", "yeşilarmut", 12,10);
            sepetManager.Ekle2("elma", "yeşilelma", 17,16);
            // sepetManager.Ekle(); bişey yazmadığında kızıyor//aynı şeyi ekrana yansı














            Console.ReadKey();
        }
    }
}
