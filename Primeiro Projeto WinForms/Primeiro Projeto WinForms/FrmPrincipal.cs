using System;
using System.Windows.Forms;

namespace Primeiro_Projeto_WinForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void lbNome_Click(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            //se o texto do txtNome sem espaços e convertido para string for uma caddeia vazia
            if (txtNome.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Preencha seu nome!", "Ops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else //senão
            {
                lbResultado.Text = $"Olá {txtNome.Text}, seja muito bem-vindo(a)";
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            lbResultado.Text = "*****";
            txtNome.Text = "";
            txtNome.Focus();
        }
    }
}
