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
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Imc imc = new Imc();
            imc.Altura = float.Parse(txtAltura.Text);
            imc.Peso = float.Parse(txtPeso.Text);
            lbResultadoIMC.Text = imc.calcularIMC().ToString();
        }
    }
}
