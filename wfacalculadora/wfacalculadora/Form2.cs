using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfacalculadora
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void calculadoraPlusPlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 interform2 = new Form2();
            interform2.MdiParent = this;
            interform2.Show();
        }

        private void calculadoraComRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form interform1 = new calcradio();
            interform1.MdiParent = this;
            interform1.Show();
        }

        private void calculadoraComBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 interform3 = new Form3();
            interform3.MdiParent = this;
            interform3.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void calculadoraOrientadoObjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 interform5 = new Form5();
            interform5.MdiParent = this;
            interform5.Show();
        }
    }
}
