namespace SenacPDV.Forms
{
    partial class Register
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
            BTNRegister = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtUsername = new TextBox();
            TxtEmail = new TextBox();
            TxtSenha = new TextBox();
            TxtConfirmarSenha = new TextBox();
            cmbTipo = new ComboBox();
            SuspendLayout();
            // 
            // BTNRegister
            // 
            BTNRegister.Location = new Point(12, 268);
            BTNRegister.Name = "BTNRegister";
            BTNRegister.Size = new Size(75, 23);
            BTNRegister.TabIndex = 0;
            BTNRegister.Text = "Registrar";
            BTNRegister.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(12, 20);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(63, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Username:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(12, 66);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(39, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 4;
            label4.Text = "Confirmar senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 222);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 5;
            label5.Text = "Tipo:";
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(130, 20);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(100, 23);
            TxtUsername.TabIndex = 6;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(130, 66);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(169, 23);
            TxtEmail.TabIndex = 7;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(130, 117);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(100, 23);
            TxtSenha.TabIndex = 8;
            // 
            // TxtConfirmarSenha
            // 
            TxtConfirmarSenha.Location = new Point(130, 168);
            TxtConfirmarSenha.Name = "TxtConfirmarSenha";
            TxtConfirmarSenha.Size = new Size(100, 23);
            TxtConfirmarSenha.TabIndex = 9;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Admin", "User" });
            cmbTipo.Location = new Point(130, 219);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 10;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbTipo);
            Controls.Add(TxtConfirmarSenha);
            Controls.Add(TxtSenha);
            Controls.Add(TxtEmail);
            Controls.Add(TxtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(BTNRegister);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNRegister;
        private Label lbl1;
        private Label lbl2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtUsername;
        private TextBox TxtEmail;
        private TextBox TxtSenha;
        private TextBox TxtConfirmarSenha;
        private ComboBox cmbTipo;
    }
}