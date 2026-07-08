namespace SenacPDV.Forms
{
    partial class FormGerenciarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExcluir = new Button();
            txtNomeProduto = new TextBox();
            txtCodigo = new TextBox();
            txtDescricao = new TextBox();
            txtCategoria = new TextBox();
            txtEstoque = new TextBox();
            txtPreco = new TextBox();
            lblDescricao = new Label();
            lblCategoria = new Label();
            lblEstoque = new Label();
            lblPreco = new Label();
            lblNomeProduto = new Label();
            lblCodigo = new Label();
            btnAtualizarEstoque = new Button();
            btnNovo = new Button();
            btnSalvar = new Button();
            dgvProdutos = new DataGridView();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(272, 286);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(84, 27);
            btnExcluir.TabIndex = 30;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(59, 37);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(293, 23);
            txtNomeProduto.TabIndex = 29;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(60, 8);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(292, 23);
            txtCodigo.TabIndex = 28;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(63, 153);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(386, 127);
            txtDescricao.TabIndex = 27;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(63, 124);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(293, 23);
            txtCategoria.TabIndex = 26;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(60, 95);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(113, 23);
            txtEstoque.TabIndex = 25;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(60, 66);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(113, 23);
            txtPreco.TabIndex = 24;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(6, 156);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 23;
            lblDescricao.Text = "Descrição:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(6, 127);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 22;
            lblCategoria.Text = "Categoria:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new Point(6, 98);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(52, 15);
            lblEstoque.TabIndex = 21;
            lblEstoque.Text = "Estoque:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(5, 69);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 20;
            lblPreco.Text = "Preço:";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(5, 40);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(53, 15);
            lblNomeProduto.TabIndex = 19;
            lblNomeProduto.Text = "Produto:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(5, 11);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 18;
            lblCodigo.Text = "Codigo:";
            // 
            // btnAtualizarEstoque
            // 
            btnAtualizarEstoque.Location = new Point(362, 286);
            btnAtualizarEstoque.Name = "btnAtualizarEstoque";
            btnAtualizarEstoque.Size = new Size(87, 27);
            btnAtualizarEstoque.TabIndex = 17;
            btnAtualizarEstoque.Text = "Atualizar Estoque";
            btnAtualizarEstoque.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(167, 286);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(87, 27);
            btnNovo.TabIndex = 16;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(63, 286);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 27);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeight = 29;
            dgvProdutos.Location = new Point(455, 8);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.Size = new Size(445, 268);
            dgvProdutos.TabIndex = 13;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(839, 282);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 31);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh";
            // 
            // FormGerenciarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 451);
            Controls.Add(btnExcluir);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtCodigo);
            Controls.Add(txtDescricao);
            Controls.Add(txtCategoria);
            Controls.Add(txtEstoque);
            Controls.Add(txtPreco);
            Controls.Add(lblDescricao);
            Controls.Add(lblCategoria);
            Controls.Add(lblEstoque);
            Controls.Add(lblPreco);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblCodigo);
            Controls.Add(btnAtualizarEstoque);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Controls.Add(dgvProdutos);
            Controls.Add(btnRefresh);
            Name = "FormGerenciarProduto";
            Text = "FormGerenciarProduto";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private TextBox txtNomeProduto;
        private TextBox txtCodigo;
        private TextBox txtDescricao;
        private TextBox txtCategoria;
        private TextBox txtEstoque;
        private TextBox txtPreco;
        private Label lblDescricao;
        private Label lblCategoria;
        private Label lblEstoque;
        private Label lblPreco;
        private Label lblNomeProduto;
        private Label lblCodigo;
        private Button btnAtualizarEstoque;
        private Button btnNovo;
        private Button btnSalvar;
        private DataGridView dgvProdutos;
        private Button btnRefresh;
    }
}