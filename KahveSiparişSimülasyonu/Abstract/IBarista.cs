using KahveSiparişSimülasyonu.Concrete;

namespace KahveSiparişSimülasyonu.Abstract
{
    internal interface IBarista
    {
        event UrunHaberTipi UrunuHazirladim;

       ISiparis HazirlananUrun { get; set; }

        void UrunHazirla(ISiparis siparis);
    }
}
