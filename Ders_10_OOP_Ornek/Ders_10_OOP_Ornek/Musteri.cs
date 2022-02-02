using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_10_OOP_Ornek
{
    class Musteri
    {
        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyetler Cinsiyeti { get; set; }
        public UrunSepeti MusterininUrunSepeti{get; set;} 

        public void MusteriBilgileriYazdir()
        {

            Console.WriteLine("Musteri ID:" + MusteriID + "-" + 
             MusteriAdi + " " + MusteriSoyadi);
        }
        public bool MusterininDogumGunumu()
        {
            bool kontrol = false;
            if (DogumTarihi.Day == DateTime.Now.Day &&
                DogumTarihi.Month == DateTime.Now.Month)
                kontrol = true;
            return kontrol;
        }

        public void MusterininSepetiniYazdir()
        {
            if (MusterininDogumGunumu())
            {
                MusterininUrunSepeti.DogumGunuHediyesiEkle();
                Console.WriteLine("Doğum gününüz kutlu olsun. Gofret hediyeniz sepete eklendi.");
            }
            int sayac = 1;
            foreach (var item in MusterininUrunSepeti.UrunlerListesi)
            {
                Console.WriteLine(sayac + ". ürününüz:" + item.UrunAdi);
                sayac++;
            }

        }
    }
}
