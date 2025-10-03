using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using YZIDRO;

namespace YZIDRO
{
    public partial class Compras : Form
    {
        decimal valor = 0;
        DataTable tabela = new DataTable();

        public Compras()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            carregarVendedores();
        }

        private void carregarVendedores()
        {
            using (MySqlConnection conn = new MySqlConnection(conexaoBanco()))
            {
                try
                {
                    conn.Open();
                    string select = "SELECT id, nome FROM tb_vendedor";
                    MySqlCommand cmd = new MySqlCommand(select, conn);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();

                    adaptador.Fill(tabela);

                    if (tabela.Rows.Count > 0)
                    {
                        comboBoxVendedores.DataSource = tabela;
                        comboBoxVendedores.DisplayMember = "nome";
                        comboBoxVendedores.ValueMember = "id";
                    }
                    else
                    {
                        MessageBox.Show("Nenhum vendedor encontrado no banco.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar vendedores:\n" + ex.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Realmente deseja finalizar a compra?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                conexaoBanco();
                using (MySqlConnection conn = new MySqlConnection(conexaoBanco()))
                {
                    try
                    {
                        conn.Open();
                        string totalCompra = atualizarValor();

                        string select = "Select descricao, nome, cod_barras ,valor_unitario FROM tb_vendas";
                        MySqlCommand cmd = new MySqlCommand(select, conn);

                        MySqlDataReader reader = cmd.ExecuteReader();
                        //MySqlDataAdapter adaptador = new MySqlDataAdapter();
                        //DataTable tabela = new DataTable();

                        //adaptador.Fill(tabela);



                        // Configuração do PDF
                        Document pdfDocumento = new Document(PageSize.A4);
                        SaveFileDialog salvar = new SaveFileDialog(); // Permite que o usuário escolha aonde vai ser salvo o arquivo
                        salvar.Filter = "PDF Files|*.pdf"; // Define o tipo de arquivo
                        salvar.Title = "Salvar Nota Fiscal"; // Titulo da janela de salvar arquivo
                        salvar.FileName = "NotaFiscal.pdf"; // nome padrão do arquivo

                        if (salvar.ShowDialog() != DialogResult.OK)
                            return;

                        PdfWriter.GetInstance(pdfDocumento, new FileStream(salvar.FileName, FileMode.Create));

                        pdfDocumento.Open();

                        // Adicionando Título no PDF
                        pdfDocumento.Add(new Paragraph("Nota Fiscal"));

                        // Adicionando espaço entre as linhas
                        pdfDocumento.Add(new Paragraph(" "));

                        // Adicionando tabela,com 4 colunas
                        PdfPTable tabela = new PdfPTable(4);

                        tabela.AddCell("descricao"); // Nomeando as Colunas
                        tabela.AddCell("nome");
                        tabela.AddCell("cod_barras");
                        tabela.AddCell("valor_unitario");


                        while (reader.Read()) // Laço de repetição para enquanto o reader estiver recebendo(lendo) valor, ele continua executando
                        {
                            tabela.AddCell(reader["descricao"].ToString()); // Vai atribuindo os valores que o reader le no banco
                            tabela.AddCell(reader["nome"].ToString());
                            tabela.AddCell(reader["cod_barras"].ToString());
                            tabela.AddCell(reader["valor_unitario"].ToString());
                        }



                        pdfDocumento.Add(tabela);

                        // Adicionando espaço entre as linhas
                        pdfDocumento.Add(new Paragraph(" "));

                        // Adicionando o paragrafo do valor total
                        pdfDocumento.Add(new Paragraph(" Total Da Compra: " + totalCompra.ToString()));

                        pdfDocumento.Close();

                        MessageBox.Show("Nota fiscal gerada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        apagarDados();
                        GridProdutos.DataSource = null;
                        labelValorUnitario.Text = "";
                        labelEstoque.Text = "";
                        textBoxCodBarras.Text = "";
                        labelValorFinal.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gerar PDF:\n" + ex.Message);
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void picturePreview_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private string conexaoBanco()
        {
            string conexaoBanco = "server=localhost;user id=root;database=db_yzidro;password=";
            return conexaoBanco;
        }

        public void carregarProduto()
        {



        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelProduto_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            conexaoBanco();

            using (MySqlConnection conn = new MySqlConnection(conexaoBanco()))
            {
                string codigoBarras = textBoxCodBarras.Text;
                try
                {
                    conn.Open();

                    string descricao = "";
                    string nome = "";
                    string codBarras = "";
                    decimal valorUnitario = 0;
                    int estoque = 0;
                    string img = "";
                    string nome_img = "";


                    string selectDescricao = "Select descricao, nome, cod_barras, valor_unitario, estoque, nome_foto, caminho_foto from tb_produtos WHERE cod_barras = @codigoBarras AND estoque > 0";
                    MySqlCommand comando1 = new MySqlCommand(selectDescricao, conn);
                    comando1.Parameters.AddWithValue("@codigoBarras", codigoBarras);

                    MySqlDataReader reader = comando1.ExecuteReader();

                    if (reader.Read())
                    {

                        descricao = reader["descricao"].ToString();
                        nome = reader["nome"].ToString();
                        codBarras = reader["cod_barras"].ToString();
                        valorUnitario = Convert.ToDecimal(reader["valor_unitario"]);
                        estoque = Convert.ToInt32(reader["estoque"]);
                        nome_img = reader["nome_foto"].ToString();
                        img = reader["caminho_foto"].ToString();

                        reader.Close();

                        string insert = "INSERT INTO tb_vendas(descricao, nome, cod_barras, valor_unitario, estoque) VALUES (@descricao, @nome, @cod_barras, @valorUnitario, @estoque)";
                        MySqlCommand cmd = new MySqlCommand(insert, conn);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cod_barras", codBarras);
                        cmd.Parameters.AddWithValue("@valorUnitario", valorUnitario);
                        cmd.Parameters.AddWithValue("@Estoque", estoque);
                        cmd.ExecuteNonQuery();

                        subtrairEstoque();

                    }
                    else
                    {
                        MessageBox.Show("Produto Não Encontrado");
                    }

                    if (estoque <= 0)
                    {
                        MessageBox.Show("Produto Não Contém estoque");
                        textBoxCodBarras.Text = "";
                        textBoxCodBarras.Focus();
                    }
                    else
                    {
                        if (File.Exists(img))
                        {
                            picturePreview.Image = System.Drawing.Image.FromFile(img);
                            picturePreview.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else
                        {
                            picturePreview.Image = null;
                        }

                      
                    }



                    //ExibirImagemProduto(img, nome_img);




                    string selectGeral = "select * from tb_vendas";
                    MySqlCommand comandoGeral = new MySqlCommand(selectGeral, conn);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoGeral);
                    DataTable tabelaGeral = new DataTable();
                    adaptador.Fill(tabelaGeral);
                    GridProdutos.DataSource = tabelaGeral;

                    atualizarValor();

                    labelValorFinal.Text = valor.ToString("C");

                    atualizarValorUnitario();
                    atualizarEstoque();
                    atualizarNome();
                    
                    conn.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro de Banco na Inserção de dados");
                }
            }
        }

        private void GridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void labelValorFinal_Click(object sender, EventArgs e)
        {

        }

        private void buttonFecharCompra_Click(object sender, EventArgs e)
        {
            apagarDados();
            this.Close();
        }

        private string atualizarValor()
        {
            conexaoBanco();
            using (MySqlConnection conn = new MySqlConnection(conexaoBanco()))
            {


                try
                {
                    conn.Open();

                    string scriptSelect = "Select SUM(valor_unitario) AS total from tb_vendas";
                    MySqlCommand cmd = new MySqlCommand(scriptSelect, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        valor = Convert.ToDecimal(reader["total"]);

                        labelValorFinal.Text = valor.ToString("C");
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao calcular total");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro de Banco");
                }
            }

            return valor.ToString("C");
        }

        public string atualizarValorUnitario()
        {
            decimal unitario = 0;



            conexaoBanco();

            using (MySqlConnection conn = new MySqlConnection(conexaoBanco()))
            {
                try
                {
                    string codigoBarras = textBoxCodBarras.Text;

                    conn.Open();

                    string select = "Select valor_unitario FROM tb_produtos WHERE cod_barras = @cod_barras";
                    MySqlCommand cmd = new MySqlCommand(select, conn);
                    cmd.Parameters.AddWithValue("@cod_barras", codigoBarras);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        unitario = Convert.ToDecimal(reader["valor_unitario"]);
                    }

                    reader.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Produto Não Encontrado");
                }
            }

            return labelValorUnitario.Text = unitario.ToString("C");
        }

        private string atualizarNome()
        {
            string nome = "";
            conexaoBanco();
            using (MySqlConnection conn = new MySqlConnection(conexaoBanco()))
            {
                string codigoBarras = textBoxCodBarras.Text;

                try
                {
                    conn.Open();
                    string select = "SELECT nome FROM tb_produtos WHERE cod_barras = @cod_barras";
                    MySqlCommand cmd = new MySqlCommand(select, conn);
                    cmd.Parameters.AddWithValue("@cod_barras", codigoBarras);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        nome = reader["nome"].ToString();
                    }

                }
                catch (Exception)
                {

                }
            }

            return labelProduto.Text = Convert.ToString(nome);
        }

        private string atualizarEstoque()
        {
            int estoque = 0;
            conexaoBanco();
            using (MySqlConnection conn = new MySqlConnection(conexaoBanco()))
            {
                string codigoBarras = textBoxCodBarras.Text;

                try
                {
                    conn.Open();
                    string select = "SELECT estoque FROM tb_produtos WHERE cod_barras = @cod_barras";
                    MySqlCommand cmd = new MySqlCommand(select, conn);
                    cmd.Parameters.AddWithValue("@cod_barras", codigoBarras);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        estoque = Convert.ToInt32(reader["estoque"]);
                    }

                }
                catch (Exception)
                {

                }
            }

            return labelEstoque.Text = Convert.ToString(estoque);
        }

        private void apagarDados()
        {
            conexaoBanco();

            using (MySqlConnection conn = new MySqlConnection(conexaoBanco()))
            {
                try
                {
                    conn.Open();

                    string scriptDelete = "DELETE FROM tb_vendas";
                    MySqlCommand cmd = new MySqlCommand(scriptDelete, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro do Banco de vendas");
                }


            }
        }

        private void subtrairEstoque()
        {
            using (MySqlConnection conn = new MySqlConnection(conexaoBanco()))
            {
                string codigoBarras = textBoxCodBarras.Text;

                try
                {
                    conn.Open();
                    string update = "UPDATE tb_produtos SET estoque = estoque - 1 WHERE cod_barras = @cod_barras AND estoque > 0";
                    MySqlCommand cmd = new MySqlCommand(update, conn);
                    cmd.Parameters.AddWithValue("@cod_barras", codigoBarras);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao atualizar estoque");
                }
            }
        }


        private void labelValorUnitario_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
