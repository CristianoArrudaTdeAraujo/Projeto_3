using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Projeto3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\windows\system32\calc.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_Nome.Text.Length == 0)
            {
                MessageBox.Show("Digite o nome:");
                textBox_Nome.Focus();

            }
            if (comboBox_Destino.Text == "")
            {
                MessageBox.Show("Destino não escolhido");
                comboBox_Destino.Focus();

            }
            if (radioButton_Aviao.Checked==false && radioButton_Onibus.Checked == false)
            {
                MessageBox.Show("Meio de Transporte não escolhido");
                radioButton_Onibus.Focus();

            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            float gasto_destino, gasto_transporte,gasto_total;
            switch (comboBox_Destino.Text.ToUpper())
            {
                case "SP":gasto_destino=1000f;
                    break;
                case "RJ":
                    gasto_destino = 1500f;
                    break;
                case "SC":
                    gasto_destino = 2000f;
                    break;
                default: gasto_destino = 0.0f;
                    break;
            }
            if (radioButton_Aviao.Checked == true)
            {

                gasto_transporte = 100f;


            }
            else
            {
                gasto_transporte = 30f;
            }
            gasto_total = gasto_transporte+ gasto_destino;
          
            groupBox_Resultado.Visible = true;
            labelgastoDestino.Text = gasto_destino.ToString("C2");
            label_gastoTransporte.Text = gasto_transporte.ToString("C2");
            label_total.Text = gasto_total.ToString("C2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_Nome.Text = "";
            radioButton_Aviao.Checked = false;
            radioButton_Onibus.Checked = false;
        }
    }
}
