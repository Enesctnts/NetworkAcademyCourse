using System;
using System.Collections.Generic;

namespace Ders10
{
    class Program
    {
        static void Main(string[] args)
        {

            //int tahmin = 0;
            //Random random = new Random();
            //int sayi1 = random.Next(1, 1000);
            //List<int> sayilar = new List<int>();
            //Console.WriteLine("Random sayi :" + sayi1);
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Tahmin: ");
            //     tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (tahmin==sayi1)
            //    {
            //        Console.WriteLine("\nTebrikler tutturdunuz!!");
            //        sayilar.Add(tahmin);
            //        break;
            //    }
            //    else if(tahmin<sayi1)
            //    {
            //        Console.WriteLine("Girilen tahmin sayidan küçüktür.");
            //        sayilar.Add(tahmin);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Girilen tahmin sayidan büyüktür");
            //        sayilar.Add(tahmin);
            //    }
            //}
            //if (!(tahmin==sayi1))
            //{
            //    Console.WriteLine("\nRandom sayi :" + sayi1);
            //    Console.Write("\nTahmin ettiğiniz sayilar: ");
            //    for (int i = 0; i < sayilar.Count; i++)
            //    {
            //        Console.Write(sayilar[i] + " ");
            //    }
            //}

            //1-20 arasında rasgele 10'ar sayi üretip iki listeye atan ve daha sonra
            //iki listede ortak olmayanları başka bir listeye atarak ekrana yazdıran progrm

            //List<int> random1 = new List<int>();
            //List<int> random2 = new List<int>();
            //List<int> random3 = new List<int>();

            //Random randomsayi = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    random1.Add(randomsayi.Next(1, 21));
            //    random2.Add(randomsayi.Next(1, 21));
            //}
            //for (int i = 0; i < random1.Count; i++)
            //{
            //    if (!(random2.Contains(random1[i])))
            //    {
            //        random3.Add(random1[i]);
            //    } 
            //}
            //for (int i = 0; i < random1.Count; i++)
            //{
            //    if (!(random1.Contains(random2[i])))
            //    {
            //        random3.Add(random2[i]);
            //    }
            //}
            //Console.WriteLine("\n\n*********1.Random dizisi*********\n");
            //for (int i = 0; i < random1.Count; i++)
            //{
            //    Console.Write(random1[i] + " ");  
            //}
            //Console.WriteLine("\n\n*********2.Random dizisi*********\n");
            //for (int i = 0; i < random1.Count; i++)
            //{
            //    Console.Write(random2[i] + " ");
            //}
            //Console.WriteLine("\n\n*********Ortak Olmayan Random dizisi*********");

            //for (int i = 0; i < random3.Count; i++)
            //{
            //    Console.Write(random3[i] + " ");
            //}

            //Sayı Tahmin oyunu: 1'den 1000'e kadar bir sayı tutsun.
            //10 tahmin yaptırsın, küçük ise küçük oldu, büyük ise
            //büyük oldu desin. Tutturursa "Tebrikler tutturdunuz" desin.
            //10 tahminde bilemezse Tutturamadınız, sayı 657 idi,
            //Tahminleriniz 12 76 233 456 878 ... yazsın. 
            //Random rnd = new Random();
            //int rastgele = rnd.Next(1, 1001);
            //int tahmin;
            //List<int> tahminler = new List<int>();
            //bool tutturdu = false;

            ////Console.WriteLine("Sayı=" + rastgele);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Tahmin: ");
            //    int.TryParse(Console.ReadLine(), out tahmin);
            //    if (rastgele == tahmin)
            //    {
            //        Console.WriteLine("Tebrikler, " + i + ". tahminde bildiniz");
            //        tutturdu = true;
            //        break;
            //    }
            //    else if (rastgele > tahmin)
            //    {
            //        Console.WriteLine("Küçük oldu!");
            //        tahminler.Add(tahmin);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Büyük oldu!");
            //        tahminler.Add(tahmin);
            //    }

            //}
            //if (!tutturdu)
            //{
            //    Console.WriteLine("Malesef bilemediniz.Sayı=" + rastgele);
            //    Console.WriteLine("Tahminleriniz:");
            //    foreach (var item in tahminler)
            //    {
            //        Console.Write(item + " ");
            //    }
            //}




            // 1-20 arasında rastgele 10'ar sayı üretip iki listeye atan ve daha sonra 
            // iki listede ortak olmayanları başka bir listeye atarak ekrana 
            // yazdıran program:
            // Örnek
            // Liste1 = 1 2 3 4 5 8 12 3 4 9
            // Liste2 = 2 3 11 13 15 8 5 6 7 9
            // Liste3 = 1 4 12 4 11 13 15 6 7
            // 
            List<int> liste1 = new List<int>();
            List<int> liste2 = new List<int>();
            List<int> liste3 = new List<int>();
            Random rand = new Random();
            Console.Write("Liste1= ");
            for (int i = 1; i <= 10; i++)
            {
                int sayi = rand.Next(1, 21);
                liste1.Add(sayi);
                Console.Write(sayi + " ");
            }
            Console.WriteLine();
            Console.Write("Liste2= ");
            for (int i = 1; i <= 10; i++)
            {
                int sayi = rand.Next(1, 21);
                liste2.Add(sayi);
                Console.Write(sayi + " ");
            }
            Console.WriteLine();

            foreach (var item in liste1)
            {
                if (liste2.Contains(item) == false)
                    if (liste3.Contains(item) == false)  // Duplike olmasın diye. 
                        liste3.Add(item);
            }
            foreach (var item in liste2)
            {
                if (liste1.Contains(item) == false)
                    if (liste3.Contains(item) == false) // Duplike olmasın diye. Aynı Sayi liste 3 te olmasın diye 
                        liste3.Add(item);
            }
            Console.WriteLine("Birleşim Liste3=");
            foreach (var item in liste3)
            {
                Console.Write(item + " ");
            }







            Console.ReadLine();
        }
    }
}
