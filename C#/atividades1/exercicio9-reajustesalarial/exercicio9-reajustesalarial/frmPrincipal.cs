using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio9_reajustesalarial
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToDouble(txtSalario.Text);
            double reajuste = Convert.ToDouble(txtReajuste.Text);

            double SalarioFinal = salario + (salario * (reajuste / 100));

            txtSalarioFinal.Text = $"R$ {SalarioFinal.ToString()}";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
