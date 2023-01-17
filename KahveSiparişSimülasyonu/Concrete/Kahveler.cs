using KahveSiparişSimülasyonu.Abstract;
using KahveSiparişSimülasyonu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişSimülasyonu.Concrete
{
    internal class Kahveler : IKahveler
    {
        public KahveCesitleri KahveCesidi { get; set; }

        public double Suresi { get; set; }

        public KahveEkSecimler KahveEkMalzeme { get; set; } 
        

        public  int SureHesaplama()
        {
            int kahveSuresi = 300;

            if (KahveEkMalzeme == KahveEkSecimler.EkMalzemeIstemiyorum) ;

            else if (KahveEkMalzeme == KahveEkSecimler.Sut)
            {
                kahveSuresi += 10;

            }
            else if (KahveEkMalzeme == KahveEkSecimler.Karamel)
            {
                kahveSuresi += 25;
            }
            else if (KahveEkMalzeme == KahveEkSecimler.BeyazCikolata)
            {
                kahveSuresi += 45;
            }
            else if (KahveEkMalzeme == KahveEkSecimler.Findik)
            {
                kahveSuresi += 10;
            }

            return kahveSuresi;
            
        }

    }
}

namespace KahveSiparişSimülasyonu
{
    public enum KahveEkSecimler
    {
        EkMalzemeIstemiyorum,
        Sut,        
        Karamel,
        BeyazCikolata,
        Findik

    }

    
}