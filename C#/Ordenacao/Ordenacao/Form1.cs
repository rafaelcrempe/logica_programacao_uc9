using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(txtNum1.Text);
            decimal num2 = Convert.ToDecimal(txtNum2.Text);
            decimal num3 = Convert.ToDecimal(txtNum3.Text);

            OrdenarCrescente(num1, num2, num3);
            OrdenarDecrescente(num1, num2, num3);

           
        }

        private void OrdenarCrescente(decimal num1, decimal num2, decimal num3) 
        {
            if(num1 <= num2 && num1 <= num3)
            {
                if (num2 <= num3)
                    mostraCrescente(num1, num2, num3);
                else
                    mostraCrescente(num1, num3, num2);
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                if (num1 <= num3)
                    mostraCrescente(num2, num1, num3);
                else
                    mostraCrescente(num2, num3, num1);
            }
            else
            {
                if (num1 <= num2)
                    mostraCrescente(num3, num1, num2);
                else
                    mostraCrescente(num3, num2, num1);
            }
        }

        private void OrdenarDecrescente(decimal num1, decimal num2, decimal num3)
        {
            if(num1 >= num2 && num1 >= num3)
            { if (num2 >= num3)
                    mostraDecrescente(num1, num2, num3);
                else
                    mostraDecrescente(num1, num3, num2);
            }
            else if (num2 >= num1 && num2 >= num3)
            { if (num1 >= num3)
                    mostraDecrescente(num2, num1, num3);
              else
                    mostraDecrescente (num2,num3, num1);
            }
            else
            { if (num1 >= num2)
                    mostraDecrescente(num3, num1, num2);
                else
                    mostraDecrescente(num3, num2, num1);

            }
        }

        private void mostraCrescente(decimal maior, decimal meio, decimal menor)
        {
            lblPosicao1.Text = menor.ToString();
            lblPosicao2.Text = meio.ToString();
            lblPosicao3.Text = maior.ToString();
        }

        private void mostraDecrescente(decimal maior, decimal meio, decimal menor)
        {
            lblPosicao4.Text = menor.ToString();
            lblPosicao5.Text = meio.ToString();
            lblPosicao6.Text = maior.ToString();
        }
    }
}
