using MySql.Data.MySqlClient;
using System;

namespace UniLocadora.Dao
{
    public class Conexao
    {
        const string server = "localhost";
        const string user = "root";
        const string password = null;
        const string database = "unilocadora_3noite";

        //a linha abaixo é exclusiva para quem ALTEROU a porta do BD:
        //apenas utilize se a sua porta não é a 3306
        //const string port = "XXX";  

        public static MySqlConnection GetConnection()
        {
            try
            {
                String connString = $"server={server};uid={user};pwd={password};database={database}";
                MySqlConnection conn = new MySqlConnection(connString);
                return conn;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
