using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medias
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txtValor1.Text);
            decimal nota2 = Convert.ToDecimal(txtValor2.Text);
            decimal nota3 = Convert.ToDecimal(txtValor3.Text);

            decimal media = (nota1 + nota2 + nota3) / 3;
            media = Math.Round(media, 1);
            MessageBox.Show("A média é: " + media.ToString());

            if (nota1 < media)
            {
                txtValor1.ForeColor = Color.Red;
            }
            if (nota2 < media)
            {
                txtValor2.ForeColor = Color.Red;
            }
            if (nota3 < media)
            {
                txtValor3.ForeColor = Color.Red;
            }
        }
    }
}