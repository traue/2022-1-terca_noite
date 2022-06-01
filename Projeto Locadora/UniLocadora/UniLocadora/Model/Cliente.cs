using System;

namespace UniLocadora.Model
{
    public class Cliente
    {
        private int idCliente;
        private string nome, cpf;
        private DateTime dtNasc;

        //construtores
        public Cliente() { }

        public Cliente(int idCliente, string nome, string cpf, DateTime dtNasc)
        {
            IdCliente = idCliente;
            Nome = nome;
            Cpf = cpf;
            DtNasc = dtNasc;
        }

        //modificadores de acesso (sets e gets):
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime DtNasc { get => dtNasc; set => dtNasc = value; }

    }
}
