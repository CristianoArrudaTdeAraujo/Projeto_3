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
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void btnAcess_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text=="")
            {
                MessageBox.Show("Você deve digitar a sua senha");



            }
            else
            {
                if(txtSenha.Text == "1234")
                {
                    Form1 frmPrincipal = new Form1();
                    frmPrincipal.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha Inválida !!");
                    txtSenha.Clear();
                 
                }
            }
        }
    }
}
