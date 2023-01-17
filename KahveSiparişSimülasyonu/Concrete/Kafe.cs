using KahveSiparişSimülasyonu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişSimülasyonu.Concrete
{

    public delegate void MusaitlikDurumuHaber(object sender);
    public delegate void UrunHaberTipi(ISiparis param);

    internal class Kafe : IKafe
    {
        public int CalisanSayısı = 6; //Sabit çalışan sayisi 6

        public List<ICalisan> KasaElemanlari { get; set; }

        public List<ICalisan> KahveHazirlamaElemanlari { get; set; }


        public ICalisan Calisan { get; set; }

        public Abstract.ISiparis Siparis { get; set; }
        public string musteri { get; set; }


        private int _KasaElemanSayisi;

        public int KasaElemanSayisi
        {
            get { return _KasaElemanSayisi; }
            set
            {
                if (value > 3)
                {
                    _KasaElemanSayisi = 3;
                }
                else
                    _KasaElemanSayisi = value;
            }
        }

        public int KahveHazirlamaElemaniSayisi { get; set; }

        public void MesaiBaslat(int kasaSayisi)
        {
            if (kasaSayisi > 3)
            {
                KahveHazirlamaElemaniSayisi = 3;

                for (int kasiyerSayac = 0; kasiyerSayac < KasaElemanSayisi; kasiyerSayac++)
                {
                    Kasiyer kasiyer = new Kasiyer();
                    KasaElemanlari.Add(kasiyer);
                }

                for (int baristaSayac = 0; baristaSayac < 6 - KasaElemanSayisi; baristaSayac++)
                {
                    Calisan barista = new Calisan();
                    KahveHazirlamaElemanlari.Add(barista);
                }
            }

            else
            {
                KasaElemanSayisi = kasaSayisi;
                KahveHazirlamaElemaniSayisi = 6 - kasaSayisi;

                for (int kasiyerSayisi = 0; kasiyerSayisi < KasaElemanSayisi; kasiyerSayisi++)
                {
                    Kasiyer kasiyer = new Kasiyer();
                    KasaElemanlari.Add(kasiyer);
                }

                for (int baristaSayac = 0; baristaSayac < KahveHazirlamaElemaniSayisi; baristaSayac++)
                {
                    Calisan barista = new Calisan();
                    KahveHazirlamaElemanlari.Add(barista);
                }

            }
        }

        public void MesaiBitir()
        {
            throw new NotImplementedException();
        }

    }
}

