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
    class cMasalar
    {
        #region Fields
        private int _ID;
        private int _KAPASITE;
        private int _SERISTURU;
        private int _DURUM;
        private int _ONAY;
        private string _MasaBilgi;
        #endregion

        #region Properties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public int KAPASITE
        {
            get { return _KAPASITE; }
            set { _KAPASITE = value; }
        }
        public int SERISTURU
        {
            get { return _SERISTURU; }
            set { _SERISTURU = value; }
        }
        public int DURUM
        {
            get { return _DURUM; }
            set { _DURUM = value; }
        }
        public int ONAY
        {
            get { return _ONAY; }
            set { _ONAY = value; } 
        }

        public string MasaBilgi
        {
            get { return _MasaBilgi; }
            set { _MasaBilgi = value; }
        }
        #endregion

        cGenel gnl = new cGenel();
        public DateTime? SessionSum(int state,string masaId)
        {
            using (SqlConnection con = new SqlConnection(gnl.conString))
            using (SqlCommand cmd = new SqlCommand("Select TARIH,MasaId From adisyonlar Right Join Masalar on adisyonlar.MasaId=Masalar.ID Where Masalar.DURUM=@durum and adisyonlar.Durum=0 and masalar.ID=@masaId", con))
            {
                cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
                cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Convert.ToInt32(masaId);

                try
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            object tarih = dr["TARIH"];
                            if (tarih != DBNull.Value)
                            {
                                return Convert.ToDateTime(tarih);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Hata loglanabilir
                    throw new Exception("Tarih bilgisi alınırken bir hata oluştu: " + ex.Message);
                }
            }
            return null;
        }

        //burayı değiştirdim
        public int TableGetbyNumber(string TableValue)
        {
            // Null kontrolü ekleyelim
            if (string.IsNullOrEmpty(TableValue))
            {
                return 0; // veya uygun bir varsayılan değer
            }

            // Eğer masa numarası 10 veya daha büyükse, son iki karakteri al
            if (TableValue.EndsWith("10"))
            {
                return 10;
            }
            // Tek basamaklı masa numaraları için son karakteri al
            else
            {
                return Convert.ToInt32(TableValue.Substring(TableValue.Length - 1, 1));
            }
        }

        public bool TableGetbyState(int ButtonName,int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select durum From Masalar Where Id=@TableId and DURUM=@state", con);

            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;
            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }

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

        //burayı değiştirdim
        public void setChangeTableState(string ButonName, int state)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update masalar Set DURUM=@Durum where ID=@MasaNo", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string aa = ButonName;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;

            if (aa.EndsWith("10"))
            {
                cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = 10;
            }
            else
            {
                cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = Convert.ToInt32(aa.Substring(uzunluk - 1, 1));
            }

            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }

        public void MasaKapasitesiveDurumGetir(ComboBox cm)
        {
            cm.Items.Clear();
            string durum = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from masalar", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cMasalar c = new cMasalar();
                if (c._DURUM==2)
                {
                    durum = "DOLU";
                    
                }
                else if (c._DURUM==3)
                {
                    durum = "Rezerve";
                }
                c._KAPASITE = Convert.ToInt32(dr["KAPASITE"]);
                c._MasaBilgi = "Masa No: " + dr["ID"].ToString() + " Kapasitesi :" + dr["KAPASITE"].ToString();
                c._ID = Convert.ToInt32(dr["ID"]);
                cm.Items.Add(c);
            }

            dr.Close();

            con.Dispose();
            con.Close();
        }

        public override string ToString()
        {
            return MasaBilgi;
        }

    }
}
