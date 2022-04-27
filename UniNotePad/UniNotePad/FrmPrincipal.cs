using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniNotePad
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Deseja realmente sair?",
                "Sair", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
