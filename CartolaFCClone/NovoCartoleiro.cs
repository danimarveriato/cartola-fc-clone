using CartolaFCClone.Dados;
using CartolaFCClone.Dados.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartolaFCClone
{
    public partial class NovoCartoleiro : Form
    {
        private DBContext _dbContext = new DBContext();

        public NovoCartoleiro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string erros = "";

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                erros += "Informe seu nome\n";
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                erros += "Informe seu e-mail\n";
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                erros += "Informe sua senha\n";
            }

            if (erros != "")
            {
                MessageBox.Show(erros, "ERROS!");
            }
            else
            {
                //Converte a data em Datetime
                string dataNascimentoString = txtDataNascimento.Text;
                DateTime dataNascimento;
                DateTime.TryParseExact(dataNascimentoString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento);

                var senha = CreateMD5(txtSenha.Text);
                bool admin = false;
                if (checkAdmin.Checked)
                {
                    admin = true;
                }

                var retornoCadastro = cadastrarNovoUsuario(txtNome.Text, txtApelido.Text, txtEmail.Text, senha, dataNascimento, txtCidade.Text, Convert.ToInt32(comboTimes.SelectedValue), admin);

                if (retornoCadastro > 0)
                {
                    MessageBox.Show("Dados cadastrados com sucesso!", "SUCESSO!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao gravar os dados!", "ERRO!");
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


        private int cadastrarNovoUsuario(string pNome, string pApelido, string pEmail, string pSenha, DateTime pDataNascimento, string pCidade, int? pTimeCoracao, bool pAdmin)
        {
            var novoUsuario = new Usuario
            {
                nome = pNome,
                apelido = pApelido,
                email = pEmail,
                senha = pSenha,
                data_nascimento = pDataNascimento,
                cidade = pCidade,
                cod_time_coracao = pTimeCoracao,
                ind_administrador = pAdmin
            };

            // Adicionando o novo usuário ao contexto (em memória)
            _dbContext.Usuarios.Add(novoUsuario);

            // Salvando as alterações no banco de dados
            return _dbContext.SaveChanges();
        }

        private void NovoCartoleiro_Shown(object sender, EventArgs e)
        {
            comboTimes.Items.Add("Selecione um time");
            var times = _dbContext.Times.ToList();

            // Preenche o combobox
            comboTimes.DataSource = times;
            comboTimes.DisplayMember = "nome";
            comboTimes.ValueMember = "codigo";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal();
            principal.ShowDialog();
        }
    }
}
