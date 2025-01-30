namespace RestorantOtomasyonu
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIndirim = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOdenecek = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.lblIndirim = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbTicket = new System.Windows.Forms.RadioButton();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.gbIndirim = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIndirimTutari = new System.Windows.Forms.TextBox();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnHesapOzeti = new System.Windows.Forms.Button();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblAdisyonId = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbIndirim.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkIndirim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(346, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özel İndirim";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkIndirim
            // 
            this.chkIndirim.AutoSize = true;
            this.chkIndirim.Location = new System.Drawing.Point(39, 84);
            this.chkIndirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIndirim.Name = "chkIndirim";
            this.chkIndirim.Size = new System.Drawing.Size(242, 40);
            this.chkIndirim.TabIndex = 0;
            this.chkIndirim.Text = "İndirim Uygula";
            this.chkIndirim.UseVisualStyleBackColor = true;
            this.chkIndirim.CheckedChanged += new System.EventHandler(this.chkIndirim_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblOdenecek);
            this.groupBox2.Controls.Add(this.lblToplamTutar);
            this.groupBox2.Controls.Add(this.lblKdv);
            this.groupBox2.Controls.Add(this.lblIndirim);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(346, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödeme Bilgisi";
            // 
            // lblOdenecek
            // 
            this.lblOdenecek.AutoSize = true;
            this.lblOdenecek.Location = new System.Drawing.Point(177, 164);
            this.lblOdenecek.Name = "lblOdenecek";
            this.lblOdenecek.Size = new System.Drawing.Size(33, 36);
            this.lblOdenecek.TabIndex = 14;
            this.lblOdenecek.Text = "0";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(177, 128);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(33, 36);
            this.lblToplamTutar.TabIndex = 13;
            this.lblToplamTutar.Text = "0";
            // 
            // lblKdv
            // 
            this.lblKdv.AutoSize = true;
            this.lblKdv.Location = new System.Drawing.Point(177, 92);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(33, 36);
            this.lblKdv.TabIndex = 12;
            this.lblKdv.Text = "0";
            // 
            // lblIndirim
            // 
            this.lblIndirim.AutoSize = true;
            this.lblIndirim.Location = new System.Drawing.Point(177, 54);
            this.lblIndirim.Name = "lblIndirim";
            this.lblIndirim.Size = new System.Drawing.Size(33, 36);
            this.lblIndirim.TabIndex = 11;
            this.lblIndirim.Text = "0";
            this.lblIndirim.TextChanged += new System.EventHandler(this.lblIndirim_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 36);
            this.label8.TabIndex = 10;
            this.label8.Text = "TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "KDV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ara Toplam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "İndirim";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rbTicket);
            this.groupBox3.Controls.Add(this.rbKrediKarti);
            this.groupBox3.Controls.Add(this.rbNakit);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(364, 213);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(329, 231);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödeme Türü";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbTicket
            // 
            this.rbTicket.AutoSize = true;
            this.rbTicket.Location = new System.Drawing.Point(59, 146);
            this.rbTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTicket.Name = "rbTicket";
            this.rbTicket.Size = new System.Drawing.Size(121, 40);
            this.rbTicket.TabIndex = 5;
            this.rbTicket.TabStop = true;
            this.rbTicket.Text = "Ticket";
            this.rbTicket.UseVisualStyleBackColor = true;
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Location = new System.Drawing.Point(59, 98);
            this.rbKrediKarti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(186, 40);
            this.rbKrediKarti.TabIndex = 4;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(59, 52);
            this.rbNakit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(109, 40);
            this.rbNakit.TabIndex = 3;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // gbIndirim
            // 
            this.gbIndirim.BackColor = System.Drawing.Color.Transparent;
            this.gbIndirim.Controls.Add(this.label9);
            this.gbIndirim.Controls.Add(this.txtIndirimTutari);
            this.gbIndirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbIndirim.ForeColor = System.Drawing.Color.White;
            this.gbIndirim.Location = new System.Drawing.Point(364, 11);
            this.gbIndirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIndirim.Name = "gbIndirim";
            this.gbIndirim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIndirim.Size = new System.Drawing.Size(329, 194);
            this.gbIndirim.TabIndex = 1;
            this.gbIndirim.TabStop = false;
            this.gbIndirim.Text = "Özel Aktivite";
            this.gbIndirim.Visible = false;
            this.gbIndirim.Enter += new System.EventHandler(this.gbIndirim_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 36);
            this.label9.TabIndex = 1;
            this.label9.Text = "İndirim Tutarı Giriniz";
            // 
            // txtIndirimTutari
            // 
            this.txtIndirimTutari.Location = new System.Drawing.Point(12, 82);
            this.txtIndirimTutari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIndirimTutari.Name = "txtIndirimTutari";
            this.txtIndirimTutari.Size = new System.Drawing.Size(292, 41);
            this.txtIndirimTutari.TabIndex = 0;
            this.txtIndirimTutari.TextChanged += new System.EventHandler(this.txtIndirimTutari_TextChanged);
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.HideSelection = false;
            this.lvUrunler.Location = new System.Drawing.Point(5, 39);
            this.lvUrunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(677, 386);
            this.lvUrunler.TabIndex = 2;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            this.lvUrunler.SelectedIndexChanged += new System.EventHandler(this.lvUrunler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 157;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UrunId";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SatisId";
            this.columnHeader5.Width = 92;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_12_27_222953;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ForeColor = System.Drawing.Color.Transparent;
            this.btnCikis.Location = new System.Drawing.Point(75, 684);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(59, 54);
            this.btnCikis.TabIndex = 15;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriDon.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_12_27_222910;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.ForeColor = System.Drawing.Color.Transparent;
            this.btnGeriDon.Location = new System.Drawing.Point(11, 684);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(59, 54);
            this.btnGeriDon.TabIndex = 14;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnHesapOzeti
            // 
            this.btnHesapOzeti.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.HESAP_OZETI;
            this.btnHesapOzeti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapOzeti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapOzeti.Location = new System.Drawing.Point(349, 480);
            this.btnHesapOzeti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHesapOzeti.Name = "btnHesapOzeti";
            this.btnHesapOzeti.Size = new System.Drawing.Size(216, 119);
            this.btnHesapOzeti.TabIndex = 16;
            this.btnHesapOzeti.UseVisualStyleBackColor = true;
            this.btnHesapOzeti.Click += new System.EventHandler(this.btnHesapOzeti_Click);
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.HESAP_KAPAT__1_;
            this.btnHesapKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapKapat.Location = new System.Drawing.Point(127, 480);
            this.btnHesapKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(216, 119);
            this.btnHesapKapat.TabIndex = 17;
            this.btnHesapKapat.UseVisualStyleBackColor = true;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.lblAdisyonId);
            this.groupBox5.Controls.Add(this.lvUrunler);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(699, 12);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(689, 432);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sipariş";
            // 
            // lblAdisyonId
            // 
            this.lblAdisyonId.AutoSize = true;
            this.lblAdisyonId.BackColor = System.Drawing.Color.Black;
            this.lblAdisyonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdisyonId.ForeColor = System.Drawing.Color.White;
            this.lblAdisyonId.Location = new System.Drawing.Point(165, 0);
            this.lblAdisyonId.Name = "lblAdisyonId";
            this.lblAdisyonId.Size = new System.Drawing.Size(51, 38);
            this.lblAdisyonId.TabIndex = 18;
            this.lblAdisyonId.Text = "ID";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.pngtree_illustration_of_3d_credit_card_with_payment_concept_for_e_commerce_image_3856353;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.gbIndirim);
            this.Controls.Add(this.btnHesapOzeti);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbIndirim.ResumeLayout(false);
            this.gbIndirim.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbIndirim;
        private System.Windows.Forms.CheckBox chkIndirim;
        private System.Windows.Forms.Label lblOdenecek;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Label lblIndirim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTicket;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIndirimTutari;
        private System.Windows.Forms.Button btnHesapOzeti;
        private System.Windows.Forms.Button btnHesapKapat;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblAdisyonId;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}