using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication2
{
    public class Database
    {
        private static MySqlConnection conn;
        private static Database instance;
        private const string URL = "Server=localhost; Database=aula; Uid=root; Pwd=ifsp;";

        private Database()
        {
            conn = new MySqlConnection(URL);
        }
        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }
        public MySqlConnection GetConnection()
        {
            return conn;
        }     
        public void ExecuteNonQuery(string qry)
        {
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            MySqlCommand comm = new MySqlCommand(qry, conn);
            comm.ExecuteNonQuery();

            conn.Close();
        }
        public DataSet ExecuteQuery(string qry)
        {

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            MySqlCommand comm = new MySqlCommand(qry,conn);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);

            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);

            conn.Close();
            return ds;
        }
    }

}
