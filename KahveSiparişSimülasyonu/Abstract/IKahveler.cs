using KahveSiparişSimülasyonu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişSimülasyonu.Abstract
{
    internal interface IKahveler
    {
        public KahveCesitleri KahveCesidi { get; set; }
        public KahveEkSecimler KahveEkMalzeme { get; set; }
        public double Suresi { get; set; }

        public int SureHesaplama();

    }
}
