using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class FrmPrincipal : Form
    {
        Bhaskara bhaskara;
        public FrmPrincipal()
        {
            InitializeComponent();
            bhaskara = new Bhaskara();
        }

        private void lbRN_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            lbDelta.Text = "";
            lbRP.Text = "";
            lbRN.Text = "";
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtA.Focus();
        }

        private void txtA_Click(object sender, EventArgs e)
        {
            txtA.Select(0, 0);
        }

        private void txtB_Click(object sender, EventArgs e)
        {
            txtB.Select(0, 0);
        }

        private void txtC_Click(object sender, EventArgs e)
        {
            txtC.Select(0, 0);
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            lbRP.Visible = lbRN.Visible = false;
            //this.Width = 610;

            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            double delta;


            bhaskara.A = a;
            bhaskara.B = b;
            bhaskara.C = c;

            if (a == 0)
            {
                MessageBox.Show("Opa... O valor \"a\" não pode ser zero!", "Erro");
                return;
            }
            else
            {
                delta = bhaskara.calculaDelta();
                lbDelta.Text = "△ = " + delta.ToString();
                lbDelta.Visible = true;
                if(delta >= 0)
                {
                    double rp = bhaskara.calculaRaizPositiva(delta);
                    double rn = bhaskara.calculaRaizNegativa(delta);

                    lbRP.Text = "X' = " + rp.ToString();
                    lbRN.Text = "X\" = " + rn.ToString();

                    lbRP.Visible = lbRN.Visible = true;
                }
                else
                {
                    lbRP.Text = "Delta é menor que zero! Não há raízes reais";
                    //this.Width += 10;
                    lbRP.Visible = true;
                    lbRN.Visible = false;
                }
            }

        }
    }
}
