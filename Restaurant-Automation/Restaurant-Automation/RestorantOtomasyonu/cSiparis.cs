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
    class cSiparis
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _Id;
        private int _adisyonID;
        private int _urunId;
        private int _adet;
        private int _masaId;
        #endregion

        #region Properties
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int AdisyonID
        {
            get { return _adisyonID; }
            set { _adisyonID = value; }
        }
        public int UrunId
        {
            get { return _urunId; }
            set { _urunId = value; }
        }
        public int Adet
        {
            get { return _adet; }
            set { _adet = value; }
        }
        public int MasaId
        {
            get { return _masaId; }
            set { _masaId = value; }
        } 
        #endregion

        //Siparişleri Getir
        public  void getByOrder(ListView lv,int AdisyonId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select URUNAD,FIYAT,Satislar.ID,URUNID,satislar.ADET from satislar Inner Join urunler on Satislar.URUNID=Urunler.ID Where ADISYONID=@AdisyonId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
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
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["FIYAT"]) * Convert.ToDecimal(dr["ADET"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());

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

        public bool setSaveOrder(cSiparis bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into satislar(ADISYONID,URUNID,ADET,MASAID) values(@AdisyonNo,@UrunId,@Adet,@masaId)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@AdisyonNo", SqlDbType.Int).Value = bilgiler._adisyonID;
                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = bilgiler._urunId;
                cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = bilgiler._adet;
                cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = bilgiler._masaId;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

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

        public void setDeleteOrder(int satisId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete From Satislar Where ID=@SatisID", con);
            cmd.Parameters.Add("@SatisID", SqlDbType.Int).Value = satisId;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }

        public decimal GenelToplamBul(int musteriId)
        {
            decimal geneltoplam = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand(@"
        SELECT ISNULL(SUM(TOPLAMTUTAR), 0) 
        FROM hesapOdemeleri ho
        INNER JOIN adisyonlar a ON ho.ADISYONID = a.ID 
        INNER JOIN paketSiparis ps ON ps.ADISYONID = a.ID
        WHERE ps.MUSTERIID = @musteriId", con);
            cmd.Parameters.Add("musteriId", SqlDbType.Int).Value = musteriId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                object result = cmd.ExecuteScalar();
                // DBNull kontrolü ekliyoruz
                if (result != null && result != DBNull.Value)
                {
                    geneltoplam = Convert.ToDecimal(result);
                }

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
            return geneltoplam;
        }

        public void adisyonpaketsiparisDetaylari(ListView lv, int adisyonID)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select satislar.ID as satisID,urunler.URUNAD,urunler.FIYAT,satislar.ADET from satislar Inner Join adisyonlar on adisyonlar.ID=satislar.ADISYONID INNER JOIN urunler on urunler.ID=satislar.URUNID where satislar.ADISYONID=@adisyonID", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@adisyonID", SqlDbType.Int).Value = adisyonID;
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
                    lv.Items.Add(dr["satisID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["FIYAT"].ToString());

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
    }
}
