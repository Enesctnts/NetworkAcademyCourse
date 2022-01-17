using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_08_Metotlar_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Topla("1","2","3","7"));
            //Console.WriteLine(Topla("Korkma", "sönmez", "bu"));
            

            //// PuanTopla : (isim, yaş, puanlar )
            //// string = isim + ToplamPuan
            //int[] p = new int[3];
            //p[0] = 75;
            //p[1] = 85;
            //p[2] = 90;
            //int toplam = p.Sum();
            //Console.WriteLine("Toplam:"+ toplam);
            ////Console.WriteLine(PuanTopla("Ahmet", 44, p));
            

            //// Recursive: Kendini çağıran metotlar.
            //Console.WriteLine(Faktoriyel(3));
            

            //Referans tipi parametreler
            // ref kullanırken parametrenin ilk değerini vermek zorunludur. 
            int s1=5;
            int s2=7;
            //DegerDegistir(ref s1, ref s2);
            //Console.WriteLine("s1=" + s1);
            //Console.WriteLine("s2=" + s2);
            int s3 = DegerDegistir2(out s1);
            Console.ReadLine();
        }  //MAIN SONU

        static int DegerDegistir2(out int sayi)
        {
            sayi = 55;
            //Console.WriteLine("s1=" + sayi);
             
            return sayi + 5; 
        }
        private static void DegerDegistir(ref int s1,  ref int s2)
        {
            s1 = 5;
            s2 = 7;
            s1 = s1 * 10;
            s2 = s2 * 100;
            Console.WriteLine("Metod içinde s1=" + s1);
            Console.WriteLine("Metod içinde s2=" + s2);
        }

        static int Faktoriyel(int sayi)
        {
            if (sayi <= 1)
                return 1;
            else
            {
                return sayi * Faktoriyel(sayi - 1);
            }
                 
        }

        private static string PuanTopla(string isim, int yas, params string[] puanlar)
        {
            string toplamPuan = "";
            foreach (string puan in puanlar)
            {
                toplamPuan += puan + " ";
            }
            return "Adı:" + isim + " Yaş:" + yas + " Toplam Puan:" + toplamPuan;
        }

        static string Topla(params string[] sayilar)
        {
            string cumle = "";
            foreach (string kelime in sayilar)
            {
                cumle += kelime + " "; 
            }
            return cumle; 
        }
    }
}
