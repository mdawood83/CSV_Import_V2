using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Import_V2.DAL
{
    public static class DBAccess
    {
        private static SqlConnection con;

        public static string GetConnSetting(string Conn_name)
        {
            ConnectionStringSettings ret_val = ConfigurationManager.ConnectionStrings[Conn_name];

            if (ret_val == null) throw new Exception("202201240916 ConnectionStrings not found [" + Conn_name + "]");

            return ret_val.ToString();
        }

        public static bool ExecuteQuery(string query)
        {
            try
            {
                string db = GetConnSetting("NaturalGasDB");

                using (con = new SqlConnection(db))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
