using System;

namespace Ders2
{
    class Program
    {
        // Kdv kaç kuruştur.
        static void Main(string[] args)
        {
            double d = 4.5;
            double  kdv = (d*18)/118;
            int kurus = Convert.ToInt32(kdv * 100);
            Console.WriteLine("Kurus= " + kurus);
        }
    }
}
