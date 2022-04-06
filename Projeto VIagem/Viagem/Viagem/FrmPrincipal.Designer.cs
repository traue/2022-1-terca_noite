namespace Viagem
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
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.lbConsumo = new System.Windows.Forms.Label();
            this.lbCombustivel = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.ckGastoPedagio = new System.Windows.Forms.CheckBox();
            this.lbPedagio = new System.Windows.Forms.Label();
            this.txtPedagio = new System.Windows.Forms.TextBox();
            this.lbKm = new System.Windows.Forms.Label();
            this.lbCifraoCombustivel = new System.Windows.Forms.Label();
            this.lbCifraoPedagio = new System.Windows.Forms.Label();
            this.lbKML = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(12, 42);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(629, 59);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Informe os dados da viagem:";
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistancia.Location = new System.Drawing.Point(13, 182);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(386, 51);
            this.lbDistancia.TabIndex = 1;
            this.lbDistancia.Text = "Distância a percorrer:";
            // 
            // lbConsumo
            // 
            this.lbConsumo.AutoSize = true;
            this.lbConsumo.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsumo.Location = new System.Drawing.Point(13, 268);
            this.lbConsumo.Name = "lbConsumo";
            this.lbConsumo.Size = new System.Drawing.Size(506, 51);
            this.lbConsumo.TabIndex = 3;
            this.lbConsumo.Text = "Consumo médio do veículo:";
            // 
            // lbCombustivel
            // 
            this.lbCombustivel.AutoSize = true;
            this.lbCombustivel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCombustivel.Location = new System.Drawing.Point(13, 354);
            this.lbCombustivel.Name = "lbCombustivel";
            this.lbCombustivel.Size = new System.Drawing.Size(396, 51);
            this.lbCombustivel.TabIndex = 4;
            this.lbCombustivel.Text = "Valor do combustível:";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.Location = new System.Drawing.Point(541, 185);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 50);
            this.txtDistancia.TabIndex = 6;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumo.Location = new System.Drawing.Point(541, 271);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 50);
            this.txtConsumo.TabIndex = 7;
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombustivel.Location = new System.Drawing.Point(541, 357);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(100, 50);
            this.txtCombustivel.TabIndex = 8;
            // 
            // ckGastoPedagio
            // 
            this.ckGastoPedagio.AutoSize = true;
            this.ckGastoPedagio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckGastoPedagio.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckGastoPedagio.Location = new System.Drawing.Point(12, 440);
            this.ckGastoPedagio.Name = "ckGastoPedagio";
            this.ckGastoPedagio.Size = new System.Drawing.Size(515, 55);
            this.ckGastoPedagio.TabIndex = 11;
            this.ckGastoPedagio.Text = "Houve gasto com pedágio";
            this.ckGastoPedagio.UseVisualStyleBackColor = true;
            this.ckGastoPedagio.CheckedChanged += new System.EventHandler(this.ckGastoPedagio_CheckedChanged);
            // 
            // lbPedagio
            // 
            this.lbPedagio.AutoSize = true;
            this.lbPedagio.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedagio.Location = new System.Drawing.Point(13, 530);
            this.lbPedagio.Name = "lbPedagio";
            this.lbPedagio.Size = new System.Drawing.Size(370, 51);
            this.lbPedagio.TabIndex = 12;
            this.lbPedagio.Text = "Gasto com pedágio:";
            this.lbPedagio.Visible = false;
            // 
            // txtPedagio
            // 
            this.txtPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedagio.Location = new System.Drawing.Point(541, 533);
            this.txtPedagio.Name = "txtPedagio";
            this.txtPedagio.Size = new System.Drawing.Size(100, 50);
            this.txtPedagio.TabIndex = 13;
            this.txtPedagio.Visible = false;
            // 
            // lbKm
            // 
            this.lbKm.AutoSize = true;
            this.lbKm.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKm.Location = new System.Drawing.Point(647, 184);
            this.lbKm.Name = "lbKm";
            this.lbKm.Size = new System.Drawing.Size(77, 51);
            this.lbKm.TabIndex = 14;
            this.lbKm.Text = "Km";
            // 
            // lbCifraoCombustivel
            // 
            this.lbCifraoCombustivel.AutoSize = true;
            this.lbCifraoCombustivel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCifraoCombustivel.Location = new System.Drawing.Point(469, 357);
            this.lbCifraoCombustivel.Name = "lbCifraoCombustivel";
            this.lbCifraoCombustivel.Size = new System.Drawing.Size(66, 51);
            this.lbCifraoCombustivel.TabIndex = 15;
            this.lbCifraoCombustivel.Text = "R$";
            // 
            // lbCifraoPedagio
            // 
            this.lbCifraoPedagio.AutoSize = true;
            this.lbCifraoPedagio.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCifraoPedagio.Location = new System.Drawing.Point(469, 530);
            this.lbCifraoPedagio.Name = "lbCifraoPedagio";
            this.lbCifraoPedagio.Size = new System.Drawing.Size(66, 51);
            this.lbCifraoPedagio.TabIndex = 16;
            this.lbCifraoPedagio.Text = "R$";
            this.lbCifraoPedagio.Visible = false;
            // 
            // lbKML
            // 
            this.lbKML.AutoSize = true;
            this.lbKML.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKML.Location = new System.Drawing.Point(647, 270);
            this.lbKML.Name = "lbKML";
            this.lbKML.Size = new System.Drawing.Size(110, 51);
            this.lbKML.TabIndex = 17;
            this.lbKML.Text = "Km/L";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCalcular.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(22, 628);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(735, 90);
            this.btCalcular.TabIndex = 18;
            this.btCalcular.Text = "Calcular gasto com essa viagem";
            this.btCalcular.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(820, 742);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbKML);
            this.Controls.Add(this.lbCifraoPedagio);
            this.Controls.Add(this.lbCifraoCombustivel);
            this.Controls.Add(this.lbKm);
            this.Controls.Add(this.txtPedagio);
            this.Controls.Add(this.lbPedagio);
            this.Controls.Add(this.ckGastoPedagio);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lbCombustivel);
            this.Controls.Add(this.lbConsumo);
            this.Controls.Add(this.lbDistancia);
            this.Controls.Add(this.lbInfo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora da Viagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Label lbConsumo;
        private System.Windows.Forms.Label lbCombustivel;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.CheckBox ckGastoPedagio;
        private System.Windows.Forms.Label lbPedagio;
        private System.Windows.Forms.TextBox txtPedagio;
        private System.Windows.Forms.Label lbKm;
        private System.Windows.Forms.Label lbCifraoCombustivel;
        private System.Windows.Forms.Label lbCifraoPedagio;
        private System.Windows.Forms.Label lbKML;
        private System.Windows.Forms.Button btCalcular;
    }
}

