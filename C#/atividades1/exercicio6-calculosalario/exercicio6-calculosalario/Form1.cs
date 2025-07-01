using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio6_calculosalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(txtValor.Text);
            decimal horas = Convert.ToDecimal(txtHoras.Text);

            decimal salario = valor * horas;
            salario = Math.Round(salario, 2);

            txtSalario.Text = $"R$ {salario.ToString()}";

           
        }
    }
}
