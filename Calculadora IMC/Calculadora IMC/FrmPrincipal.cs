using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class FrmPrincipal : Form
    {
        Imc imc;

        public FrmPrincipal()
        {
            InitializeComponent();
            imc = new Imc();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            imc.Altura = float.Parse(txtAltura.Text);
            imc.Peso = float.Parse(txtPeso.Text);
            float resultado = imc.calcularIMC();
            lbResultadoIMC.Text = resultado.ToString();
            lbClassificacaoIMC.Text = imc.classificaIMC(resultado);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            lbClassificacaoIMC.Text = "------";
            lbResultadoIMC.Text = "------";
            txtAltura.Clear();
            txtPeso.Clear();
            txtPeso.Focus();
        }
    }
}
