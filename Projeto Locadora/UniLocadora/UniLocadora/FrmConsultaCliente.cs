using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using UniLocadora.Dao;
using UniLocadora.Model;

namespace UniLocadora
{
    public partial class FrmConsultaCliente : Form
    {
        FrmCadastroCliente frmCadastroCliente;
        public FrmConsultaCliente(FrmCadastroCliente frmCadastroCliente)
        {
            InitializeComponent();
            this.frmCadastroCliente=frmCadastroCliente;
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            ClienteDao cDAO = new ClienteDao();

            List<Cliente> clientes = cDAO.GetClientes();

            dgvClientes.DataSource = clientes;

            dgvClientes.Columns[0].HeaderCell.Value = "Cód. do Cliente";
            dgvClientes.Columns[1].HeaderCell.Value = "Nome";
            dgvClientes.Columns[2].HeaderCell.Value = "CPF";
            dgvClientes.Columns[3].HeaderCell.Value = "Dt. Nascimento";

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.IdCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            cliente.Nome = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            cliente.Cpf = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            cliente.DtNasc = Convert.ToDateTime(dgvClientes.CurrentRow.Cells[3].Value);

            frmCadastroCliente.txtCodigo.Text = cliente.IdCliente.ToString();
            frmCadastroCliente.txtNome.Text = cliente.Nome;
            frmCadastroCliente.txtCPF.Text = cliente.Cpf;
            frmCadastroCliente.txtDtnasc.Text = cliente.DtNasc.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            frmCadastroCliente.txtCPF.Enabled = false;
            frmCadastroCliente.btnExcluir.Enabled = true;
            frmCadastroCliente.btnIncluir.Text = "Salvar";

            frmCadastroCliente.Editando = true;

            this.Close();
        }
    }
}
