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
    public partial class MusteriEkleme : Form
    {
        public MusteriEkleme()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (mskTelefon.Text.Length==11)
            {
                if (string.IsNullOrWhiteSpace(txtMusteriAd.Text) || string.IsNullOrWhiteSpace(txtMusteriSoyad.Text))
                {
                    MessageBox.Show("Ad ve Soyad boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    bool sonuc = c.MusteriVarmi(mskTelefon.Text);

                    if (!sonuc)
                    {
                        c.Musteriad = txtMusteriAd.Text;
                        c.Musterisoyad = txtMusteriSoyad.Text;
                        c.Telefon = mskTelefon.Text;
                        c.Email = txtEmail.Text;
                        c.Adres = txtAdres.Text;
                        txtMusteriNo.Text = c.musteriEkle(c).ToString();
                        if (txtMusteriNo.Text!="")
                        {
                            MessageBox.Show("Müşteri Eklendi.");

                        }
                        else
                        {
                            MessageBox.Show("Müşteri Eklenmedi!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kayıt bulunmaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen En Az 11 Haneli Bir Telefon Numarası Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
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

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            if (cGenel._musteriEkleme==0)
            {
                frmRezervasyon frm = new frmRezervasyon();
                cGenel._musteriEkleme = 1;
                this.Close();
                frm.Show();
            }
            else if (cGenel._musteriEkleme==1)
            {
                frmPaketSiparis frm = new frmPaketSiparis();
                cGenel._musteriEkleme = 0;
                this.Close();
                frm.Show();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Telefon numarası kontrolü
            if (mskTelefon.Text.Length != 11)
            {
                MessageBox.Show("Lütfen En Az 11 Haneli Bir Telefon Numarası Giriniz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ad ve Soyad boşluk kontrolü
            if (string.IsNullOrWhiteSpace(txtMusteriAd.Text) || string.IsNullOrWhiteSpace(txtMusteriSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad boş olamaz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Müşteri bilgilerini güncelle
            cMusteriler c = new cMusteriler();
            c.Musteriad = txtMusteriAd.Text;
            c.Musterisoyad = txtMusteriSoyad.Text;
            c.Telefon = mskTelefon.Text;
            c.Email = txtEmail.Text;
            c.Adres = txtAdres.Text;
            c.Musteriid = Convert.ToInt32(txtMusteriNo.Text);

            // Güncelleme işlemini gerçekleştir
            bool sonuc = c.musteriBilgileriGuncelle(c);

            if (sonuc)
            {
                MessageBox.Show("Müşteri başarıyla güncellendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Form kontrollerini temizle veya formu kapat
                // this.Close(); // veya
                // FormTemizle();
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi başarısız oldu!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MusteriEkleme_Load(object sender, EventArgs e)
        {
            if (cGenel._musteriId>0)
            {
                cMusteriler c = new cMusteriler();
                txtMusteriNo.Text = cGenel._musteriId.ToString();
                c.musterilerigetirID(Convert.ToInt32(txtMusteriNo.Text), txtMusteriAd, txtMusteriSoyad, mskTelefon, txtAdres, txtEmail);
               
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            frmMusteriAra frm = new frmMusteriAra();
            this.Close();
            frm.Show();
        }

        public SimpleButton BtnEkle
        {
            get { return btnEkle; }
        }

        public SimpleButton BtnGuncelle
        {
            get { return btnGuncelle; }
        }

    }
}
