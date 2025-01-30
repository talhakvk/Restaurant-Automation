using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RestorantOtomasyonu
{
    public partial class frmKasaİslemleri : Form
    {
        public frmKasaİslemleri()
        {
            InitializeComponent();
        }

        private void frmKasaİslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'DataSet1.DataTable2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.DataTable2TableAdapter.Fill(this.DataSet1.DataTable2);
            // TODO: Bu kod satırı 'DataSet1.DataTable1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            this.rpvAylik.RefreshReport();

            this.rpvGunluk.RefreshReport();

            rpvGunluk.Visible = false;
            label1.Text = "AYLIK RAPOR";
        }

        private void btnAylikRapor_Click(object sender, EventArgs e)
        {
            label1.Text = "AYLIK RAPOR";
            rpvAylik.Visible = true;
            rpvGunluk.Visible = false;
        }

        private void btnZRapor_Click(object sender, EventArgs e)
        {
            label1.Text = "GÜNLÜK RAPOR";
            rpvAylik.Visible = false;
            rpvGunluk.Visible = true;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
