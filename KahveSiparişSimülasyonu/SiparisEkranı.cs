using KahveSiparişSimülasyonu.Abstract;
using KahveSiparişSimülasyonu.Concrete;
using KahveSiparişSimülasyonu.Enum;

namespace KahveSiparişSimülasyonu
{
    public partial class SiparisEkranı : Form
    {
        public SiparisEkranı()
        {
            InitializeComponent();
        }

        static IKafe kahveDukkani;
        static ICalisan calisan = new Calisan();
        private void SiparişEkranı_Load(object sender, EventArgs e)
        {
            cmbKahveTuru.Items.Add(KahveCesitleri.Amerikano);
            cmbKahveTuru.Items.Add(KahveCesitleri.Espresso);
            cmbKahveTuru.Items.Add(KahveCesitleri.DutchMochaMintLatte);
            cmbKahveTuru.Items.Add(KahveCesitleri.TurkKahvesi);

            cmbEkSecim.Items.Add(KahveEkSecimler.EkMalzemeIstemiyorum);
            cmbEkSecim.Items.Add(KahveEkSecimler.Sut);
            cmbEkSecim.Items.Add(KahveEkSecimler.Karamel);
            cmbEkSecim.Items.Add(KahveEkSecimler.BeyazCikolata);
            cmbEkSecim.Items.Add(KahveEkSecimler.Findik);


        }
        
        private void btnKahveciyiAc_Click(object sender, EventArgs e)
        {

            kahveDukkani = new Kafe();
            kahveDukkani.MesaiBaslat(3);
            
        }

        private void txtKasiyerSayisi_TextChanged(object sender, EventArgs e)
        {
            calisan.KasiyerSayisi = Convert.ToInt32(txtKasiyerSayisi.Text);
            lblKasiyer.Text = calisan.KasiyerSayisi.ToString();
            calisan.BaristaSayisi = 5 - calisan.KasiyerSayisi;
            lblBaristaSayisi.Text = calisan.BaristaSayisi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Musteri mstr = new Musteri();
            Kasiyer kasa = new Kasiyer();

            //kasa.SiparisAlabilirim += mstr.SiraGeldiMiKontrol();
            mstr.KasaBenGeldim += kasa.SiparisAl();
        }

        private void btnMusteriGeldi_Click(object sender, EventArgs e)
        {
            IMusteri musteri = new Musteri();
            Siparis siparis = new Siparis();
            musteri.Siparis = (Siparis)cmbKahveTuru.SelectedItem;
        }
        //private void cmbKasiyerSayısı_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbKasiyerSayısı.SelectedIndex == 0)
        //    {
        //        // 6 çalışan var kasiyer seçimine göre diğeri kaç işlem yap

        //    }
        //}
        private void SiparisEkranı_FormClosed(object sender, FormClosedEventArgs e)
        {
            kahveDukkani.MesaiBitir();

        }

    }
}