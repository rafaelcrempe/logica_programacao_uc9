using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio11_divisao_resto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNum.Text);
            int quociente = numero / 3;
            int resto = numero % 3;

            txtQuociente.Text = quociente.ToString();
            txtResto.Text = resto.ToString();
        }
    }
}
