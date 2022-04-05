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
    public partial class calcradio : Form
    {
        public calcradio()
        {
            InitializeComponent();
        }

        private void rdbsoma_CheckedChanged(object sender, EventArgs e)
        {
            lblresult.Text = (int.Parse(txtBox1.Text) + int.Parse(txtBox2.Text)).ToString();
        }

        private void rdbsubt_CheckedChanged(object sender, EventArgs e)
        {
            lblresult.Text = (int.Parse(txtBox1.Text) - int.Parse(txtBox2.Text)).ToString();
        }

        private void rdbmult_CheckedChanged(object sender, EventArgs e)
        {
            lblresult.Text = (int.Parse(txtBox1.Text) * int.Parse(txtBox2.Text)).ToString();
        }

        private void rdbdiv_CheckedChanged(object sender, EventArgs e)
        {
            lblresult.Text = (int.Parse(txtBox1.Text) / int.Parse(txtBox2.Text)).ToString();
        }

        private void btnlimpa_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
        }
    }
}
