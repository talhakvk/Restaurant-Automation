namespace RestorantOtomasyonu
{
    partial class frmKasaİslemleri
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new RestorantOtomasyonu.DataSet1();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvAylik = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvGunluk = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new RestorantOtomasyonu.DataSet1TableAdapters.DataTable1TableAdapter();
            this.DataTable2TableAdapter = new RestorantOtomasyonu.DataSet1TableAdapters.DataTable2TableAdapter();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnZRapor = new System.Windows.Forms.Button();
            this.btnAylikRapor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.DataSet1;
            // 
            // rpvAylik
            // 
            this.rpvAylik.DocumentMapWidth = 47;
            this.rpvAylik.ForeColor = System.Drawing.SystemColors.ControlText;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rpvAylik.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvAylik.LocalReport.ReportEmbeddedResource = "RestorantOtomasyonu.Report1.rdlc";
            this.rpvAylik.Location = new System.Drawing.Point(145, 69);
            this.rpvAylik.Name = "rpvAylik";
            this.rpvAylik.ServerReport.BearerToken = null;
            this.rpvAylik.Size = new System.Drawing.Size(1096, 446);
            this.rpvAylik.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(596, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "AYLIK RAPOR";
            // 
            // rpvGunluk
            // 
            this.rpvGunluk.DocumentMapWidth = 22;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable2BindingSource;
            this.rpvGunluk.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvGunluk.LocalReport.ReportEmbeddedResource = "RestorantOtomasyonu.Report2.rdlc";
            this.rpvGunluk.Location = new System.Drawing.Point(145, 69);
            this.rpvGunluk.Name = "rpvGunluk";
            this.rpvGunluk.ServerReport.BearerToken = null;
            this.rpvGunluk.Size = new System.Drawing.Size(1096, 446);
            this.rpvGunluk.TabIndex = 3;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Ekran_görüntüsü_2024_12_27_222953;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(75, 637);
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
            this.btnGeriDon.Location = new System.Drawing.Point(11, 637);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(58, 54);
            this.btnGeriDon.TabIndex = 12;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnZRapor
            // 
            this.btnZRapor.BackColor = System.Drawing.Color.Transparent;
            this.btnZRapor.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.HESAP_KAPAT__4_;
            this.btnZRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZRapor.Location = new System.Drawing.Point(686, 546);
            this.btnZRapor.Name = "btnZRapor";
            this.btnZRapor.Size = new System.Drawing.Size(180, 120);
            this.btnZRapor.TabIndex = 0;
            this.btnZRapor.UseVisualStyleBackColor = false;
            this.btnZRapor.Click += new System.EventHandler(this.btnZRapor_Click);
            // 
            // btnAylikRapor
            // 
            this.btnAylikRapor.BackColor = System.Drawing.Color.Transparent;
            this.btnAylikRapor.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.HESAP_KAPAT__3_;
            this.btnAylikRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAylikRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAylikRapor.Location = new System.Drawing.Point(495, 546);
            this.btnAylikRapor.Name = "btnAylikRapor";
            this.btnAylikRapor.Size = new System.Drawing.Size(180, 120);
            this.btnAylikRapor.TabIndex = 0;
            this.btnAylikRapor.UseVisualStyleBackColor = false;
            this.btnAylikRapor.Click += new System.EventHandler(this.btnAylikRapor_Click);
            // 
            // frmKasaİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestorantOtomasyonu.Properties.Resources.Leonardo_Phoenix_10_Create_an_opulent_darkthemed_background_fo_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.rpvGunluk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvAylik);
            this.Controls.Add(this.btnZRapor);
            this.Controls.Add(this.btnAylikRapor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKasaİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKasaİslemleri";
            this.Load += new System.EventHandler(this.frmKasaİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAylikRapor;
        private System.Windows.Forms.Button btnZRapor;
        private Microsoft.Reporting.WinForms.ReportViewer rpvAylik;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvGunluk;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private DataSet1TableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
    }
}