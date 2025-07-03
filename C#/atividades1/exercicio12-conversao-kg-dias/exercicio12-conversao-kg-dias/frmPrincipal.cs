using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio12_conversao_kg_dias
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int alimento = Convert.ToInt32(txtQtdAlimentos.Text) * 1000;
            int consumo = Convert.ToInt32(txtConsumo.Text);
            int dias = alimento / consumo;

            txtDias.Text = dias.ToString();



            
            
        }
    }
}
