namespace CartolaFCClone
{
    partial class AreaCartoleiro
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
            labelNomeCartoleiro = new Label();
            label1 = new Label();
            btnLogout = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // labelNomeCartoleiro
            // 
            labelNomeCartoleiro.AutoSize = true;
            labelNomeCartoleiro.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomeCartoleiro.Location = new Point(509, 37);
            labelNomeCartoleiro.Name = "labelNomeCartoleiro";
            labelNomeCartoleiro.Size = new Size(0, 32);
            labelNomeCartoleiro.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(329, 37);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 8;
            label1.Text = "Bem vindo(a) ";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(870, 282);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(181, 46);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // button1
            // 
            button1.Location = new Point(598, 282);
            button1.Name = "button1";
            button1.Size = new Size(181, 46);
            button1.TabIndex = 14;
            button1.Text = "Tabela de Jogos";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(313, 282);
            button2.Name = "button2";
            button2.Size = new Size(181, 46);
            button2.TabIndex = 13;
            button2.Text = "Visualizar Escalação";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(36, 282);
            button4.Name = "button4";
            button4.Size = new Size(181, 46);
            button4.TabIndex = 12;
            button4.Text = "Escalar Time";
            button4.UseVisualStyleBackColor = true;
            // 
            // AreaCartoleiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 611);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(btnLogout);
            Controls.Add(labelNomeCartoleiro);
            Controls.Add(label1);
            Name = "AreaCartoleiro";
            Text = "Área Administrativa - Cartoleiro";
            Shown += AreaCartoleiro_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomeCartoleiro;
        private Label label1;
        private Button btnLogout;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}