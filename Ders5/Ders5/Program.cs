using System;

namespace Ders5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yıldız Aldoritması Zorrrr
            Console.Write("Yildizlar kac sutun  olsun: ");
            int sutun = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yildizlar kac satir  olsun: ");
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yıldızların içine ne yazmak istersiniz: ");
            string a = Console.ReadLine();
            Console.Clear();

            for (int i = 1; i <= satir; i++)
            {
                for (int j = 1; j <= sutun; j++)
                {
                    if (i == 1 || i == satir)
                    {
                        Console.Write("*");
                        
                    }
                    else
                    {
                        
                        if (j == 1 || j == sutun)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                            if (i == 2 && j ==2)
                            {
                                Console.Write(a);
                                j = (a.Length+2);
                            }
                            
                            
                        }
                    }
                }
                Console.WriteLine();

            }


            /*
            //Örnek2: Yıldız algoritmasi
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");

                }
                Console.Write("\n");
            }
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            */








            Console.ReadLine();
        }
    }
}
