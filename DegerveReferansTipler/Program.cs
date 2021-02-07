using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerveReferansTipler
{
    class Program
    {
        
        // HİÇ BİR YAZILIMM YOKTUR Kİ YAZILDIKTAN SONRA DEĞİŞİM ALMASIN.


        static void Main(string[] args)
        {
            int SAYİ1 = 10;
            int sayi2 = 30;
            SAYİ1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(SAYİ1);
            //İNT,DECİMAL,FLOAT,DOUBLE,BOOL BUNLAR DEĞER TİP

            Console.WriteLine("*************************");




            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
            //ARRAY,CLASS,İNTERGAİVE BUNLARDA REFERANS TİPLERDİR

            Console.ReadKey();
            //bellekte Stack VE heap diye iki alan var değer tipler stack'e atılıyor 
            //stack sayi1 = 10; sayi2=20; sayi1=sayi2 dediğinde sayi1=20 olur okadar
            //heap de ise referans tipler olur  sayilar1 ler stack da [10,20,30] ise heap kısmında oluşur 
            //sayilar1 in referans numarası eşittir sayılar2 nin referans numarasına  ve sayılar2 ye eşitt olur 
            //sayilar2 nin 0. elemanı 999 olduğundan sayilar1 inde 0.elemanı 999 olur
            //ve sayılar1 in değerleri sonra silinir yok olur 

          




        }
    }
}
