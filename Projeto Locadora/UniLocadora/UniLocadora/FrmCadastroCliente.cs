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
        public bool Editando = false;

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

            if (Editando)
            {
                salvarCliente();
            }
            else
            {
                gravaNovoCliente();
            }

        }

        private void salvarCliente()
        {
            DateTime dataAux;
            DateTime.TryParseExact(txtDtnasc.Text, "dd/MM/yyyy", new CultureInfo("pt-BR"),
                DateTimeStyles.None, out dataAux);

            Cliente cliente = new Cliente(
                Convert.ToInt32(txtCodigo.Text),
                txtNome.Text,
                txtCPF.Text,
                dataAux);

            ClienteDao cDAo = new ClienteDao();

            try
            {
                if (cDAo.atualizaCLiente(cliente))
                {
                    MessageBox.Show("Cliente atualizado com sucesso!",
                        "Cliente Cadastrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void gravaNovoCliente()
        {
            DateTime dataAux;
            DateTime.TryParseExact(txtDtnasc.Text, "dd/MM/yyyy", new CultureInfo("pt-BR"),
                DateTimeStyles.None, out dataAux);

            Cliente cliente = new Cliente(
                0,
                txtNome.Text,
                txtCPF.Text,
                dataAux);

            ClienteDao cDAo = new ClienteDao();

            try
            {
                if (cDAo.adicionaCliente(cliente))
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!",
                        "Cliente Cadastrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
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

            if (!dataValida)
            {
                MessageBox.Show("Houve algum erro na data de nescimento!",
                                   "Verifique a data",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                txtDtnasc.Focus();
                return false;
            }

            //validação do nome:
            if (string.IsNullOrEmpty(txtNome.Text))
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente consultaCliente = new FrmConsultaCliente(this);
            consultaCliente.MdiParent = this.MdiParent;
            consultaCliente.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que este cliente " +
                "deve ser exclu'do permanentemente?", 
                "Excluir?", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClienteDao cDAO = new ClienteDao();
                if (cDAO.excluirCliente(Convert.ToInt32(txtCodigo.Text)))
                {
                    MessageBox.Show("Cliente excluído!",
                    "Excluído",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    btLimpar_Click(sender, e);
                }
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtCPF.Clear();
            txtNome.Clear();
            txtDtnasc.Clear();
            Editando = false;
            txtCPF.Enabled = !Editando;
            btnExcluir.Enabled = Editando;
            btnIncluir.Text = "Incluir";
        }
    }
}
