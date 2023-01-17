using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişSimülasyonu.Concrete
{
    internal class TurkKahvesi : Kahveler
    {
        public int HazırlanmaSüresi()
        {
            return base.SureHesaplama() + 120;


        }
    }
}
