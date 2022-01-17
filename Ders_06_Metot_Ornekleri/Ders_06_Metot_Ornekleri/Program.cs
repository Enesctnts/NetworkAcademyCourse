using System;
using System.Collections.Generic;

namespace Ders_06_Metot_Ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int sayi1 = sayiGir();
            ////int sayi2 = sayiGir();
            ////Console.WriteLine("Sayi1=" + sayi1 +"Sayi2=" + sayi2);
            //////Sayi girişini otomatikleştiren metodu yazınız.
            //////Kullanıcıdan alınan int tipindeki sayıyı döndürecek.


            ////Console.WriteLine(MerhabaDunya("Şükrü"));
            ////Console.ReadLine();

            ////Parametre olarak aldığı sayının 
            //// Faktoriyelini alıp döndüren metot.

            ////int faktoriyel = Faktoriyel();
            ////Console.WriteLine("Faktoriyel;" + faktoriyel);
            ////Console.ReadLine();

            ////int faktoriyel5 = Faktoriyel(5);
            ////Console.WriteLine("Faktoriyel;" + faktoriyel5);
            ////Console.ReadLine();

            ////Parametre olarak aldığı sayının asal olup olmadığını 
            //// döndüren metot. Asal ise true, değilse false döndürsün.
            //// 5 asal mı? 2,3,4'e tam bölünmüyorsa asaldır.
            //// 7 asal mı? 2,3,4,5,6'ya tam bölünmüyorsa asaldır.
            ////int sayi = sayiGir();
            ////bool k = isPrime(sayi);
            ////if (sayi <= 0)
            ////{
            ////    Console.WriteLine(sayi + " sayısı geçersizdir");                
            ////}
            ////else if (k)
            ////    Console.WriteLine(sayi + " asaldır.");
            ////else
            ////    Console.WriteLine(sayi + " asal değildir.");




            ////// 0-100 aralığında rastgele ürettiği 10 sayyı int tipinde
            //////dizi(array) olarak döndüren metodu tanımlayınız.
            ////int[] rastgele10 = Random10();

            ////foreach (var item in rastgele10)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// DiziYaz metodunu yazınız, parametre olarak int[] dizi alsın. 







            //// Dizi alıp yazdıran metot:
            //int[] sayilar = { 10, 20, 30, 40, 50, 11, 22, 33, 44, 55 };


            ////Kendisine gönderilen dizideki tek sayıları yine dizi ile döndüren 
            ////metodu yazınız. (Limit = 20 : eleman sayısı)
            //Console.WriteLine("Sıfırları görmek ister misiniz?(E,H):");
            //string cevap = Console.ReadLine();
            //bool cevapBool = (cevap.ToUpper() == "E") ? true : false;
            //int[] tekSayilar = DiziTekleri(sayilar);
            //DiziYaz(tekSayilar, cevapBool);

            ////DiziYaz(DiziTekleri(sayilar));

            //// Dizi alıp yazdıran DiziYaz metotuna sifirlariYaz parametresiyle
            //// bir overload yapalım.
            //// DiziYaz(tekSayilar, cevapBool);

            ////Buyuk2li(99, 88); Aldığı 2 sayıdan büyük olanı döndüren metot.
            //int a = sayiGir();
            //int b = sayiGir();
            //int c = sayiGir();
            //Console.WriteLine(a + "," + b + " sayılarından büyük olan :" + buyuk2li(a, b));
            //int buyuk = buyuk2li((buyuk2li(a, b)), c);
            //Console.WriteLine(a + "," + "," + b + "," + c + " sayılarından büyük olan :" + buyuk3lu(a,b,c));

            ////buyuk2li kullanarak buyuk3lu yazınız.
            ////buyuk = buyuk3lu(12, 88, 42);

            //// Liste tipinde aldığı değişken adet sayının karelerini List tipinde döndüren
            ////metodu yazınız. (2 tane list olacak)

            //List<int> sayilarim = new List<int> { 2, 3, 4, 5, 6, 7, 10,12};
            //List<int> karelerim = ListeKare(sayilarim);
            //for (int i = 0; i < sayilarim.Count; i++)
            //{
            //    Console.WriteLine(sayilarim[i] + " sayısının karesi = " + karelerim[i]);
            //}

            //Liste sorusu: Kullanıcıdan 10 sayı alıp liste ile döndüren metod.
            // Metod ismi SayiGetir10
            //List<int> donenSayilar = new List<int>();
            //donenSayilar = SayiGetir10();
            //foreach (var item in donenSayilar)
            //{
            //    Console.Write(item + " ");
            //}

            // Parametreler (enKucuk, enBuyuk, sayiAdedi)
            // Metot: bu parametreleri alıp sayiAdedi kadar enKucuk ile enBuyuk
            // arasında rastgele sayı üretip liste olarak geri dönsün.
            //List<int> sayiListesi = SayiUret(1, 6, 2);
            //foreach (var item in sayiListesi)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            // Listeyi tek string yapan metod.
            List<string> kelimelerim = new List<string>() { "araba", "hızla", "yanımdan", "geçti" ,"gitti"};
            string cumlem = ListToString(kelimelerim);
            Console.WriteLine(cumlem);


        }  // Main Sonu

        private static string ListToString(List<string> kelimelerim)
        {
            string cumle = "";
            for (int i = 0; i < kelimelerim.Count; i++)
            {
                cumle += kelimelerim[i] + " ";
            }
            return cumle;
        }

        //static string ListToString(List<string> kelimeler)
        //{
        //    string cumle = "";
        //    for (int i = 0; i < kelimeler.Count; i++)
        //    {
        //        cumle += kelimeler[i] + " ";
        //    }
        //    return cumle;
        //}

        static List<int> SayiUret(int enKucuk, int enBuyuk, int sayiAdedi)
        {
            List<int> sayilar = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < sayiAdedi; i++)
            {
                sayilar.Add(rnd.Next(enKucuk, enBuyuk+1));
            }
            return sayilar;
        }


        static List<int> SayiGetir10()
        {
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ". sayıyı giriniz:");
                sayilar.Add(int.Parse(Console.ReadLine()));
            }
            return sayilar;
        }

        static List<int> ListeKare(List<int> sayilarABC)
        {
            List<int> kareler = new List<int>();
            for (int i = 0; i < sayilarABC.Count; i++)
            {
                kareler.Add(sayilarABC[i] * sayilarABC[i]);
            }
            return kareler;
        }
        static int buyuk3lu(int a, int b, int c)
        {
            return buyuk2li(buyuk2li(a, b), c);
        }
        static int buyuk2li(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }


        //Yeni bir overload
        static void DiziYaz(int[] dizi, bool sifirlariYaz)
        {
            foreach (int eleman in dizi)
            {
                if (sifirlariYaz == true)
                {
                    Console.Write(eleman + " ");
                }
                else
                {
                    if (eleman != 0)
                    {
                        Console.Write(eleman + " ");
                    }
                }
            }
            Console.WriteLine();
        }

        static int[] DiziTekleri(int[] sayiDizisi)
        {
            int[] teklerDizisi = new int[sayiDizisi.Length];
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (sayiDizisi[i] % 2 == 1)
                    teklerDizisi[i] = sayiDizisi[i];


            }
            return teklerDizisi;
        }

        static void DiziYaz(int[] dizi)
        {
            foreach (int eleman in dizi)
            {
                Console.Write(eleman + " ");
            }
            Console.WriteLine();
        }

        static int[] Random10()
        {
            int[] sayiDizisi = new int[10]; //Boş bir array tanımla.
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                sayiDizisi[i] = rnd.Next(0, 101);//üretilen sayıları diziye dolduruyoruz.
            }
            return sayiDizisi;
        }
        static bool isPrime(int sayi)
        {
            if (sayi == 1) return false;
            int karekok = (int)Math.Sqrt(sayi);
            for (int i = 2; i <= karekok + 1; i++)
            {
                Console.WriteLine(i + "sayısı kontrol ediliyor");
                if (sayi % i == 0)
                    return false;
            }
            return true;
        }

        //Değer döndüren, parametre almayan.
        static int Faktoriyel()
        {
            Console.Write("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int carpim = 1;
            for (int i = 2; i <= sayi; i++)
            {
                carpim *= i;
            }
            return carpim;
        }
        //Değer döndüren, parametre alan.
        static int Faktoriyel(int sayi)
        {
            int carpim = 1;
            for (int i = 2; i <= sayi; i++)
            {
                carpim *= i;
            }
            return carpim;
        }


        // static dönüştipi metotadi(tip parametre, tip parametre,...) 
        static int sayiGir()
        {
            Console.WriteLine("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            return sayi;
        }
        //Değer döndüren, parametre almayan.
        static string MerhabaDunya()
        {
            Console.WriteLine("Merhaba Dunya");
            return "İşlem tamamlandı.";
        }

        //Değer döndüren, parametre alan.
        static string MerhabaDunya(string isim)
        {
            Console.WriteLine("Merhaba " + isim);
            return "İşlem tamamlandı.";
        }

    }
}
