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
            int turmaC = 60;
            int turmaD = 20;
            int totalTurmas = 80;

            decimal reprov_turmaC = Convert.ToDecimal(txtPctReprovadosC.Text) / 100;
            decimal reprov_turmaD = Convert.ToDecimal(txtPctReprovadosD.Text) / 100;

            txtNumReprovadosC.Text = (reprov_turmaC * turmaC).ToString();
            txtNumReprovadosD.Text = (reprov_turmaD * turmaD).ToString();

            int numReprovadosC = Convert.ToInt32(txtNumReprovadosC.Text);
            int numReprovadosD = Convert.ToInt32(txtNumReprovadosD.Text);

            int totalReprovados = ((numReprovadosC + numReprovadosD) * 100) / totalTurmas;

            txtTotalReprovados.Text = totalReprovados.ToString();
        }
    }
}
