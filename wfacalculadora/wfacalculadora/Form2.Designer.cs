
namespace wfacalculadora
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculadoraComRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraComBotõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraPlusPlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraOrientadoObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraComRadioToolStripMenuItem,
            this.calculadoraComBotõesToolStripMenuItem,
            this.calculadoraPlusPlusToolStripMenuItem,
            this.calculadoraOrientadoObjetoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // calculadoraComRadioToolStripMenuItem
            // 
            this.calculadoraComRadioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculadoraComRadioToolStripMenuItem.Name = "calculadoraComRadioToolStripMenuItem";
            this.calculadoraComRadioToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.calculadoraComRadioToolStripMenuItem.Text = "calculadora com radio";
            this.calculadoraComRadioToolStripMenuItem.Click += new System.EventHandler(this.calculadoraComRadioToolStripMenuItem_Click);
            // 
            // calculadoraComBotõesToolStripMenuItem
            // 
            this.calculadoraComBotõesToolStripMenuItem.Name = "calculadoraComBotõesToolStripMenuItem";
            this.calculadoraComBotõesToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.calculadoraComBotõesToolStripMenuItem.Text = "calculadora com botões";
            this.calculadoraComBotõesToolStripMenuItem.Click += new System.EventHandler(this.calculadoraComBotõesToolStripMenuItem_Click);
            // 
            // calculadoraPlusPlusToolStripMenuItem
            // 
            this.calculadoraPlusPlusToolStripMenuItem.Name = "calculadoraPlusPlusToolStripMenuItem";
            this.calculadoraPlusPlusToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.calculadoraPlusPlusToolStripMenuItem.Text = "calculadora plus plus";
            this.calculadoraPlusPlusToolStripMenuItem.Click += new System.EventHandler(this.calculadoraPlusPlusToolStripMenuItem_Click);
            // 
            // calculadoraOrientadoObjetoToolStripMenuItem
            // 
            this.calculadoraOrientadoObjetoToolStripMenuItem.Name = "calculadoraOrientadoObjetoToolStripMenuItem";
            this.calculadoraOrientadoObjetoToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.calculadoraOrientadoObjetoToolStripMenuItem.Text = "calculadora orientado objeto";
            this.calculadoraOrientadoObjetoToolStripMenuItem.Click += new System.EventHandler(this.calculadoraOrientadoObjetoToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(703, 519);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraComRadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraComBotõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraPlusPlusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraOrientadoObjetoToolStripMenuItem;
    }
}