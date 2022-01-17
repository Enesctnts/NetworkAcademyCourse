using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_06_Metotlar_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MerhabaDunya("Ezgi");


            // 2 sayının toplamını alan metot.
            int toplam = Topla(88, 99);
            //int buyuk = BuyukOlaniDondur(123, 11, 99);
            int buyuk = BuyukOlaniDondur(44, 11);
            Console.WriteLine("Buyuk olan:" + buyuk);
            Console.WriteLine("55'in karesi=" + Kare(55));

            // Kendisine gönderilen fiyata %18 KDV ekleyip geri döndüren
            // metodu yazınız. 

            Console.Write("KDV'siz fiyatı giriniz:");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ürün tipi giriniz:");
            string urunTipi = Console.ReadLine();

            Console.WriteLine("Ürün Tipi=" + urunTipi + " fiyat=" 
                + fiyat + " KDV'li hali=" + 
                                        KDVDahilHesapla(fiyat,urunTipi));

            // fiyat ve ürün tipine göre KDV'li fiyatı döndürsün:
            // ürün tipi gıda ise KDV oranı %8,
            // ürün tipi eğitim ise KDV oranı %5, diğerleri %18 KDV olarak 
            // ekleyip geri döndüren
            // metodu yazınız. 
            fiyat = 100.0;
            Console.WriteLine(fiyat + " fiyatının KDV'li hali=" +
                                        KDVDahilHesapla(fiyat));

            Console.ReadLine();
        }  //Main sonu
        static void MerhabaDunya(string isim)
        {
            Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int s1, int s2)
        {
            Console.WriteLine("Merhaba Dünya");
            if (s1 > s2)
                return s1 + s2;
            else
                return s1 + s2;
        }
        //METHOD OVERLOADING
        static int BuyukOlaniDondur(int s1, int s2)
        {
            Console.WriteLine("Merhaba Dünya");
            if (s1 > s2)
                return s1;
            else
                return s2;
        }
        static int BuyukOlaniDondur(int s1, int s2, int s3)
        {
            Console.WriteLine("Merhaba Dünya");
            int buyuk = s1;
            if (s2 > buyuk)
                buyuk = s2;
            if (s3 > buyuk)
                buyuk = s3;
            return buyuk;
        }
        static int Kare(int s)
        {
            return s * s;
        }

        static double KDVDahilHesapla(double kdvsizFiyat)
        {
            return kdvsizFiyat * 1.18;
        }
        static double KDVDahilHesapla(double kdvsizFiyat, string urunTipi)
        {
            if (urunTipi == "gıda")
            return kdvsizFiyat * 1.08;
            else if (urunTipi == "eğitim")
                return kdvsizFiyat * 1.05;
            else return kdvsizFiyat * 1.18;
        }








    }
    //
}

