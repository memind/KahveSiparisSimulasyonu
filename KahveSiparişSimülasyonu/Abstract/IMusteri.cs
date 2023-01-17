using KahveSiparişSimülasyonu.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişSimülasyonu.Abstract
{
    internal interface IMusteri
    {
        public event MusaitlikDurumuHaber KasaBenGeldim;
        public event MusaitlikDurumuHaber KasiyerUrunuAlmayaGeldim;

        public bool SiraDurum { get; set; }
        public ISiparis Siparis { get; set; }

        public void SiparisVer();
        public void SiraGeldiMiKontrol();
    }
}
