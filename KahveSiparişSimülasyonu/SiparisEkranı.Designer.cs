namespace KahveSiparişSimülasyonu
{
    partial class SiparisEkranı
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisEkranı));
            this.lblHataMesajı = new System.Windows.Forms.Label();
            this.cmbEkSecim = new System.Windows.Forms.ComboBox();
            this.cmbKahveTuru = new System.Windows.Forms.ComboBox();
            this.btnKahveciyiAc = new System.Windows.Forms.Button();
            this.gbSiparisOlustur = new System.Windows.Forms.GroupBox();
            this.EkSecim = new System.Windows.Forms.Label();
            this.lblKahveSeçimi = new System.Windows.Forms.Label();
            this.cmbKasiyerSayısı = new System.Windows.Forms.ComboBox();
            this.LblKasiyerSecimi = new System.Windows.Forms.Label();
            this.txtKasiyerSayisi = new System.Windows.Forms.TextBox();
            this.lblBarista = new System.Windows.Forms.Label();
            this.lblBaristaSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKasiyer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbSiparisOlustur.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHataMesajı
            // 
            this.lblHataMesajı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHataMesajı.Location = new System.Drawing.Point(389, 371);
            this.lblHataMesajı.Name = "lblHataMesajı";
            this.lblHataMesajı.Size = new System.Drawing.Size(323, 25);
            this.lblHataMesajı.TabIndex = 0;
            // 
            // cmbEkSecim
            // 
            this.cmbEkSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEkSecim.FormattingEnabled = true;
            this.cmbEkSecim.Location = new System.Drawing.Point(152, 117);
            this.cmbEkSecim.Name = "cmbEkSecim";
            this.cmbEkSecim.Size = new System.Drawing.Size(151, 28);
            this.cmbEkSecim.TabIndex = 1;
            // 
            // cmbKahveTuru
            // 
            this.cmbKahveTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKahveTuru.FormattingEnabled = true;
            this.cmbKahveTuru.Location = new System.Drawing.Point(152, 69);
            this.cmbKahveTuru.Name = "cmbKahveTuru";
            this.cmbKahveTuru.Size = new System.Drawing.Size(151, 28);
            this.cmbKahveTuru.TabIndex = 1;
            // 
            // btnKahveciyiAc
            // 
            this.btnKahveciyiAc.Location = new System.Drawing.Point(35, 183);
            this.btnKahveciyiAc.Name = "btnKahveciyiAc";
            this.btnKahveciyiAc.Size = new System.Drawing.Size(139, 53);
            this.btnKahveciyiAc.TabIndex = 2;
            this.btnKahveciyiAc.Text = "Kahve Dükkanını Aç";
            this.btnKahveciyiAc.UseVisualStyleBackColor = true;
            this.btnKahveciyiAc.Click += new System.EventHandler(this.btnKahveciyiAc_Click);
            // 
            // gbSiparisOlustur
            // 
            this.gbSiparisOlustur.Controls.Add(this.EkSecim);
            this.gbSiparisOlustur.Controls.Add(this.lblKahveSeçimi);
            this.gbSiparisOlustur.Controls.Add(this.cmbEkSecim);
            this.gbSiparisOlustur.Controls.Add(this.cmbKahveTuru);
            this.gbSiparisOlustur.Location = new System.Drawing.Point(368, 123);
            this.gbSiparisOlustur.Name = "gbSiparisOlustur";
            this.gbSiparisOlustur.Size = new System.Drawing.Size(397, 219);
            this.gbSiparisOlustur.TabIndex = 3;
            this.gbSiparisOlustur.TabStop = false;
            this.gbSiparisOlustur.Text = "Sipariş Bilgisi";
            // 
            // EkSecim
            // 
            this.EkSecim.AutoSize = true;
            this.EkSecim.Location = new System.Drawing.Point(37, 125);
            this.EkSecim.Name = "EkSecim";
            this.EkSecim.Size = new System.Drawing.Size(68, 20);
            this.EkSecim.TabIndex = 2;
            this.EkSecim.Text = "Ek Seçim";
            // 
            // lblKahveSeçimi
            // 
            this.lblKahveSeçimi.AutoSize = true;
            this.lblKahveSeçimi.Location = new System.Drawing.Point(37, 77);
            this.lblKahveSeçimi.Name = "lblKahveSeçimi";
            this.lblKahveSeçimi.Size = new System.Drawing.Size(97, 20);
            this.lblKahveSeçimi.TabIndex = 2;
            this.lblKahveSeçimi.Text = "Kahve Seçimi";
            // 
            // cmbKasiyerSayısı
            // 
            this.cmbKasiyerSayısı.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKasiyerSayısı.FormattingEnabled = true;
            this.cmbKasiyerSayısı.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbKasiyerSayısı.Location = new System.Drawing.Point(35, 343);
            this.cmbKasiyerSayısı.Name = "cmbKasiyerSayısı";
            this.cmbKasiyerSayısı.Size = new System.Drawing.Size(151, 28);
            this.cmbKasiyerSayısı.TabIndex = 4;
            // 
            // LblKasiyerSecimi
            // 
            this.LblKasiyerSecimi.AutoSize = true;
            this.LblKasiyerSecimi.Location = new System.Drawing.Point(35, 35);
            this.LblKasiyerSecimi.Name = "LblKasiyerSecimi";
            this.LblKasiyerSecimi.Size = new System.Drawing.Size(147, 20);
            this.LblKasiyerSecimi.TabIndex = 5;
            this.LblKasiyerSecimi.Text = "Kasiyer Sayısı Giriniz ";
            // 
            // txtKasiyerSayisi
            // 
            this.txtKasiyerSayisi.Location = new System.Drawing.Point(174, 24);
            this.txtKasiyerSayisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKasiyerSayisi.Name = "txtKasiyerSayisi";
            this.txtKasiyerSayisi.Size = new System.Drawing.Size(131, 27);
            this.txtKasiyerSayisi.TabIndex = 6;
            this.txtKasiyerSayisi.TextChanged += new System.EventHandler(this.txtKasiyerSayisi_TextChanged);
            // 
            // lblBarista
            // 
            this.lblBarista.Location = new System.Drawing.Point(35, 124);
            this.lblBarista.Name = "lblBarista";
            this.lblBarista.Size = new System.Drawing.Size(104, 31);
            this.lblBarista.TabIndex = 7;
            this.lblBarista.Text = "Barista Sayısı";
            // 
            // lblBaristaSayisi
            // 
            this.lblBaristaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBaristaSayisi.Location = new System.Drawing.Point(174, 123);
            this.lblBaristaSayisi.Name = "lblBaristaSayisi";
            this.lblBaristaSayisi.Size = new System.Drawing.Size(131, 31);
            this.lblBaristaSayisi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kasiyer Sayısı";
            // 
            // lblKasiyer
            // 
            this.lblKasiyer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKasiyer.Location = new System.Drawing.Point(174, 73);
            this.lblKasiyer.Name = "lblKasiyer";
            this.lblKasiyer.Size = new System.Drawing.Size(131, 31);
            this.lblKasiyer.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SiparişEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKasiyer);
            this.Controls.Add(this.lblBaristaSayisi);
            this.Controls.Add(this.lblBarista);
            this.Controls.Add(this.txtKasiyerSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblKasiyerSecimi);
            this.Controls.Add(this.cmbKasiyerSayısı);
            this.Controls.Add(this.gbSiparisOlustur);
            this.Controls.Add(this.btnKahveciyiAc);
            this.Controls.Add(this.lblHataMesajı);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiparişEkranı";
            this.Text = "Sipariş Ekranı";
            this.Load += new System.EventHandler(this.SiparişEkranı_Load);
            this.gbSiparisOlustur.ResumeLayout(false);
            this.gbSiparisOlustur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHataMesajı;
        private ComboBox cmbEkSecim;
        private ComboBox cmbKahveTuru;
        private Button btnKahveciyiAc;
        private GroupBox gbSiparisOlustur;
        private Label EkSecim;
        private Label lblKahveSeçimi;
        private ComboBox cmbKasiyerSayısı;
        private Label LblKasiyerSecimi;
        private TextBox txtKasiyerSayisi;
        private Label lblBarista;
        private Label lblBaristaSayisi;
        private Label label1;
        private Label lblKasiyer;
        private Button button1;
    }
}