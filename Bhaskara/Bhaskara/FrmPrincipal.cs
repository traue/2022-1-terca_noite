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
        public FrmPrincipal()
        {
            InitializeComponent();
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
    }
}
