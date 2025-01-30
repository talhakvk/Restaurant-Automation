using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestorantOtomasyonu
{
    class cRezervasyon
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _ID;
        private int _TableId;
        private int _ClientId;
        private DateTime _Date;
        private int _CleintCount;
        private string _Description;
        private int _AdditionId;
        #endregion

        #region Properties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public int TableId
        {
            get { return _TableId; }
            set { _TableId = value; }
        }
        public int ClientId
        {
            get { return _ClientId; }
            set { _ClientId = value; }
        }
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public int CleintCount
        {
            get { return _CleintCount; }
            set { _CleintCount = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public int AdditionId
        {
            get { return _AdditionId; }
            set { _AdditionId = value; }
        }
        #endregion

        //MüşteriId masa numarasına göre
        public int getByClientIdFromRezervasyon(int tableId)
        {
            int clientId = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 MUSTERIID from Rezervasyonlar where MASAID=@masaid order by MUSTERIID Desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@masaid", SqlDbType.Int).Value = tableId;
                clientId = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return clientId;
        }

        //Hesap kapatırken rezervasyonlu masayı kapattık.
        public bool rezervationClose(int adisyonID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Rezervasyonlar set durum=0 where ADISYONID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonID;
                // ExecuteNonQuery kullanıp etkilenen satır sayısını kontrol et
                result = Convert.ToBoolean(cmd.ExecuteNonQuery() > 0);
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

        //Rezervasyonları Getir
        public void musteriIdGetirFromRezervasyon(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select Rezervasyonlar.MUSTERIID,( AD + SOYAD ) as musteri from Rezervasyonlar Inner Join musteriler on Rezervasyonlar.MUSTERIID=musteriler.ID where Rezervasyonlar.Durum=0", conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["MUSTERIID"].ToString());
                lv.Items[i].SubItems.Add(dr["musteri"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();

        }

        //Eski rezervasyonları getir --TARIH < Tarih--
        public void eskirezervasyonlariGetir(ListView lv,int mId)
        {
            lv.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select Rezervasyonlar.MUSTERIID, AD, SOYAD,ADISYONID,TARIH from Rezervasyonlar Inner Join musteriler on Rezervasyonlar.MUSTERIID=musteriler.ID where Rezervasyonlar.MUSTERIID=@mId and Rezervasyonlar.Durum=0 order by rezervasyonlar.ID Desc", conn);

            comm.Parameters.Add("@mId", SqlDbType.Int).Value = mId;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["MUSTERIID"].ToString());
                lv.Items[i].SubItems.Add(dr["AD"].ToString());
                lv.Items[i].SubItems.Add(dr["SOYAD"].ToString());
                lv.Items[i].SubItems.Add(dr["TARIH"].ToString());
                lv.Items[i].SubItems.Add(dr["ADISYONID"].ToString());

                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();

        }

        //en son rezervasyon tarihini getir
        public DateTime EnSonRezervasyonTarihi(int mId)
        {
            DateTime tarih = new DateTime();
            tarih = DateTime.Now;
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select TARIH from Rezervasyonlar where Rezervasyonlar.MUSTERIID=@mId and Rezervasyonlar.Durum=1 order by rezervasyonlar.ID Desc", conn);

            comm.Parameters.Add("@mId", SqlDbType.Int).Value = mId;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            tarih = Convert.ToDateTime(comm.ExecuteScalar());
            

            conn.Dispose();
            conn.Close();

            return tarih;
        }

        //açık rezervasyon sayısını getir
        public int acikRezervasyonSayisi()
        {
            int sonuc = 0;
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select count(*) from Rezervasyonlar where Rezervasyonlar.Durum=0", conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                sonuc = Convert.ToInt32(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }

            conn.Dispose();
            conn.Close();

            return sonuc;
        }

        //Rezervasyon açık mı kontrol et
        public bool RezervasyonAcikmiKontrol(int mId)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 Rezervasyonlar.ID from Rezervasyonlar where MUSTERIID=@mID and Durum=1 order by ID desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@mID", SqlDbType.Int).Value = mId;
                result = Convert.ToBoolean(cmd.ExecuteScalar());

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

        //Rezervasyon aç
        public bool RezervasyonAc(cRezervasyon r)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Rezervasyonlar (MUSTERIID,MASAID,ADISYONID,KISISAYISI,TARIH,ACIKLAMA,DURUM) values (@MUSTERIID,@MASAID,@ADISYONID,@KISISAYISI,@TARIH,@ACIKLAMA,@DURUM)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@MUSTERIID", SqlDbType.Int).Value = r._ClientId;
                cmd.Parameters.Add("@MASAID", SqlDbType.Int).Value = r._TableId;
                cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value = r._AdditionId;
                cmd.Parameters.Add("@KISISAYISI", SqlDbType.Int).Value = r._CleintCount;
                cmd.Parameters.Add("@TARIH", SqlDbType.Date).Value = r._Date;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = r._Description;
                cmd.Parameters.Add("@DURUM", SqlDbType.Int).Value = 1;  // Başlangıçta true (1) olarak değiştirdik
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

        //Rezerve masanın ID'sini getir
        public int RezerveMasaIdGetir(int mId)
        {
            int sonuc = 0;
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select Rezervasyonlar.MASAID from Rezervasyonlar INNER JOIN Adisyonlar on Rezervasyonlar.ADISYONID=Adisyonlar.ID where (Rezervasyonlar.Durum=1) and Adisyonlar.Durum=0 and Rezervasyonlar.MUSTERIID=@mId", conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                comm.Parameters.Add("@mId", SqlDbType.Int).Value = mId;
                sonuc = Convert.ToInt32(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }

            conn.Dispose();
            conn.Close();

            return sonuc;
        }
    }
}
