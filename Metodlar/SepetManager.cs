using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class SepetManager
    {

        public void  Ekle(Product urun)//eğer bir yerde böyle bir prantez görürsen orda metoda çalışıyor javada da öyle
        {//metodumuz bir parametre alıyor o parametremizin ismi urun
            Console.WriteLine("Sepete eklendi:" + urun.Adi);

        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int StokAdeti)
        {
            Console.WriteLine("teprikler" + urunAdi);
        }





    }
}
