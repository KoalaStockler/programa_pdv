namespace CadastroProdutosMercado
{
    partial class FormEditarProduto
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.TextBox txtNomeFoto;
        private System.Windows.Forms.Button btnSelecionarFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtNomeFoto = new System.Windows.Forms.TextBox();
            this.btnSelecionarFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            this.lblNome.Location = new System.Drawing.Point(12, 15);
            this.lblNome.Size = new System.Drawing.Size(80, 20);
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            this.txtNome.Location = new System.Drawing.Point(100, 12);
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            // 
            // lblDescricao
            this.lblDescricao.Location = new System.Drawing.Point(12, 45);
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            this.txtDescricao.Location = new System.Drawing.Point(100, 42);
            this.txtDescricao.Size = new System.Drawing.Size(200, 20);
            // 
            // lblCodigo
            this.lblCodigo.Location = new System.Drawing.Point(12, 75);
            this.lblCodigo.Size = new System.Drawing.Size(80, 20);
            this.lblCodigo.Text = "Código Barras:";
            // 
            // txtCodigo
            this.txtCodigo.Location = new System.Drawing.Point(100, 72);
            this.txtCodigo.Size = new System.Drawing.Size(200, 20);
            // 
            // lblValor
            this.lblValor.Location = new System.Drawing.Point(12, 105);
            this.lblValor.Size = new System.Drawing.Size(80, 20);
            this.lblValor.Text = "Valor Unitário:";
            // 
            // txtValor
            this.txtValor.Location = new System.Drawing.Point(100, 102);
            this.txtValor.Size = new System.Drawing.Size(200, 20);
            // 
            // lblEstoque
            this.lblEstoque.Location = new System.Drawing.Point(12, 135);
            this.lblEstoque.Size = new System.Drawing.Size(80, 20);
            this.lblEstoque.Text = "Estoque:";
            // 
            // txtEstoque
            this.txtEstoque.Location = new System.Drawing.Point(100, 132);
            this.txtEstoque.Size = new System.Drawing.Size(200, 20);
            // 
            // lblFoto
            this.lblFoto.Location = new System.Drawing.Point(12, 165);
            this.lblFoto.Size = new System.Drawing.Size(80, 20);
            this.lblFoto.Text = "Nome Foto:";
            // 
            // txtNomeFoto
            this.txtNomeFoto.Location = new System.Drawing.Point(100, 162);
            this.txtNomeFoto.Size = new System.Drawing.Size(200, 20);
            // 
            // btnSelecionarFoto
            this.btnSelecionarFoto.Location = new System.Drawing.Point(310, 160);
            this.btnSelecionarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarFoto.Text = "Selecionar";
            this.btnSelecionarFoto.Click += new System.EventHandler(this.btnSelecionarFoto_Click);
            // 
            // pbFoto
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(400, 12);
            this.pbFoto.Size = new System.Drawing.Size(200, 200);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // btnSalvar
            this.btnSalvar.Location = new System.Drawing.Point(100, 200);
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(220, 200);
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormEditarProduto
            this.ClientSize = new System.Drawing.Size(620, 250);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnSelecionarFoto);
            this.Controls.Add(this.txtNomeFoto);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FormEditarProduto";
            this.Text = "Editar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
