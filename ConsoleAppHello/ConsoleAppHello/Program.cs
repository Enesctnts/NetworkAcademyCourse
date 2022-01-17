using System;

namespace ConsoleAppHello
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Merhaba, Dünya!"); //Yorum , ekrana bişeyler yazar
            ////Console.WriteLine("Merhaba, Dünya!");
            ////Console.WriteLine("Merhaba, Dünya!");
            ////Console.WriteLine("Merhaba, Dünya!");


            /////* Çoklu satır
            ////  yorumlar
            ////  var */
            //////Tip ad = Veri;

            ////sbyte sayi = -45;
            ////sayi = 75;
            ////byte bmax = byte.MaxValue;
            ////Console.WriteLine($"Byte tipinin alacağı en büyük değer: {bmax}");
            ////Console.WriteLine("Byte tipinin alacağı en büyük değer: " + bmax);

            ////int kint = int.MinValue;
            ////Console.WriteLine($"int tipinin alacağı en küçük değer: {kint}");

            ////float floatSayiMax = float.MaxValue;
            ////Console.WriteLine("Float tipinin alacağı en büyük değer: " + floatSayiMax);


            ////float f = 3.5f;
            ////double d = 1.2d;
            ////Console.WriteLine("double tipinde bir değer: " + d);

            ////decimal decimalSayiMax = decimal.MaxValue;
            ////Console.WriteLine("Decimal tipinin alacağı en büyük değer: " + decimalSayiMax);

            ////char a = 'A';
            ////string s = "Veysel Perü";
            ////Console.WriteLine(s);

            //////Console.WriteLine(d.GetType());


            ////Int32 i32 = 99;
            ////Int16 i16 = 88;

            ////Console.WriteLine("i16 nin max ı " + Int16.MaxValue);
            ////Console.WriteLine("i32 nin max ı " + Int32.MaxValue);
            ////Console.WriteLine("i64 nin max ı " + Int64.MaxValue);
            ////Console.WriteLine("int nin max ı " + int.MaxValue);

            ////bool devamEdilsinMi = false; 
            ////bool bb = (1==2); // false

            //////Console.Clear();


            ////// Ad soyad, yaş, eposta adresi ekrandan al, tek bir writeLine ile yazdıralım.
            //////Console.WriteLine("Ad soyad:");
            ////// string adsoyad = Console.ReadLine();
            ////// Console.WriteLine("Yaş:");
            ////// string yas = Console.ReadLine();
            ////// Console.WriteLine("Eposta:");
            ////// string eposta = Console.ReadLine();

            ////// Console.WriteLine("Ad Soyad:" + adsoyad + "\n" +
            //////     "Yaş:" + yas + "\n" +
            //////     "Eposta:" + eposta);
            ////object genelDegisken=12;
            ////genelDegisken = 33;
            ////Console.Write("Genel Değişken: " + genelDegisken);
            ////genelDegisken = "Veysel";
            ////Console.Write("Genel Değişken: " + genelDegisken);
            ////genelDegisken = 123.45f;
            ////Console.Write("Genel Değişken: " + genelDegisken);

            ////if (d == 33)
            ////{
            ////    d = d + 1;
            ////}
            ////else if (d == 35)
            ////{
            ////    d = d - 1;
            ////}
            ////else
            ////{
            ////    d = d - 2;
            ////}

            //Console.WriteLine("Bir sayı giriniz");

            //int i = Convert.ToInt32(Console.ReadLine());

            //if (i % 2 == 0)
            //    Console.WriteLine("Bu sayı 2 ye tam bölünür.");
            //if (i % 3 == 0)
            //    Console.WriteLine("Bu sayı 3 e tam bölünür.");
            //if (i % 5 == 0)
            //    Console.WriteLine("Bu sayı 5 e tam bölünür.");

            //float d = 50000f + 0.12345f;
            //Console.WriteLine("d=" + d.ToString());

            double d = 4.5;
            double kdv = d * 18 / 118;


            Console.WriteLine("d=" + kdv.ToString());

            int kurus = Convert.ToInt32 (kdv * 100);
            Console.WriteLine("kurus=" + kurus);

            Console.Read();
        }
    }
}
