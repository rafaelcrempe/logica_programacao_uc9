using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NomeCompleto
{
    public partial class NomeCompleto : Form
    {
        public NomeCompleto()
        {
            InitializeComponent();
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            lblNomeCompleto.Text = txtNome.Text + " " + txtSobrenome.Text;
        }
    }
}
