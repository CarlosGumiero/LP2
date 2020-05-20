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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lado1 = Convert.ToDouble(txt1.Text);
            double lado2 = Convert.ToDouble(txt2.Text);
            double lado3 = Convert.ToDouble(txt3.Text);

            if(lado1 == lado2 && lado2 == lado3 && lado1 == lado3)
            {
               txtResp.Text = $"Triângulo Equilátero";
            }

            else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
            {
                txtResp.Text = $"Triângulo Isóceles";
            }

            else if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1)
            {
                txtResp.Text = $"Triângulo Escaleno";
            }
        }



    }
}
