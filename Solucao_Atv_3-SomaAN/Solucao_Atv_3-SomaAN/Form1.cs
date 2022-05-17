using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucao_Atv_3_SomaAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int a, n;
            Int32.TryParse(txtVA.Text, out a);
            Int32.TryParse(txtVN.Text, out n);
            lbResposta.Text = SomaAN(a, n);
        }

        private String SomaAN(int a, int n)
        {
            int cont = a;
            int aux = a;
            string saida = a.ToString();

            for (int i = 1; i < n; i++)
            {
                cont += (a + i);
                saida += " + ";
                aux = a + i;
                saida += aux;
            }

            return saida + " = " + cont;
        }
    }
}
