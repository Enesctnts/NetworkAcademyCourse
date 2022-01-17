using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_08_StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string birlesim = String.Concat("Network ", "Akademi ", "303Sabah ", 2022);
            //Console.WriteLine(birlesim);


            //string[] dizi = { "Korkma ", "sönmez ", "bu ", "şafaklarda" };
            //birlesim = String.Concat(dizi);
            //Console.WriteLine(birlesim);


            //int[] intDizi = { 1, 2, 3, 4, 5 };
            //birlesim = String.Concat(intDizi);
            //Console.WriteLine(birlesim);


            //string s1 = "Adıyaman";
            //string s2= "Adıyaman";

            //int comp = String.Compare(s1, s2);
            //Console.WriteLine("comp=" + comp);
            //if (comp == -1)
            //    Console.WriteLine(s1);
            //else
            //    Console.WriteLine(s2);
            //Console.ReadLine();


            string metin = "BEŞİKTAŞ";
            Console.WriteLine(metin.IndexOf("Ş"));
            Console.WriteLine(metin.LastIndexOf("Ş"));
            Console.WriteLine(metin.StartsWith("BEŞ"));
            Console.WriteLine(metin.StartsWith("Beş"));
            Console.WriteLine(metin.EndsWith("TAŞ"));
             

            metin = "      ____FENERBAHÇE_____    ";
            Console.WriteLine(metin.Trim('_', ' ','E'));
             

            metin = "Merhaba Dünya";
            Console.WriteLine(metin.PadLeft(20,'.'));
            Console.WriteLine(metin.PadRight(20, '.'));
              

            string youtubeStr = "https://www.youtube.com/watch?v=tbCiWKLLjBY";
            string[] adres = youtubeStr.Split('/');
            Console.WriteLine("adres[0]=" + adres[0]);
            Console.WriteLine("adres[1]=" + adres[1]);
            Console.WriteLine("adres[2]=" + adres[2]);
            Console.WriteLine("adres[3]=" + adres[3]);
            

            string cumle = "Merhaba arkadaşlar bugün hava çok güzel";
            string[] kelimeler = cumle.Split(' ');
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            

            string yeniCumle = string.Join("/", kelimeler);
            Console.WriteLine(yeniCumle);
            

            yeniCumle = yeniCumle.ToUpper();
            Console.WriteLine(yeniCumle);
            yeniCumle = yeniCumle.ToLower();
            Console.WriteLine(yeniCumle);

            yeniCumle = yeniCumle.Remove(3,1);
            Console.WriteLine(yeniCumle);

            Console.WriteLine(yeniCumle.Insert(6," 123 "));
            yeniCumle=yeniCumle.Replace('a', 'e');
            Console.WriteLine(yeniCumle.Replace("arkadaşlar", "gençler"));
            Console.WriteLine(yeniCumle);

            Console.WriteLine(yeniCumle.Substring(0,8));
            Console.WriteLine(yeniCumle[0]);
            



            // TestYaz(string yazi) metodu.
            yeniCumle = "Network         Akademi     çok     iyi   bir  kurum";
            TersYaz(yeniCumle);
            

            //KelimeSay(string yazi) metodu.
            int k = KelimeSay(yeniCumle);
            Console.WriteLine("Kelime sayısı = " + k);
            Console.ReadLine();

        }  // Main sonu

        private static int KelimeSay(string yeniCumle)
        {
            int sayac = 0;
            string[] dizi = yeniCumle.Split(' ');
            foreach (var item in dizi)
            {
                if (item != "")
                    sayac++;
            }
            return sayac;
        }

        private static void TersYaz(string yeniCumle)
        {
             
            for (int i = yeniCumle.Length - 1; i >= 0 ; i--)
            {
               
                Console.Write(yeniCumle[i]);
            }
            Console.WriteLine();
        }
    }
}
