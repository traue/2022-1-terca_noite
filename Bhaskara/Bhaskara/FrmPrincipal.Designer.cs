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
            this.txtB = new System.Windows.Forms.MaskedTextBox();
            this.txtC = new System.Windows.Forms.MaskedTextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbZero = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lbDelta = new System.Windows.Forms.Label();
            this.lbRP = new System.Windows.Forms.Label();
            this.lbRN = new System.Windows.Forms.Label();
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
            this.txtA.Click += new System.EventHandler(this.txtA_Click);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(206, 140);
            this.txtB.Mask = "#0000";
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 44);
            this.txtB.TabIndex = 2;
            this.txtB.Click += new System.EventHandler(this.txtB_Click);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(384, 140);
            this.txtC.Mask = "#0000";
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 44);
            this.txtC.TabIndex = 3;
            this.txtC.Click += new System.EventHandler(this.txtC_Click);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(125, 147);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(75, 37);
            this.lbA.TabIndex = 4;
            this.lbA.Text = "X² +";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(312, 147);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(66, 37);
            this.lbB.TabIndex = 5;
            this.lbB.Text = "X +";
            // 
            // lbZero
            // 
            this.lbZero.AutoSize = true;
            this.lbZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZero.Location = new System.Drawing.Point(490, 143);
            this.lbZero.Name = "lbZero";
            this.lbZero.Size = new System.Drawing.Size(63, 37);
            this.lbZero.TabIndex = 6;
            this.lbZero.Text = "= 0";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(19, 218);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(534, 59);
            this.btCalcular.TabIndex = 7;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btLimpar.Location = new System.Drawing.Point(12, 545);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(534, 47);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lbDelta
            // 
            this.lbDelta.AutoSize = true;
            this.lbDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelta.Location = new System.Drawing.Point(12, 316);
            this.lbDelta.Name = "lbDelta";
            this.lbDelta.Size = new System.Drawing.Size(121, 37);
            this.lbDelta.TabIndex = 9;
            this.lbDelta.Text = "DELTA";
            this.lbDelta.Visible = false;
            // 
            // lbRP
            // 
            this.lbRP.AutoSize = true;
            this.lbRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRP.Location = new System.Drawing.Point(12, 377);
            this.lbRP.Name = "lbRP";
            this.lbRP.Size = new System.Drawing.Size(254, 37);
            this.lbRP.TabIndex = 10;
            this.lbRP.Text = "RAIZ_POSITIVA";
            this.lbRP.Visible = false;
            // 
            // lbRN
            // 
            this.lbRN.AutoSize = true;
            this.lbRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRN.Location = new System.Drawing.Point(12, 441);
            this.lbRN.Name = "lbRN";
            this.lbRN.Size = new System.Drawing.Size(271, 37);
            this.lbRN.TabIndex = 11;
            this.lbRN.Text = "RAIZ_NEGATIVA";
            this.lbRN.Visible = false;
            this.lbRN.Click += new System.EventHandler(this.lbRN_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 618);
            this.Controls.Add(this.lbRN);
            this.Controls.Add(this.lbRP);
            this.Controls.Add(this.lbDelta);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbZero);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbInformacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Bhaskara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInformacao;
        private System.Windows.Forms.MaskedTextBox txtA;
        private System.Windows.Forms.MaskedTextBox txtB;
        private System.Windows.Forms.MaskedTextBox txtC;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbZero;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lbDelta;
        private System.Windows.Forms.Label lbRP;
        private System.Windows.Forms.Label lbRN;
    }
}