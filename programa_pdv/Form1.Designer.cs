namespace YZIDRO
{
    partial class Compras
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelProduto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelEstoque = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelValorUnitario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxCodBarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelValorFinal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFializarCompra = new System.Windows.Forms.Button();
            this.buttonFecharCompra = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.comboBoxVendedores = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1604, 89);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Font = new System.Drawing.Font("Microsoft New Tai Lue", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.labelProduto.Location = new System.Drawing.Point(3, 9);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(0, 38);
            this.labelProduto.TabIndex = 3;
            this.labelProduto.Click += new System.EventHandler(this.labelProduto_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.panel2.Controls.Add(this.labelProduto);
            this.panel2.Location = new System.Drawing.Point(21, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 49);
            this.panel2.TabIndex = 2;
            // 
            // picturePreview
            // 
            this.picturePreview.BackColor = System.Drawing.Color.Transparent;
            this.picturePreview.Location = new System.Drawing.Point(21, 186);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(251, 354);
            this.picturePreview.TabIndex = 3;
            this.picturePreview.TabStop = false;
            this.picturePreview.Click += new System.EventHandler(this.picturePreview_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(97)))));
            this.panel5.Controls.Add(this.labelEstoque);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(323, 468);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 72);
            this.panel5.TabIndex = 6;
            // 
            // labelEstoque
            // 
            this.labelEstoque.AutoSize = true;
            this.labelEstoque.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstoque.Location = new System.Drawing.Point(249, 35);
            this.labelEstoque.Name = "labelEstoque";
            this.labelEstoque.Size = new System.Drawing.Size(0, 22);
            this.labelEstoque.TabIndex = 2;
            this.labelEstoque.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ESTOQUE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(97)))));
            this.panel4.Controls.Add(this.labelValorUnitario);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(323, 354);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 72);
            this.panel4.TabIndex = 7;
            // 
            // labelValorUnitario
            // 
            this.labelValorUnitario.AutoSize = true;
            this.labelValorUnitario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorUnitario.Location = new System.Drawing.Point(176, 38);
            this.labelValorUnitario.Name = "labelValorUnitario";
            this.labelValorUnitario.Size = new System.Drawing.Size(0, 22);
            this.labelValorUnitario.TabIndex = 3;
            this.labelValorUnitario.Click += new System.EventHandler(this.labelValorUnitario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "VALOR UNITÁRIO";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(97)))));
            this.panel6.Controls.Add(this.textBoxCodBarras);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(323, 186);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 72);
            this.panel6.TabIndex = 7;
            // 
            // textBoxCodBarras
            // 
            this.textBoxCodBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            this.textBoxCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodBarras.Location = new System.Drawing.Point(3, 38);
            this.textBoxCodBarras.Name = "textBoxCodBarras";
            this.textBoxCodBarras.Size = new System.Drawing.Size(273, 31);
            this.textBoxCodBarras.TabIndex = 14;
            this.textBoxCodBarras.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CÓDIGO DE BARRAS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(97)))));
            this.panel3.Controls.Add(this.labelValorFinal);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(627, 564);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 72);
            this.panel3.TabIndex = 8;
            // 
            // labelValorFinal
            // 
            this.labelValorFinal.AutoSize = true;
            this.labelValorFinal.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorFinal.Location = new System.Drawing.Point(400, 12);
            this.labelValorFinal.Name = "labelValorFinal";
            this.labelValorFinal.Size = new System.Drawing.Size(0, 44);
            this.labelValorFinal.TabIndex = 1;
            this.labelValorFinal.Click += new System.EventHandler(this.labelValorFinal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL RECEBIDO";
            // 
            // buttonFializarCompra
            // 
            this.buttonFializarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(97)))));
            this.buttonFializarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFializarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFializarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFializarCompra.ForeColor = System.Drawing.Color.White;
            this.buttonFializarCompra.Location = new System.Drawing.Point(627, 652);
            this.buttonFializarCompra.Name = "buttonFializarCompra";
            this.buttonFializarCompra.Size = new System.Drawing.Size(283, 71);
            this.buttonFializarCompra.TabIndex = 11;
            this.buttonFializarCompra.Text = "Finalizar Compra";
            this.buttonFializarCompra.UseVisualStyleBackColor = false;
            this.buttonFializarCompra.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonFecharCompra
            // 
            this.buttonFecharCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(97)))));
            this.buttonFecharCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFecharCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFecharCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecharCompra.ForeColor = System.Drawing.Color.White;
            this.buttonFecharCompra.Location = new System.Drawing.Point(919, 652);
            this.buttonFecharCompra.Name = "buttonFecharCompra";
            this.buttonFecharCompra.Size = new System.Drawing.Size(283, 71);
            this.buttonFecharCompra.TabIndex = 12;
            this.buttonFecharCompra.Text = "FECHAR";
            this.buttonFecharCompra.UseVisualStyleBackColor = false;
            this.buttonFecharCompra.Click += new System.EventHandler(this.buttonFecharCompra_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(627, 186);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(575, 44);
            this.panel8.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "LISTA DE PRODUTOS";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(97)))));
            this.button2.Location = new System.Drawing.Point(469, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 48);
            this.button2.TabIndex = 15;
            this.button2.Text = "LER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // GridProdutos
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GridProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridProdutos.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.GridProdutos.Location = new System.Drawing.Point(627, 230);
            this.GridProdutos.Name = "GridProdutos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridProdutos.Size = new System.Drawing.Size(575, 334);
            this.GridProdutos.TabIndex = 16;
            this.GridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProdutos_CellContentClick);
            // 
            // comboBoxVendedores
            // 
            this.comboBoxVendedores.FormattingEnabled = true;
            this.comboBoxVendedores.Location = new System.Drawing.Point(21, 576);
            this.comboBoxVendedores.Name = "comboBoxVendedores";
            this.comboBoxVendedores.Size = new System.Drawing.Size(197, 21);
            this.comboBoxVendedores.TabIndex = 17;
            this.comboBoxVendedores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1594, 792);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxVendedores);
            this.Controls.Add(this.GridProdutos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.buttonFecharCompra);
            this.Controls.Add(this.buttonFializarCompra);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.picturePreview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonFializarCompra;
        private System.Windows.Forms.Label labelValorFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFecharCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelValorUnitario;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCodBarras;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.Label labelEstoque;
        private System.Windows.Forms.ComboBox comboBoxVendedores;
    }
}

