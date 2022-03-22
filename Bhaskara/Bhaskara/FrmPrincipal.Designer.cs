namespace Bhaskara
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lbInformacao = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbInformacao
            // 
            this.lbInformacao.AutoSize = true;
            this.lbInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformacao.Location = new System.Drawing.Point(12, 36);
            this.lbInformacao.Name = "lbInformacao";
            this.lbInformacao.Size = new System.Drawing.Size(468, 37);
            this.lbInformacao.TabIndex = 0;
            this.lbInformacao.Text = "Insira uma equação quadrática:";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(19, 140);
            this.txtA.Mask = "#0000";
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 44);
            this.txtA.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbInformacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Bhaskara";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInformacao;
        private System.Windows.Forms.MaskedTextBox txtA;
    }
}