using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraButton
{
    public partial class CalcButton : Form
    {
        public CalcButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(txtBox1.Text) + int.Parse(txtBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(txtBox1.Text) - int.Parse(txtBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(txtBox1.Text) * int.Parse(txtBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(txtBox1.Text) / int.Parse(txtBox2.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double n1 = int.Parse(txtBox1.Text);
            double n2 = int.Parse(txtBox2.Text);


            lblResult.Text = Math.Pow(n1, n2).ToString();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
        }
    }
}
