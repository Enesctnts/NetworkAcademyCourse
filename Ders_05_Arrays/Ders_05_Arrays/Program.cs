using System;
using System.Linq;

namespace Ders_05_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ////tip[] diziAdi = new tip[boyut];
            //// int[] sayilar = new int[10];
            //int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //// int rakamlar=new int[10];

            //// int[] sayilar = new int[10]; 
            //// indis numaraları 0'dan başlar, birer birer artarak devam eder.

            //string isim1 = "Ahmet";
            //string isim2 = "Ali";
            //string isim3 = "Ayşe";
            //string isim4 = "Veli";
            //string isim5 = "Eda";

            //string[] isimler = new string[5];
            //isimler[0] = "Ahmet";
            //isimler[1] = "Ali";
            //isimler[2] = "Ayşe";
            //isimler[3] = "Veli";
            //isimler[4] = "Eda";


            //rakamlar.SetValue(130, 0); // ilk elemana 130 ata.
            //rakamlar[1] = 100; // ikinci elemana 100 ata
            //Console.WriteLine("rakamlar.GetValue(1)=" + rakamlar.GetValue(1));
            //Console.WriteLine("rakamlar[1]=" + rakamlar[1]);

            //Console.WriteLine("rakamlar.GetValue(0)=" + rakamlar.GetValue(0));
            //Console.WriteLine("rakamlar[0]=" + rakamlar[0]);

            //Console.WriteLine("rakamlar.GetType()=" + rakamlar.GetType());
            //Console.WriteLine("rakamlar.Length()=" + rakamlar.Length);
            ////rakamlar[10] = 100;  // index out of range hatası.

            //for(int i=0; i< isimler.Length;i++)
            //    Console.WriteLine("isimler[" + i + "]=" + isimler[i] );
            //Console.WriteLine("--------------------------------------------");
            //for (int i = 0; i < isimler.Length; i++)
            //    Console.WriteLine("isimler[" + i + "]=" + isimler.GetValue(i));

            //Console.WriteLine("--------------------------------------------");
            string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Adana" };
            //for (int i = 0; i < sehirler.Length; i++)
            //    Console.WriteLine("sehirler[" + i + "]=" + sehirler[i]);
            //Console.WriteLine("--------------------------------------------");
            //int k = 0;
            ////Foreach for ile benzer işi yapar, indis yerine doğrudan şehir bilgisine
            //// ulaşır. 
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine("Sehirler[" + k + "]=" + item);
            //    k++;
            //}

            //İki array yaratalım: 
            //string[] mySourceArray = new string[10];
            //mySourceArray[0] = "yuvalarında"; 
            //mySourceArray[1] = "uyuyan"; 
            //mySourceArray[2] = "üç"; 
            //mySourceArray[3] = "uykulu"; 
            //mySourceArray[4] = "tavuğun"; 
            //mySourceArray[5] = "5"; 
            //mySourceArray[6] = "6"; 
            //mySourceArray[7] = "7"; 
            //mySourceArray[8] = "8"; 
            //mySourceArray[9] = "9";

            //string[] myTargetArray = new string[15];
            //myTargetArray[0] = "Çevik";
            //myTargetArray[1] = "kahverengi";
            //myTargetArray[2] = "tilki";
            //myTargetArray[3] = "atladı";
            //myTargetArray[4] = "üstüne";
            //myTargetArray[5] = "tembel";
            //myTargetArray[6] = "köpeğin";

            //foreach (var item in myTargetArray)
            //{
            //    Console.WriteLine(item);
            //}
            //mySourceArray.CopyTo(myTargetArray, 5);
            //Console.WriteLine("--------------------------------------------");

            //for (int i = 0; i < mySourceArray.Length; i++)
            //{
            //    Console.WriteLine(i + " " + mySourceArray[i]);
            //}
            //Console.WriteLine("--------------------------------------------");
            //foreach (var item in myTargetArray)
            //{
            //    Console.WriteLine(item);
            //}

            //int indis = Array.IndexOf(sehirler, "Adana", 2);
            //Console.WriteLine("indis=" + indis);

            //// Kullanıcıdan alınan 10 adet isim bilgisini string bir diziye
            //// kaydedip, Daha sonra dizi elemanlarını ekrana yazdıran prog.

            //string[] isimler = new string[10]; // 10 elemanlı dizi.

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.Write("İsim giriniz: ");
            //    isimler[i] = Console.ReadLine();
            //}
            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------------------------------------------");
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine("İsim[" + i + "]=" + isimler[i]);
            //}

            //int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30, 90 };
            //Console.WriteLine("puanlar.Length=" + puanlar.Length);

            //int indis = Array.IndexOf(puanlar, 10);  // 0 gelir

            //// indexOf değerin ilk buunan indisini getirir.
            //indis = Array.IndexOf(puanlar, 10, 1); // 4 gelir
            //indis = Array.IndexOf(puanlar, 10, 5); // 6 gelir
            //indis = Array.IndexOf(puanlar, 20);  // 1 gelir
            //Console.WriteLine("indis=" + indis);

            //Array.Sort(puanlar);  // küçükten büyüğe
            //Array.Reverse(puanlar);  // büyükten küçüğe 
            //foreach (int item in puanlar)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("puanlar[9] = " + puanlar[9]);

            //Array.Sort(sehirler);  // küçükten büyüğe
            //                       // Array.Reverse(puanlar);  // büyükten küçüğe 
            //Array.Reverse(sehirler);
            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            //object[] karisikDizi = new object[10];
            //karisikDizi[0] = 10;
            //karisikDizi[1] = "Ayşe";
            //karisikDizi[2] = 15.4F;
            //karisikDizi[3] = 16.123D;

            //foreach (var item in karisikDizi)
            //{
            //    Console.WriteLine(item);
            //}
            //object eleman = "Ayşe";
            //int indis = Array.IndexOf(karisikDizi, eleman);
            //Console.WriteLine("indis=" + indis);

            //int[] ar = new int[10];
            //ar[0] = 123;
            //ar[9] = 124;
            //foreach (var item in ar)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Indexof=" + Array.IndexOf(ar, 0, 3));

            //eleman = 15.4;
            // indis = Array.IndexOf(karisikDizi, eleman);
            //Console.WriteLine("Indexof=" + Array.IndexOf(ar, 0));

            // 1 ile 10 arasında rastgele 10 sayı üretip bir diziye atın,
            // sonra da diziyi ekrana yazdırın.

            //Random rastgele = new Random();
            //int[] arraySayilar = new int[100];
            //    for (int i = 0; i<arraySayilar.Length; i++)
            //{
            //    arraySayilar[i] = rastgele.Next(1, 11);// 0, 10 verirsek 0,dan 9'a 
            //                                           // kadar çıkar,
            //}
            //int sayac = 0;
            //int cc = 0;
            //foreach (var item in arraySayilar)
            //{
            //    Console.Write(item + " ");
            //    sayac++;
            //    if (sayac%10 == 0 )
            //        Console.WriteLine("");
            //    //if (item == 7)
            //    //    count7++;


            //}
            //Console.WriteLine("7 sayısının adedi=" + cc);

            //Console.WriteLine("arraySayilar.Count()=" + arraySayilar.Count());

            //cc = arraySayilar.Count(sayi => sayi == 7);
            //Console.WriteLine("arraySayilar.Count()=" + cc);

            //cc = arraySayilar.Count(x => x == 5);
            //Console.WriteLine("arraySayilar.Count()=" + cc);

            //cc = arraySayilar.Count(x => x % 3 ==0);
            //Console.WriteLine("arraySayilar.Count()=" + cc);

            //Console.ReadLine();

            // Dizideki 10 değerlerinin index numaralarını ekrana yazdırın.
            // For döngüsü ile. 

            ////int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30, 90 };
            //int[] puanlar = new int[100000];
            //Random ran = new Random();
            //for (int i = 0; i < puanlar.Length; i++)
            //{
            //    puanlar[i] = ran.Next(1, 100);  
            //}

            //int startIndex = 0;
            //int adet10 = puanlar.Count(sayi => sayi == 10);
            //for (int i = 0; i < adet10; i++)
            //{
            //    startIndex = Array.IndexOf(puanlar, 10, startIndex);//puanlar içinde
            //    // 10 değerini arattır, startIndex ten başla. 
            //    Console.WriteLine("10 değeri " + startIndex + ". indexte var");
            //    startIndex += 1;
            //}



            //Console.WriteLine("--------------------------------");
            //for (int i = 0; i < puanlar.Length; i++)
            //{
            //    if (puanlar[i] == 10)
            //        Console.WriteLine("10 değeri " + i + ". indexte var");
            //}

            //// Arraydeki çift sayıların ve tek sayıların adedi.
            ////int[] sayilar = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 4 };

            ////int ciftSayilarinSayisi = sayilar.Count(c => c % 2 == 0);
            ////Console.WriteLine("ciftSayilarinSayisi=" + ciftSayilarinSayisi); //6
            ////Console.ReadLine();

            ////for (int i = 0; i < sayilar.Length; i++)
            ////    if (sayilar[i] %2==0)
            ////        Console.WriteLine(sayilar[i] + " ");

            //int[] sayilar2 = new int[100];
            //Random ran2 = new Random();
            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    sayilar2[i] = ran2.Next(1, 100);
            //}

            //Array.Sort(sayilar2);
            //Array.Reverse(sayilar2);
            ////int yok = Array.IndexOf(sayilar2, 102);





            //Console.WriteLine("sayilar2[102]=" + sayilar2[102]);// Run time error.

            //Console.ReadLine();
            //for (int i = 0; i < sayilar2.Length; i++)
            //    if (sayilar2[i] % 3 == 1)
            //        Console.Write(sayilar2[i] + " ");


            //// Diziden diziye kopyalama
            //int[] dizi1 = { 11, 41, 21, 32, 43, 54, 65, 66, 77, 86 };
            ////int[] dizi2 = new int[dizi1.Length + 5];

            ////dizi1.CopyTo(dizi2, 5); // dizi2'nin 0'ıncı elemanından itibaren 
            //////dizi1'i kopyala. 
            //int[] dizi2 = { 44, 55, 13, 14, 12, 54, 21, 33, 57, 56 };
            //Array.Copy(dizi1, dizi2, 3); //dizi1'den dizi2'ye 0.indisten itibaren 
            //                             // 3 elemanı kopyala.

            //for (int i = 0; i < dizi2.Length; i++)
            //    Console.WriteLine(dizi2[i]);

            //// dizi1'in 3.indisten itibaren 5 elemanı kopyala
            //// dizi2'ye 0. indisten itibaren yapıştır.
            //Array.Copy(dizi1, 3, dizi2, 0, 5);



            //int[] dizi3 = new int[20];
            //Random rnd3 = new Random();
            //for (int i = 0; i < 20; i++)
            //    dizi3[i] = rnd3.Next(1, 21);
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.Write(dizi3[i] + "--->");
            //    for (int j = 0; j < dizi3[i] % 5; j++)
            //        Console.Write("*");
            //    Console.WriteLine("");
            //}

            //ÇOK BOYUTLU DİZİLER

            //int[,] matris = new int[5, 5];
            //matris[0, 0] = 10;
            //matris[0, 4] = 20;
            //matris[4, 0] = 30;
            //matris[4, 4] = 40;

            //for(int i=0;i<5;i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Aşağıdaki çıktıyı veren matrisi döngü ile oluşturunuz:
            /* 
             2 0 0 0 2
             1 0 0 0 1
             2 0 0 0 2
             1 0 0 0 1
             2 0 0 0 2           
             */
            int[,] matris = new int[5, 5];
            //for (int satir = 0; satir < 5; satir++)
            //{
            //    for (int sutun = 0; sutun<5; sutun++)
            //    {
            //        if (satir % 2 == 0 && (sutun == 0 || sutun == 4))
            //            matris[satir, sutun] = 2;
            //        else if (satir % 2 == 1 && (sutun == 0 || sutun == 4))
            //            matris[satir, sutun] = 1;
            //        else  
            //            matris[satir, sutun] = 3;   
            //    }
            //    matris[satir, 2] = 0;
            //}

            //for (int satir = 0; satir < 5; satir++)
            //{
            //    for (int sutun = 0; sutun < 5; sutun++)
            //    {
            //        if (satir == sutun)
            //            matris[satir, sutun] = 1;
            //    }

            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i, j] + " ");
            //    }
            //    Console.WriteLine(); //İçteki döngü tamamlanınca alt satıra geç.
            //}



            //Aşağıdaki çıktıyı veren matrisi döngü ile oluşturunuz:
            /* 
             1 0 0 0 1
             0 1 0 1 0
             0 0 1 0 0
             0 1 0 1 0
             1 0 0 0 1           
             */
            //for (int satir = 0; satir < 5; satir++)
            //{
            //    for (int sutun = 0; sutun < 5; sutun++)
            //    {
            //        if (satir == sutun || satir + sutun == 4 )
            //            matris[satir, sutun] = 1;
            //    }

            //}



            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i, j] + " ");
            //    }
            //    Console.WriteLine(); //İçteki döngü tamamlanınca alt satıra geç.
            //}


            //2X3 matris, tüm elemanları 5 olsun. 

            //int[,] dizi2B = new int[2, 3];
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        dizi2B[i, j] = 5;
            //        Console.Write(dizi2B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // 2X4 lük bir dizi tanımlayın.
            // Her bir elemanı klavyeden alın.
            //Bu diziyi ekrana yazdırın. 
            //int[,] dizi24 = new int[2, 4];
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("Sayı:");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        dizi24[i, j] = sayi;
            //    }
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(dizi24[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //2 X 4 matris, Her satırın son değeri hariç klavyeden alınsın.
            // son kolon satırdaki sayıların toplamını tutsun. 
            // Örnek:
            // 1 2 3 6 
            // 4 5 6 15
            //int[,] dizi2 = new int[2, 4];
            //for (int i = 0; i < 2; i++)
            //{
            //    int satirToplam = 0;
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (j < 3)
            //        {
            //            Console.WriteLine("Sayı=");
            //            dizi2[i, j] = int.Parse(Console.ReadLine());
            //            satirToplam += dizi2[i, j];
            //        }
            //        else
            //            dizi2[i, 3] = satirToplam;

            //    }
            //}




            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(dizi2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////////////////////////
            // 3 boyutlu Diziler:  //
            ////////////////////////
            int[,,] dizi3B = new int[2, 3, 3];
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        dizi3B[i, j, k] = rnd.Next(1,1001);
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        dizi3B[i, j, k] = rnd.Next(1, 1001);
                        Console.Write(dizi3B[i, j, k]+" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("****************************");
                Console.WriteLine("****************************");
            }


        }
    }
}
