using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio10_aplicacao_financeira
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal deposito = Convert.ToDecimal(txtDeposito.Text);
            decimal rendimento = Convert.ToDecimal(txtRendimento.Text) / 100;
        
            int meses = Convert.ToInt32(txtMeses.Text);

            decimal final =  deposito + ((deposito *  rendimento) * meses);
            final = Math.Round(final, 2);

            txtRendaFinal.Text = $"R$ {final.ToString()}";


        }
    }
}
