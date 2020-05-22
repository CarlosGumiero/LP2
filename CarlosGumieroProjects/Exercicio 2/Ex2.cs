using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosGumieroProjects
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(txtAltura.Text);
            double peso = Convert.ToDouble(txtPesoatual.Text);
            double pesoIdeal;

            if(rbtnMasc.Checked)
            {
                pesoIdeal = (72.7 * altura) - 58;
            }

            else
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            
            txtPesoideal.Text = $"Peso ideal: {pesoIdeal} Kg";

            if(peso < pesoIdeal)
            {
                txtResp.Text = $"Coma bastante massas e doces.";
            }
            else if(peso == pesoIdeal)
            {
                txtResp.Text = $"Peso ideal.";
            }
            else
            {
                txtResp.Text = $"Faça um regime";
            }
        }

        private void rbtnFem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
