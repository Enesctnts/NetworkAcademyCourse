using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_10_OOP_Ornek
{
    class UrunSepeti
    {
        public int SepetId { get; set; }
        public int MusteriId { get; set; }
        public List<Urun> UrunlerListesi = new List<Urun>();

        public void DogumGunuHediyesiEkle()
        {
            Urun hediye = new Urun()
            {
                UrunAdi = "Hediye Gofret",
                UrunId = 300,
                UrunKategorisi = UrunKategorileri.Gıda
            };
            UrunlerListesi.Add(hediye);
        }

    }
}
