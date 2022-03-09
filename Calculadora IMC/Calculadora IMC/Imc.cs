using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_IMC
{
    public class Imc
    {
        private float peso;
        private float altura;

        public float Peso
        {
            get => peso;  //retorno, famoso "me dá"
            set => peso = value;  //altera o valor, famoco "tó"
        }

        public float Altura
        {
            get => altura;
            set => altura = value;
        }

        public float calculaIMC()
        {
            float imc = peso / (altura * altura);
            return imc;
        }

        //desafio do tio: 
        //façam sozinhos o método que calcula a classificação...
        //usando essa tabela: https://arquivos.sbn.org.br/equacoes/eq5.htm
        //❤️

    }
}
