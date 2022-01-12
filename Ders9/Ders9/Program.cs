using System;

namespace Ders9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayiyi Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi+ "!= " + faktoriyel(sayi));
            
        }
        static int faktoriyel(int sayi)
        {
            int fak = 1;
            
            for (int i = 2; i <= sayi; i++)
            {
                fak = fak * i;

            }
            return fak;
        }
    }
}
