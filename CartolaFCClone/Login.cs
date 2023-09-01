using CartolaFCClone.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartolaFCClone
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Informe o usuário e a senha para prosseguir!", "ERRO");
            }
            else
            {
                string senhaMd5 = CreateMD5(txtSenha.Text);
                bool indAdministrador = false;

                if(rbtnIndAdministrador.Checked)
                {
                    indAdministrador = true;
                }

                var dbContext = new DBContext();
                var usuario = dbContext.Usuarios.FirstOrDefault(x => x.email == txtUsuario.Text && x.senha == senhaMd5 && x.ind_administrador == indAdministrador);

                if (usuario != null)
                {
                    string nomeUsuario = usuario.nome;

                    if (indAdministrador)
                    {
                        this.Hide();
                        AdminCartoleiro admin = new AdminCartoleiro(nomeUsuario);
                        admin.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        AreaCartoleiro cartoleiro = new AreaCartoleiro(nomeUsuario);
                        cartoleiro.ShowDialog();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Login incorreto ou usuário inexistente.", "ERRO");
                }
            }
        }



        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }
    }
}
