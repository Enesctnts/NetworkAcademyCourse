using System;

namespace Ders_02_Alistirmalar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //Klavyeden alınan sayı 5 ten büyükse sayının kendisini, değilse 
            //sayının karesini ekrana yazdıran programı yazınız.
            //
            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //bool sayiBestenBuyuk = (sayi > 5);
            //if (sayiBestenBuyuk)
            //    Console.WriteLine("Sayı 5 ten büyüktür");
            //else
            //    Console.WriteLine("Sayı 5 ten küçük ya da eşittir.  " + Math.Pow(sayi, 2));

            //Klavyeden girilen 2 sayıdan büyük olanı ekrana yazdıran program.

            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    if (sayi1 > sayi2)
            //        Console.WriteLine("Büyük olan sayı" + sayi1);
            //    else if (sayi1 < sayi2)
            //        Console.WriteLine("Büyük olan sayı" + sayi2);
            //    else
            //        Console.WriteLine("İki sayı eşittir.");
            //}

            // Klavyeden girilen 3 adet sayıdan, 100'den küçük olanlarının toplamını yazan prog.
            //Console.WriteLine("s1 giriniz:");
            //int s1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("s2 giriniz:");
            //int s2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("s3 giriniz:");
            //int s3 = Convert.ToInt32(Console.ReadLine());

            //int sonuc = 0;
            //if (s1 < 100)
            //    sonuc += s1;
            //if (s2 < 100)
            //    sonuc += s2;
            //if (s3 < 100)
            //    sonuc += s3;
            //Console.WriteLine("Yüzden küçük olanların toplamı:" + sonuc.ToString());

            //Örnek: Notu harfe çeviren program: 
            //0-49: F
            //50-64: D
            //65-74: C
            //75-84: B
            //85-100: A

            //Console.WriteLine("Not giriniz:");
            //int not = Convert.ToInt32(Console.ReadLine());
            //if (not >= 0 && not <=49)
            //    Console.WriteLine("F");
            //else if (not >= 50 && not <= 64)
            //    Console.WriteLine("D");
            //else if (not >= 65 && not <= 74)
            //    Console.WriteLine("C");
            //else if (not >= 75 && not <= 84)
            //    Console.WriteLine("B");
            //else if (not >= 85 && not <= 100)
            //    Console.WriteLine("A");
            //else 
            //    Console.WriteLine("Not hatalı girildi. 0 ve 100 arasında olmalıdır.");

            // Klavyeden  2 sayı alınız.
            // Klavyeden işlem bilgisi alınız: (topla, cikar, carp, bol )
            // Girilen değerleri, girilen işleme sokunuz.

            //Console.WriteLine("sayı1 giriniz:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sayı2 giriniz:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İşlem(topla, cikar, carp, bol) giriniz:");
            //string islem = Convert.ToString(Console.ReadLine());

            //if (islem == "topla")
            //    Console.WriteLine("topla işleminin sonucu: " + (sayi1 + sayi2));
            //else if (islem == "cikar")
            //    Console.WriteLine("cikar işleminin sonucu: " + (sayi1 - sayi2));
            //else if (islem == "carp")
            //    Console.WriteLine("carp işleminin sonucu: " + (sayi1 * sayi2));
            //else if (islem == "bol")
            //{ 
            //    if (sayi2 == 0 )
            //    Console.WriteLine("Sıfıra bölme yapılamaz! " );
            //    else
            //    Console.WriteLine("bol işleminin sonucu: " + (sayi1 / sayi2));
            //}

            // Klavyeden girilen sayı
            // Çift ise ekrana yazdırılsın.
            // Tek ise 3 ün katı mı değil mi kontrol edilsin. 
            // 3 ün katı ise kaç katı olduğu ekrana yazdırılsın. 
            // 3 ün katı değilse, mod 3 ten artan sayı yazılsın. 
            Console.WriteLine("Bir sayı giriniz:");
            int birsayi = Convert.ToInt32(Console.ReadLine());

            if (birsayi % 2 == 0)
                Console.WriteLine("Çift sayı:" + birsayi);
            else if (birsayi % 3 == 0)
                Console.WriteLine("3 ün " + (birsayi / 3) + " katıdır.");
            else
                Console.WriteLine("3 e bölünce kalan " + (birsayi % 3) + " dır.");

            /* Klavyeden girilen 5 sayıdan kaçının pozitif, kaçının negatif olduğunu sayan
             * Ayrıca negatiflerle pozitiflerin ayrı ayrı toplamlarını alan prog.
             * 1.Adım: Negatifler toplamı: -30 Pozitifler toplamı: 150
             * 2.Adım: 2 Negatif, 3 Pozitif sayı girildi. 
             */
            //ÖRN : sayılar: -5,9,11,-15,10
            // 1. aşama: Negatifler Toplamı: -20, Pozitifler toplamı: 25
            // 2. aşama: 2 negatif,3 pozitif sayı girildi.
            int s1 = -10;
            int s2 = 20;
            int s3 = 90;
            int s4 = -9;
            int s5 = -1;

            int nToplam = 0;
            int pToplam = 0;
            int nSayac = 0;
            int pSayac = 0;

            if (s1 > 0)
            {
                pToplam += s1;
                pSayac += 1;
            }
            else if (s1 < 0)
            {
                nToplam += s1;
                nSayac++;
            }
            if (s2 > 0)
            {
                pToplam += s2;
                pSayac += 1;
            }
            else if (s2 < 0)
            {
                nToplam += s2;
                nSayac++;
            }

            if (s3 > 0)
            {
                pToplam += s3;
                pSayac += 1;
            }
            else if (s3 < 0)
            {
                nToplam += s3;
                nSayac++;
            }

            if (s4 > 0)
            {
                pToplam += s4;
                pSayac += 1;
            }
            else if (s4 < 0)
            {
                nToplam += s4;
                nSayac++;
            }

            if (s5 > 0)
            {
                pToplam += s5;
                pSayac += 1;
            }
            else if (s5 < 0)
            {
                nToplam += s5;
                nSayac++;
            }
            Console.WriteLine($"{nSayac} adet negatif sayının toplamı: {nToplam}");
            Console.WriteLine($"{pSayac} adet pozitif sayının toplamı: {pToplam}");



        }
    }

    //
}
