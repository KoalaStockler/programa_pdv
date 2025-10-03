using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cad_vendedorN
{
    public partial class cad_vendedor : Form
    {
        public cad_vendedor()
        {
            InitializeComponent();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void placeholder(TextBox campo, string textoPlaceholder)
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


        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxNome.ForeColor = Color.Gray;
            textBoxtelefone.ForeColor = Color.Gray;


            placeholder(textBoxNome, "Digite seu nome");
            placeholder(textBoxtelefone, "Digite seu telefone");
        }

        private void buttonCadVendedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text) || string.IsNullOrWhiteSpace(textBoxtelefone.Text))
            {
                MessageBox.Show("Insira algo nos 2 campos por favor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conexaoBanco = "server=localhost;user id=root;password=;database=db_yzidro";

            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conexao.Open();
                    string sql = "INSERT INTO tb_vendedor (nome, telefone) VALUES (@nome, @telefone)";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", textBoxNome.Text.Trim());
                        comando.Parameters.AddWithValue("@telefone", textBoxtelefone.Text.Trim());
                        comando.ExecuteNonQuery();

                        DialogResult resultado = MessageBox.Show(
                            "Vendedor cadastrado com sucesso! Deseja cadastrar outro vendedor?",
                            "Cadastro",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (resultado == DialogResult.No)
                        {
                            this.Close();
                        }
                        else
                        {
                            textBoxNome.Text = "";
                            textBoxtelefone.Text = "";
                            textBoxNome.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar vendedor: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxtelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
