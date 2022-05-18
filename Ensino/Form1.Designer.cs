namespace Ensino
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeAlunosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaHorariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovoCurso = new System.Windows.Forms.Button();
            this.btnEditarCurso = new System.Windows.Forms.Button();
            this.btnDeletarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AutoGenerateColumns = false;
            this.dgvCursos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.quantidadeAlunosDataGridViewTextBoxColumn,
            this.cargaHorariaDataGridViewTextBoxColumn});
            this.dgvCursos.DataSource = this.cursoBindingSource;
            this.dgvCursos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCursos.Location = new System.Drawing.Point(12, 235);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(776, 174);
            this.dgvCursos.TabIndex = 0;
            this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome do Curso";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 180;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.turnoDataGridViewTextBoxColumn.Width = 60;
            // 
            // quantidadeAlunosDataGridViewTextBoxColumn
            // 
            this.quantidadeAlunosDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeAlunos";
            this.quantidadeAlunosDataGridViewTextBoxColumn.HeaderText = "Quantidade de Alunos";
            this.quantidadeAlunosDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.quantidadeAlunosDataGridViewTextBoxColumn.Name = "quantidadeAlunosDataGridViewTextBoxColumn";
            this.quantidadeAlunosDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeAlunosDataGridViewTextBoxColumn.Width = 150;
            // 
            // cargaHorariaDataGridViewTextBoxColumn
            // 
            this.cargaHorariaDataGridViewTextBoxColumn.DataPropertyName = "CargaHoraria";
            this.cargaHorariaDataGridViewTextBoxColumn.HeaderText = "Carga horária";
            this.cargaHorariaDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.cargaHorariaDataGridViewTextBoxColumn.Name = "cargaHorariaDataGridViewTextBoxColumn";
            this.cargaHorariaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargaHorariaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(Ensino.Models.Curso);
            // 
            // btnNovoCurso
            // 
            this.btnNovoCurso.Location = new System.Drawing.Point(713, 415);
            this.btnNovoCurso.Name = "btnNovoCurso";
            this.btnNovoCurso.Size = new System.Drawing.Size(75, 23);
            this.btnNovoCurso.TabIndex = 1;
            this.btnNovoCurso.Text = "Novo";
            this.btnNovoCurso.UseVisualStyleBackColor = true;
            this.btnNovoCurso.Click += new System.EventHandler(this.btnNovoCurso_Click);
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.Location = new System.Drawing.Point(632, 415);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCurso.TabIndex = 1;
            this.btnEditarCurso.Text = "Alterar";
            this.btnEditarCurso.UseVisualStyleBackColor = true;
            this.btnEditarCurso.Click += new System.EventHandler(this.btnEditarCurso_Click);
            // 
            // btnDeletarCurso
            // 
            this.btnDeletarCurso.Location = new System.Drawing.Point(551, 415);
            this.btnDeletarCurso.Name = "btnDeletarCurso";
            this.btnDeletarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarCurso.TabIndex = 2;
            this.btnDeletarCurso.Text = "Deletar";
            this.btnDeletarCurso.UseVisualStyleBackColor = true;
            this.btnDeletarCurso.Click += new System.EventHandler(this.btnDeletarCurso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletarCurso);
            this.Controls.Add(this.btnEditarCurso);
            this.Controls.Add(this.btnNovoCurso);
            this.Controls.Add(this.dgvCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeAlunosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaHorariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNovoCurso;
        private System.Windows.Forms.Button btnEditarCurso;
        private System.Windows.Forms.Button btnDeletarCurso;
    }
}

