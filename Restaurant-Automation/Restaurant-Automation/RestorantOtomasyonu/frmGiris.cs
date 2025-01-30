using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace RestorantOtomasyonu
{
    public partial class frmGiris : Form
    {

        public frmGiris()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?","Uyarı!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
        private void frmGiris_Load_1(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            cbKullanici.DropDownStyle = ComboBoxStyle.DropDownList; // Salt okunur yapar
            p.personelGetbyInformation(cbKullanici);
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            cGenel gnl = new cGenel();
            cPersoneller p = new cPersoneller();
            bool result = p.personelEntryControl(txtSifre.Text, cGenel._personelId);

            if (result)
            {
                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Giriş Yaptı"; 
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);

                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Giriş başarısız. Lütfen bilgilerinizi kontrol edin!","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }


        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        // WinAPI'yi ekledim
        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void btnGiris_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.PersonelGorevId;
        }

        private void frmGiris_MouseDown(object sender, MouseEventArgs e)
        {
            // Sol fare tuşu ile taşınabilir yap
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}
