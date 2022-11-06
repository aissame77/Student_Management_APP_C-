using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
namespace miniProjet_dll
{
    public class Connexion
    {
        public static IDbConnection con = null;
        public static IDbCommand cmd = null;
        private static Dictionary<string, string> DataC = new Dictionary<string, string>();
        public static void Connect(string choix)
        {
            switch (choix)
            {
                case "Sql":
                    con = new SqlConnection("Data Source=AMINE22;Initial Catalog=Ensat_Manager;Integrated Security=True");
                    cmd = new SqlCommand();
                    if (con.State.ToString() == "Closed")
                    {
                        con.Open();
                        cmd.Connection = con;
                    }
                    break;
                case "Mysql":
                    //con = MySqlConnection();
                    break;
                default:
                    throw new Exception("invalid choix name");
            }

        }
        public static int IUD(string procedurename, Dictionary<string, object> dico)
        {
            cmd.Parameters.Clear();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (KeyValuePair<string, object> kp in dico)
            {
                cmd.Parameters.Add(CreateParameter(kp.Key, kp.Value));
            }
            cmd.CommandText = procedurename;
            return cmd.ExecuteNonQuery();
        }
        public static int iud(string req)
        {
            cmd.Parameters.Clear();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = req;
            return cmd.ExecuteNonQuery();
        }
        public static IDataReader Select(string req)
        {
            cmd.CommandText = req;
            return (IDataReader)cmd.ExecuteReader();
        }
       public static List<string> getChamps_table(string table)
        {
            List<String> LE = new List<String>();
            string sql = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME =" + "'" + table + "'";

            IDataReader Dr = Select(sql);
            while (Dr.Read())
            {
                LE.Add(Dr.GetString(0));
            }

            Dr.Close();

            return LE;
        }
        private static IDataParameter CreateParameter(string parameterName, object value)
        {
            IDataParameter parameter = null;
            switch (DataC["dialect"].ToLower())
            {
                case "mysql":
                    parameter = new MySqlParameter() { ParameterName = parameterName, Value = value };
                    break;
                case "sqlserver":
                    parameter = new SqlParameter() { ParameterName = parameterName, Value = value };
                    break;
            }
            return parameter;
        }
       
    }
}
