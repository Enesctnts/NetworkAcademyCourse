using System;
using System.IO;

namespace Ders_04_While
{
    class Program
    {
        static void Main(string[] args)
        {

            //double prim = 6000;
            //double yilSayisi = 0;
            //while (prim < 7200)
            //{
            //    yilSayisi = (7200 - prim) / 360;
            //    Console.WriteLine("Emekliliğe daha " + Math.Round(yilSayisi, 2) +" yıl var, çalışmaya devam! ");
            //    Console.ReadLine();
            //    prim += 360;

            //}
            //Console.WriteLine("Tebrikler, emekli oldunuz :)");

            //While kullanarak 1'den 10'a kadar sayıları ekrana yazalım:
            //int limit = 1;
            //int sayi = -5;
            //Console.Write("Sayi:");
            //limit = Convert.ToInt32(Console.ReadLine());            
            //while (sayi <= limit)
            //{
            //    Console.WriteLine("Sayı=" + sayi);
            //    sayi++;
            //}

            //Klavyeden girilen değer ÇIK olmadığı sürece
            //alınan yazıları ekrana yazdıran prog.
            //While kullanarak.





            //Console.Write("Mesajınızı yazınız(Çıkmak için ÇIK yazınız):");
            //string yazi = ""; // Console.ReadLine();
            //while (yazi.ToLower() != "çık")
            //{
            //    Console.WriteLine(yazi);
            //    Console.Write("Mesajınızı yazınız(Çıkmak için ÇIK yazınız):");
            //    yazi= Console.ReadLine();
            //}
            //Console.WriteLine("Program sonlandı!");
            //Klavyeden girilen değer "bitir" olmadığı sürece alınan sayıları
            //Toplayıp, en son ekrana toplamı yazdıran prog. 
            //int toplam = 0;
            //int sayi;
            //try
            //{
            //    Console.Write("Sayı giriniz:");
            //    string str = Console.ReadLine();
            //    while (str.ToLower() != "bitir")
            //    {
            //        sayi = Convert.ToInt32(str);
            //        //if (int.TryParse(str, out sayi))
            //        {
            //            toplam += sayi;
            //        }
            //        Console.Write("Sayı giriniz:");
            //        str = Console.ReadLine();
            //    }
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("Dosya bulunamadı."  );
            //}

            //catch (SystemException e)
            //{
            //    Console.WriteLine("Sayı formatı hatalı, işlem yapılamadı!");
            //    Console.WriteLine("İşlemler geri alındı!");
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.Message);

            //}

            //finally
            //{
            //    if (toplam > 0)
            //        Console.WriteLine("Toplam=" + toplam);
            //}
            //Console.WriteLine("Program sona erdi");

            //Yıldız(*) ile 50 X 20 lik bir çerçeve olsun, içinde
            //üst tarafta Network Akademi yazsın.
            //Gerekirse while kullanılsın.
            //Console.WriteLine("**************************************************");
            //Console.WriteLine("* Network Akademi                                *");
            //int sayac = 1;
            //while (sayac <= 17)
            //{
            //    Console.WriteLine("*                                                *");
            //    sayac++;
            //}
            //Console.WriteLine("**************************************************");
            //Console.ReadLine();


            // en ve yukseklik klavyeden girilecek.
            // Zemin lacivert, yazılar sarı olsun.


            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //const int doluSatirSayisi = 3;
            //const int ikiYildiz = 2;

            //Console.Clear();

            ////int en = Convert.ToInt32( Console.ReadLine());
            //int en = 0, yukseklik = 0;
            //int minEn = 20;
            //int maxEn = 100;
            //int minYukseklik = 10;
            //int maxYukseklik = 30;
            //do
            //{
            //    Console.Write("En(20 ile 100 arası):");
            //    int.TryParse(Console.ReadLine(), out en);
            //} while (!(en >= minEn && en <= maxEn));
            //Console.Write("Yükseklik:");
            //do
            //{
            //    Console.Write("Yükseklik(10 ile 25 arası):");
            //    int.TryParse(Console.ReadLine(), out yukseklik);
            //} while (!(yukseklik >= minYukseklik && yukseklik <= maxYukseklik));
            // yukseklik = Convert.ToInt32(Console.ReadLine());

            // 

            //string uzun_cizgi = "*************************************************************************";
            //string network = "** Network Akademi                                                           ";
            //string bos_satir = "**                                                                          ";
            //try
            //{
            //    Console.WriteLine(uzun_cizgi.Substring(0, en));
            //Console.WriteLine(uzun_cizgi.Substring(0, en));
            //Console.WriteLine(network.Substring(0, en - 2) + "**");
            //int sayac = 1;

            //while (sayac <= yukseklik - doluSatirSayisi)
            //{
            //    Console.WriteLine(bos_satir.Substring(0, en - ikiYildiz) + "**");
            //    sayac++;
            //}
            //Console.WriteLine(uzun_cizgi.Substring(0, en));
            //Console.WriteLine(uzun_cizgi.Substring(0, en));
            //Console.ReadLine();
            //}
            //catch (SystemException e)
            //{
            //    Console.WriteLine("Bir hata oluştu, hata bilgisi:" + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Program sona erdi.");
            //}




            //int en = 44, yukseklik = 22;
            //int minEn = 19;
            //int maxEn = 99;
            //int minYukseklik = 10;
            //int maxYukseklik = 25;
            //do
            //{
            //    Console.Write("En(" + minEn +  " ile "+ maxEn +" arası):");
            //    int.TryParse(Console.ReadLine(), out en);
            //} while (!(en >= minEn && en <= maxEn));

            //do
            //{
            //    Console.Write("Yükseklik(" + minYukseklik + " ile "+maxYukseklik+" arası):");
            //    int.TryParse(Console.ReadLine(), out yukseklik);
            //} while (!(yukseklik >= minYukseklik && yukseklik <= maxYukseklik));
            //Console.WriteLine("en: " + en + " yükseklik:" + yukseklik);



            // Klavyeden girilen sayıları ekrana yazdıran prog.
            // koşullar: 5'in katlarında "BOM" yazsın, 19'un katı
            // girilince proramdan çıksın. 
            //int sayi = 0;
            //while (true)
            //{

            //    do
            //    {
            //        Console.Write("Sayı(10-1000 arası:");
            //        int.TryParse(Console.ReadLine(), out sayi);
            //    } while (!(sayi >= 10 && sayi <= 1000));
            //    if (sayi % 5 == 0)
            //    {
            //        Console.WriteLine("BOM");
            //    }
            //    if (sayi % 19 == 0)
            //    {
            //        Console.WriteLine("19'un katı girildi, döngüden çıkılıyor.");
            //        break;
            //    }
            //    // if (!(sayi % 5 == 0 && sayi % 19 == 0))
            //    Console.WriteLine(sayi.ToString());
            //}

            // 1-10 arasındaki sayıları yazdıran prog.
            // 7 ye gelince bir şey yazdırmasın, atlasın.
            // 9 gelince (9 u da yazıp) döngüden çıksın.
            //int i = 1;
            //while (i <= 15)
            //{
            //    if (i == 7)
            //    {
            //        i++;
            //        continue;
            //    }
            //    if (i == 10)
            //        break;
            //    Console.WriteLine(i);
            //    i++;
            //}
            // 1'den klavyeden girilen üst limit arası
            // sayıların tek mi çift mi
            // oldugunu ekrana yazan prog.

            //int sayi = 1;
            //int i = 1;
            //do
            //{
            //    Console.Write("Bitiş sayısı (1-1000 arası:");
            //    int.TryParse(Console.ReadLine(), out sayi);
            //} while (!(sayi >= 1 && sayi <= 1000));

            //while (i <= sayi)
            //{
            //    if (i % 2 == 1)
            //        Console.WriteLine(i + " sayısı tek  bir sayıdır." );
            //    else
            //        Console.WriteLine(i + " sayısı çift bir sayıdır.");
            //    i++;
            //}

            int sayı = 1;
            int i = 0;
            do    // Önce sayıyı alıyoruz.
            {
                Console.WriteLine("Sayı(1-1000 arası):");
                int.TryParse(Console.ReadLine(), out sayı);

            }
            while (!(sayı >= 1 && sayı <= 1000));
            //
            while (true)
            {

                if (i % 2 == 1)
                    Console.WriteLine(i + " sayısı tek  bir sayıdır.");
                else
                    Console.WriteLine(i + " sayısı çift bir sayıdır.");
                i++;
                if (i == sayı + 1)
                    break;
            }

            //Console.WriteLine(sayı);

        }

    }
}

