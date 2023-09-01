using CartolaFCClone.Dados;
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
    public partial class GerenciamentoTimes : Form
    {
        private DBContext _dbContext = new DBContext();
        public GerenciamentoTimes()
        {
            InitializeComponent();
        }

        private void GerenciamentoTimes_Shown(object sender, EventArgs e)
        {
            var times = _dbContext.Times.ToList();

            // Vinculando os dados ao DataGridView
            dgvListaTimes.DataSource = times;
        }
    }
}
