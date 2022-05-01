using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_WindowsForm_01_Exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            if (textUsuario.Text == "Cleydson" && textSenha.Text == "123456")
            {
                Menu NovaTela = new Menu(); // chamar 
                NovaTela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nome de Usuário/Senha incorreto.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btLogin.Focus();
                textSenha.Clear();
                textUsuario.Clear();
            }
                         
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            

            if(textSenha.TextLength <= 5)
            {
                btLogin.Enabled = false;
            }
            else
            {
                btLogin.Enabled = true;
            }
        }
    }
}
