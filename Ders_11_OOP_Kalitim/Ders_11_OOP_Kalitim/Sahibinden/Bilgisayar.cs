using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_11_OOP_Kalitim.Sahibinden
{
    class Bilgisayar:Ilan
    {
        private string _Marka;
        private string _Islemci;
        private string _Bellek;
        private short _HDD;
        private short _SSD;
        private bool _EthernetVarMi;
        private bool _WifiVarMi;

        
        public string Marka { get => _Marka; set => _Marka = value; }
        public string Islemci { get => _Islemci; set => _Islemci = value; }
        public string Bellek { get => _Bellek; set => _Bellek = value; }
        public short HDD { get => _HDD; set => _HDD = value; }
        public short SSD { get => _SSD; set => _SSD = value; }
        public bool EthernetVarMi { get => _EthernetVarMi; set => _EthernetVarMi = value; }
        public bool WifiVarMi { get => _WifiVarMi; set => _WifiVarMi = value; }
 }
}
