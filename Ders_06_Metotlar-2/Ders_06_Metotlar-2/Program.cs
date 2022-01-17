using System;
using System.Collections.Generic;

namespace Ders_06_Metotlar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //kisaKenar ve uzunKenar'ı klavyeden alsın.
            // CevreAlan metodu ile cevre ve alanı yazsın. 
            //Console.Write("Kısa kenar:");
            //int kK = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Uzun kenar:");
            //int uK = Convert.ToInt32(Console.ReadLine());

            // CevreAlan(kK, uK);
            // CevreAlan(kK, uK);
            // 1. metot: Kullanıcıdan veri girişi alan ve girilen stringi geri dönen Yaz() metodu. 
            // 2. metot: CokYaz(int adet) adet kadar input(Yaz) alacak, List halinde geri
            //    döndürecek. 

            //string ifade = Yaz();
            List<string> gelenYazilar = CokYaz(5);
            foreach (var item in gelenYazilar)
            {
                Console.WriteLine(item);
            }
             
        }  //  Main sonu 

        static List<string> CokYaz(int v)
        {
            List<string> yazilar = new List<string>();
            for (int i = 0; i < v; i++)
            {
                yazilar.Add(Yaz());
            }
            return yazilar;
        }

        static string Yaz()
        {
            Console.WriteLine("Yaz: ");
            return (Console.ReadLine());
        }



        static void CevreAlan(int kK, int uK)
        {
            int cevre = 2 * (kK + uK);
            int alan = kK * uK;
            Console.WriteLine("Dikdörtgenin alanı=" + alan + " Çevresi=" + cevre);


            
        }
    }
}
