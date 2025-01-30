using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace RestorantOtomasyonu
{
    class cUrunler
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _urunid;
        private int _urunturno;
        private string _urunad;
        private decimal _fiyat;
        private string _aciklama;
        #endregion

        #region Properties
        public int Urunid
        {
            get { return _urunid; }
            set { _urunid = value; }
        }
        public int Urunturno
        {
            get { return _urunturno; }
            set { _urunturno = value; }
        }
        public string Urunad
        {
            get { return _urunad; }
            set { _urunad = value; }
        }
        public decimal Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        } 
        #endregion

        //ürün adına göre listeleme
        public void urunleriListeleByUrunAdi(ListView lv,string urunadi)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select urunler.* ,KATEGORIADI from urunler Inner join kategoriler on kategoriler.ID=urunler.KATEGORIID Where urunler.Durum=0 and URUNAD like '%' +@urunAdi+ '%'", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@urunAdi", SqlDbType.VarChar).Value = urunadi;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                int sayac = 0;

                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}",dr["FIYAT"].ToString()));
                    sayac++;
                }
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }

        //ürün ekle
        public int urunEkle(cUrunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into urunler(URUNAD,KATEGORIID,ACIKLAMA,FIYAT) values(@urunAd,@katId,@aciklama,@fiyat)", con);


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@urunAd", SqlDbType.VarChar).Value = u._urunad;
                cmd.Parameters.Add("@katId", SqlDbType.Int).Value = u._urunturno;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@fiyat", SqlDbType.Money).Value = u._fiyat;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());

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

        //ÜRÜNler ve kategorileri listeleyecek
        public void urunleriListele(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select urunler.*,KATEGORIADI from urunler Inner join kategoriler on kategoriler.ID=urunler.KATEGORIID Where urunler.Durum=0", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                int sayac = 0;

                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
                    lv.Items[sayac].SubItems.Add(dr["ACIKLAMA"].ToString());
                    
                    sayac++;
                }
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }


        //ürünleri güncelle
        public int urunGuncelle(cUrunler u)
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update urunler set URUNAD=@urunad,KATEGORIID=@katID,ACIKLAMA=@aciklama,FIYAT=@fiyat where ID=@urunID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Parametreleri ekle
                cmd.Parameters.Add("@urunad", SqlDbType.VarChar).Value = u._urunad;
                cmd.Parameters.Add("@katID", SqlDbType.Int).Value = u._urunturno;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@fiyat", SqlDbType.Money).Value = u._fiyat;
                cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = u._urunid;

                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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

        //ürünleri sil
        public int urunSil(cUrunler u,int kat)
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);

            string sql = "Update urunler set Durum=1 where ";
            if (kat==0)
            {
                sql += "KATEGORIID=@urunID";
            }
            else
            {
                sql += "ID=@urunID";
            }

            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = u._urunid;

                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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

        //ürün ID ye göre listeleme
        public void urunleriListeleByUrunAdi(ListView lv, int urunId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select urunler.*,KATEGORIADI from urunler Inner join kategoriler on kategoriler.ID=urunler.KATEGORIID where urunler.Durum=0 and urunler.KATEGORIID=@urunID", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@urunID", SqlDbType.Int).Value = urunId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                int sayac = 0;

                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KATEGORIADI"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["FIYAT"].ToString()));
                    sayac++;
                }
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }

        //bütün ürünleri 2 tarih arası getiriyor
        public void urunleriListeleIstatistiklereGore(ListView lv,DateTimePicker Baslangic,DateTimePicker Bitis)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand(@"
        SELECT top 10 
            dbo.urunler.URUNAD, 
            dbo.kategoriler.KATEGORIADI,
            sum(dbo.satislar.ADET) as adeti 
        FROM dbo.kategoriler 
        INNER JOIN dbo.urunler ON dbo.kategoriler.ID = dbo.urunler.KATEGORIID 
        INNER JOIN dbo.satislar ON dbo.urunler.ID = dbo.Satislar.URUNID 
        INNER JOIN dbo.adisyonlar ON dbo.Satislar.ADISYONID = dbo.adisyonlar.ID 
        WHERE TARIH >= @Baslangic 
        AND TARIH < DATEADD(day, 1, @Bitis)
        GROUP BY dbo.urunler.URUNAD, dbo.kategoriler.KATEGORIADI
        ORDER BY adeti desc", con);

            DateTime baslangicTarih = Baslangic.Value.Date;
            DateTime bitisTarih = Bitis.Value.Date;

            cmd.Parameters.AddWithValue("@Baslangic", baslangicTarih);
            cmd.Parameters.AddWithValue("@Bitis", bitisTarih);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dr["URUNAD"].ToString();
                    item.SubItems.Add(dr["adeti"].ToString());
                    item.SubItems.Add(dr["KATEGORIADI"].ToString());  // Kategori adını da ekliyoruz
                    lv.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }

        //belli kategoriye ait ürünleri listeliyor
        public void urunleriListeleIstatistiklereGoreUrunId(ListView lv, DateTimePicker Baslangic, DateTimePicker Bitis,int urunkatId)
        {

            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand(@"
    SELECT top 10 
        dbo.urunler.URUNAD, 
        sum(dbo.satislar.ADET) as adeti 
    FROM dbo.kategoriler 
    INNER JOIN dbo.urunler ON dbo.kategoriler.ID = dbo.urunler.KATEGORIID 
    INNER JOIN dbo.satislar ON dbo.urunler.ID = dbo.Satislar.URUNID 
    INNER JOIN dbo.adisyonlar ON dbo.Satislar.ADISYONID = dbo.adisyonlar.ID 
    WHERE TARIH >= @Baslangic 
    AND TARIH < DATEADD(day, 1, @Bitis)
    AND dbo.urunler.KATEGORIID = @katId
    GROUP BY dbo.urunler.URUNAD 
    ORDER BY adeti desc", con);

            // DateTime parametrelerini ayarlayalım
            DateTime baslangicTarih = Baslangic.Value.Date; // Saat 00:00:00
            DateTime bitisTarih = Bitis.Value.Date; // Saat 00:00:00

            cmd.Parameters.AddWithValue("@Baslangic", baslangicTarih);
            cmd.Parameters.AddWithValue("@Bitis", bitisTarih);
            cmd.Parameters.AddWithValue("@katId", urunkatId);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dr = cmd.ExecuteReader();
                int sayac = 0;

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dr["URUNAD"].ToString();
                    item.SubItems.Add(dr["adeti"].ToString());
                    lv.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
    }
}
