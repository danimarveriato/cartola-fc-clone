namespace CartolaFCClone
{
    partial class AdminCartoleiro
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
            button1 = new Button();
            btnGerTimes = new Button();
            btnLogout = new Button();
            label1 = new Label();
            labelNomeAdmin = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(207, 276);
            button1.Name = "button1";
            button1.Size = new Size(181, 46);
            button1.TabIndex = 2;
            button1.Text = "Cadastro Jogadores";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnGerTimes
            // 
            btnGerTimes.Location = new Point(481, 276);
            btnGerTimes.Name = "btnGerTimes";
            btnGerTimes.Size = new Size(181, 46);
            btnGerTimes.TabIndex = 4;
            btnGerTimes.Text = "Gerenciamento Times";
            btnGerTimes.UseVisualStyleBackColor = true;
            btnGerTimes.Click += btnGerTimes_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(764, 276);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(181, 46);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(343, 56);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 6;
            label1.Text = "Bem vindo(a) ";
            // 
            // labelNomeAdmin
            // 
            labelNomeAdmin.AutoSize = true;
            labelNomeAdmin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomeAdmin.Location = new Point(523, 56);
            labelNomeAdmin.Name = "labelNomeAdmin";
            labelNomeAdmin.Size = new Size(162, 32);
            labelNomeAdmin.TabIndex = 7;
            labelNomeAdmin.Text = "Bem vindo(a) ";
            // 
            // AdminCartoleiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 662);
            Controls.Add(labelNomeAdmin);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnGerTimes);
            Controls.Add(button1);
            Name = "AdminCartoleiro";
            Text = "Área Administrativa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnGerTimes;
        private Button btnLogout;
        private Label label1;
        private Label labelNomeAdmin;
    }
}