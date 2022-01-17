using System;

namespace Ders_05_For_Devam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen değer "bitir" olmadığı sürece alınan sayıları toplayıp en son ekrana toplamı yazdıran programı yazınız.
            //int toplam = 0;
            //int sayi = 0;
            //string str = "";
            //do
            //{
            //    Console.Write("Sayı giriniz : ");
            //    str = Console.ReadLine();
            //    bool dogru = int.TryParse(str, out sayi);
            //    if (dogru==false && str.ToLower() != "bitir" && str != "0")
            //        Console.WriteLine("Geçersiz sayı.");
            //    toplam += sayi;
            //} while (str.ToLower() != "bitir");
            //Console.WriteLine($"While loop ile TOPLAM = {toplam}");

            //toplam = 0;
            //sayi = 0;
            //str = "";
            //for (; ; )
            //{
            //    Console.Write("Sayı giriniz : ");
            //    str = Console.ReadLine();
            //    if (str.ToLower() == "bitir")
            //        break;
            //    bool dogru = int.TryParse(str, out sayi);
            //    if (!dogru && str.ToLower() != "bitir" && str != "0")
            //        Console.WriteLine("Geçersiz sayı.");
            //    toplam += sayi;
            //}
            //Console.WriteLine($"For loop ile TOPLAM = {toplam}");
            //Console.ReadLine();

            // Çarpım tablosu yapınız.
            // 1 ler 2 ler diye alt alta yazsın.
            //int i, j;
            //for (i = 1; i <= 10; i++)
            //{ 
            //  for (j = 1; j <= 10; j++)
            //    {
            //        //Console.WriteLine(i + " X " + j + " = " + i * j);
            //        Console.WriteLine(i + "\t X \t" + j + "\t=\t" + i * j);
            //    }
            //    Console.WriteLine("");
            //}

            //// 1 lerle 6  ları , 2 lerle 7 leri,...  diye alt alta ve yanyana yazsın.
            //int i, j;
            //for (i = 1; i <= 5; i++)
            //{
            //    for (j = 1; j <= 10; j++)
            //    {
            //        //Console.WriteLine(i + " X " + j + " = " + i * j);
            //        Console.Write(i + "\t X \t" + j + "\t=\t" + i * j + "\t\t");
            //        Console.WriteLine(i + 5 + "\t X \t" + j + "\t=\t" + (i+5) * j);
            //    }
            //    Console.WriteLine("");
            //}


            // iki grup halinde;

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(i + "x" + j + "=" + (i * j) + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("\n\n");
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 6; j <= 10; j++)
            //    {
            //        Console.Write(i + "x" + j + "=" + (i * j) + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            // Birden girilen sayıya kadar olan çift sayıları yazan, ve aşağıda
            // toplamını alan prog.

            //Console.Write("Sayı giriniz : ");
            //string str = Console.ReadLine();
            //int sayi, toplam = 0;
            //bool dogru = int.TryParse(str, out sayi);
            //for (int i = sayi; i >= 0; i-=1)
            //{
            //    if (i%2==1)
            //    { 
            //    Console.Write(i + " ");
            //    toplam += i;
            //    }
            //}
            //Console.WriteLine("Toplam = " + toplam);

            // İki sayı giriniz, hangisi küçük ise o sayıdan başlayarak diğerine kadar
            // olan sayıları yazan prog.
            //uint sayi1, sayi2;
            //string str;
            //Console.Write("Sayı 1 giriniz : ");
            //str = Console.ReadLine();
            ////uint.TryParse(str, out sayi1);
            //sayi1 = Convert.ToUInt32(str);

            //Console.Write("Sayı 2 giriniz : ");
            //str = Console.ReadLine();
            ////uint.TryParse(str, out sayi2);
            //sayi2 = Convert.ToUInt32(str);
            //uint kucuk, buyuk;
            //if(sayi1 < sayi2)
            //{
            //    kucuk = sayi1;
            //    buyuk = sayi2;
            //}
            //else
            //{
            //    kucuk = sayi2;
            //    buyuk = sayi1;
            //}
            //for (uint sayac = kucuk; sayac <= buyuk; sayac++)
            //{
            //    Console.Write(sayac + " ");
            //}

            // Markette 5 ürünün fiyatı tek tek girilip 
            // her biri için %18 KDV'li fiyatını ekrana yazdıran prog.
            // En altta toplam yazsın.
            //double toplam = 0;
            //double kdvsizF;
            //double kdvliF;
            //int k;
            //for (k = 1; k <= 5; k++)
            //{
            //    Console.Write(k + ". ürünün fiyatı:");
            //    kdvsizF = Convert.ToDouble(Console.ReadLine());
            //    kdvliF = kdvsizF * 1.18;
            //    Console.WriteLine("Ürünün KDV'li fiyatı: " + Math.Round(kdvliF, 2));
            //    toplam += kdvliF;
            //}
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Toplam KDV'li fiyatı: " + Math.Round(toplam,2));
            //Console.ReadLine();

            //string satirlar = "\n";
            //while (true)
            //{
            //    Console.WriteLine("Birşeyler yazın:" );
            //    string satir = Console.ReadLine();
            //    if (satir.ToLower() == "çık")
            //    {
            //        Console.WriteLine("Girilen değerler: " + satirlar);
            //        break;
            //    }
            //    else
            //    {
            //        satirlar += satir + "\n";
            //    }
            //}
            //Console.ReadLine();

            // 1 10 arası sayıların faktoriyellerini ekrana yazdırıp, en
            // altta da faktoriyeller toplamını yazdırsın.





            //int i,j, toplam = 0, aratoplam = 1;
            //string bos = "                               ", formatli;
            //for (i = 1; i <= 10; i++)
            //{
            //    aratoplam = 1;
            //    for (j = 2; j <= i; j++)
            //    {
            //        //Console.WriteLine(j);
            //        aratoplam *= j; 
            //    }
            //    toplam += aratoplam;
            //    formatli = aratoplam.ToString();
            //    formatli = bos.Substring(0,5 - formatli.Length) + aratoplam.ToString();
            //    Console.WriteLine(i + " sayısının faktoriyeli= " + formatli);
            //                }
            //Console.WriteLine("Faktoriyeller toplamı=   \t" + toplam);

            // Yıldızlardan Dik üçgen çiziniz:
            string cizgi = "*******************";
            for(int i=1; i<=10;i++)
            {
                Console.WriteLine(cizgi.Substring(1,i));
            }
        }




    }
}
