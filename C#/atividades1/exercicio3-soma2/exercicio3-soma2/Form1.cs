using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio3_soma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(txtNum1.Text);
            decimal num2 = Convert.ToDecimal(txtNum2.Text);

            decimal resultado = (num1 * num1) + (num2 * num2);

            lblResultado.Text = $"A soma dos quadrados é: {resultado.ToString()}";
        }
    }
}
