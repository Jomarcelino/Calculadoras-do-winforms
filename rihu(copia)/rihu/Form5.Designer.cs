namespace rihu
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
            this.cmbOPERAÇÕES = new System.Windows.Forms.ComboBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOPERAÇÕES
            // 
            this.cmbOPERAÇÕES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOPERAÇÕES.FormattingEnabled = true;
            this.cmbOPERAÇÕES.Items.AddRange(new object[] {
            "Mais",
            "Menos",
            "Multilpicar por",
            "Dividir por",
            "Elevado a"});
            this.cmbOPERAÇÕES.Location = new System.Drawing.Point(215, 77);
            this.cmbOPERAÇÕES.Name = "cmbOPERAÇÕES";
            this.cmbOPERAÇÕES.Size = new System.Drawing.Size(143, 21);
            this.cmbOPERAÇÕES.TabIndex = 1;
            this.cmbOPERAÇÕES.SelectedIndexChanged += new System.EventHandler(this.CmbOPERAÇÕES_SelectedIndexChanged);
            this.cmbOPERAÇÕES.TextChanged += new System.EventHandler(this.CmbOPERAÇÕES_TextChanged);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(29, 78);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(140, 20);
            this.txtN1.TabIndex = 2;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(385, 78);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(134, 20);
            this.txtN2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "é";
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(171, 166);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(230, 23);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "?";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 256);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.cmbOPERAÇÕES);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOPERAÇÕES;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
    }
}

