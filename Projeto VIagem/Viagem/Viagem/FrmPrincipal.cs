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
    }
}
