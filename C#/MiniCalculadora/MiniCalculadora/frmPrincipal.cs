using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalculadora
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void btnSoma_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(TxtValor1.Text);
            decimal num2 = Convert.ToDecimal(TxtValor2.Text);
            decimal adicao = num1 + num2;
            lblResultado.Text = adicao.ToString();

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(TxtValor1.Text);
            decimal num2 = Convert.ToDecimal(TxtValor2.Text);
            decimal subtracao = num1 - num2;
            lblResultado.Text = subtracao.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(TxtValor1.Text);
            decimal num2 = Convert.ToDecimal(TxtValor2.Text);
            decimal multiplicacao = num1 * num2;
            lblResultado.Text = multiplicacao.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(TxtValor1.Text);
            decimal num2 = Convert.ToDecimal(TxtValor2.Text);
            if (num2 == 0)
            {
                MessageBox.Show("Não existe divisão por 0!");
                lblResultado.Text = "0";
            }
            else {

                decimal divisao = num1 / num2;
                lblResultado.Text = divisao.ToString();
                divisao = Math.Round(divisao, 2);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
