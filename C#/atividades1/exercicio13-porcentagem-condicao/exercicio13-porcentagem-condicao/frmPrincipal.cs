using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio13_porcentagem_condicao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double turmaC = 60;
            double turmaD = 20;
            double totalTurmas = 80;

            double reprov_turmaC = Convert.ToDouble(txtPctReprovadosC.Text) / 100;
            double reprov_turmaD = Convert.ToDouble(txtPctReprovadosD.Text) / 100;

            double numReprovadosC = reprov_turmaC * turmaC;

            double numReprovadosD = reprov_turmaD * turmaD;

            txtNumReprovadosC.Text = numReprovadosC.ToString();
            txtNumReprovadosD.Text = numReprovadosD.ToString();

            double totalReprovados = ((numReprovadosC + numReprovadosD) * 100) / totalTurmas;

            txtTotalReprovados.Text = totalReprovados.ToString();
        }
    }
}
