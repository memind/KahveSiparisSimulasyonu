using KahveSiparişSimülasyonu.Abstract;
using KahveSiparişSimülasyonu.Concrete;
namespace KahveSiparişSimülasyonu.Concrete
{
    public class Siparis : ISiparis
    {
        string ISiparis.Siparis { get; set; }
        public KahveEkSecimler EkSecim { get; set; }
    }
}
