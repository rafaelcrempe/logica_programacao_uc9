using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio4_metros_centimetros
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(txtValor.Text);
            decimal resultado = num1 * 100;

            lblResultado.Text = $"{num1}m são {resultado}cm.";
            lblResultado.Left = this.Width / 2 - 75;
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            lblResultado.Left = this.Width / 2 - 75;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
