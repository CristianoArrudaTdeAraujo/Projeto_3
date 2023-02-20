using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opção2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.FormOpçao1 formOpcao1 = new formularios.FormOpçao1();
            formOpcao1.Show();
        }

        private void opção2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formularios.FormOpcao2 formOpcao2 = new formularios.FormOpcao2();
            formOpcao2.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
