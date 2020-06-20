using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CarlosGumieroProjects.Exercicio_7
{
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            double[] qtd = new double[10];
            double[] preco = new double[10];
            string val = "";
            double fat = 0;

            for (var x = 0; x < 10; x++)
            {
                val = Interaction.InputBox("Quantidade de mercadoria" + (x + 1) + ": ", "Entrada de dados");
                if (double.TryParse(val, out qtd[x]))
                {
                    while (true)
                    {
                        val = Interaction.InputBox("Valor da mercadoria" + (x + 1) + ": ", "Entrada de dados");
                        if (double.TryParse(val, out preco[x]))
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Insira o valor da mercadoria" + (x + 1) + ": ", "corretamente");
                        }
                    }
                    fat += qtd[x] * preco[x];
                }
                else
                {
                    MessageBox.Show("Insira a quantidade da mercadoria" + (x + 1) + ": ", "corretamente");
                    x--;
                }
            }
        }
    }
}
