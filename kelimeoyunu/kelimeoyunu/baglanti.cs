using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace kelimeoyunu
{
    class baglanti
    {
        public SqlConnection con = new SqlConnection();
        public SqlDataAdapter da = new SqlDataAdapter();


        public void baglan()
        {
            con = new SqlConnection("Data Source=LAPTOP-SMDU8F43;Initial Catalog=kelimeoyunu;Integrated Security=True");

            con.Open();

        }
        public string[,] kelimecagir(int harf_sayi)
        {

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select top 2 kelimeler,sorular From sorular where len(kelimeler)='" + harf_sayi + "' ORDER BY NEWID()", con);

            da.Fill(ds, "sorular");
            dt = ds.Tables["sorular"];
            string[,] array2Db = new string[2, 2] {
    { dt.Rows[0]["kelimeler"].ToString(), dt.Rows[0]["sorular"].ToString() }, { dt.Rows[1]["kelimeler"].ToString(), dt.Rows[1]["sorular"].ToString() }};
            return array2Db;


        }
        public void ekle(string sorgu)
        {
            SqlCommand komut = new SqlCommand(sorgu, con);
            komut.ExecuteNonQuery();
            con.Close(); 

        }
    




    }
}
