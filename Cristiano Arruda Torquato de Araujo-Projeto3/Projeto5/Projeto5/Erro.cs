using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto5
{
    public partial class Erro : Form
    {
        public Erro()
        {
            InitializeComponent();
         

        }

        private void Erro_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "")
            {
                errorProvider1.SetError(textBoxNome, "Você não digito o nome");
                textBoxNome.Focus();
                return;

            }
            errorProvider1.Clear();
            try
            {
                if (Convert.ToInt32(textBoxIdade.Text) > 150)
                {
                    errorProvider2.SetError(textBoxIdade, "|Você digitou idade inválida");
                    textBoxIdade.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na digitação da idade","Mensagem de alerta");
            }



        }
    }
}
