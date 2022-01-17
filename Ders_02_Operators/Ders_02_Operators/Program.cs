using System;

namespace Ders_02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            double a, b, c, d, sonuc1, sonuc2, sonuc3;
            a = 5;
            b = 10;
            c = 20;
            d = 30;
            sonuc1 = a * b / c + d;
            Console.WriteLine("Sonuc = " + sonuc1.ToString());

            sonuc2 = a * b / (c + d);
            Console.WriteLine("Sonuc = " + sonuc2.ToString());

            double miktar = 10 % 4;
            //miktar += 5; //miktarın var olan değerine 5 ekler. 
            Console.WriteLine("Miktar = " + miktar.ToString());
            //miktar -= 6;
            //Console.WriteLine("Miktar = " + miktar.ToString());
            //miktar *= 3;
            //Console.WriteLine("Miktar = " + miktar.ToString());
            //miktar /= 4;
            //Console.WriteLine("Miktar = " + miktar.ToString());

            byte minikSayı = 76;
            minikSayı++;
            ++minikSayı;
            

            byte ikinciSayı = ++minikSayı; // Önce bir artırıyor, sonra atama işlemi yapıyor.  
            ikinciSayı = minikSayı++; // Önce atama işlemi yapıyor, sonra bir artırıyor. 
            Console.WriteLine("ikinciSayı = " + ikinciSayı.ToString());
            Console.WriteLine("Miniksayı = " + minikSayı.ToString());

            int deger1 = 8;
            int deger2 = deger1++; // değer2 = 8, deger1=9 olur. 
            Console.WriteLine("deger1 = " + deger1.ToString());
            Console.WriteLine("deger2 = " + deger2.ToString());

            //   > < == != 
            int s1 = 90;
            int s2 = 99;

            //bool s1_buyuk_s2 = (s1 > s2); // false
            //if (s1 > s2)
            //    Console.WriteLine("s1 büyüktür s2");
            //else if (s1 < s2)
            //    Console.WriteLine("s1 küçüktür s2");
            //else if (s1 == s2)
            //    Console.WriteLine("s1 eşittir s2");

            if (s1 == s2)
            Console.WriteLine("s1 eşittir s2");

            // as is 
            object obj = "Veysel";
            string yazi = obj as string;
            //string yazi = obj as string; //

            bool intMi = yazi is int;
            Console.WriteLine("intMi=" + intMi.ToString());

            bool stringMi = yazi is string;
            Console.WriteLine("stringMi=" + stringMi.ToString());

            // Mantıksal Operatörler: 
            // && ||   !

            int sayi = 5;
            bool notGecerli = sayi <= 100 && sayi >= 0; // iki koşul da sağlanırsa true.
            //Console.WriteLine("notGecerli=" + notGecerli.ToString());
            if (notGecerli)
                Console.WriteLine("not geçerli , " + sayi + " aldınız");
            string ifade =  sayi.ToString();

            int s3 = 45;
            bool kont = !(s3 != 55 && s3 < 78);

            // Bitsel Operatorler & | ~
            byte bSayi = 5; // 0101
            byte iSayi = 1; // 0001
            int sonuc4 = bSayi & iSayi;
            Console.WriteLine("sonuc4 = " + sonuc4);

            uint a5 = 65;
            uint b5 = ~a5;
            Console.WriteLine(Convert.ToString(b5, toBase: 2));

            //Bitsel sağa kaydırma >> (2 ye böler.)
            byte bs = 6; // 0110 --> 0011
            byte bs2 = (byte) (bs << 1);
            Console.WriteLine("bs2=" + bs2);





        }
    }
}
