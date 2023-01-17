using KahveSiparişSimülasyonu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişSimülasyonu.Concrete
{
    internal class Barista : Calisan, IBarista
    {
        public event UrunHaberTipi UrunuHazirladim;

        public ISiparis HazirlananUrun { get; set; }

        public void UrunHazirla(ISiparis siparis)
        {
            Kahveler kahveler = new Kahveler();
            if (kahveler.Suresi == 0)
                UrunuHazirladim(siparis);
        }
    }
}
