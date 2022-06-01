using System;

namespace UniLocadora.Model
{
    public class Veiculo
    {
        private string placa, fabricante, modelo, cor;
        private int ano;

        //Construtores
        public Veiculo() { }
        public Veiculo(string placa, string fabricante, string modelo, string cor, int ano)
        {
            Placa = placa;
            Fabricante = fabricante;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
        }

        //Modificadores de Acesso (gets e sets):
        public string Placa { get => placa; set => placa = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public int Ano { get => ano; set => ano = value; }
    }
}
