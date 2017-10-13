using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace WindowsFormsApplication2
{
    public class Database
    {
        private static SQLiteConnection conn;
        private static Database instance;
        private const string URL = "Data Source=database.db";
        private const string NOMEBANCO = "database.db";

        private Database()
        {
            conn = new SQLiteConnection(URL);

            if (!File.Exists(NOMEBANCO))
            {
                CriarDatabase();
            }
        }

        public static void CriarDatabase()
        {
            SQLiteConnection.CreateFile(NOMEBANCO);
            SQLiteConnection con = new SQLiteConnection(URL);
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Pessoa ([cpf] varchar(14) PRIMARY KEY, [nome] varchar(64), [email] varchar(32), [telefone] varchar(15));");
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Login([nome] varchar(16) PRIMARY KEY, [senha] varchar(256));");
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Conta([id] integer PRIMARY KEY autoincrement, [nome] varchar(64), [detalhes] varchar(128), [valor] float, [vencimento] date, [cpfresponsavel] varchar(14), foreign key(cpfresponsavel) references pessoa(cpf));");
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Produto([id] integer PRIMARY KEY autoincrement, [nome] varchar(64), [detalhes] varchar(128), [quantidade] float);");
            sql.AppendLine("CREATE TABLE IF NOT EXISTS CompraEVenda([id] integer PRIMARY KEY autoincrement, [data] date, [valor] float, [int] compra);");
            sql.AppendLine("CREATE TABLE IF NOT EXISTS CompraEVenda_Produto([idcompra] integer, [idproduto] integer, [quantidade] float, PRIMARY KEY(idcompra,idproduto), FOREIGN KEY(idcompra) REFERENCES CompraEVenda(id) ON DELETE CASCADE, FOREIGN KEY(idproduto) REFERENCES Produto(id) ON DELETE CASCADE);");
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), con);
            cmd.ExecuteNonQuery();
        }

        public static Database GetInstance()
        {
            if(instance == null)
            {
                instance = new Database();
            }
            return instance;
        }
        public SQLiteConnection GetConnection()
        {
            return conn;
        }     
        public void ExecuteNonQuery(string qry)
        {
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            SQLiteCommand comm = new SQLiteCommand(qry, conn);
            comm.ExecuteNonQuery();

            conn.Close();
        }
        public DataSet ExecuteQuery(string qry)
        {

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            SQLiteCommand comm = new SQLiteCommand(qry,conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);

            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);

            conn.Close();
            return ds;
        }
    }
}
