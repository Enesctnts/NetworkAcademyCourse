using System;
using System.Collections.Generic;

namespace Ders_07_Metotlar_3
{
    class Program
    {
        static List<long> TCler = new List<long>();
        static List<string> adSoyadlar = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefonlar = new List<string>();

        static void Main(string[] args)
        {
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
            //List<int> liste1 = new List<int>();
            //List<int> liste2 = new List<int>();
            //List<int> liste3 = new List<int>();
            //Random rand = new Random();
            //Console.Write("Liste1=" );
            //for (int i = 1; i <= 10; i++)
            //{
            //    int sayi = rand.Next(1, 21);
            //    liste1.Add(sayi);
            //    Console.Write(sayi  + " ");
            //}
            //Console.WriteLine();
            //Console.Write("Liste2=");
            //for (int i = 1; i <= 10; i++)
            //{
            //    int sayi = rand.Next(1, 21);
            //    liste2.Add(sayi);
            //    Console.Write(sayi + " ");
            //}
            //Console.WriteLine();

            //foreach (var item in liste1)
            //{
            //    if (liste2.Contains(item) == false)
            //        if(liste3.Contains(item) == false)  // Duplike olmasın diye. 
            //        liste3.Add(item);
            //}
            //foreach (var item in liste2)
            //{
            //    if (liste1.Contains(item) == false)
            //        if (liste3.Contains(item) == false) // Duplike olmasın diye. 
            //            liste3.Add(item);
            //}
            //Console.WriteLine("Birleşim Liste3=" );
            //foreach (var item in liste3)
            //{
            //    Console.Write(item + " ");
            //}

            //double r = 34.5;
            ////double pi = 3.14;
            //double cevre = CevreBul(r, 3.14);
            //Console.WriteLine(cevre);

            //Console.WriteLine(Topla());
            //Console.WriteLine(Topla(b:7));
            //Console.ReadLine();

            //Kendisine gönderilen double dizisini float dizisine çeviren
            // MakeItFloat isimli metodu yazınız. 
            //double[] d = new double[10] { 1.2,2.3,3.4,5,5,5,5,5,5,6};
            //float[] f = MakeItFloat(d);

            //foreach (var item in f)
            //{
            //    Console.Write(item + " ");
            //}

            // Liste içinde liste
            //List<object> listem = new List<object>();
            //List<int> sayilarim1 = new List<int> { 23, 34, 45, 77 };
            //List<int> sayilarim2 = new List<int> { 65, 54, 21 };

            //listem.Add(sayilarim1);
            //listem.Add(sayilarim2);
            //foreach (List<int> liste in listem)
            //{
            //    foreach (var item in liste)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine();
            //}
            //Basit bir Personel Bilgi Sistemi:
            // TC(long), adSoyad string, adres string, telefon string için birer tane liste
            // tanımlayınız. PersonelIndexGetir(tc),PersonelEkleGuncelle(başarılı ise true döndür)
            // PersonelGetir: (TC veya adSoyad ile arama yapacak) tüm bilgileri tek string olarak döndür.
            //PersonelSil(tc): Remove edecek.
            //
            //Ödev: PersonelEkleGuncelle yi PersonelGuncelle ve PersonelEkle olarak yazınız. 

            int index = PersonelIndexGetir(67309105720);
            Console.WriteLine("index=" + index);
            bool basarili = PersonelEkleGuncelle(tc: 67309105720,
                                 adSoyad: "Veysel Perü",
                                 adres: "SahrayıCedit/Kadıköy...",
                                 telefon: "05327741763");
              basarili = PersonelEkleGuncelle(tc: 11111111112,
                                 adSoyad: "Ezgi",
                                 adres: "Bostancı...",
                                 telefon: "05321111111");
              basarili = PersonelEkleGuncelle(tc: 22222222222,
                                 adSoyad: "Şükrü",
                                 adres: "Sarıgazi...",
                                 telefon: "05322222222");
              basarili = PersonelEkleGuncelle(tc: 3333333333,
                                 adSoyad: "Uğur Okan",
                                 adres: "Bağcılar...",
                                 telefon: "05323333333");
              basarili = PersonelEkleGuncelle(tc: 44444444444,
                                 adSoyad: "Melike",
                                 adres: "Beşiktaş...",
                                 telefon: "05324444444");
            index = PersonelIndexGetir(67309105720);
            Console.WriteLine("index=" + index);
            
            basarili = PersonelEkleGuncelle(tc: 67309105720,
                                 telefon: "0555 5555555");
            for (int i = 0; i < TCler.Count; i++)
            {
                 
                Console.WriteLine(TCler[i]);
                Console.WriteLine(adSoyadlar[i]);
                Console.WriteLine(adresler[i]);
                Console.WriteLine(telefonlar[i]);
                
            }
            Console.WriteLine(PersonelGetir(tc: 67309105720, adSoyad: "Ezgi123"));
            Console.WriteLine(PersonelGetir(tc: 44444444444));
            basarili = PersonelSil(44444446666);
            Console.WriteLine(PersonelGetir(tc: 44444444444));
            
            string p = PersonelGetir( adSoyad: "Ezgi");
            Console.WriteLine(p);
            Console.ReadLine();
        } // Main sonu 

        static bool PersonelSil(long tc)
        {
            if (tc>0)
            {
                int index = PersonelIndexGetir(tc);
                if (index != -1)
                {
                    TCler.RemoveAt(index);
                    adSoyadlar.RemoveAt(index);
                    adresler.RemoveAt(index);
                    telefonlar.RemoveAt(index);
                    return true;
                }

            }
            return false;
        }
        static string PersonelGetir(long tc=0, string adSoyad="")
        {
            int personelIndex = -1;
            string personel="";
            if (adSoyad != "") personel = "Ad soyad " + adSoyad + " bulunamadı";
            if (tc != 0) personel = "TC " + tc + " bulunamadı";
            if (tc != 0)
            {
                personelIndex = TCler.IndexOf(tc);//PersonelIndexGetir(tc);
            }
            else
            {
                    personelIndex = adSoyadlar.IndexOf(adSoyad);
            }
            if (personelIndex!=-1)
            {
                personel = Convert.ToString(TCler[personelIndex]) + " " + 
                    adSoyadlar[personelIndex] + " " +
                    adresler[personelIndex] + " " +
                    telefonlar[personelIndex];
            }
            return personel;
        }

        static int PersonelIndexGetir(long tc)
        {
            int personelIndex = -1;
            if (TCler.Contains(tc))
            {
                personelIndex = TCler.IndexOf(tc);
            }
            return personelIndex;
 }

        private static bool PersonelEkleGuncelle(long tc=0, string adSoyad="", string adres="", string telefon="")
        {
            int personelIndex = -1;
            if (!TcGecerli(tc))
            {
                Console.WriteLine("TC formatı yanlış. ("+ tc + ")  Entera basınız.");
                Console.ReadLine();
                return false;
            }
            if (tc==0)
            {
                Console.WriteLine("TC sıfır olamaz. Entera basınız.");
                Console.ReadLine();
                return false;
            }
            else 
            {
                personelIndex = PersonelIndexGetir(tc);
                if(personelIndex == -1)       // Personel yok, o zaman ekleyeceğiz.
                {
                    if (adSoyad == "")
                    {
                        Console.WriteLine("Ad Soyad boş olamaz. Entera basınız.");
                        Console.ReadLine();
                        return false;
                    }
                    TCler.Add(tc);
                    adSoyadlar.Add(adSoyad);
                    adresler.Add(adres);
                    telefonlar.Add(telefon);
                }
                else   // TC var, o zaman güncelle!
                {
                    if (adSoyad!="") adSoyadlar[personelIndex] = adSoyad;
                    if (adres!="") adresler[personelIndex] = adres;
                    if (telefon!="") telefonlar[personelIndex] = telefon;
             }
            }
            return true;
        }

        private static bool TcGecerli(long tc)
        {
            if (tc < 10000000000 || tc > 99999999999)
                return false;
            else
                return true;

        }

        static float[] MakeItFloat(double[] doubleArray)
        {
            float[] floatArray = new float[doubleArray.Length];
            for (int i = 0; i < doubleArray.Length; i++)
            {
                floatArray[i] = (float)doubleArray[i];
            }
            return floatArray;
        }

        static int[] MakeItInt(double[] doubleArray)
        {
            int[] intArray = new int[doubleArray.Length];
            for (int i = 0; i < doubleArray.Length; i++)
            {
                intArray[i] = (int)doubleArray[i];
            }
            return intArray;
        }

        static double CevreBul(double r, double pi = 3.14159275358)
        {
            return r * pi;
            //how I wish a drink alcocolic of course after the heavy lectures
        }
        static double Topla(int a = 10, int b = 20)
        {
            return a + b;
            //how I wish a drink alcoholic of course after the heavy lectures
        }
    }
}
