using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_11_OOP_Kalitim.Sahibinden
{
    enum Kategori
    {
        Masaüstü_Bilgisayar,
        Dizüstü_Bilgisayar,
        Temizlik_Ürünü
    }
    class Ilan
    {
        // Ilan: IlanNo,Baslik, IlanTarihi,
        // Kategori, Fiyat, Satıcı(Kullanici sinifindan)
        // BilgiYaz, IndirimYap(yuzde)
        private long _IlanNo;
        public long IlanNo
        {
            get { return _IlanNo; }
            set
            {
                try
                {
                    _IlanNo = value;
                }
                catch
                {
                    Console.WriteLine("Atama yapılamadı.");
                }
            }
        }

        private string _Baslik;
        private DateTime _IlanTarihi;
        private Kategori _Kategori;
        private double _Fiyat;
        private Kullanici _Satici;

        public string Baslik
        { get => _Baslik; set => _Baslik = value; }
        public DateTime IlanTarihi
        { get => _IlanTarihi; set => _IlanTarihi = value; }
        public Kategori Kategori
        { get => _Kategori; set => _Kategori = value; }
        public double Fiyat
        { get => _Fiyat; set => _Fiyat = value; }
        public Kullanici Satici
        { get => _Satici; set => _Satici = value; }


    }
}
