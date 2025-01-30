namespace RestorantOtomasyonu
{
    partial class frmSiparisKontrol
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
            this.lvMusteriDetaylari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSatisDetaylari = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamSiparis = new System.Windows.Forms.Label();
            this.lblsonSiparisTarihi = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMusteriDetaylari
            // 
            this.lvMusteriDetaylari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.AId});
            this.lvMusteriDetaylari.FullRowSelect = true;
            this.lvMusteriDetaylari.HideSelection = false;
            this.lvMusteriDetaylari.Location = new System.Drawing.Point(5, 21);
            this.lvMusteriDetaylari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMusteriDetaylari.Name = "lvMusteriDetaylari";
            this.lvMusteriDetaylari.Size = new System.Drawing.Size(527, 494);
            this.lvMusteriDetaylari.TabIndex = 0;
            this.lvMusteriDetaylari.UseCompatibleStateImageBehavior = false;
            this.lvMusteriDetaylari.View = System.Windows.Forms.View.Details;
            this.lvMusteriDetaylari.SelectedIndexChanged += new System.EventHandler(this.lvMusteriDetaylari_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AD";
            this.columnHeader2.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SOYAD";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TARİH";
            this.columnHeader4.Width = 114;
            // 
            // AId
            // 
            this.AId.Text = "AId";
            this.AId.Width = 0;
            // 
            // lvSatisDetaylari
            // 
            this.lvSatisDetaylari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvSatisDetaylari.FullRowSelect = true;
            this.lvSatisDetaylari.HideSelection = false;
            this.lvSatisDetaylari.Location = new System.Drawing.Point(5, 21);
            this.lvSatisDetaylari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvSatisDetaylari.Name = "lvSatisDetaylari";
            this.lvSatisDetaylari.Size = new System.Drawing.Size(367, 299);
            this.lvSatisDetaylari.TabIndex = 1;
            this.lvSatisDetaylari.UseCompatibleStateImageBehavior = false;
            this.lvSatisDetaylari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SatisId";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ÜRÜN ADI";
            this.columnHeader6.Width = 127;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ADET";
            this.columnHeader7.Width = 61;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "FİYAT";
            this.columnHeader8.Width = 84;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Location = new System.Drawing.Point(1176, 71);
            this.txtToplamTutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToplamTutar.Multiline = true;
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(179, 41);
            this.txtToplamTutar.TabIndex = 2;
            this.txtToplamTutar.TextChanged += new System.EventHandler(this.txtToplamTutar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(977, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplam Adet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1039, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(955, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "En Son Sipariş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(962, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genel Toplam :";
            // 
            // lblToplamSiparis
            // 
            this.lblToplamSiparis.AutoSize = true;
            this.lblToplamSiparis.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSiparis.ForeColor = System.Drawing.Color.White;
            this.lblToplamSiparis.Location = new System.Drawing.Point(1195, 178);
            this.lblToplamSiparis.Name = "lblToplamSiparis";
            this.lblToplamSiparis.Size = new System.Drawing.Size(97, 29);
            this.lblToplamSiparis.TabIndex = 4;
            this.lblToplamSiparis.Text = "______";
            // 
            // lblsonSiparisTarihi
            // 
            this.lblsonSiparisTarihi.AutoSize = true;
            this.lblsonSiparisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblsonSiparisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonSiparisTarihi.ForeColor = System.Drawing.Color.White;
            this.lblsonSiparisTarihi.Location = new System.Drawing.Point(1187, 303);
            this.lblsonSiparisTarihi.Name = "lblsonSiparisTarihi";
            this.lblsonSiparisTarihi.Size = new System.Drawing.Size(97, 29);
            this.lblsonSiparisTarihi.TabIndex = 5;
            this.lblsonSiparisTarihi.Text = "______";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblGenelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelToplam.ForeColor = System.Drawing.Color.Red;
            this.lblGenelToplam.Location = new System.Drawing.Point(1194, 243);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(97, 29);
            this.lblGenelToplam.TabIndex = 6;
            this.lblGenelToplam.Text = "______";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.HideSelection = false;
            this.lvMusteriler.Location = new System.Drawing.Point(1359, 456);
            this.lvMusteriler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(10, 10);
            this.lvMusteriler.TabIndex = 1;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.Visible = false;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "MusteriId";
            this.columnHeader9.Width = 87;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Musteri";
            this.columnHeader10.Width = 74;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "AdisyonId";
            this.columnHeader11.Width = 78;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_12_27_222953;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(1312, 638);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(59, 54);
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
            this.btnGeriDon.Location = new System.Drawing.Point(1248, 638);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(59, 54);
            this.btnGeriDon.TabIndex = 12;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lvMusteriDetaylari);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(539, 526);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Detayları";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvSatisDetaylari);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(556, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(379, 326);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satış Detayları";
            // 
            // frmSiparisKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Leonardo_Phoenix_10_A_darkthemed_digital_illustration_depictin_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1381, 703);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.lblsonSiparisTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblToplamSiparis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.lvMusteriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSiparisKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSiparisKontrol";
            this.Load += new System.EventHandler(this.frmSiparisKontrol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMusteriDetaylari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader AId;
        private System.Windows.Forms.ListView lvSatisDetaylari;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamSiparis;
        private System.Windows.Forms.Label lblsonSiparisTarihi;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}