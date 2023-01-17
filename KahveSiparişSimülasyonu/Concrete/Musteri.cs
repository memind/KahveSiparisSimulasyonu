using KahveSiparişSimülasyonu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişSimülasyonu.Concrete
{
    internal class Musteri : IMusteri
    {
        public event MusaitlikDurumuHaber KasaBenGeldim;
        public event MusaitlikDurumuHaber KasiyerUrunuAlmayaGeldim;

        public bool SiraDurum { get; set; }
        public ISiparis Siparis { get; set; }
        public Kahveler KahveSecimi { get; set; }

        public void SiparisiAl(ISiparis siparis)
        {
            if (siparis == Siparis)
                KasiyerUrunuAlmayaGeldim(this);
        }

        public void SiraGeldiMiKontrol()
        {
            SiparisVer();
        }

        public void SiparisVer()
        {
            if (SiraDurum == true)
                KasaBenGeldim(this);
        }
    }
}
