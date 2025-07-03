using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio16_decomposicao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnDecompor_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNum.Text);
            int milhar = (numero / 1000) % 10;
            int centena = (numero / 100) % 10;
            int dezena = (numero / 10) % 10;
            int unidade = numero % 10;



            txtMilhar.Text = milhar.ToString();
            txtCentena.Text = centena.ToString();
            txtDezena.Text = dezena.ToString();
            txtUnidade.Text = unidade.ToString();

        }
    }
}
