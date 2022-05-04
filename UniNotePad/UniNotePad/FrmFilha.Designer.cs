namespace UniNotePad
{
    partial class FrmFilha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilha));
            this.rtTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtTexto
            // 
            this.rtTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtTexto.Location = new System.Drawing.Point(0, 0);
            this.rtTexto.Name = "rtTexto";
            this.rtTexto.Size = new System.Drawing.Size(1072, 720);
            this.rtTexto.TabIndex = 0;
            this.rtTexto.Text = "";
            // 
            // FrmFilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 720);
            this.Controls.Add(this.rtTexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFilha";
            this.Text = "FrmFilha";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtTexto;
    }
}