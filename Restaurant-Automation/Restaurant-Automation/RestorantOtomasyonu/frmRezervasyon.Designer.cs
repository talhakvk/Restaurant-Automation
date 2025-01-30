namespace RestorantOtomasyonu
{
    partial class frmRezervasyon
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.cbMasa = new System.Windows.Forms.ComboBox();
            this.cbKisiSayisi = new System.Windows.Forms.ComboBox();
            this.txtMasaNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnSiparisKontrol = new System.Windows.Forms.Button();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(802, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tarih :";
            // 
            // txtTarih
            // 
            this.txtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Location = new System.Drawing.Point(927, 35);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(173, 41);
            this.txtTarih.TabIndex = 15;
            this.txtTarih.TextChanged += new System.EventHandler(this.txtTarih_TextChanged);
            // 
            // txtMasa
            // 
            this.txtMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasa.Location = new System.Drawing.Point(927, 120);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.ReadOnly = true;
            this.txtMasa.Size = new System.Drawing.Size(173, 41);
            this.txtMasa.TabIndex = 15;
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKisiSayisi.Location = new System.Drawing.Point(927, 189);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.ReadOnly = true;
            this.txtKisiSayisi.Size = new System.Drawing.Size(173, 41);
            this.txtKisiSayisi.TabIndex = 15;
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTarih.Location = new System.Drawing.Point(1106, 34);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(23, 41);
            this.dtTarih.TabIndex = 16;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            this.dtTarih.Enter += new System.EventHandler(this.dtTarih_Enter);
            this.dtTarih.MouseEnter += new System.EventHandler(this.dtTarih_MouseEnter);
            this.dtTarih.MouseLeave += new System.EventHandler(this.dtTarih_MouseLeave);
            // 
            // cbMasa
            // 
            this.cbMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMasa.FormattingEnabled = true;
            this.cbMasa.Location = new System.Drawing.Point(1106, 117);
            this.cbMasa.Name = "cbMasa";
            this.cbMasa.Size = new System.Drawing.Size(23, 44);
            this.cbMasa.TabIndex = 17;
            this.cbMasa.SelectedIndexChanged += new System.EventHandler(this.cbMasa_SelectedIndexChanged);
            this.cbMasa.MouseEnter += new System.EventHandler(this.cbMasa_MouseEnter);
            this.cbMasa.MouseLeave += new System.EventHandler(this.cbMasa_MouseLeave);
            // 
            // cbKisiSayisi
            // 
            this.cbKisiSayisi.Enabled = false;
            this.cbKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKisiSayisi.FormattingEnabled = true;
            this.cbKisiSayisi.Location = new System.Drawing.Point(1106, 186);
            this.cbKisiSayisi.Name = "cbKisiSayisi";
            this.cbKisiSayisi.Size = new System.Drawing.Size(23, 44);
            this.cbKisiSayisi.TabIndex = 17;
            this.cbKisiSayisi.SelectedIndexChanged += new System.EventHandler(this.cbKisiSayisi_SelectedIndexChanged);
            this.cbKisiSayisi.MouseEnter += new System.EventHandler(this.cbKisiSayisi_MouseEnter);
            this.cbKisiSayisi.MouseLeave += new System.EventHandler(this.cbKisiSayisi_MouseLeave);
            // 
            // txtMasaNo
            // 
            this.txtMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasaNo.Location = new System.Drawing.Point(911, 120);
            this.txtMasaNo.Name = "txtMasaNo";
            this.txtMasaNo.ReadOnly = true;
            this.txtMasaNo.Size = new System.Drawing.Size(10, 41);
            this.txtMasaNo.TabIndex = 15;
            this.txtMasaNo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(739, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Masa Seç :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(730, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kişi Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "MÜŞTERİ";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAd.Location = new System.Drawing.Point(21, 72);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(225, 46);
            this.txtMusteriAd.TabIndex = 19;
            this.txtMusteriAd.TextChanged += new System.EventHandler(this.txtMusteriAd_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(264, 72);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(225, 46);
            this.txtTelefon.TabIndex = 19;
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(505, 72);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(225, 46);
            this.txtAdres.TabIndex = 19;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(257, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 39);
            this.label5.TabIndex = 18;
            this.label5.Text = "TELEFON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(498, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 39);
            this.label6.TabIndex = 18;
            this.label6.Text = "ADRES";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.HideSelection = false;
            this.lvMusteriler.Location = new System.Drawing.Point(21, 122);
            this.lvMusteriler.MultiSelect = false;
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(709, 457);
            this.lvMusteriler.TabIndex = 20;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MusteriNO";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(747, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(927, 278);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(202, 216);
            this.txtAciklama.TabIndex = 15;
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.HESAP_KAPAT__7_;
            this.btnMusteriGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(1199, 608);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(150, 120);
            this.btnMusteriGuncelle.TabIndex = 21;
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnSiparisKontrol
            // 
            this.btnSiparisKontrol.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.HESAP_KAPAT__8_;
            this.btnSiparisKontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiparisKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisKontrol.Location = new System.Drawing.Point(1043, 608);
            this.btnSiparisKontrol.Name = "btnSiparisKontrol";
            this.btnSiparisKontrol.Size = new System.Drawing.Size(150, 120);
            this.btnSiparisKontrol.TabIndex = 21;
            this.btnSiparisKontrol.UseVisualStyleBackColor = true;
            this.btnSiparisKontrol.Click += new System.EventHandler(this.btnSiparisKontrol_Click);
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.HESAP_KAPAT__6_;
            this.btnMusteriSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriSec.Location = new System.Drawing.Point(885, 608);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(150, 120);
            this.btnMusteriSec.TabIndex = 21;
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            this.btnMusteriSec.Click += new System.EventHandler(this.btnMusteriSec_Click);
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.YENİmusteri;
            this.btnYeniMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniMusteri.Location = new System.Drawing.Point(729, 608);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(150, 120);
            this.btnYeniMusteri.TabIndex = 21;
            this.btnYeniMusteri.UseVisualStyleBackColor = true;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_12_27_222953;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(69, 684);
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
            this.btnGeriDon.Location = new System.Drawing.Point(5, 684);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(58, 54);
            this.btnGeriDon.TabIndex = 12;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Leonardo_Phoenix_10_Create_a_sophisticated_and_modern_backgrou_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnSiparisKontrol);
            this.Controls.Add(this.btnMusteriSec);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKisiSayisi);
            this.Controls.Add(this.cbMasa);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.txtMasaNo);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRezervasyon";
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ComboBox cbMasa;
        private System.Windows.Forms.ComboBox cbKisiSayisi;
        private System.Windows.Forms.TextBox txtMasaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Button btnSiparisKontrol;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAciklama;
    }
}