using KahveSiparişSimülasyonu.Abstract;
using KahveSiparişSimülasyonu.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişSimülasyonu.Concrete
{
    internal class Kasiyer : Calisan, IKasiyer
    {

        public event MusaitlikDurumuHaber SiparisAlabilirim;
        public event UrunHaberTipi CalisandanSiparisiAldim;
        public event UrunHaberTipi MusteridenSiparisAldim;

        public Kasiyer()
        {
            SiparisAlabilirim(this);
        }


        public void Musaitim(object sender) 
        {
            Musteri  musteri = sender as Musteri;

            musteri.KasaBenGeldim += this.SiparisAlabilirim;
            this.SiparisAlabilirim += this.SiparisAl;
        }

        public void SiparisAl(object sender)
        {
            Barista barista = new Barista();

            if (Baristalar.Count > 0)
            {
                SiparisAlabilirim(this);

                IMusteri musteri = sender as IMusteri;
                ISiparis siparis = null;

                musteri.Siparis = siparis;
                MusteridenSiparisAldim(siparis);
            }

        }

        public void UrunAl(object sender)
        {
            throw new NotImplementedException();
        }

        internal MusaitlikDurumuHaber SiparisAl()
        {
            throw new NotImplementedException();
        }
    }
}
