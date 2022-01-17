using System;

namespace Ders_02_TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {

            ///////////////////////////////////////////////
            ////  Bilinçsiz Tür Dönüşümü                 //
            //////////////////////////////////////////////
            /////

            //// Küçük tür, Büyük türe otomatik olarak dönüştürülür.

            //byte byteSayi = 58;
            //int intSayi = byteSayi;
            //int ii = 60000;
            ////byte bb = ii;    // Hata veriyor.

            //float fSayi = 29.45f;
            //double dSayi = fSayi;


            //double dSayi2 = fSayi;
            ////float fSayi2 = dSayi2;   Hata verir.

            ///////////////////////////////////////////////
            ////  Kasıtlı Tür Dönüşümü (Casting)         //
            //////////////////////////////////////////////
            /////
            //checked
            //{ 
            //double dblSayi6 = 30;
            //byte byteSayi6 = (byte) dblSayi6; //


            //Console.WriteLine("byteSayi6=" + byteSayi6);
            //}
            ///////////////////////////////////////////////
            ////  Convert Sınıfı ile Tür Dönüşümü        //
            //////////////////////////////////////////////
            /////
            //double ddd = 678.455D;
            //string str = Convert.ToString(ddd);
            //Console.WriteLine("str=" + str);

            //string postaKodu = "34734";
            //int postaKoduInt = Convert.ToInt32(postaKodu);
            //Console.WriteLine("postaKoduInt=" + postaKoduInt);

            //Soru: Klavyeden Fahrenheit olarak girilen sıcaklık bilgisini Santigrat 
            //cinsine çevirip, aşağıdaki formatta ekrana yazdıran program.
            // 32 Fahrenheit => 0 Santigrad derecedir.
            //c = (F - 32) /1.8

            //Console.WriteLine("Fahrenheit bilgisi giriniz: ");
            //string sFah = Console.ReadLine();
            //double dFah = Convert.ToDouble(sFah);

            //double dSan = (dFah - 32) / 1.8;
            //dSan = Math.Round(dSan, 2);
            //Console.WriteLine(dFah.ToString() + " fahrenheit " + dSan.ToString() + " derecedir.");

            char karakter1 = 'A';
            int sayi8 = Convert.ToInt32(karakter1);
            Console.WriteLine("sayi8 = " + sayi8);

            // Ekrandan alınan 2 sayının toplamının karesini
            // Ekrana yazan program. 
            // 3 ve 7 sayılarının toplamının karesi = 100 dür"

            Console.WriteLine("Birinci Sayıyı giriniz:");
            double i1Sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı giriniz:");
            double i2Sayi = Convert.ToDouble(Console.ReadLine());
            double i3Sayi = (i1Sayi + i2Sayi);
            double sonuc;
            sonuc = Math.Pow (i3Sayi, 2) ;
            Console.WriteLine(i1Sayi + " ve " + i2Sayi + " sayılarının toplamının karesi = " + sonuc + " dır");
            string s2Sayi = Console.ReadLine();

            char y = '6';
            object kutu = y;

            object p = 'P';
            // y =  p as char; //hata verir



        }
    }
}
