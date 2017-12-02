using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace HouseManager
{
    public class Database
    {
        //Declaração de variáveis.
        private static SQLiteConnection conn; // variável para conectar com a DB.
        private static Database instance; //variável para verificar a instância da DB. 
        private const string URL = "Data Source=database.db"; // caminho da DB
        private const string NOMEBANCO = "database.db"; // nome da DB

        //Construtor
        private Database()
        {
            conn = new SQLiteConnection(URL); // faz a conexão com db.

            //verifica se a db existe e se o resultado for false chama o método de criar a db.
            if (!File.Exists(NOMEBANCO)) 
            {
                CriarDatabase();
            }
        }

        //Método de criação da DB
        public static void CriarDatabase()
        {
            SQLiteConnection.CreateFile(NOMEBANCO);
            SQLiteConnection con = new SQLiteConnection(URL);
            con.Open();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Pessoa ([cpf] varchar(14) PRIMARY KEY, [nome] varchar(64), [email] varchar(32), [telefone] varchar(15));");
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Login([nome] varchar(16) PRIMARY KEY, [senha] varchar(256), [admin] integer, [cpfpessoa] varchar(14), FOREIGN KEY(cpfpessoa) REFERENCES Pessoa(cpf) ON DELETE CASCADE);");
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Conta([id] integer PRIMARY KEY autoincrement, [nome] varchar(64), [detalhes] varchar(128), [valor] float, [vencimento] date, [cpfresponsavel] varchar(14), foreign key(cpfresponsavel) references pessoa(cpf));");
            //sql.AppendLine("CREATE TABLE IF NOT EXISTS Produto([id] integer PRIMARY KEY autoincrement, [nome] varchar(64) UNIQUE, [detalhes] varchar(128), [quantidade] float);");
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Transacao([id] integer PRIMARY KEY autoincrement, [data] date, [valor] float, [idconta] integer, FOREIGN KEY(idconta) REFERENCES Conta(id));");
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Transacao_Produto([idcompra] integer, [produto] varchar(64), [quantidade] float, PRIMARY KEY(idcompra,produto), FOREIGN KEY(idcompra) REFERENCES CompraEVenda(id) ON DELETE CASCADE);");
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Pagamento([idconta] integer,[cpfpessoa] varchar(14), [pago] integer, [apagar] float, PRIMARY KEY(idconta,cpfpessoa), FOREIGN KEY(idconta) REFERENCES Conta(id) ON DELETE CASCADE, FOREIGN KEY(cpfpessoa) REFERENCES Pessoa(cpf) ON DELETE CASCADE);");
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), con);
            cmd.ExecuteNonQuery();
        }

        //Método de verificar a instancia da db.
        public static Database GetInstance()
        {
            if(instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        //Método de verificar conexão.
        public SQLiteConnection GetConnection()
        {
            return conn;
        }     

        //Método de executar uma query na db recebendo ela como parâmetro sem retornar nada.
        public void ExecuteNonQuery(string qry)
        {   //Verifica e abre conexão com o banco.
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            // Passa a qry e a conexão para uma variável do tipo cmd e chama o método para executar o comando no banco.
            SQLiteCommand comm = new SQLiteCommand(qry, conn);
            comm.ExecuteNonQuery();
            //fecha conexão.
            conn.Close();
        }

        //Método de executar query na db com retorno de linhas alteradas.
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
