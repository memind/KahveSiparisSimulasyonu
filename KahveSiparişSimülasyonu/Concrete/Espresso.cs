﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişSimülasyonu.Concrete
{
    internal class Espresso : Kahveler
    {
        public int HazirlanmaSuresi()
        {
            return base.SureHesaplama() + 30;
        }
    }
}
