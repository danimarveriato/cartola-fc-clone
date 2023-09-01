using CartolaFCClone.Dados;
using Microsoft.EntityFrameworkCore;
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
    public partial class AreaCartoleiro : Form
    {
        private string _nomeCartoleiro;
        
        public AreaCartoleiro(string nomeCartoleiro)
        {
            InitializeComponent();
            _nomeCartoleiro = nomeCartoleiro;
            labelNomeCartoleiro.Text = _nomeCartoleiro;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AreaCartoleiro_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
