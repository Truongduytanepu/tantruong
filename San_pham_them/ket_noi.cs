using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace San_pham_them
{
    class ket_noi
    {
        string conrt = @"Data Source=LAPTOP-C7K4JJ2S\SQLEXPRESS;Initial Catalog=PMStore;Integrated Security=True";
        SqlConnection connection;

        public ket_noi()
        {
            connection = new SqlConnection(conrt);
        }

        public DataSet lay_du_lieu(string truyvan)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(truyvan, connection);
            adapter.Fill(ds);
            return ds;
        }

        public bool thuthi(string truyvan)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(truyvan, connection);
                int r = cmd.ExecuteNonQuery();
                connection.Close();
                return r > 0;
            }
            catch
            {
                return false;
            }
        }
        



    }
}
