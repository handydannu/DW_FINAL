using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace BAPPEDADW.Class
{
    public class Koneksi
    {
        public SqlConnection konek_oltp = new SqlConnection(@"Data Source=Dannu\;Initial Catalog=RKA2011;Integrated Security=TRUE");
        SqlConnection konek_dw = new SqlConnection(@"Data Source=Dannu\;Initial Catalog=BAPPEDADW;Integrated Security=TRUE");
        SqlCommand com = null;

        public DataTable tampil_data_oltp(string x)
        {
            DataTable dt = new DataTable();
            try
            {
                konek_oltp.Open();
                com = new SqlCommand();
                com.Connection = konek_oltp;
                com.CommandType = CommandType.Text;
                com.CommandText = x;
                SqlDataReader mdr = com.ExecuteReader();
                dt.Load(mdr);
                konek_oltp.Close();
            }
            catch(SqlException)
            {

            }
            com = null;
            return dt;
        } //konek_oltp

        public DataTable tampil_data_dw(string x)
        {
            DataTable dt = new DataTable();
            try
            {
                konek_dw.Open();
                com = new SqlCommand();
                com.Connection = konek_dw;
                com.CommandType = CommandType.Text;
                com.CommandText = x;
                SqlDataReader mdr = com.ExecuteReader();
                dt.Load(mdr);
                konek_dw.Close();
            }
            catch (SqlException)
            {
            }
            com = null;
            return dt;
        } //konek_dw
        
    }
}