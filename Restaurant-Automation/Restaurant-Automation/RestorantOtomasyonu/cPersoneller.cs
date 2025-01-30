using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace RestorantOtomasyonu
{
    class cPersoneller
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _PersonelId;
        private int _PersonelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _PersonelDurum;
        #endregion
        #region Properties
        public int PersonelId
        {
            get { return _PersonelId; }
            set { _PersonelId = value; }
        }
        public int PersonelGorevId
        {
            get { return _PersonelGorevId; }
            set { _PersonelGorevId = value; }
        }
        public string PersonelAd
        {
            get { return _PersonelAd; }
            set { _PersonelAd = value; }
        }
        public string PersonelSoyad
        {
            get { return _PersonelSoyad; }
            set { _PersonelSoyad = value; }
        }
        public string PersonelParola
        {
            get { return _PersonelParola; }
            set { _PersonelParola = value; }
        }
        public string PersonelKullaniciAdi
        {
            get { return _PersonelKullaniciAdi; }
            set { _PersonelKullaniciAdi = value; }
        }
        public bool PersonelDurum
        {
            get { return _PersonelDurum; }
            set { _PersonelDurum = value; }
        }
        #endregion

        public bool personelEntryControl(string password, int UserId)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM personeller WHERE ID = @Id AND PAROLA = @password", con);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = UserId; // UserId'nin tipi int olduğu için SqlDbType.Int kullanın
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                // Sorgudan dönen kayıt sayısını kontrol et
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                result = count > 0; // Eğer kayıt varsa true, yoksa false döner
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                // Hataları kullanıcıya veya log sistemine bildirebilirsiniz
                throw new Exception("Veritabanı hatası: " + hata);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); // Bağlantıyı kapatmayı unutmayın
                }
            }

            return result;
        }


        public void personelGetbyInformation(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from personeller", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cPersoneller p = new cPersoneller();
                p._PersonelId = Convert.ToInt32(dr["ID"]);
                p._PersonelGorevId = Convert.ToInt32(dr["GOREVID"]);
                p._PersonelAd = Convert.ToString(dr["AD"]);
                p._PersonelSoyad = Convert.ToString(dr["SOYAD"]);
                p._PersonelParola = Convert.ToString(dr["PAROLA"]);
                p._PersonelKullaniciAdi = Convert.ToString(dr["KULLANICIADI"]);
                p._PersonelDurum = Convert.ToBoolean(dr["DURUM"]);
                cb.Items.Add(p);
            }
            dr.Close();
            con.Close();



        }

        public override string ToString()
        {
            return $"{PersonelAd} {PersonelSoyad}";
        }

        public void personelBilgileriniGetirLV(ListView lv)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Personeller.*,personelGorevleri.GOREV from Personeller Inner join PersonelGorevleri on PersonelGorevleri.ID=Personeller.GOREVID where Personeller.Durum=0", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {

                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["GOREVID"].ToString());
                lv.Items[i].SubItems.Add(dr["GOREV"].ToString());
                lv.Items[i].SubItems.Add(dr["AD"].ToString());
                lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                lv.Items[i].SubItems.Add(dr["KULLANICIADI"].ToString());
                i++;

                //cPersoneller p = new cPersoneller();         
                //cb.Items.Add(p);
            }
            dr.Close();
            con.Close();



        }

        public void personelBilgileriniGetirfromIDLV(ListView lv,int perID)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Personeller.*,personelGorevleri.GOREV from Personeller Inner join PersonelGorevleri on PersonelGorevleri.ID=Personeller.GOREVID where Personeller.Durum=0 and Personeller.ID=@perID", con);

            cmd.Parameters.Add("perID", SqlDbType.Int).Value = perID;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {

                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["GOREVID"].ToString());
                lv.Items[i].SubItems.Add(dr["GOREV"].ToString());
                lv.Items[i].SubItems.Add(dr["AD"].ToString());
                lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                lv.Items[i].SubItems.Add(dr["KULLANICIADI"].ToString());
                i++;

                //cPersoneller p = new cPersoneller();         
                //cb.Items.Add(p);
            }
            dr.Close();
            con.Close();



        }

        public string personelBilgiGetirIsim(int perId)
        {
            string sonuc = "";

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select CONCAT(AD, ' ', SOYAD) from personeller where Personeller.Durum=0 and Personeller.ID=@perId", con);
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = perId; 

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return sonuc;
        }

        public bool personelSifreDegistir(int personelID,string pass)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update personeller set PAROLA=@pass where ID=@perId", con);
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = personelID; // UserId'nin tipi int olduğu için SqlDbType.Int kullanın
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return result;
        }

        public bool personelEkle(cPersoneller cp)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert into Personeller(AD,SOYAD,PAROLA,GOREVID) values (@AD,@SOYAD,@PAROLA,@GOREVID)", con);
            cmd.Parameters.Add("@AD", SqlDbType.VarChar).Value = _PersonelAd; 
            cmd.Parameters.Add("@SOYAD", SqlDbType.VarChar).Value = _PersonelSoyad;
            cmd.Parameters.Add("@PAROLA", SqlDbType.VarChar).Value = _PersonelParola;
            cmd.Parameters.Add("@GOREVID", SqlDbType.Int).Value = _PersonelGorevId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return result;
        }

        public bool personelGuncelle(cPersoneller cp,int perId)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update personeller set AD=@AD,SOYAD=@SOYAD,PAROLA=@PAROLA,GOREVID=@GOREVID where ID=@perId", con);
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = perId;
            cmd.Parameters.Add("@AD", SqlDbType.VarChar).Value = _PersonelAd;
            cmd.Parameters.Add("@SOYAD", SqlDbType.VarChar).Value = _PersonelSoyad;
            cmd.Parameters.Add("@PAROLA", SqlDbType.VarChar).Value = _PersonelParola;
            cmd.Parameters.Add("@GOREVID", SqlDbType.Int).Value = _PersonelGorevId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return result;
        }

        public bool personelSil(int perId)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update personeller set Durum=1 where ID=@perId", con);
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = perId;
            

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return result;
        }
    }
}
