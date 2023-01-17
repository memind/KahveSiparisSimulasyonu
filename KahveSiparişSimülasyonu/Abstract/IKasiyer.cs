using KahveSiparişSimülasyonu.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişSimülasyonu.Abstract
{
    internal interface IKasiyer
    {
        public event MusaitlikDurumuHaber SiparisAlabilirim;
        public event UrunHaberTipi CalisandanSiparisiAldim;
        public event UrunHaberTipi MusteridenSiparisAldim;

        public void Musaitim(object sender);
        public void UrunAl(object sender);
        public void SiparisAl(object sender);
    }
}
