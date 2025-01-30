using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RestorantOtomasyonu
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
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

        private void btnAnaYemekler_Click(object sender, EventArgs e)
        {
            Istatistik("Ana Yemekler İstatistiği", 3, Color.Red);
        }

        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            Istatistik("İçecekler İstatistiği", 8, Color.Orange);
        }

        private void Istatistik(string gfName,int KatId,Color renk)
        {
            chRapor.Palette = ChartColorPalette.None;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color = renk;
            cUrunler u = new cUrunler();
            lvIstatistik.Items.Clear();
            u.urunleriListeleIstatistiklereGoreUrunId(lvIstatistik, dtBaslangic, dtBitis, KatId);
            gbIstatistik.Text = gfName;

            if (lvIstatistik.Items.Count > 0)
            {
                chRapor.Series["Satislar"].Points.Clear();
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    string urunAdi = lvIstatistik.Items[i].SubItems[0].Text;
                    string satisMiktari = lvIstatistik.Items[i].SubItems[1].Text;

                    DataPoint point = new DataPoint();
                    point.SetValueXY(urunAdi, Convert.ToDouble(satisMiktari));
                    point.Label = satisMiktari; // Satış miktarını bar üzerinde göster
                    chRapor.Series["Satislar"].Points.Add(point);
                }

                // X ekseni etiketlerinin açısını ayarla
                chRapor.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                // Etiketlerin çakışmasını önlemek için aralığı ayarla
                chRapor.ChartAreas[0].AxisX.Interval = 1;
            }
            else
            {
                MessageBox.Show("Gösterilecek İstatistik Yok, Başka Bir Zaman Dilimi Seçiniz!");
            }
        }

        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            Istatistik("Tatlılar İstatistiği", 7, Color.LightBlue);
        }

        private void btnSalata_Click(object sender, EventArgs e)
        {
            Istatistik("Salatalar İstatistiği", 6, Color.Green);
        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {
            Istatistik("FastFood İstatistiği", 5, Color.Purple);
        }

        private void btnCorba_Click(object sender, EventArgs e)
        {
            Istatistik("Çorbalar İstatistiği", 1, Color.Orange);
        }

        private void btnMakarna4_Click(object sender, EventArgs e)
        {
            Istatistik("Makarnalar İstatistiği", 4, Color.Firebrick);
        }

        private void btnAraSicak_Click(object sender, EventArgs e)
        {
            Istatistik("Arasıcaklar İstatistiği", 2, Color.Brown);
        }

        private void btnZRapor_Click(object sender, EventArgs e)
        {
            chRapor.Palette = ChartColorPalette.None;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color = Color.DarkBlue;
            cUrunler u = new cUrunler();
            lvIstatistik.Items.Clear();
            u.urunleriListeleIstatistiklereGore(lvIstatistik, dtBaslangic, dtBitis);
            gbIstatistik.Text = "Tüm Ürünler";

            if (lvIstatistik.Items.Count > 0)
            {
                chRapor.Series["Satislar"].Points.Clear();
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    string urunAdi = lvIstatistik.Items[i].SubItems[0].Text;
                    string kategoriAdi = lvIstatistik.Items[i].SubItems[2].Text;
                    string displayText = $"{urunAdi}\n({kategoriAdi})";

                    DataPoint point = new DataPoint();
                    point.SetValueXY(displayText, Convert.ToDouble(lvIstatistik.Items[i].SubItems[1].Text));
                    point.Label = lvIstatistik.Items[i].SubItems[1].Text;
                    chRapor.Series["Satislar"].Points.Add(point);
                }

                // X ekseni etiketlerinin açısını ayarlayalım
                chRapor.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                // Etiketlerin çakışmasını önlemek için aralığı ayarlayalım
                chRapor.ChartAreas[0].AxisX.Interval = 1;
            }
            else
            {
                MessageBox.Show("Gösterilecek İstatistik Yok, Başka Bir Zaman Dilimi Seçiniz!");
            }
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            chRapor.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White; // X ekseni sayıları beyaz
            chRapor.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White; // Y ekseni sayıları beyaz
            chRapor.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 12, FontStyle.Bold); // X ekseni yazı boyutu
            chRapor.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Y ekseni yazı boyutu

        }
    }
}
