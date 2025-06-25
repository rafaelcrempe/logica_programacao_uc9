using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio7_imc
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
         double peso = Convert.ToDouble(txtPeso.Text);
         double altura = Convert.ToDouble(txtAltura.Text);

        double imc = peso / (altura * altura);
        imc = Math.Round(imc, 1);


            if(imc < 18.5){
                MessageBox.Show($"Seu IMC é {imc}. Você está abaixo do peso.");
            }
            else if(imc >= 18.5 && imc <= 24.9){
                MessageBox.Show($"Seu IMC é {imc}. Você está no peso normal.");
            }
            else if(imc >= 25 && imc <= 29.9){
                MessageBox.Show($"Seu IMC é {imc}. Você está em sobrepeso.");
            }
            else if(imc >= 30 && imc <= 34.9){
                MessageBox.Show($"Seu IMC é {imc}. Você está em Obesidade Grau 1.");
            }
            else if (imc >= 35 && imc <= 39.9){
                MessageBox.Show($"Seu IMC é {imc}. Você está em Obesidade Grau 2.");
            }
            else {
                MessageBox.Show($"Seu IMC é {imc}. Você está em Obesidade Grau 3.");
            }

        }
    }
}
