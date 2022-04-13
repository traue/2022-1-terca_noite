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
