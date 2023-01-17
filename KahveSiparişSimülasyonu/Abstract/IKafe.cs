using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparişSimülasyonu.Abstract
{
    internal interface IKafe
    {
        public List<ICalisan> KasaElemanlari{ get; set; }
        public List<ICalisan> KahveHazirlamaElemanlari { get; set; }
        public int KasaElemanSayisi{ get; set; }
        public int KahveHazirlamaElemaniSayisi { get; set; }
        void MesaiBaslat(int kasaSayisi);

        void MesaiBitir();


    }
}
