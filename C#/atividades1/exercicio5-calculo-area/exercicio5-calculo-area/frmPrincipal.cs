using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio5_calculo_area
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal lado = Convert.ToDecimal(txtValor.Text);
            decimal area = lado * lado;
            decimal dobro = area * 2;

            txtArea.Text = area.ToString();
            txtDobro.Text = dobro.ToString();


        }
    }
}
