using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            Form filhaAtiva = this.ActiveMdiChild;
            if (filhaAtiva != null)
            {
                try
                {
                    RichTextBox rtTexto = (RichTextBox)filhaAtiva.ActiveControl;
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Arquivo de Texto | *.txt";
                    saveFileDialog.FileName = "Meu Arquivo.txt";
                    saveFileDialog.RestoreDirectory = true;

                    if(saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());
                        filhaAtiva.Text = saveFileDialog.FileName;
                        for(int i = 0; i < rtTexto.Lines.Length; i++)
                        {
                            writer.WriteLine(rtTexto.Lines[i]);
                        }

                        writer.Dispose();
                        writer.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Você precisa selecionar uma janela!");
                }
            }
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilha f = new FrmFilha();
            f.Text = String.Format("Formulário {0}", this.MdiChildren.Length + 1);
            f.MdiParent = this;
            f.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI = (MdiClient)this.Controls[this.Controls.Count - 1];
            ctlMDI.BackColor = Color.Black;

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilha f;
            if(this.ActiveMdiChild == null)
            {
                f = new FrmFilha();
                f.MdiParent = this;
                f.ActiveControl = f.rtTexto;
            }
            else
            {
                f = (FrmFilha)this.ActiveMdiChild;
            }

            RichTextBox richText = (RichTextBox)f.ActiveControl;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Arquivo de Texto |*.txt";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader =
                    new StreamReader(openFileDialog.OpenFile());

                richText.Text = reader.ReadToEnd().ToString();

                reader.Dispose();
                reader.Close();

                f.Text = String.Format("{0}", openFileDialog.FileName);
                f.Show();
            }
        }
    }

    //DESAFIO DO TIO!!!
    //VALE 10 NA DISCIPLINA. ISSO MESMO!
    //SE VOCÊ FIZER, NÃO É PRECISO REALIZAR MAIS NENHUMA ATIVIDADE!!!
    /*
     * Implementar, sem COPIAR DA INTERNET (o tio vai investigar)
     * Os métodos de 
     *  - salvar como, 
     *  - salvar (corrigir o nosso),
     *  - recortar (o texto selecionado)
     *  - Alterar fonte da richTextBox (apenas em runtime, não é preciso salvar em rtf)
     *  - Arrumar todos os ícones
     *  - Implementar quebra automática de linha (word wrap)
     *  - Imprimir
     *  - Localizar no texto (opcional)
     *  - Qualquer outra coisa que quiser incluir...
     */
}
