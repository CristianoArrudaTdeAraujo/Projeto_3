using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4
{
    public partial class Calcular : Form
    {
        public Calcular()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor1, valor2, res;
                valor1 = Convert.ToDecimal(textBoxValor1.Text);
                valor2 = Convert.ToDecimal(textBoxValor2.Text);

                res = valor1 / valor2;
                labelResultado.Text = Convert.ToString("Resultado:"+res);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não existe divisão por zero");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
