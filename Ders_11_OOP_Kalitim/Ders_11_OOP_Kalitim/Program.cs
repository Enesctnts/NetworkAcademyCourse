using Ders_11_OOP_Kalitim.Sahibinden;
using System;
using System.Threading;

namespace Ders_11_OOP_Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            AltClass nesne = new AltClass();
            nesne.AdSoyad = "Salih Uçan"; //AltClass özelliği
            nesne.KayitTarihi = DateTime.Now; // Ana Class özelliği
            nesne.IlanTarihi = Convert.ToDateTime("2022-01-15");
            nesne.IlanTarihiYaz(); // AnaClass metodu.
            nesne.AdSoyadYaz();  // AltClass metodu
            nesne.BilgiYaz();    // AltClass metodu

            //Thread.Sleep(5000);  // 5 saniye bekliyor.
            AltClass2 nesne2 = new AltClass2();
            nesne2.KayitTarihi = DateTime.Now;
            nesne2.Baslik = "Uygun fiyatlı olta takımı";

            nesne2.IlanTarihi = Convert.ToDateTime("2022-01-15");
            nesne2.IlanTarihiYaz();
            nesne2.BaslikYaz();

            AnaClass anaNesne = new AnaClass();
            anaNesne.IlanTarihi = Convert.ToDateTime("2021-01-15");
            anaNesne.KayitTarihi = Convert.ToDateTime("2021-01-15");
            anaNesne.IlanTarihiYaz();

            EnAltClass enAltNesne = 
                new EnAltClass(23, DateTime.Now, "Hakan Şükür", "uzun");

            Kullanici Shakir = new Kullanici();
            Shakir.AdSoyad = "Şakir Demir";
            Shakir.Telefon = "05324445566";
            Console.WriteLine(Shakir.AdSoyad);



        }
    }
}
