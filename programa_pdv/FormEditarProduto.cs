using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastroProdutosMercado
{
    public partial class FormEditarProduto : Form
    {
        private string connectionString = "server=localhost;database=db_yzidro;uid=root;pwd=";
        private int produtoId;

        public FormEditarProduto(int id, string nome, string descricao, string codigo, string valor, string estoque, string nomeFoto, string caminhoFoto)
        {
            InitializeComponent();

            produtoId = id;
            txtNome.Text = nome;
            txtDescricao.Text = descricao;
            txtCodigo.Text = codigo;
            txtValor.Text = valor;
            txtEstoque.Text = estoque;
            txtNomeFoto.Text = nomeFoto;

            if (File.Exists(caminhoFoto))
                pbFoto.Image = System.Drawing.Image.FromFile(caminhoFoto);
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
            try
            {
                string caminhoFoto = txtNomeFoto.Text != "" ? Path.Combine(Application.StartupPath, "Fotos", txtNomeFoto.Text) : "";

                string pastaFotos = Path.Combine(Application.StartupPath, "Fotos");
                if (!Directory.Exists(pastaFotos))
                    Directory.CreateDirectory(pastaFotos);

                if (pbFoto.Image != null && openFileDialog1.FileName != "")
                    File.Copy(openFileDialog1.FileName, caminhoFoto, true);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE tb_produtos SET 
                                    descricao=@descricao,
                                    nome=@nome,
                                    cod_barras=@cod_barras,
                                    valor_unitario=@valor_unitario,
                                    estoque=@estoque,
                                    nome_foto=@nome_foto,
                                    caminho_foto=@caminho_foto
                                    WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cod_barras", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@valor_unitario", txtValor.Text);
                    cmd.Parameters.AddWithValue("@estoque", txtEstoque.Text);
                    cmd.Parameters.AddWithValue("@nome_foto", txtNomeFoto.Text);
                    cmd.Parameters.AddWithValue("@caminho_foto", caminhoFoto);
                    cmd.Parameters.AddWithValue("@id", produtoId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Produto atualizado com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
