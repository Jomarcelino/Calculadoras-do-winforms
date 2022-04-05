
namespace wfacalculadora
{
    partial class calcradio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calcradio));
            this.gpBox1 = new System.Windows.Forms.GroupBox();
            this.rdbdiv = new System.Windows.Forms.RadioButton();
            this.rdbmult = new System.Windows.Forms.RadioButton();
            this.rdbsubt = new System.Windows.Forms.RadioButton();
            this.rdbsoma = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblresult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btnlimpa = new System.Windows.Forms.Button();
            this.ltbhistorico = new System.Windows.Forms.ListBox();
            this.histlimpa = new System.Windows.Forms.Button();
            this.gpBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBox1
            // 
            this.gpBox1.Controls.Add(this.rdbdiv);
            this.gpBox1.Controls.Add(this.rdbmult);
            this.gpBox1.Controls.Add(this.rdbsubt);
            this.gpBox1.Controls.Add(this.rdbsoma);
            resources.ApplyResources(this.gpBox1, "gpBox1");
            this.gpBox1.Name = "gpBox1";
            this.gpBox1.TabStop = false;
            // 
            // rdbdiv
            // 
            resources.ApplyResources(this.rdbdiv, "rdbdiv");
            this.rdbdiv.Name = "rdbdiv";
            this.rdbdiv.TabStop = true;
            this.rdbdiv.UseVisualStyleBackColor = true;
            this.rdbdiv.CheckedChanged += new System.EventHandler(this.rdbdiv_CheckedChanged);
            // 
            // rdbmult
            // 
            resources.ApplyResources(this.rdbmult, "rdbmult");
            this.rdbmult.Name = "rdbmult";
            this.rdbmult.TabStop = true;
            this.rdbmult.UseVisualStyleBackColor = true;
            this.rdbmult.CheckedChanged += new System.EventHandler(this.rdbmult_CheckedChanged);
            // 
            // rdbsubt
            // 
            resources.ApplyResources(this.rdbsubt, "rdbsubt");
            this.rdbsubt.Name = "rdbsubt";
            this.rdbsubt.TabStop = true;
            this.rdbsubt.UseVisualStyleBackColor = true;
            this.rdbsubt.CheckedChanged += new System.EventHandler(this.rdbsubt_CheckedChanged);
            // 
            // rdbsoma
            // 
            resources.ApplyResources(this.rdbsoma, "rdbsoma");
            this.rdbsoma.Name = "rdbsoma";
            this.rdbsoma.TabStop = true;
            this.rdbsoma.UseVisualStyleBackColor = true;
            this.rdbsoma.CheckedChanged += new System.EventHandler(this.rdbsoma_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblresult);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBox2);
            this.panel1.Controls.Add(this.txtBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblresult
            // 
            resources.ApplyResources(this.lblresult, "lblresult");
            this.lblresult.Name = "lblresult";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtBox2
            // 
            resources.ApplyResources(this.txtBox2, "txtBox2");
            this.txtBox2.Name = "txtBox2";
            // 
            // txtBox1
            // 
            resources.ApplyResources(this.txtBox1, "txtBox1");
            this.txtBox1.Name = "txtBox1";
            // 
            // btnlimpa
            // 
            resources.ApplyResources(this.btnlimpa, "btnlimpa");
            this.btnlimpa.Name = "btnlimpa";
            this.btnlimpa.UseVisualStyleBackColor = true;
            this.btnlimpa.Click += new System.EventHandler(this.btnlimpa_Click);
            // 
            // ltbhistorico
            // 
            this.ltbhistorico.FormattingEnabled = true;
            resources.ApplyResources(this.ltbhistorico, "ltbhistorico");
            this.ltbhistorico.Name = "ltbhistorico";
            // 
            // histlimpa
            // 
            resources.ApplyResources(this.histlimpa, "histlimpa");
            this.histlimpa.Name = "histlimpa";
            this.histlimpa.UseVisualStyleBackColor = true;
            // 
            // calcradio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.histlimpa);
            this.Controls.Add(this.ltbhistorico);
            this.Controls.Add(this.btnlimpa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpBox1);
            this.Name = "calcradio";
            this.gpBox1.ResumeLayout(false);
            this.gpBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBox1;
        private System.Windows.Forms.RadioButton rdbdiv;
        private System.Windows.Forms.RadioButton rdbmult;
        private System.Windows.Forms.RadioButton rdbsubt;
        private System.Windows.Forms.RadioButton rdbsoma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btnlimpa;
        private System.Windows.Forms.ListBox ltbhistorico;
        private System.Windows.Forms.Button histlimpa;
    }
}

