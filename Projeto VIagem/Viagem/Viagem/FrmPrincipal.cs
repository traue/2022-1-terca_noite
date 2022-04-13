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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ckGastoPedagio_CheckedChanged(object sender, EventArgs e)
        {
            lbPedagio.Visible = lbCifraoPedagio.Visible = txtPedagio.Visible = ckGastoPedagio.Checked;
            if (ckGastoPedagio.Checked)
                txtPedagio.Focus();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float consumo, distancia, combustivel, pedagios;

                consumo = float.Parse(txtConsumo.Text);
                distancia = float.Parse(txtDistancia.Text);
                combustivel = float.Parse(txtCombustivel.Text);

                //if(ckGastoPedagio.Checked)
                //{
                //    pedagios = float.Parse(txtPedagio.Text);
                // }

                //if ternário
                // <uma condução booleana> ? resultado se verdadeiro : resultado se falso;
                pedagios = ckGastoPedagio.Checked ? float.Parse(txtPedagio.Text) : 0;

                FrmRelatorio frmRelatorio = new FrmRelatorio(consumo, distancia, combustivel, pedagios);
                frmRelatorio.Show();
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Ops.. algo errado com os valores...");
            }
        }
    }
}
