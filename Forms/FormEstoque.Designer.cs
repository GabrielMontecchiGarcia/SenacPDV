namespace SenacPDV.Forms
{
    partial class FormEstoque
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
            DgvProdutos = new DataGridView();
            BtnAdicionar = new Button();
            BtnRemover = new Button();
            BtnAtualizar = new Button();
            TxtCodigo = new TextBox();
            TxtNome = new TextBox();
            TxtPreco = new TextBox();
            lblCodigo = new Label();
            lblNome = new Label();
            lblPreco = new Label();
            label1 = new Label();
            TxtPesquisar = new TextBox();
            BtnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // DgvProdutos
            // 
            DgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProdutos.Location = new Point(7, 115);
            DgvProdutos.Name = "DgvProdutos";
            DgvProdutos.Size = new Size(373, 202);
            DgvProdutos.TabIndex = 0;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.Location = new Point(7, 86);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(75, 23);
            BtnAdicionar.TabIndex = 1;
            BtnAdicionar.Text = "Adicionar";
            BtnAdicionar.UseVisualStyleBackColor = true;
            BtnAdicionar.Click += btnAdicionar_Click;
            // 
            // BtnRemover
            // 
            BtnRemover.Location = new Point(88, 85);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(75, 23);
            BtnRemover.TabIndex = 2;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = true;
            // 
            // BtnAtualizar
            // 
            BtnAtualizar.Location = new Point(169, 85);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(75, 23);
            BtnAtualizar.TabIndex = 3;
            BtnAtualizar.Text = "Atualizar";
            BtnAtualizar.UseVisualStyleBackColor = true;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(52, 6);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(142, 23);
            TxtCodigo.TabIndex = 5;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(52, 31);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(142, 23);
            TxtNome.TabIndex = 6;
            // 
            // TxtPreco
            // 
            TxtPreco.Location = new Point(52, 56);
            TxtPreco.Name = "TxtPreco";
            TxtPreco.Size = new Size(142, 23);
            TxtPreco.TabIndex = 7;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(6, 9);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 9;
            lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 34);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(9, 59);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 11;
            lblPreco.Text = "Preço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 323);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 12;
            label1.Text = "Pesquisar:";
            // 
            // TxtPesquisar
            // 
            TxtPesquisar.Location = new Point(72, 320);
            TxtPesquisar.Name = "TxtPesquisar";
            TxtPesquisar.Size = new Size(242, 23);
            TxtPesquisar.TabIndex = 13;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(320, 323);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(60, 23);
            BtnPesquisar.TabIndex = 14;
            BtnPesquisar.Text = "Buscar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // FormEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 481);
            Controls.Add(BtnPesquisar);
            Controls.Add(TxtPesquisar);
            Controls.Add(label1);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Controls.Add(lblCodigo);
            Controls.Add(TxtPreco);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Controls.Add(BtnAtualizar);
            Controls.Add(BtnRemover);
            Controls.Add(BtnAdicionar);
            Controls.Add(DgvProdutos);
            Name = "FormEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEstoque";
            ((System.ComponentModel.ISupportInitialize)DgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvProdutos;
        private Button BtnAdicionar;
        private Button BtnRemover;
        private Button BtnAtualizar;
        private TextBox TxtCodigo;
        private TextBox TxtNome;
        private TextBox TxtPreco;
        private Label lblCodigo;
        private Label lblNome;
        private Label lblPreco;
        private Label label1;
        private TextBox TxtPesquisar;
        private Button BtnPesquisar;
    }
}