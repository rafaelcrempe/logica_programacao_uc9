using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlturaMedia
{
    public partial class AlturaMedia : Form
    {
        public AlturaMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal alt1 = Convert.ToDecimal(txtAltura1.Text);
            decimal alt2 = Convert.ToDecimal(txtAltura2.Text);
            decimal alt3 = Convert.ToDecimal(txtAltura3.Text);

            decimal media = (alt1 + alt2 + alt3) / 3;

            lblAlturaMedia.Text = Math.Round(media,1).ToString();
        }
    }
}
