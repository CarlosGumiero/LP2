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
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double raio = Convert.ToDouble(txtRaio.Text);
            double altura = Convert.ToDouble(txtAltura.Text);
            double volume = 3.14 * (raio * raio * (altura));

            txtVolume.Text = $"Volume: {volume}";
        }
    }
}
