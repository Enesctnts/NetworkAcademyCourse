using System;
using System.Threading;

namespace Ders_11_OOP_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanici ahmet = new Kullanici();
            //ahmet.AdSoyad = "Ahmet Çelik";
            //Bisiklet bisan = new Bisiklet();
            //bisan.Marka = "Bisan";

            //Kiralama kiralama = new Kiralama();
            //kiralama.Kullanici = ahmet;
            //kiralama.Bisiklet = bisan;
            //kiralama.Baslat();
            //Thread.Sleep(10000);
            //kiralama.Bitir();


            Kullanici fikri = new Kullanici();
            fikri.AdSoyad = "Fikri Çalışkan";

            fikri.kuafor.SacTrasiYap();
            fikri.kuafor.SacYikamaYap();

            fikri.kuafor.BilgiYaz();
        }
    }
}
