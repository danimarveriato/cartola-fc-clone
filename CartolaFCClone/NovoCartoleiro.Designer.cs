namespace CartolaFCClone
{
    partial class NovoCartoleiro
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
            label2 = new Label();
            panel1 = new Panel();
            txtDataNascimento = new MaskedTextBox();
            label6 = new Label();
            txtSenha = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtApelido = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            comboTimes = new ComboBox();
            label10 = new Label();
            txtCidade = new TextBox();
            label11 = new Label();
            label12 = new Label();
            btnVoltar = new Button();
            btnCadastrar = new Button();
            checkAdmin = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 25);
            label2.Name = "label2";
            label2.Size = new Size(190, 23);
            label2.TabIndex = 4;
            label2.Text = "Informações Principais";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtDataNascimento);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtApelido);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(273, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 261);
            panel1.TabIndex = 5;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(206, 209);
            txtDataNascimento.Mask = "99/99/9999";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(305, 27);
            txtDataNascimento.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(31, 213);
            label6.Name = "label6";
            label6.Size = new Size(146, 23);
            label6.TabIndex = 12;
            label6.Text = "Data Nascimento:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(206, 164);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(305, 27);
            txtSenha.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(109, 166);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 10;
            label5.Text = "Senha:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(206, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(305, 27);
            txtEmail.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(109, 124);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 8;
            label4.Text = "E-mail:";
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(206, 74);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(305, 27);
            txtApelido.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(109, 76);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 6;
            label3.Text = "Apelido";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(206, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(305, 27);
            txtNome.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 28);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 4;
            label1.Text = "Seu nome:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(checkAdmin);
            panel2.Controls.Add(comboTimes);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtCidade);
            panel2.Controls.Add(label11);
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(273, 367);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 180);
            panel2.TabIndex = 7;
            // 
            // comboTimes
            // 
            comboTimes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTimes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboTimes.FormattingEnabled = true;
            comboTimes.Items.AddRange(new object[] { "Selecione um valor" });
            comboTimes.Location = new Point(207, 72);
            comboTimes.Name = "comboTimes";
            comboTimes.Size = new Size(303, 31);
            comboTimes.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(42, 76);
            label10.Name = "label10";
            label10.Size = new Size(140, 23);
            label10.TabIndex = 6;
            label10.Text = "Time do Coração";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(206, 28);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(305, 27);
            txtCidade.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(84, 28);
            label11.Name = "label11";
            label11.Size = new Size(96, 23);
            label11.TabIndex = 4;
            label11.Text = "Sua Cidade";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(66, 328);
            label12.Name = "label12";
            label12.Size = new Size(166, 23);
            label12.TabIndex = 6;
            label12.Text = "Outras Informações";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(51, 595);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(181, 46);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(470, 585);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(181, 46);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // checkAdmin
            // 
            checkAdmin.AutoSize = true;
            checkAdmin.Location = new Point(207, 129);
            checkAdmin.Name = "checkAdmin";
            checkAdmin.Size = new Size(126, 24);
            checkAdmin.TabIndex = 10;
            checkAdmin.Text = "Administrador";
            checkAdmin.UseVisualStyleBackColor = true;
            // 
            // NovoCartoleiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 653);
            Controls.Add(btnCadastrar);
            Controls.Add(btnVoltar);
            Controls.Add(panel2);
            Controls.Add(label12);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "NovoCartoleiro";
            Text = "Cadastro de Cartoleiro";
            Shown += NovoCartoleiro_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtApelido;
        private Label label3;
        private Label label6;
        private TextBox txtSenha;
        private Label label5;
        private MaskedTextBox txtDataNascimento;
        private Panel panel2;
        private Label label10;
        private TextBox txtCidade;
        private Label label11;
        private Label label12;
        private ComboBox comboTimes;
        private Button btnVoltar;
        private Button btnCadastrar;
        private CheckBox checkAdmin;
    }
}