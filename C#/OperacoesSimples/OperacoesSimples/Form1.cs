using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacoesSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(txtNumero1.Text);
            decimal num2 = Convert.ToDecimal(txtNumero2.Text);
            decimal adicao = num1 + num2;
            decimal subtracao = num1 - num2;
            decimal divisao = num1 / num2;
            decimal multiplicacao = num1 * num2;
            lblAdicao.Text = $"SOMA: {num1} + {num2} = {adicao.ToString()}.";
            lblSubtracao.Text = $"SUBTRAÇÃO: {num1} - {num2} = {subtracao.ToString()}.";
            lblMultiplicacao.Text = $"MULTIPLICAÇÃO: {num1} * {num2} = {multiplicacao.ToString()}.";
            lblDivisao.Text = $"DIVISÃO: {num1} / {num2} = {divisao.ToString()}.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
