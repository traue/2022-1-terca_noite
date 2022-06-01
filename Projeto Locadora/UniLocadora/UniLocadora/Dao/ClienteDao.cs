using MySql.Data.MySqlClient;
using System;
using System.Data;
using UniLocadora.Model;

namespace UniLocadora.Dao
{
    public class ClienteDao
    {
        public bool adicionaCliente(Cliente cliente)
        {
            MySqlConnection conn = Conexao.GetConnection();

            try
            {
                //instrução de insert no banco...:
                string query = "INSERT INTO cliente(nome, cpf, data_nasc) " +
                                "VALUES(@nome, @cpf, @dtNasc)";

                //abre a conexão:
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                //cria um objeto com as instruções que definimos:

                MySqlCommand cmd = new MySqlCommand(query, conn);

                //define os parâmetros da query:
                cmd.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
                cmd.Parameters.Add(new MySqlParameter("@cpf", cliente.Cpf));
                cmd.Parameters.Add(new MySqlParameter("@dtNasc", cliente.DtNasc));

                //executa o comando:
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Clone();
                }
                return false;
            }
        }
    }
}
