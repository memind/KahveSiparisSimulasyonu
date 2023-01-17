using KahveSiparişSimülasyonu.Abstract;

namespace KahveSiparişSimülasyonu.Concrete
{
    internal class Calisan : ICalisan
    {
        public List<ICalisan> Calisanlar { get; set; }
        public List<ICalisan> Baristalar { get; set; }
        public List<ICalisan> Kasiyerler { get; set; }
        public int KasiyerSayisi { get; set; }
        public int BaristaSayisi { get; set; }
    }
}
