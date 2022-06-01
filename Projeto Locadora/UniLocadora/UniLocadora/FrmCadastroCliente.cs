using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;
using UniLocadora.Model;
using UniLocadora.Dao;

namespace UniLocadora
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!validaDados())
            {
                return;
            }

            DateTime dataAux;
            DateTime.TryParseExact(txtDtnasc.Text, "dd/MM/yyyy", new CultureInfo("pt-BR"),
                DateTimeStyles.None, out dataAux);

            Cliente cliente = new Cliente(
                0,
                txtNome.Text,
                txtCPF.Text,
                dataAux);

            ClienteDao cDAo = new ClienteDao();

            if(cDAo.adicionaCliente(cliente))
            {
                MessageBox.Show("Cliente cadastrado com sucesso!",
                    "Cliente Cadastrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao adicionar o cliente!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool validaDados()
        {
            //velida o cpf:
            if (!txtCPF.MaskFull)
            {
                MessageBox.Show("O CPF está incompleto!",
                    "Verifique o CPF",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtCPF.Focus();

                return false;
            }

            //primeira verificação da data
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool dataValida = regex.IsMatch(txtDtnasc.Text.Trim());

            //segunda verificação da data:
            DateTime dt;
            dataValida &= DateTime.TryParseExact(txtDtnasc.Text, "dd/MM/yyyy", new CultureInfo("pt-BR"), 
                DateTimeStyles.None, out dt);

            if(!dataValida)
            {
                MessageBox.Show("Houve algum erro na data de nescimento!",
                                   "Verifique a data",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                txtDtnasc.Focus();
                return false;
            }

            //validação do nome:
            if(string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("O nome não pode ser vazio!",
                    "Verifique o Nome",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtNome.Focus();

                return false;
            }

            return true;
        }
    }
}
