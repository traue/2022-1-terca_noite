namespace PorValor_PorReferencia
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVarA = new System.Windows.Forms.TextBox();
            this.txtVarB = new System.Windows.Forms.TextBox();
            this.txtResA = new System.Windows.Forms.TextBox();
            this.txtResB = new System.Windows.Forms.TextBox();
            this.btValor = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Variável A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variável B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Variável A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Variável B:";
            // 
            // txtVarA
            // 
            this.txtVarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVarA.Location = new System.Drawing.Point(190, 87);
            this.txtVarA.Name = "txtVarA";
            this.txtVarA.Size = new System.Drawing.Size(266, 44);
            this.txtVarA.TabIndex = 4;
            // 
            // txtVarB
            // 
            this.txtVarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVarB.Location = new System.Drawing.Point(189, 146);
            this.txtVarB.Name = "txtVarB";
            this.txtVarB.Size = new System.Drawing.Size(267, 44);
            this.txtVarB.TabIndex = 5;
            // 
            // txtResA
            // 
            this.txtResA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResA.Location = new System.Drawing.Point(190, 314);
            this.txtResA.Name = "txtResA";
            this.txtResA.Size = new System.Drawing.Size(266, 44);
            this.txtResA.TabIndex = 6;
            // 
            // txtResB
            // 
            this.txtResB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResB.Location = new System.Drawing.Point(189, 381);
            this.txtResB.Name = "txtResB";
            this.txtResB.Size = new System.Drawing.Size(267, 44);
            this.txtResB.TabIndex = 7;
            // 
            // btValor
            // 
            this.btValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValor.Location = new System.Drawing.Point(17, 222);
            this.btValor.Name = "btValor";
            this.btValor.Size = new System.Drawing.Size(255, 57);
            this.btValor.TabIndex = 8;
            this.btValor.Text = "Por Valor";
            this.btValor.UseVisualStyleBackColor = true;
            this.btValor.Click += new System.EventHandler(this.btValor_Click);
            // 
            // btnRef
            // 
            this.btnRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef.Location = new System.Drawing.Point(280, 222);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(264, 57);
            this.btnRef.TabIndex = 9;
            this.btnRef.Text = "Por Referência";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 556);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btValor);
            this.Controls.Add(this.txtResB);
            this.Controls.Add(this.txtResA);
            this.Controls.Add(this.txtVarB);
            this.Controls.Add(this.txtVarA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Por Valor / Por Referência";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVarA;
        private System.Windows.Forms.TextBox txtVarB;
        private System.Windows.Forms.TextBox txtResA;
        private System.Windows.Forms.TextBox txtResB;
        private System.Windows.Forms.Button btValor;
        private System.Windows.Forms.Button btnRef;
    }
}

