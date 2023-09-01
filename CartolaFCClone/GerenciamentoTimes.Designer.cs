namespace CartolaFCClone
{
    partial class GerenciamentoTimes
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            dgvListaTimes = new DataGridView();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            timeBindingSource = new BindingSource(components);
            timeBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvListaTimes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 32);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 5;
            label2.Text = "Lista de Times";
            // 
            // dgvListaTimes
            // 
            dgvListaTimes.AutoGenerateColumns = false;
            dgvListaTimes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaTimes.Columns.AddRange(new DataGridViewColumn[] { codigoDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn, cidadeDataGridViewTextBoxColumn, statusDataGridViewCheckBoxColumn });
            dgvListaTimes.DataSource = timeBindingSource;
            dgvListaTimes.Location = new Point(164, 69);
            dgvListaTimes.Name = "dgvListaTimes";
            dgvListaTimes.ReadOnly = true;
            dgvListaTimes.RowHeadersWidth = 51;
            dgvListaTimes.RowTemplate.Height = 29;
            dgvListaTimes.Size = new Size(809, 339);
            dgvListaTimes.TabIndex = 6;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            codigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            cidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            cidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            statusDataGridViewCheckBoxColumn.ReadOnly = true;
            statusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // timeBindingSource
            // 
            timeBindingSource.DataSource = typeof(Dados.Entidades.Time);
            // 
            // timeBindingSource1
            // 
            timeBindingSource1.DataSource = typeof(Dados.Entidades.Time);
            // 
            // GerenciamentoTimes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 589);
            Controls.Add(dgvListaTimes);
            Controls.Add(label2);
            Name = "GerenciamentoTimes";
            Text = "Gerenciamento de Times";
            Shown += GerenciamentoTimes_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvListaTimes).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private BindingSource timeBindingSource;
        public DataGridView dgvListaTimes;
        private BindingSource timeBindingSource1;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}