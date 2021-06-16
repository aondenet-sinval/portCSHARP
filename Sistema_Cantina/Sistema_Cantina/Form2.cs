using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtLogin.Text;
            senha = txtSenha.Text;

            if (usuario == "Admin" && senha == "Admin")
            {
                Form1 novo = new Form1();
                novo.Show();
                this.Visible = false;
                /*Declaração de variáveis e atribuição
                Condição - Se o usuário e (&&) Senha forem iguais a Admin,
                Será chamado o Form2.
               Ou seja ele terá acesso ao sistema, somente se o usuário e senha estiver correto*/
            }
        }
    }
}
