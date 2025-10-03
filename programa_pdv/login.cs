using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroProdutosMercado;
using YZIDRO;

namespace cad_vendedorN
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void placeholder(System.Windows.Forms.TextBox campo, string textoPlaceholder)
        {
            campo.Text = textoPlaceholder;
            campo.ForeColor = Color.Gray;

            campo.Enter += (s, ev) =>
            {
                if (campo.Text == textoPlaceholder)
                {
                    campo.Text = "";
                    campo.ForeColor = Color.Black;
                }
            };

            campo.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(campo.Text))
                {
                    campo.Text = textoPlaceholder;
                    campo.ForeColor = Color.Gray;
                }
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

            textBoxUser.ForeColor = Color.Gray;
            textBoxSenha.ForeColor = Color.Gray;

            placeholder(textBoxUser, "Digite seu Nome de Usuario");
            placeholder(textBoxSenha, "Digite sua Senha");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "adm" && textBoxSenha.Text == "321")
            {
                Compras form1 = new Compras();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Incorreto");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCad_Click(object sender, EventArgs e)
        {
            cad_vendedor cadastro = new cad_vendedor();
            cadastro.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
