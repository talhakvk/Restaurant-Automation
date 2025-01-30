namespace RestorantOtomasyonu
{
    partial class frmMutfak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvKategoriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGidaListesi = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelUrun = new System.Windows.Forms.Panel();
            this.txtGidaFiyatı = new System.Windows.Forms.TextBox();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.txtGidaAdi = new System.Windows.Forms.TextBox();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAnaKategori = new System.Windows.Forms.Panel();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtKategoriID = new System.Windows.Forms.TextBox();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbAltKategori = new System.Windows.Forms.RadioButton();
            this.rbAnaKategori = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panelUrun.SuspendLayout();
            this.panelAnaKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvKategoriler
            // 
            this.lvKategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvKategoriler.FullRowSelect = true;
            this.lvKategoriler.GridLines = true;
            this.lvKategoriler.HideSelection = false;
            this.lvKategoriler.Location = new System.Drawing.Point(12, 12);
            this.lvKategoriler.Name = "lvKategoriler";
            this.lvKategoriler.Size = new System.Drawing.Size(566, 648);
            this.lvKategoriler.TabIndex = 0;
            this.lvKategoriler.UseCompatibleStateImageBehavior = false;
            this.lvKategoriler.View = System.Windows.Forms.View.Details;
            this.lvKategoriler.SelectedIndexChanged += new System.EventHandler(this.lvKategoriler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TurId";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori";
            this.columnHeader2.Width = 241;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Açıklama";
            this.columnHeader3.Width = 200;
            // 
            // lvGidaListesi
            // 
            this.lvGidaListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvGidaListesi.FullRowSelect = true;
            this.lvGidaListesi.GridLines = true;
            this.lvGidaListesi.HideSelection = false;
            this.lvGidaListesi.Location = new System.Drawing.Point(12, 12);
            this.lvGidaListesi.Name = "lvGidaListesi";
            this.lvGidaListesi.Size = new System.Drawing.Size(566, 648);
            this.lvGidaListesi.TabIndex = 1;
            this.lvGidaListesi.UseCompatibleStateImageBehavior = false;
            this.lvGidaListesi.View = System.Windows.Forms.View.Details;
            this.lvGidaListesi.SelectedIndexChanged += new System.EventHandler(this.lvGidaListesi_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Urun Id";
            this.columnHeader4.Width = 57;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "UrunTurNo";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kategori";
            this.columnHeader6.Width = 129;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Urun Adı";
            this.columnHeader7.Width = 132;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fiyatı";
            this.columnHeader8.Width = 113;
            // 
            // panelUrun
            // 
            this.panelUrun.BackColor = System.Drawing.Color.Transparent;
            this.panelUrun.Controls.Add(this.txtGidaFiyatı);
            this.panelUrun.Controls.Add(this.txtUrunId);
            this.panelUrun.Controls.Add(this.txtGidaAdi);
            this.panelUrun.Controls.Add(this.cbKategoriler);
            this.panelUrun.Controls.Add(this.label3);
            this.panelUrun.Controls.Add(this.label2);
            this.panelUrun.Controls.Add(this.label1);
            this.panelUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelUrun.ForeColor = System.Drawing.Color.White;
            this.panelUrun.Location = new System.Drawing.Point(606, 113);
            this.panelUrun.Name = "panelUrun";
            this.panelUrun.Size = new System.Drawing.Size(764, 231);
            this.panelUrun.TabIndex = 3;
            // 
            // txtGidaFiyatı
            // 
            this.txtGidaFiyatı.Location = new System.Drawing.Point(385, 152);
            this.txtGidaFiyatı.Name = "txtGidaFiyatı";
            this.txtGidaFiyatı.Size = new System.Drawing.Size(232, 30);
            this.txtGidaFiyatı.TabIndex = 7;
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(623, 96);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(10, 30);
            this.txtUrunId.TabIndex = 7;
            this.txtUrunId.Visible = false;
            // 
            // txtGidaAdi
            // 
            this.txtGidaAdi.Location = new System.Drawing.Point(385, 96);
            this.txtGidaAdi.Name = "txtGidaAdi";
            this.txtGidaAdi.Size = new System.Drawing.Size(232, 30);
            this.txtGidaAdi.TabIndex = 7;
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(385, 34);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(232, 33);
            this.cbKategoriler.TabIndex = 4;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gıda Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gıda Fiyatı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gıda Kategorisi :";
            // 
            // panelAnaKategori
            // 
            this.panelAnaKategori.BackColor = System.Drawing.Color.Transparent;
            this.panelAnaKategori.Controls.Add(this.txtAciklama);
            this.panelAnaKategori.Controls.Add(this.txtKategoriID);
            this.panelAnaKategori.Controls.Add(this.txtKategoriAd);
            this.panelAnaKategori.Controls.Add(this.label4);
            this.panelAnaKategori.Controls.Add(this.label5);
            this.panelAnaKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelAnaKategori.ForeColor = System.Drawing.Color.White;
            this.panelAnaKategori.Location = new System.Drawing.Point(606, 113);
            this.panelAnaKategori.Name = "panelAnaKategori";
            this.panelAnaKategori.Size = new System.Drawing.Size(764, 231);
            this.panelAnaKategori.TabIndex = 3;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(387, 118);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(230, 30);
            this.txtAciklama.TabIndex = 7;
            // 
            // txtKategoriID
            // 
            this.txtKategoriID.Location = new System.Drawing.Point(623, 49);
            this.txtKategoriID.Name = "txtKategoriID";
            this.txtKategoriID.Size = new System.Drawing.Size(10, 30);
            this.txtKategoriID.TabIndex = 7;
            this.txtKategoriID.Visible = false;
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(387, 49);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(230, 30);
            this.txtKategoriAd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategori Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Açıklama :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rbAltKategori
            // 
            this.rbAltKategori.AutoSize = true;
            this.rbAltKategori.BackColor = System.Drawing.Color.Transparent;
            this.rbAltKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAltKategori.ForeColor = System.Drawing.Color.White;
            this.rbAltKategori.Location = new System.Drawing.Point(817, 49);
            this.rbAltKategori.Name = "rbAltKategori";
            this.rbAltKategori.Size = new System.Drawing.Size(127, 29);
            this.rbAltKategori.TabIndex = 4;
            this.rbAltKategori.TabStop = true;
            this.rbAltKategori.Text = "Ürün Ekle";
            this.rbAltKategori.UseVisualStyleBackColor = false;
            this.rbAltKategori.CheckedChanged += new System.EventHandler(this.rbAltKategori_CheckedChanged);
            // 
            // rbAnaKategori
            // 
            this.rbAnaKategori.AutoSize = true;
            this.rbAnaKategori.BackColor = System.Drawing.Color.Transparent;
            this.rbAnaKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAnaKategori.ForeColor = System.Drawing.Color.White;
            this.rbAnaKategori.Location = new System.Drawing.Point(1027, 49);
            this.rbAnaKategori.Name = "rbAnaKategori";
            this.rbAnaKategori.Size = new System.Drawing.Size(214, 29);
            this.rbAnaKategori.TabIndex = 4;
            this.rbAnaKategori.TabStop = true;
            this.rbAnaKategori.Text = "Ürün Kategori Ekle";
            this.rbAnaKategori.UseVisualStyleBackColor = false;
            this.rbAnaKategori.CheckedChanged += new System.EventHandler(this.rbAnaKategori_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(705, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Aramak İstediğiniz Ürün :";
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(991, 391);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(232, 28);
            this.txtArama.TabIndex = 7;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_12_27_222953;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(73, 684);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(58, 54);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriDon.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_12_27_222910;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Location = new System.Drawing.Point(9, 684);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(58, 54);
            this.btnGeriDon.TabIndex = 12;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.sil1;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(1169, 508);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(170, 100);
            this.btnSil.TabIndex = 2;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.Transparent;
            this.btnBul.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.BUL;
            this.btnBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBul.Location = new System.Drawing.Point(993, 508);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(170, 100);
            this.btnBul.TabIndex = 2;
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.Transparent;
            this.btnDegistir.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.GÜNCELLE;
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegistir.Location = new System.Drawing.Point(817, 508);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(170, 100);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.EKLE;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(641, 508);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(170, 100);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmMutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Leonardo_Phoenix_10_Create_a_dramatic_restaurant_kitchen_backg_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.rbAnaKategori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbAltKategori);
            this.Controls.Add(this.panelAnaKategori);
            this.Controls.Add(this.panelUrun);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lvGidaListesi);
            this.Controls.Add(this.lvKategoriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMutfak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMutfak";
            this.Load += new System.EventHandler(this.frmMutfak_Load);
            this.panelUrun.ResumeLayout(false);
            this.panelUrun.PerformLayout();
            this.panelAnaKategori.ResumeLayout(false);
            this.panelAnaKategori.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvKategoriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvGidaListesi;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panelUrun;
        private System.Windows.Forms.TextBox txtGidaFiyatı;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.TextBox txtGidaAdi;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAnaKategori;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtKategoriID;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbAltKategori;
        private System.Windows.Forms.RadioButton rbAnaKategori;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArama;
    }
}