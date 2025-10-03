using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using cad_vendedorN;

namespace CadastroProdutosMercado
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;database=db_yzidro;uid=root;pwd=";

        private DataTable dtProdutos = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, descricao, nome, cod_barras, valor_unitario, estoque, nome_foto, caminho_foto FROM tb_produtos";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    dtProdutos.Clear();
                    adapter.Fill(dtProdutos);
                    dgvProdutos.DataSource = dtProdutos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProdutos.SelectedRows[0];
                lblDetalhes.Text = $"ID: {row.Cells["id"].Value}\n" +
                                   $"Nome: {row.Cells["nome"].Value}\n" +
                                   $"Descrição: {row.Cells["descricao"].Value}\n" +
                                   $"Código de Barras: {row.Cells["cod_barras"].Value}\n" +
                                   $"Valor Unitário: {row.Cells["valor_unitario"].Value}\n" +
                                   $"Estoque: {row.Cells["estoque"].Value}\n" +
                                   $"Nome Foto: {row.Cells["nome_foto"].Value}\n" +
                                   $"Caminho Foto: {row.Cells["caminho_foto"].Value}";

                string caminhoFoto = row.Cells["caminho_foto"].Value.ToString();
                if (File.Exists(caminhoFoto))
                {
                    pbFoto.Image = System.Drawing.Image.FromFile(caminhoFoto);
                }
                else
                {
                    pbFoto.Image = null;
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastroProduto form = new FormCadastroProduto();
            if (form.ShowDialog() == DialogResult.OK)
                CarregarProdutos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                var row = dgvProdutos.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string nome = row.Cells["nome"].Value.ToString();
                string descricao = row.Cells["descricao"].Value.ToString();
                string codigo = row.Cells["cod_barras"].Value.ToString();
                string valor = row.Cells["valor_unitario"].Value.ToString();
                string estoque = row.Cells["estoque"].Value.ToString();
                string nomeFoto = row.Cells["nome_foto"].Value.ToString();
                string caminhoFoto = row.Cells["caminho_foto"].Value.ToString();

                FormEditarProduto form = new FormEditarProduto(id, nome, descricao, codigo, valor, estoque, nomeFoto, caminhoFoto);
                if (form.ShowDialog() == DialogResult.OK)
                    CarregarProdutos();
            }
            else
            {
                MessageBox.Show("Selecione um produto para editar");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Deseja realmente excluir o produto?", "Excluir", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow row = dgvProdutos.SelectedRows[0];
                        int id = Convert.ToInt32(row.Cells["id"].Value);

                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "DELETE FROM tb_produtos WHERE id=@id";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                        CarregarProdutos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir");
            }
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }

        private void lblDetalhes_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
