using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio8_milhas_em_kms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double milhas = Convert.ToDouble(txtMilhas.Text);

            double conversao = (milhas * 0.6214);

            conversao = Math.Round(conversao, 2);

            lblResultado.Text = $"{milhas} milha(s) equivalem à {conversao}km(s).";


        }
    }
}
