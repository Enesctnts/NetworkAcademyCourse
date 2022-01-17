using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_05_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // List Dizilerden farklı olarak: Kapasitesi sınırlı değildir.
            // otomatik genişler. 

            //Tanımlama
            List<int> ilkListem = new List<int>();
            List<string> sehirler = new List<string>() { "İstanbul", "İzmir", "Manisa", "Van" };

            // string[] sehirler2 = new string[] { "İstanbul", "İzmir", "Manisa", "Van" };
            //List<int> araListe = new List<int>() { 1000, 2000, 3000 };
            //// Veri ekleme
            //ilkListem.Add(1990); // Add metodu listenin sonuna ekleme yapar. 
            ////Add en sona ekliyor, insert araya sıkıştırıyor. 
            //ilkListem.Add(1231);
            //ilkListem.Add(1921);
            //ilkListem.Insert(0, 1988); // 0. indexe 1988 atar. 
            //ilkListem.InsertRange(2, araListe); // 2. sıraya aralisteyi koyar.



            ////ilkListem.AddRange(ilkListem);
            //foreach (var item in ilkListem)
            //{
            //    Console.WriteLine(item);
            //}


            //ilkListem.AddRange(araListe);
            //Console.WriteLine("----------------------- ");

            //foreach (var item in ilkListem)
            //{
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    if (item == 1000 || item == 2000 || item == 3000)
            //        Console.BackgroundColor = ConsoleColor.Red;
            //    else
            //        Console.BackgroundColor = ConsoleColor.Black;

            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();
            //Console.Clear();
            //Console.BackgroundColor = ConsoleColor.Black;

            //Console.WriteLine("1231 in indexi=" + ilkListem.IndexOf(1231));
            //Console.WriteLine("----------------------- sort");
            //ilkListem.Sort();
            //foreach (var item in ilkListem)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("1231 in indexi sıralama sonrası=" + ilkListem.IndexOf(1231));


            //Console.WriteLine("Listedeki elemanların sayısı= " + ilkListem.Count) ;

            //ilkListem.Clear();
            //foreach (var item in ilkListem)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
            //sehirler.Add("Hakkari");
            //Console.WriteLine("2. indisteki şehir" + sehirler[2]);
            //Console.WriteLine("Sehirler.Remove(İstanbul)"); 
            //sehirler.Remove("İstanbul");
            //Console.WriteLine("2. indisteki şehir" + sehirler[2]);
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            //// Listede var mı? 
            //bool sivasCheck = sehirler.Contains("Sivas");
            //if (sivasCheck)
            //    Console.WriteLine("Sivas listede var");
            //else
            //    Console.WriteLine("Sivas listede yok");
            //sehirler.Insert(3, "Urfa");

            ////sehirler.RemoveAt(1);

            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            //sehirler.Sort();
            //int indexBinary = sehirler.BinarySearch("Urfa");
            //Console.WriteLine("indexBinary=" + indexBinary);
            //Console.ReadLine();

            List<string> liste = new List<string>();
            liste.Add("Ahmet");
            liste.Add("Ayşe");
            liste.Add("Selvi");
            liste.Add("Müslüm");
            liste.Add("Betül");
            liste.Add("Okan");
            liste.Add("Hayri");
            // List yapılarında boyut sınırlı değil. 

            Console.WriteLine(liste[0]);
            Console.WriteLine(liste[1]);

            int v = liste.Count;
            Console.WriteLine("Listedeki eleman sayısı:" + v);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------");
            //liste.Remove("Hayri");
            //liste.RemoveAt(0);

            ////liste.Remove("Selvi");
            //int indis = -1;
            //for(int i = 0; i<liste.Count; i++)
            //{
            //    if (liste[i].ToUpper() == "selvi".ToUpper())
            //    {
            //        indis = i;
            //        break;
            //    }
            //}
            //if (indis != -1)
            //    liste.RemoveAt(indis);
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}
            //Program p = new Program();

            if (ElemanListedeVarMi(liste, "Ayşe"))
                Console.WriteLine("Ayşe var.");
            else
                Console.WriteLine("Listede Ayşe yok.");
            Console.ReadLine();
        }
        public static bool ElemanListedeVarMi(List<string> adlar, string arananAd)
        {
            foreach (var isim in adlar)
            {
                if (isim == arananAd)
                    return true;
            }
            return false;
        }



    }
}

