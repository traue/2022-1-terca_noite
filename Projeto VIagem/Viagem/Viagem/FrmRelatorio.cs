using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viagem
{
    public partial class FrmRelatorio : Form
    {
        float consumo, distancia, combustivel, pedagios;

        public FrmRelatorio(float consumo, float distancia, float combustivel, float pedagios)
        {
            this.consumo = consumo;
            this.distancia = distancia;
            this.combustivel = combustivel;
            this.pedagios = pedagios;
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            //faremos na aula que vem... :(
            String aux = "";

            //coloca a distância informada no relatório:
            aux = "Distância informada: " + distancia + "Km";
            adicionaTexto(aux);

            //coloca o consumo médio do veículo no relaólrio:
            aux = "Consumo médio informado: " + consumo + "Km/L";
            adicionaTexto(aux);

            //coloca o valor do combustível no relatório:
            aux = "Valor do combustível: R$" + combustivel;
            adicionaTexto(aux);

            //adiciona a informação do pedágio:
            aux = "Houve gasto com pedágio: " + (pedagios == 0 ? "Não" : "Sim");
            adicionaTexto(aux);

            //se houve gasto com pedágios, mostra...
            if(pedagios != 0)
            {
                aux = "Valor gasto com pedágios: R$" + pedagios;
                adicionaTexto(aux);
            }

            //mostra a quantidade de litros utilizada:
            float qtdLitros = calcula_qtd_litros(distancia, consumo);
            aux = "Quantidade de litros de combustível: " + qtdLitros + "L";
            adicionaTexto(aux);

            //mostra o gasto com combustível:
            float gasto_combustivel = calcula_gasto_combustivel(qtdLitros, combustivel);
            aux = "Valor total gasto com combustível: R$" + gasto_combustivel;
            adicionaTexto(aux);

            rtRelatorio.AppendText(Environment.NewLine + "-----------" + Environment.NewLine);

            //adiciona o valor total da viagem:
            aux = "Valor total da viagem: R$" + (gasto_combustivel + pedagios);
            adicionaTexto(aux);
        }

        private float calcula_qtd_litros(float distancia, float consumo)
        {
            return distancia / consumo;
        }

        private float calcula_gasto_combustivel(float qtdLitros, float combustivel)
        {
            return qtdLitros * combustivel;
        }

        //de: https://stackoverflow.com/questions/4077582/format-text-in-rich-text-box
        private void adicionaTexto(string texto)
        {
            string[] str = texto.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

            if (str.Length == 2)
            {
                rtRelatorio.DeselectAll();
                rtRelatorio.SelectionFont = new Font(rtRelatorio.SelectionFont, FontStyle.Bold);
                rtRelatorio.AppendText(Environment.NewLine + str[0] + ": ");
                rtRelatorio.SelectionFont = new Font(rtRelatorio.SelectionFont, FontStyle.Regular);
                rtRelatorio.AppendText(str[1]);
            } // Else?? Well, do something else..
        }


    }
}
