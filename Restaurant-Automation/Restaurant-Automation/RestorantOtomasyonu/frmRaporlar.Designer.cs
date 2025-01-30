namespace RestorantOtomasyonu
{
    partial class frmRaporlar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.grpMenuBaslik = new System.Windows.Forms.GroupBox();
            this.btnAraSicak = new System.Windows.Forms.Button();
            this.btnMakarna4 = new System.Windows.Forms.Button();
            this.btnZRapor = new System.Windows.Forms.Button();
            this.btnCorba = new System.Windows.Forms.Button();
            this.btnFastFood = new System.Windows.Forms.Button();
            this.btnSalata = new System.Windows.Forms.Button();
            this.btnTatlilar = new System.Windows.Forms.Button();
            this.btnIcecekler = new System.Windows.Forms.Button();
            this.btnAnaYemekler = new System.Windows.Forms.Button();
            this.gbIstatistik = new System.Windows.Forms.GroupBox();
            this.lvIstatistik = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRapor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.grpMenuBaslik.SuspendLayout();
            this.gbIstatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(451, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(534, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitiş Tarihi :";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CalendarForeColor = System.Drawing.Color.White;
            this.dtBaslangic.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtBaslangic.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtBaslangic.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtBaslangic.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtBaslangic.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangic.Location = new System.Drawing.Point(749, 430);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(467, 46);
            this.dtBaslangic.TabIndex = 1;
            // 
            // dtBitis
            // 
            this.dtBitis.CalendarForeColor = System.Drawing.Color.White;
            this.dtBitis.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtBitis.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtBitis.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtBitis.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtBitis.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Location = new System.Drawing.Point(743, 508);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(473, 46);
            this.dtBitis.TabIndex = 1;
            // 
            // grpMenuBaslik
            // 
            this.grpMenuBaslik.BackColor = System.Drawing.Color.Transparent;
            this.grpMenuBaslik.Controls.Add(this.btnAraSicak);
            this.grpMenuBaslik.Controls.Add(this.btnMakarna4);
            this.grpMenuBaslik.Controls.Add(this.btnZRapor);
            this.grpMenuBaslik.Controls.Add(this.btnCorba);
            this.grpMenuBaslik.Controls.Add(this.btnFastFood);
            this.grpMenuBaslik.Controls.Add(this.btnSalata);
            this.grpMenuBaslik.Controls.Add(this.btnTatlilar);
            this.grpMenuBaslik.Controls.Add(this.btnIcecekler);
            this.grpMenuBaslik.Controls.Add(this.btnAnaYemekler);
            this.grpMenuBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMenuBaslik.ForeColor = System.Drawing.Color.White;
            this.grpMenuBaslik.Location = new System.Drawing.Point(12, 12);
            this.grpMenuBaslik.Name = "grpMenuBaslik";
            this.grpMenuBaslik.Size = new System.Drawing.Size(403, 631);
            this.grpMenuBaslik.TabIndex = 2;
            this.grpMenuBaslik.TabStop = false;
            this.grpMenuBaslik.Text = "Menü";
            // 
            // btnAraSicak
            // 
            this.btnAraSicak.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.arasıcaklar;
            this.btnAraSicak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAraSicak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAraSicak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAraSicak.Location = new System.Drawing.Point(202, 390);
            this.btnAraSicak.Name = "btnAraSicak";
            this.btnAraSicak.Size = new System.Drawing.Size(183, 112);
            this.btnAraSicak.TabIndex = 0;
            this.btnAraSicak.UseVisualStyleBackColor = true;
            this.btnAraSicak.Click += new System.EventHandler(this.btnAraSicak_Click);
            // 
            // btnMakarna4
            // 
            this.btnMakarna4.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.makarnalar;
            this.btnMakarna4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMakarna4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakarna4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakarna4.Location = new System.Drawing.Point(15, 390);
            this.btnMakarna4.Name = "btnMakarna4";
            this.btnMakarna4.Size = new System.Drawing.Size(183, 112);
            this.btnMakarna4.TabIndex = 0;
            this.btnMakarna4.UseVisualStyleBackColor = true;
            this.btnMakarna4.Click += new System.EventHandler(this.btnMakarna4_Click);
            // 
            // btnZRapor
            // 
            this.btnZRapor.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.HESAP_KAPAT__5_;
            this.btnZRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZRapor.Location = new System.Drawing.Point(15, 508);
            this.btnZRapor.Name = "btnZRapor";
            this.btnZRapor.Size = new System.Drawing.Size(370, 110);
            this.btnZRapor.TabIndex = 4;
            this.btnZRapor.UseVisualStyleBackColor = true;
            this.btnZRapor.Click += new System.EventHandler(this.btnZRapor_Click);
            // 
            // btnCorba
            // 
            this.btnCorba.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.corbalar;
            this.btnCorba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorba.Location = new System.Drawing.Point(202, 272);
            this.btnCorba.Name = "btnCorba";
            this.btnCorba.Size = new System.Drawing.Size(183, 112);
            this.btnCorba.TabIndex = 0;
            this.btnCorba.UseVisualStyleBackColor = true;
            this.btnCorba.Click += new System.EventHandler(this.btnCorba_Click);
            // 
            // btnFastFood
            // 
            this.btnFastFood.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.fastfood;
            this.btnFastFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFastFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFastFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastFood.Location = new System.Drawing.Point(15, 272);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(183, 112);
            this.btnFastFood.TabIndex = 0;
            this.btnFastFood.UseVisualStyleBackColor = true;
            this.btnFastFood.Click += new System.EventHandler(this.btnFastFood_Click);
            // 
            // btnSalata
            // 
            this.btnSalata.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.salata;
            this.btnSalata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalata.Location = new System.Drawing.Point(202, 154);
            this.btnSalata.Name = "btnSalata";
            this.btnSalata.Size = new System.Drawing.Size(183, 112);
            this.btnSalata.TabIndex = 0;
            this.btnSalata.UseVisualStyleBackColor = true;
            this.btnSalata.Click += new System.EventHandler(this.btnSalata_Click);
            // 
            // btnTatlilar
            // 
            this.btnTatlilar.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.tatlilar;
            this.btnTatlilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTatlilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTatlilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatlilar.Location = new System.Drawing.Point(15, 154);
            this.btnTatlilar.Name = "btnTatlilar";
            this.btnTatlilar.Size = new System.Drawing.Size(183, 112);
            this.btnTatlilar.TabIndex = 0;
            this.btnTatlilar.UseVisualStyleBackColor = true;
            this.btnTatlilar.Click += new System.EventHandler(this.btnTatlilar_Click);
            // 
            // btnIcecekler
            // 
            this.btnIcecekler.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.icecekler;
            this.btnIcecekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIcecekler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcecekler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcecekler.Location = new System.Drawing.Point(202, 36);
            this.btnIcecekler.Name = "btnIcecekler";
            this.btnIcecekler.Size = new System.Drawing.Size(183, 112);
            this.btnIcecekler.TabIndex = 0;
            this.btnIcecekler.UseVisualStyleBackColor = true;
            this.btnIcecekler.Click += new System.EventHandler(this.btnIcecekler_Click);
            // 
            // btnAnaYemekler
            // 
            this.btnAnaYemekler.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.anayemek;
            this.btnAnaYemekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaYemekler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaYemekler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaYemekler.Location = new System.Drawing.Point(15, 36);
            this.btnAnaYemekler.Name = "btnAnaYemekler";
            this.btnAnaYemekler.Size = new System.Drawing.Size(183, 112);
            this.btnAnaYemekler.TabIndex = 0;
            this.btnAnaYemekler.UseVisualStyleBackColor = true;
            this.btnAnaYemekler.Click += new System.EventHandler(this.btnAnaYemekler_Click);
            // 
            // gbIstatistik
            // 
            this.gbIstatistik.BackColor = System.Drawing.Color.Transparent;
            this.gbIstatistik.Controls.Add(this.lvIstatistik);
            this.gbIstatistik.Controls.Add(this.chRapor);
            this.gbIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbIstatistik.ForeColor = System.Drawing.Color.White;
            this.gbIstatistik.Location = new System.Drawing.Point(421, 12);
            this.gbIstatistik.Name = "gbIstatistik";
            this.gbIstatistik.Size = new System.Drawing.Size(795, 401);
            this.gbIstatistik.TabIndex = 3;
            this.gbIstatistik.TabStop = false;
            // 
            // lvIstatistik
            // 
            this.lvIstatistik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvIstatistik.FullRowSelect = true;
            this.lvIstatistik.GridLines = true;
            this.lvIstatistik.HideSelection = false;
            this.lvIstatistik.Location = new System.Drawing.Point(779, 24);
            this.lvIstatistik.Name = "lvIstatistik";
            this.lvIstatistik.Size = new System.Drawing.Size(10, 10);
            this.lvIstatistik.TabIndex = 1;
            this.lvIstatistik.UseCompatibleStateImageBehavior = false;
            this.lvIstatistik.View = System.Windows.Forms.View.Details;
            this.lvIstatistik.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Adı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adedi";
            // 
            // chRapor
            // 
            this.chRapor.BackColor = System.Drawing.Color.Transparent;
            this.chRapor.BorderlineColor = System.Drawing.Color.Transparent;
            this.chRapor.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chRapor.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chRapor.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chRapor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chRapor.Legends.Add(legend1);
            this.chRapor.Location = new System.Drawing.Point(6, 40);
            this.chRapor.Name = "chRapor";
            this.chRapor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Label = "Satislar";
            series1.Legend = "Legend1";
            series1.Name = "Satislar";
            this.chRapor.Series.Add(series1);
            this.chRapor.Size = new System.Drawing.Size(783, 355);
            this.chRapor.TabIndex = 0;
            this.chRapor.Text = "chart1";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_12_27_222953;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(77, 684);
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
            this.btnGeriDon.Location = new System.Drawing.Point(13, 684);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(58, 54);
            this.btnGeriDon.TabIndex = 12;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Leonardo_Phoenix_10_Render_a_sophisticated_mysterious_backgrou_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.gbIstatistik);
            this.Controls.Add(this.grpMenuBaslik);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRaporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRaporlar";
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            this.grpMenuBaslik.ResumeLayout(false);
            this.gbIstatistik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.GroupBox grpMenuBaslik;
        private System.Windows.Forms.Button btnAraSicak;
        private System.Windows.Forms.Button btnMakarna4;
        private System.Windows.Forms.Button btnCorba;
        private System.Windows.Forms.Button btnFastFood;
        private System.Windows.Forms.Button btnSalata;
        private System.Windows.Forms.Button btnTatlilar;
        private System.Windows.Forms.Button btnIcecekler;
        private System.Windows.Forms.Button btnAnaYemekler;
        private System.Windows.Forms.GroupBox gbIstatistik;
        private System.Windows.Forms.ListView lvIstatistik;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chRapor;
        private System.Windows.Forms.Button btnZRapor;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
    }
}