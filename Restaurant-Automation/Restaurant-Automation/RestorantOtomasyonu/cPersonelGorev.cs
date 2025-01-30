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
    class cPersonelGorev
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _personelGorevId;
        private string _tanim;
        #endregion

        #region Properties
        public int PersonelGorevId
        {
            get { return _personelGorevId; }
            set { _personelGorevId = value; }
        }
        public string Tanim
        {
            get { return _tanim; }
            set { _tanim = value; }
        } 
        #endregion

        public void PersonelGorevGetir(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from personelGorevleri", con);


            SqlDataReader dr = null;



            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cPersonelGorev p = new cPersonelGorev();
                    p._personelGorevId = Convert.ToInt32(dr["ID"]);
                    p._tanim = dr["GOREV"].ToString();
                    
                    cb.Items.Add(p);
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

        public string PersonelGorevTanim(int pr)
        {
            string aa = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select GOREV from personelGorevleri where ID=@perId", con);

            cmd.Parameters.Add("perId", SqlDbType.Int).Value = pr;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                aa = cmd.ExecuteScalar().ToString();
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
            return aa;
        }

        public override string ToString()
        {
            return _tanim; 
        }
    }
}
