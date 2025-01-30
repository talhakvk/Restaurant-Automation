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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        cSiparis cs = new cSiparis(); int odemeTuru = 0;
        private void frmBill_Load(object sender, EventArgs e)
        {
            if (cGenel._ServisTurNo==1)
            {
                lblAdisyonId.Text = cGenel._AdisyonId;
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));
                if (lvUrunler.Items.Count>0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }

                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }
                gbIndirim.Visible = false;
                txtIndirimTutari.Clear();
            }
            else if (cGenel._ServisTurNo == 2)
            {
                lblAdisyonId.Text = cGenel._AdisyonId;
                cPaketler pc = new cPaketler();
                odemeTuru = pc.OdemeTurIdGetir(Convert.ToInt32(lblAdisyonId.Text));
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));

                if (odemeTuru==1)
                {
                    rbNakit.Checked = true;
                }
                else if (odemeTuru==2)
                {
                    rbKrediKarti.Checked = true;
                }
                else if (odemeTuru==3)
                {
                    rbTicket.Checked = true;
                }

                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }

                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }
                gbIndirim.Visible = false;
                txtIndirimTutari.Clear();
            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

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

        private void lvUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtIndirimTutari_TextChanged(object sender, EventArgs e)
        {
            if(txtIndirimTutari.Text == "")
            {
                txtIndirimTutari.Text = "";
            }
            else
            {
                try
                {
                    if (Convert.ToDecimal(txtIndirimTutari.Text) < Convert.ToDecimal(lblToplamTutar.Text))
                    {
                        try
                        {
                            lblIndirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(txtIndirimTutari.Text));
                        }
                        catch (Exception)
                        {

                            lblIndirim.Text = string.Format("{0:0.000}", 0);
                        }
                    }
                    else
                    {
                        MessageBox.Show("İndirim Tutarı Toplam Tutardan Fazla Olmaz!!!");
                    }
                }
                catch (Exception)
                {

                    lblIndirim.Text = string.Format("{0:0.000}", 0);
                }
            }
        }
        
        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirim.Checked)
            {
                gbIndirim.Visible = true;
                txtIndirimTutari.Clear();
            }
            else
            {
                gbIndirim.Visible = false;
                txtIndirimTutari.Clear();
            }
        }

        private void lblIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblIndirim.Text)>0)
            {
                decimal odenecek = 0;
                lblOdenecek.Text = lblToplamTutar.Text;
                odenecek = Convert.ToDecimal(lblOdenecek.Text) - Convert.ToDecimal(lblIndirim.Text);
                lblOdenecek.Text = string.Format("{0:0.000}", odenecek);
            }

            decimal kdv = Convert.ToDecimal(lblOdenecek.Text)*18/100;
            lblKdv.Text= string.Format("{0:0.000}", kdv);
        }

        private void gbIndirim_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        cMasalar masalar = new cMasalar();
        cRezervasyon rezerve = new cRezervasyon();
        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            if (cGenel._ServisTurNo == 1)
            {
                int masaId = masalar.TableGetbyNumber(cGenel._ButtonName);
                int musteriId = 0;

                if (masalar.TableGetbyState(masaId,3)==true)
                {
                    musteriId = rezerve.getByClientIdFromRezervasyon(masaId);
                }
                else
                {
                    musteriId = 1;
                }

                int odemeTurId = 0;
                if (rbNakit.Checked)
                {
                    odemeTurId = 1;
                }
                if (rbKrediKarti.Checked)
                {
                    odemeTurId = 2;
                }
                if (rbTicket.Checked)
                {
                    odemeTurId = 3;
                }

                cOdeme odeme = new cOdeme();
                odeme.AdisyonID = Convert.ToInt32(lblAdisyonId.Text);
                odeme.OdemeTurId = odemeTurId;
                odeme.MusteriId = musteriId;
                odeme.AraToplam = Convert.ToDecimal(lblOdenecek.Text);
                odeme.Kdvtutari = Convert.ToDecimal(lblKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblToplamTutar.Text);
                odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);

                bool result = odeme.billClose(odeme);
                if (result)
                {
                    MessageBox.Show("Hesap Kapatılmıştır. İyi günler :)");
                    masalar.setChangeTableState(Convert.ToString(masaId), 1);

                    cRezervasyon c = new cRezervasyon();
                    c.rezervationClose(Convert.ToInt32(lblAdisyonId.Text));

                    cAdisyon a = new cAdisyon();
                    a.adisyonKapat(Convert.ToInt32(lblAdisyonId.Text),0);

                    frmMasalar frm = new frmMasalar();
                    this.Close();
                    frm.Show();
                }
                else
                {
                    string hataMesaji = "Hesap kapatılırken bir hata oluştu:\n";
                    hataMesaji += "- Masa durumu: " + masalar.TableGetbyState(masaId, 3) + "\n";
                    hataMesaji += "- Müşteri ID: " + musteriId + "\n";
                    MessageBox.Show(hataMesaji + "Lütfen yetkililere bildiriniz.");
                }

            }//Paket Sipariş
            else if (cGenel._ServisTurNo == 2)
            {
                cOdeme odeme = new cOdeme();
                odeme.AdisyonID = Convert.ToInt32(lblAdisyonId.Text);
                odeme.OdemeTurId = odemeTuru;
                odeme.MusteriId = cGenel._musteriId;
                odeme.AraToplam = Convert.ToDecimal(lblOdenecek.Text);
                odeme.Kdvtutari = Convert.ToDecimal(lblKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblToplamTutar.Text);
                odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);

                bool result = odeme.billClose(odeme);
                if (result)
                {
                   

                    cAdisyon a = new cAdisyon();
                    a.adisyonKapat(Convert.ToInt32(lblAdisyonId.Text), 1);

                    cPaketler p = new cPaketler();
                    p.OrderSeriveceClose(Convert.ToInt32(lblAdisyonId.Text));
                    MessageBox.Show("Hesap Kapatılmıştır. İyi günler :)");

                    frmMenu frm = new frmMenu();
                    cGenel._ServisTurNo = 1;
                    this.Close();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Hesap Kapatılırken bir hata oluştu. Lütfen Yetkililere bildiriniz... ");
                }
            }

        }

        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Yazı tipleri ve fırça
            Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);
            Font icerik = new Font("Verdana", 10);
            SolidBrush sb = new SolidBrush(Color.Black);

            // Sayfa boyutları
            int pageWidth = e.PageBounds.Width;

            // Başlangıç koordinatları
            int currentY = 50; // Y ekseninde başlangıç noktası
            int centerX = pageWidth / 2; // X ekseninde ortalama

            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center; // Ortalamak için

            // Logo veya Resim Ekleme
            Image logo = Image.FromFile(@"C:\Users\talha\source\repos\RestorantOtomasyonu\RestorantOtomasyonu\Resources\Leonardo_Phoenix_Design_a_sleek_and_modern_logo_for_Kavaklar_R_1-Photoroom.png"); // Resim dosyasının tam yolu
            int logoWidth = 350; // Logo genişliği
            int logoHeight = 350; // Logo yüksekliği
            e.Graphics.DrawImage(logo, centerX - (logoWidth / 2), currentY, logoWidth, logoHeight);
            currentY += logoHeight + 20; // Logo boyutuna göre boşluk bırak

            // Çizgi ve başlık satırı
            e.Graphics.DrawString(new string('-', 50), altBaslik, sb, centerX, currentY, centerFormat);
            currentY += 30;
            e.Graphics.DrawString("Ürün Adı", altBaslik, sb, centerX - 100, currentY, centerFormat);
            e.Graphics.DrawString("Adet", altBaslik, sb, centerX, currentY, centerFormat);
            e.Graphics.DrawString("Fiyat", altBaslik, sb, centerX + 100, currentY, centerFormat);
            currentY += 30;
            e.Graphics.DrawString(new string('-', 50), altBaslik, sb, centerX, currentY, centerFormat);

            // Dinamik ürün listesi
            currentY += 30;
            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text, icerik, sb, centerX - 100, currentY, centerFormat);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[1].Text, icerik, sb, centerX, currentY, centerFormat);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[2].Text, icerik, sb, centerX + 100, currentY, centerFormat);
                currentY += 30;
            }

            // Çizgi ve toplam bilgileri
            currentY += 20;
            e.Graphics.DrawString(new string('-', 50), altBaslik, sb, centerX, currentY, centerFormat);
            currentY += 30;
            e.Graphics.DrawString("İndirim Tutarı: " + lblIndirim.Text + " TL", altBaslik, sb, centerX, currentY, centerFormat);
            currentY += 30;
            e.Graphics.DrawString("KDV Tutarı: " + lblKdv.Text + " TL", altBaslik, sb, centerX, currentY, centerFormat);
            currentY += 30;
            e.Graphics.DrawString("Toplam Tutar: " + lblToplamTutar.Text + " TL", altBaslik, sb, centerX, currentY, centerFormat);
            currentY += 30;
            e.Graphics.DrawString("Ödediğiniz Tutar: " + lblOdenecek.Text + " TL", altBaslik, sb, centerX, currentY, centerFormat);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
