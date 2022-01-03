using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mükemmel sayiyi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int toplam = 0;
            for (int i = 1 ; i < sayi; i++)
            {
                if (sayi%i==0)
                {
                    toplam += i;
                }
            }
            if (toplam == sayi)
            {
                Console.WriteLine("Girilen sayi MÜKEMMEL sayidir.");
            }
            else
            {
                Console.WriteLine("Girilen sayi MÜKEMMEL sayi değildir");
            }
        }
    }
}
