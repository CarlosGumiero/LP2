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
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            string nomeFunc = txtNomeFunc.Text;
            double salBruto = Convert.ToDouble(txtSalarioBrut.Text);
            double numFil = Convert.ToDouble(txtNumFilho.Text);
            string respText, respText2;
            double IRPF = Convert.ToDouble(txtDescIRPF.Text);
            double salFam = Convert.ToDouble(txtSalFam.Text);
            double salLiq = Convert.ToDouble(txtSalLiq.Text);
            double descontoINSS = Convert.ToDouble(txtDescINSS.Text);
            double descontoIRPF = Convert.ToDouble(txtDescIRPF.Text);

            if (rbtnFem.Checked)
            {
                respText = "da Srta";
            }
            else
            {
                respText = "do Sr";
            }

            if(ccbCasado.Checked)
            {
                respText2 = "Casado(a)";
            }
            else
            {
                respText2 = "Solteiro(a)";
            }

            txtResult.Text = $"Os descontos {respText} {nomeFunc} que é {respText2} e que tem {numFil} filho(os) são:";

            //Lidando com o INSS:

            if(salBruto <= 800.47)
            {
                txtAliINSS.Text = "7,65%";
                descontoINSS = 7.65 / 100 * salBruto;
            }
            else if (salBruto <= 1050)
            {
                txtAliINSS.Text = "8,65%";
                descontoINSS = 8.65 / 100 * salBruto;
            }
            else if (salBruto <= 1400.77)
            {
                txtAliINSS.Text = "9,00%";
                descontoINSS = 9 / 100 * salBruto;
            }
            else if (salBruto <= 2801.56)
            {
                txtAliINSS.Text = "11,00%";
                descontoINSS = 11 / 100 * salBruto;
            }
            else
            {
                txtAliINSS.Text = "Teto: 308.17";
                descontoINSS =308.17;
            }

            //Lidando com o IRPF:

            if (salBruto <= 1257.12)
            {
                txtIRPF.Text = "Isento";
                descontoIRPF = 0;
            }
            else if (salBruto <= 2512.08)
            {
                txtIRPF.Text = "15,00%";
                descontoIRPF = 15 / 100 * salBruto;
            }
            else
            {
                txtIRPF.Text = "27,5%";
                descontoIRPF = 27.5 / 100 * salBruto;
            }

            //Lidando com Salario Familia:

            if (salBruto <= 435.52)
            {
                salFam = numFil * 22.33;
            }
            else if (salBruto <= 654.61)
            {
                salFam = numFil * 15.74;
            }
            else
            {
                txtIRPF.Text = "27,5%";
                descontoIRPF = 27.5 / 100 * salBruto;
            }

            salLiq = salBruto - descontoINSS - descontoIRPF + salFam;
        }

        private void txtNomeFunc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
