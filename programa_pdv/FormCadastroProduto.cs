using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace CadastroProdutosMercado
{
    public partial class FormCadastroProduto : Form
    {
        private string connectionString = "server=localhost;database=db_yzidro;uid=root;pwd=";

        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnSelecionarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNomeFoto.Text = Path.GetFileName(openFileDialog1.FileName);
                pbFoto.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha o nome do produto");
                return;
            }

            try
            {
                string caminhoFoto = txtNomeFoto.Text != "" ? Path.Combine(Application.StartupPath, "Fotos", txtNomeFoto.Text) : "";

                // Cria pasta Fotos se não existir
                string pastaFotos = Path.Combine(Application.StartupPath, "Fotos");
                if (!Directory.Exists(pastaFotos))
                    Directory.CreateDirectory(pastaFotos);

                // Copia a foto selecionada para a pasta do projeto
                if (pbFoto.Image != null && File.Exists(openFileDialog1.FileName))
                    File.Copy(openFileDialog1.FileName, caminhoFoto, true);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO tb_produtos 
                                    (descricao, nome, cod_barras, valor_unitario, estoque, nome_foto, caminho_foto) 
                                    VALUES (@descricao, @nome, @cod_barras, @valor_unitario, @estoque, @nome_foto, @caminho_foto)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cod_barras", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@valor_unitario", txtValor.Text);
                    cmd.Parameters.AddWithValue("@estoque", txtEstoque.Text);
                    cmd.Parameters.AddWithValue("@nome_foto", txtNomeFoto.Text);
                    cmd.Parameters.AddWithValue("@caminho_foto", caminhoFoto);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Produto cadastrado com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
