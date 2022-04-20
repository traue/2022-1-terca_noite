namespace Viagem
{
    partial class FrmRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            this.rtRelatorio = new System.Windows.Forms.RichTextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.btExportarTXT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtRelatorio
            // 
            this.rtRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtRelatorio.Location = new System.Drawing.Point(12, 12);
            this.rtRelatorio.Name = "rtRelatorio";
            this.rtRelatorio.Size = new System.Drawing.Size(1004, 538);
            this.rtRelatorio.TabIndex = 0;
            this.rtRelatorio.Text = "";
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(779, 556);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(237, 71);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btExportarTXT
            // 
            this.btExportarTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btExportarTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportarTXT.Location = new System.Drawing.Point(450, 556);
            this.btExportarTXT.Name = "btExportarTXT";
            this.btExportarTXT.Size = new System.Drawing.Size(323, 71);
            this.btExportarTXT.TabIndex = 2;
            this.btExportarTXT.Text = "Exportar para TXT";
            this.btExportarTXT.UseVisualStyleBackColor = false;
            this.btExportarTXT.Click += new System.EventHandler(this.btExportarTXT_Click);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 700);
            this.Controls.Add(this.btExportarTXT);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.rtRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorio";
            this.Text = "Relatório de Gastos";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtRelatorio;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btExportarTXT;
    }
}