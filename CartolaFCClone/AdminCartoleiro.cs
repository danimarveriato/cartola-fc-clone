using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartolaFCClone
{
    public partial class AdminCartoleiro : Form
    {
        private string _nomeAdmin;
        public AdminCartoleiro(string nomeAdmin)
        {
            InitializeComponent();
            _nomeAdmin = nomeAdmin;
            labelNomeAdmin.Text = _nomeAdmin;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void btnGerTimes_Click(object sender, EventArgs e)
        {
            this.Hide();
            GerenciamentoTimes GerTimes = new GerenciamentoTimes();
            GerTimes.ShowDialog();
        }
    }
}
