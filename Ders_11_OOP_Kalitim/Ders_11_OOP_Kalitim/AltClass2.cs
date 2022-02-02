using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_11_OOP_Kalitim
{
    class AltClass2 : AnaClass
    {
        public string Baslik;
        public void BaslikYaz()
        {
            Console.WriteLine("Başlık:" + Baslik);
        }
    }
}
