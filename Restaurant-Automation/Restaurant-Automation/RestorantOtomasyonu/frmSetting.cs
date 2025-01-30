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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void frmSetting_Load(object sender, EventArgs e)
        {
             cPersoneller cp = new cPersoneller();
            cPersonelGorev cpg = new cPersonelGorev();
            string gorev = cpg.PersonelGorevTanim(cGenel._gorevId);
            if (gorev=="Müdür")
            {
                cp.personelGetbyInformation(cbPersonel);
                cpg.PersonelGorevGetir(cbGorevi);
                cp.personelBilgileriniGetirLV(lvPersoneller);
                btnYeni.Enabled = true;
                btnSil.Enabled = false;
                btnBilgiDegistir.Enabled = false;
                btnEkle.Enabled = false;
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

                lblBilgi.Text = "Mevki : Müdür / Yetki Sınırsız / Kullanıcı : " + cp.personelBilgiGetirIsim(cGenel._personelId);

            }
            else
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                lblBilgi.Text = "Mevki : "+gorev+" / Yetki Sınırlı / Kullanıcı : " + cp.personelBilgiGetirIsim(cGenel._personelId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text.Trim() != "" || txtYeniSifreTekrar.Text.Trim() != "")
            {
                if (txtYeniSifre.Text==txtYeniSifreTekrar.Text)
                {
                    if (txtPersonelId.Text != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(txtPersonelId.Text), txtYeniSifre.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre Değiştirme İşlemi Başarıyla Gerçekleştirilmiştir.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel Seçiniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Aynı Değil!");
                }
            }
            else
            {
                MessageBox.Show("Şifre Alanını Boş Bırakmayınız!");
            }
        }

        private void cbGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonelGorev c = (cPersonelGorev)cbGorevi.SelectedItem;
            txtGorevId2.Text = Convert.ToString(c.PersonelGorevId);
        }

        private void cbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller c = (cPersoneller)cbPersonel.SelectedItem;
            txtPersonelId.Text = Convert.ToString(c.PersonelId);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
            btnBilgiDegistir.Enabled = false;
            btnEkle.Enabled = true;
            txtSifre.ReadOnly = false;
            txtSifreTekrar.ReadOnly = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Silmek İstediğinizden Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cPersoneller c = new cPersoneller();
                    bool sonuc = c.personelSil(Convert.ToInt32(lvPersoneller.SelectedItems[0].Text));

                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt Başarıyla Silinmiştir.");
                        c.personelBilgileriniGetirLV(lvPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Silinirken Bir Hata Oluştu!");
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Seçiniz!");
                }
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() !="" & txtSoyad.Text.Trim() !="" & txtSifre.Text.Trim() !="" & txtSifreTekrar.Text!="" & txtGorevId2.Text.Trim() !="")
            {
                if (txtSifre.Text.Length>5 || txtSifreTekrar.Text.Length>5)
                {
                    if (txtSifreTekrar.Text.Trim() == txtSifre.Text.Trim())
                    {
                        cPersoneller c = new cPersoneller();
                        c.PersonelAd = txtAd.Text.Trim();
                        c.PersonelSoyad = txtSoyad.Text.Trim();
                        c.PersonelParola = txtSifreTekrar.Text;
                        c.PersonelGorevId = Convert.ToInt32(txtGorevId2.Text);
                        bool sonuc = c.personelEkle(c);

                        if (sonuc)
                        {
                            MessageBox.Show("Kayıt Başarıyla Eklenmiştir.");
                            c.personelBilgileriniGetirLV(lvPersoneller);

                        }
                        else
                        {
                            MessageBox.Show("Kayıt Eklenirken Bir Hata Oluştu!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Aynı Değil!");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen En Az 6 Haneli Şifre Girin!");
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
        }

        private void btnBilgiDegistir_Click(object sender, EventArgs e)
        {

            if (lvPersoneller.SelectedItems.Count>0)
            {

            
            if (txtAd.Text != "" || txtSoyad.Text != "" || txtSifre.Text != "" || txtSifreTekrar.Text != "" || txtGorevId2.Text != "")
            {
                    if (txtSifre.Text.Length > 5 || txtSifreTekrar.Text.Length > 5)
                    {
                        if (txtSifreTekrar.Text.Trim() == txtSifre.Text.Trim())
                        {
                            cPersoneller c = new cPersoneller();
                            c.PersonelAd = txtAd.Text.Trim();
                            c.PersonelSoyad = txtSoyad.Text.Trim();
                            c.PersonelParola = txtSifreTekrar.Text;
                            c.PersonelGorevId = Convert.ToInt32(txtGorevId2.Text);
                            bool sonuc = c.personelGuncelle(c, Convert.ToInt32(txtPersonelID2.Text));

                            if (sonuc)
                            {
                                MessageBox.Show("Kayıt Başarıyla Eklenmiştir.");
                                c.personelBilgileriniGetirLV(lvPersoneller);
                            }
                            else
                            {
                                MessageBox.Show("Kayıt Eklenirken Bir Hata Oluştu!");
                            }


                        }
                        else
                        {
                            MessageBox.Show("Şifreler Aynı Değil!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen En Az 6 Haneli Şifrenizi Giriniz!");
                    }

                
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
            }
            else
            {
                MessageBox.Show("Kayıt Seçiniz!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox8.Text.Trim() != "" || textBox9.Text.Trim() != "")
            {
                if (textBox8.Text == textBox9.Text)
                {
                    if (cGenel._personelId.ToString() != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(cGenel._personelId), textBox8.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre Değiştirme İşlemi Başarıyla Gerçekleştirilmiştir.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel Seçiniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Aynı Değil!");
                }
            }
            else
            {
                MessageBox.Show("Şifre Alanını Boş Bırakmayınız!");
            }
        }

        private void lvPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count>0)
            {
                btnSil.Enabled = true;
                btnBilgiDegistir.Enabled = true;
                txtPersonelID2.Text = lvPersoneller.SelectedItems[0].SubItems[0].Text;
                cbGorevi.SelectedIndex = Convert.ToInt32(lvPersoneller.SelectedItems[0].SubItems[1].Text) - 1;
                txtAd.Text = lvPersoneller.SelectedItems[0].SubItems[3].Text;
                txtSoyad.Text = lvPersoneller.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                btnSil.Enabled = false;
                btnBilgiDegistir.Enabled = true;
            }

        }

        private void txtPersonelID2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblBilgi_Click(object sender, EventArgs e)
        {

        }
    }
}
