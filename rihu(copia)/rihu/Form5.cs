using rihu.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rihu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmbOPERAÇÕES_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbOPERAÇÕES_TextChanged(object sender, EventArgs e)
        {
            CalculadoraBasica objCalc = new CalculadoraBasica();
            switch (cmbOPERAÇÕES.Text)
            {
                case "Mais":
                    objCalc.Num1 = decimal.Parse(txtN1.Text);
                    objCalc.Num2 = decimal.Parse(txtN2.Text);
                    objCalc.somar();
                    lblResultado.Text = objCalc.Resultado.ToString();
                    break;

                    case "Menos":
                    objCalc.Num1 = decimal.Parse(txtN1.Text);
                    objCalc.Num2 = decimal.Parse(txtN2.Text);
                    objCalc.Menos();
                    lblResultado.Text = objCalc.Resultado.ToString();
                    break;

                    case "Multiplicar":
                    objCalc.Num1 = decimal.Parse(txtN1.Text);
                    objCalc.Num2 = decimal.Parse(txtN2.Text);
                    objCalc.Multiplicar();
                    lblResultado.Text = objCalc.Resultado.ToString();
                    break;

                    case "Dividir":
                    objCalc.Num1 = decimal.Parse(txtN1.Text);
                    objCalc.Num2 = decimal.Parse(txtN2.Text);
                    objCalc.Dividir();
                    lblResultado.Text = objCalc.Resultado.ToString();
                    break;

                    case "Potencia":
                    objCalc.Num1 = decimal.Parse(txtN1.Text);
                    objCalc.Num2 = decimal.Parse(txtN2.Text);
                    objCalc.Potencia();
                    lblResultado.Text = objCalc.Resultado.ToString();
                    break;
            }
        }
    }
}
