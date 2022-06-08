using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Clone();
                }

                throw;
            }
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            
            string query = "SELECT id_cliente, nome, data_nasc, cpf "+
                   "FROM cliente ORDER BY nome";
            
            MySqlConnection conn = Conexao.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dtr;

            try
            {
                conn.Open();
                dtr = cmd.ExecuteReader();

                while(dtr.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = dtr.GetInt32("id_cliente");
                    cliente.Nome = dtr.GetString("nome");
                    cliente.Cpf = dtr.GetString("cpf");
                    cliente.DtNasc = dtr.GetDateTime("data_nasc");

                    clientes.Add(cliente);
                }
                conn.Clone();
                return clientes;

            }
            catch
            {
                throw;
            }
        }

        public bool atualizaCLiente(Cliente cliente)
        {
            MySqlConnection conn = Conexao.GetConnection();
            try
            {
                string query = "UPDATE cliente SET " +
                    "nome = @nome, " +
                    "data_nasc = @data_nasc " +
                    "WHERE id_cliente = @id_cliente";

                if(conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
                cmd.Parameters.Add(new MySqlParameter("@data_nasc", cliente.DtNasc));
                cmd.Parameters.Add(new MySqlParameter("@id_cliente", cliente.IdCliente));

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool excluirCliente(int idCliente)
        {
            MySqlConnection conn = Conexao.GetConnection();
            try
            {
                string query = "DELETE FROM cliente WHERE id_cliente = @id_cliente";

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.Add(new MySqlParameter("@id_cliente", idCliente));

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                throw;
            }

        }
    }
}
