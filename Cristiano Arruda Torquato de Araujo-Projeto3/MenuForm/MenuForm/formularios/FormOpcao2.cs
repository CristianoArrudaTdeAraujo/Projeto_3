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
    public partial class FormOpcao2 : Form
    {
        public FormOpcao2()
        {
            InitializeComponent();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            int resultado;
            classes.ClassOpçao2 opcao2 = new classes.ClassOpçao2();
            resultado = opcao2.mult(Convert.ToInt32(txtN1.Text), Convert.ToInt32(txtN2.Text));
            txtRes.Text = resultado.ToString();



        }
    }
}
