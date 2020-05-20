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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex1 ex = new Ex1();
            ex.MdiParent = this;
            ex.Show();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex2 ex = new Ex2();
            ex.MdiParent = this;
            ex.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex3 ex = new Ex3();
            ex.MdiParent = this;
            ex.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex4 ex = new Ex4();
            ex.MdiParent = this;
            ex.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
