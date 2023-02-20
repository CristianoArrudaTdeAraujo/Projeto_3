using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForm.formularios
{
    public partial class FormOpçao1 : Form
    {
        public FormOpçao1()
        {
            InitializeComponent();
        }

        private void buttonSaudar_Click(object sender, EventArgs e)
        {
            classes.ClassOpçao1 opcao1 = new classes.ClassOpçao1();
            String minhasaudacao = opcao1.Saudar(textBox1.Text);
            MessageBox.Show(minhasaudacao);
        }
    }
}
