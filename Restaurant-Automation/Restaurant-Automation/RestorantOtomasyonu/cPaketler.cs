using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RestorantOtomasyonu
{
    class cPaketler
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _ID;
        private int _AdditionID;
        private int _ClientId;
        private string _Description;
        private int _State;
        private int _Paytypeid;
        #endregion

        #region Properties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public int AdditionID
        {
            get { return _AdditionID; }
            set { _AdditionID = value; }
        }
        public int ClientId
        {
            get { return _ClientId; }
            set { _ClientId = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public int State
        {
            get { return _State; }
            set { _State = value; }
        }
        public int Paytypeid
        {
            get { return _Paytypeid; }
            set { _Paytypeid = value; }
        } 
        #endregion

        //Paket Servisi Açma
        public bool OrderSeriveceOpen(cPaketler order)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            // Önce mevcut açık siparişleri kontrol edelim
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM paketSiparis WHERE MUSTERIID=@MUSTERIID AND durum=0", con);
            SqlCommand cmd = new SqlCommand("Insert Into paketSiparis(ADISYONID,MUSTERIID,ODEMETURID,ACIKLAMA,durum) values (@ADISYONID,@MUSTERIID,@ODEMETURID,@ACIKLAMA,0)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Önce müşterinin açık siparişi var mı kontrol et
                checkCmd.Parameters.Add("@MUSTERIID", SqlDbType.Int).Value = order._ClientId;
                int existingOrders = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (existingOrders == 0) // Eğer açık sipariş yoksa yeni sipariş ekle
                {
                    cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value = order._AdditionID;
                    cmd.Parameters.Add("@MUSTERIID", SqlDbType.Int).Value = order._ClientId;
                    cmd.Parameters.Add("@ODEMETURID", SqlDbType.Int).Value = order._Paytypeid;
                    cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = order._Description;

                    result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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

            return result;
        }

        //Paket Servis Kapatma
        public void OrderSeriveceClose(int AdditionID)
        {
          
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update paketSiparis set paketSiparis.durum=1 where paketSiparis.ADISYONID=@AdditionID", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@AdditionID", SqlDbType.Int).Value = AdditionID;

                Convert.ToBoolean(cmd.ExecuteNonQuery());
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
        }

        //Açılan adisyon ve paket siparişe ait öngirilen odeme tur id
        public int OdemeTurIdGetir(int adisyonId)
        {
            int odemeTurID = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select paketSiparis.ODEMETURID from paketSiparis Inner Join Adisyonlar on paketSiparis.ADISYONID=Adisyonlar.ID where adisyonlar.ID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;

                odemeTurID = Convert.ToInt32(cmd.ExecuteScalar());
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
            return odemeTurID;
        }

        //Sipariş kontrol için müşteriyeait açık olan en son adisyon nosunu getirme
        //bir müşteriye ait 2 tane siparişin açık olmayacağını belirtiyoruz.
        public int musteriSonAdisyonIDGetir(int musteriID)
        {
            int no = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select adisyonlar.ID from adisyonlar Inner Join paketSiparis on paketSiparis.ADISYONID=Adisyonlar.ID where (adisyonlar.DURUM=0) and (paketSiparis.DURUM=0) and (paketSiparis.MUSTERIID=@musteriID)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@musteriID", SqlDbType.Int).Value = musteriID;

                no = Convert.ToInt32(cmd.ExecuteScalar());
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

            return no;
        }

        //Müşteri arama ekranında adisyonbul butonu adisyon açık mı değil mi kontrol.
        public bool getCheckOpenAdditionID(int additionID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from adisyonlar where (DURUM=0) and (ID=@additionID)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@additionID", SqlDbType.Int).Value = additionID;

                result = Convert.ToBoolean(cmd.ExecuteScalar());
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

            return result;
        }
    }
}
