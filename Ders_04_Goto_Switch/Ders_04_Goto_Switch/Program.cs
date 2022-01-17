using System;

namespace Ders_04_Goto_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // İstenilen Sayının Faktöriyelini alan prog. 
            // 5 faktoriyel= 5*4*3*2*1=120

            //    int GirilenSayi = Convert.ToInt32(Console.ReadLine());
            //    int fak = 1;
            //    int i = GirilenSayi;
            //FaktoriyelHesap:
            //    fak *= i;
            //    i--;
            //    if (i > 1)
            //        goto FaktoriyelHesap;
            //    Console.WriteLine(GirilenSayi + " sayısının faktoriyeli=" + fak.ToString());


            // Formül (Math.Pow) kullanmadan :
            // Klavyeden taban ve üs bilgisi alın, tabanın üs bilgisine 
            // göre kuvvetini hesaplayın. 
            //    int taban = 9;
            //    int ust = 4;
            //    int usSakla = ust;
            //    int sonuc = 1;
            //kuvvetHesapla:
            //    sonuc *= taban;
            //    ust--;
            //    if (ust > 0)
            //        goto kuvvetHesapla;
            //    Console.WriteLine(taban +" sayısının " + usSakla + " kuvveti=" + sonuc);

            // Klavyeden girilen sayı 0-100 arasında değil ise
            // tekrar isteyen program yazalım.
            // Yukardaki şekilde 3 sayı alıp aritmetik ortalamasını
            // alan prog. yazınız. 
            //    double toplam = 0;
            //    int sayac = 1;
            //labelSayiIste:
            //    Console.Write(sayac + ". Sayı: ");
            //    int s = Convert.ToInt32(Console.ReadLine());
            //    if (s >= 0 && s <= 100)
            //    {
            //        toplam += s;
            //        sayac++;
            //    }
            //    else
            //    {
            //        goto labelSayiIste;
            //    }
            //    if (sayac <= 3)
            //        goto labelSayiIste;
            //    Console.WriteLine("3 sayının ortalaması:" + Math.Round((toplam / 3), 2));

            ///////////////////////////////
            /// Switch Case             ///
            //////////////////////////////
            ///
            //string seviye = "orta";
            //switch (seviye)
            //{
            //    case "kolay":
            //        Console.WriteLine("Seviye = kolay");
            //        break;
            //    case "orta":
            //        Console.WriteLine("Seviye = orta");
            //        break;
            //    case "zor":
            //        Console.WriteLine("Seviye = zor");
            //        break;
            //    default:
            //        Console.WriteLine("Seviye hatalı");
            //        break;

            //}

            //Klavyeden 2 sayı ve işlem bilgisi alıp.
            //Switch kullanarak seçilen işleme göre sonucu
            // gösterecek prog.
            // İşlem toplama, çıkarma, çarpma, bölme , çıkış
            //Hatalı işlem veya çıkış seçilirse program sona erecek,
            //aksi taktirde işleme deva edecek.
            islemYap:
            Console.WriteLine("Sayı 1:");
            float sayi1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Sayı 2:");
            float sayi2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("İşlem: toplama, çıkarma, çarpma, bölme , çıkış ");
            string islem = Console.ReadLine();
            switch (islem)
            {
                case "toplama":
                    Console.WriteLine("Toplam=" + (sayi1 + sayi2));
                    break;
                case "çıkarma":
                    Console.WriteLine("Fark=" + (sayi1 - sayi2));
                    break;
                case "çarpma":
                    Console.WriteLine("Çarpım=" + (sayi1 * sayi2));
                    break;
                case "bölme":
                    if (sayi2 != 0)
                    {
                        Console.WriteLine("Bölüm=" + (sayi1 / sayi2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bölen 0 olamaz!");
                        break;
                    }
                case "çıkış":
                    break;                    
                default:
                    Console.WriteLine("Hatalı İşlem!");
                    break;
            }
            if (islem != "çıkış")
                goto islemYap;
        cikis:
            Console.WriteLine("İşlem sona erdi.");


        }
    }
}
