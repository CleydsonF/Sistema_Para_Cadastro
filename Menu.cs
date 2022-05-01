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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;
            resposta = MessageBox.Show("Deseja salvar?","Salvar",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Dados cadastrado com sucesso!");
            }
            else
            {
               
            }
        }
    }
}
