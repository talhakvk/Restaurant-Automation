using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RestorantOtomasyonu
{
    public partial class frmMusteriAra : Form
    {
        public frmMusteriAra()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            MusteriEkleme m = new MusteriEkleme();
            cGenel._musteriEkleme = 1;
            m.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            frmSiparisKontrol frm = new frmSiparisKontrol();
            this.Close();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        // frmMusteriAra.cs içinde
        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                // Seçilen müşterinin ID'sini al
                cGenel._musteriId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                cGenel._ServisTurNo = 2; // Paket sipariş için

                // Yeni adisyon oluştur
                cAdisyon newAddition = new cAdisyon();
                newAddition.ServisTurNo = 2; // Paket sipariş
                newAddition.PersonelId = 1;
                newAddition.MasaId = 0; // Paket sipariş için masa yok
                newAddition.Tarih = DateTime.Now;

                if (newAddition.setByAdditionNew(newAddition))
                {
                    // Oluşturulan adisyon ID'sini al
                    int newAdditionId = newAddition.getByAddition(0);
                    cGenel._AdisyonId = newAdditionId.ToString();

                    // Paket siparişi oluştur
                    cPaketler paket = new cPaketler();
                    paket.AdditionID = newAdditionId;
                    paket.ClientId = cGenel._musteriId;
                    paket.Description = "Paket Sipariş";
                    paket.State = 0;
                    paket.Paytypeid = 1; // Varsayılan ödeme türü

                    if (paket.OrderSeriveceOpen(paket))
                    {
                        frmSiparis frm = new frmSiparis();
                        frm.SetOdemeButtonVisibility(false);
                        this.Close();
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sipariş oluşturulurken bir hata oluştu!", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmMusteriAra_Load(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.musterileriGetir(lvMusteriler);

        }

        private void btnYeniMusteri_Click_1(object sender, EventArgs e)
        {
            MusteriEkleme m = new MusteriEkleme();
            cGenel._musteriEkleme = 1;
            m.BtnGuncelle.Visible = false;
            m.BtnEkle.Visible = true;
            this.Close();
            m.Show();
        }



        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count>0)
            {
                MusteriEkleme frm = new MusteriEkleme();
                cGenel._musteriEkleme = 1;
                cGenel._musteriId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
                frm.BtnEkle.Visible = false;
                frm.BtnGuncelle.Visible = true;
                this.Close();
                frm.Show();
            }
        }

        private void txtMusteriAd_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.musteriGetirAd(lvMusteriler, txtMusteriAd.Text);
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.musteriGetirSoyad(lvMusteriler, txtSoyad.Text);
        }

        private void mskTelefon_TextChanged(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.musteriGetirTlf(lvMusteriler, mskTelefon.Text);
        }

        private void btnAdisyonBul_Click(object sender, EventArgs e)
        {
            if (txtAdisyonID.Text !="")
            {

                cGenel._AdisyonId = txtAdisyonID.Text;
                cPaketler c = new cPaketler();

                bool sonuc = c.getCheckOpenAdditionID(Convert.ToInt32(txtAdisyonID.Text));
                if (sonuc)
                {
                    frmBill frm = new frmBill();
                    cGenel._ServisTurNo = 2;
                    this.Close();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show(txtAdisyonID.Text+" No'lu Adisyon Bulunamadı!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Aramak İstediğiniz Adisyonu Yazınız.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            cMusteriler m = new cMusteriler();
            m.musteriGetirAdres(lvMusteriler, txtAdres.Text); // Doğru metodu çağırıyoruz
        }

        private void lvMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
