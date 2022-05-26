namespace Ensino.Views
{
    partial class FCursos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCursos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalvarCurso = new System.Windows.Forms.Button();
            this.txtBoxNomeCurso = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxTurnoCurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownCargaHoraria = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvListarCursos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeAlunosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaHorariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeletarCurso = new System.Windows.Forms.Button();
            this.btnCancelarCurso = new System.Windows.Forms.Button();
            this.btnEditarCurso = new System.Windows.Forms.Button();
            this.btnImprimirRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargaHoraria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarCurso
            // 
            this.btnSalvarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnSalvarCurso.FlatAppearance.BorderSize = 0;
            this.btnSalvarCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalvarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCurso.ForeColor = System.Drawing.Color.White;
            this.btnSalvarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCurso.Image")));
            this.btnSalvarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCurso.Location = new System.Drawing.Point(679, 516);
            this.btnSalvarCurso.Name = "btnSalvarCurso";
            this.btnSalvarCurso.Size = new System.Drawing.Size(180, 35);
            this.btnSalvarCurso.TabIndex = 3;
            this.btnSalvarCurso.Text = "SALVAR";
            this.btnSalvarCurso.UseVisualStyleBackColor = false;
            this.btnSalvarCurso.Click += new System.EventHandler(this.btnNovoCurso_Click);
            // 
            // txtBoxNomeCurso
            // 
            this.txtBoxNomeCurso.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeCurso.Location = new System.Drawing.Point(72, 100);
            this.txtBoxNomeCurso.Name = "txtBoxNomeCurso";
            this.txtBoxNomeCurso.Size = new System.Drawing.Size(320, 24);
            this.txtBoxNomeCurso.TabIndex = 5;
            this.txtBoxNomeCurso.TextChanged += new System.EventHandler(this.txtBoxNomeCurso_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(68, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 20);
            this.label15.TabIndex = 39;
            this.label15.Text = "Nome do Curso";
            // 
            // comboBoxTurnoCurso
            // 
            this.comboBoxTurnoCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurnoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxTurnoCurso.FormattingEnabled = true;
            this.comboBoxTurnoCurso.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno",
            "Integral"});
            this.comboBoxTurnoCurso.Location = new System.Drawing.Point(426, 100);
            this.comboBoxTurnoCurso.Name = "comboBoxTurnoCurso";
            this.comboBoxTurnoCurso.Size = new System.Drawing.Size(157, 24);
            this.comboBoxTurnoCurso.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(422, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Turno:";
            // 
            // numericUpDownCargaHoraria
            // 
            this.numericUpDownCargaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numericUpDownCargaHoraria.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCargaHoraria.Location = new System.Drawing.Point(72, 158);
            this.numericUpDownCargaHoraria.Maximum = new decimal(new int[] {
            67108864,
            -1022856342,
            48789097,
            0});
            this.numericUpDownCargaHoraria.Name = "numericUpDownCargaHoraria";
            this.numericUpDownCargaHoraria.Size = new System.Drawing.Size(157, 24);
            this.numericUpDownCargaHoraria.TabIndex = 42;
            this.numericUpDownCargaHoraria.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(68, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Carga horária:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(66, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 31);
            this.label7.TabIndex = 47;
            this.label7.Text = "Cadastro de Curso";
            // 
            // dgvListarCursos
            // 
            this.dgvListarCursos.AllowUserToAddRows = false;
            this.dgvListarCursos.AllowUserToDeleteRows = false;
            this.dgvListarCursos.AutoGenerateColumns = false;
            this.dgvListarCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListarCursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListarCursos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListarCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListarCursos.ColumnHeadersHeight = 30;
            this.dgvListarCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListarCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.quantidadeAlunosDataGridViewTextBoxColumn,
            this.cargaHorariaDataGridViewTextBoxColumn});
            this.dgvListarCursos.DataSource = this.cursoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarCursos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListarCursos.EnableHeadersVisualStyles = false;
            this.dgvListarCursos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvListarCursos.Location = new System.Drawing.Point(72, 211);
            this.dgvListarCursos.MultiSelect = false;
            this.dgvListarCursos.Name = "dgvListarCursos";
            this.dgvListarCursos.ReadOnly = true;
            this.dgvListarCursos.RowHeadersVisible = false;
            this.dgvListarCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarCursos.Size = new System.Drawing.Size(511, 286);
            this.dgvListarCursos.TabIndex = 48;
            this.dgvListarCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarCursos_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 67;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnoDataGridViewTextBoxColumn.Width = 65;
            // 
            // quantidadeAlunosDataGridViewTextBoxColumn
            // 
            this.quantidadeAlunosDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeAlunos";
            this.quantidadeAlunosDataGridViewTextBoxColumn.HeaderText = "QuantidadeAlunos";
            this.quantidadeAlunosDataGridViewTextBoxColumn.Name = "quantidadeAlunosDataGridViewTextBoxColumn";
            this.quantidadeAlunosDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeAlunosDataGridViewTextBoxColumn.Width = 141;
            // 
            // cargaHorariaDataGridViewTextBoxColumn
            // 
            this.cargaHorariaDataGridViewTextBoxColumn.DataPropertyName = "CargaHoraria";
            this.cargaHorariaDataGridViewTextBoxColumn.HeaderText = "CargaHoraria";
            this.cargaHorariaDataGridViewTextBoxColumn.Name = "cargaHorariaDataGridViewTextBoxColumn";
            this.cargaHorariaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargaHorariaDataGridViewTextBoxColumn.Width = 112;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(Ensino.Models.Curso);
            // 
            // btnDeletarCurso
            // 
            this.btnDeletarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnDeletarCurso.FlatAppearance.BorderSize = 0;
            this.btnDeletarCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDeletarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarCurso.ForeColor = System.Drawing.Color.White;
            this.btnDeletarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletarCurso.Location = new System.Drawing.Point(195, 516);
            this.btnDeletarCurso.Name = "btnDeletarCurso";
            this.btnDeletarCurso.Size = new System.Drawing.Size(115, 35);
            this.btnDeletarCurso.TabIndex = 50;
            this.btnDeletarCurso.Text = "DELETAR";
            this.btnDeletarCurso.UseVisualStyleBackColor = false;
            this.btnDeletarCurso.Click += new System.EventHandler(this.btnDeletarCurso_Click);
            // 
            // btnCancelarCurso
            // 
            this.btnCancelarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnCancelarCurso.FlatAppearance.BorderSize = 0;
            this.btnCancelarCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCurso.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCurso.Location = new System.Drawing.Point(72, 516);
            this.btnCancelarCurso.Name = "btnCancelarCurso";
            this.btnCancelarCurso.Size = new System.Drawing.Size(115, 35);
            this.btnCancelarCurso.TabIndex = 51;
            this.btnCancelarCurso.Text = "CANCELAR";
            this.btnCancelarCurso.UseVisualStyleBackColor = false;
            this.btnCancelarCurso.Click += new System.EventHandler(this.btnCancelarCurso_Click);
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnEditarCurso.FlatAppearance.BorderSize = 0;
            this.btnEditarCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCurso.ForeColor = System.Drawing.Color.White;
            this.btnEditarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCurso.Location = new System.Drawing.Point(316, 516);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(115, 35);
            this.btnEditarCurso.TabIndex = 52;
            this.btnEditarCurso.Text = "EDITAR";
            this.btnEditarCurso.UseVisualStyleBackColor = false;
            this.btnEditarCurso.Click += new System.EventHandler(this.btnEditarCurso_Click);
            // 
            // btnImprimirRelatorio
            // 
            this.btnImprimirRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnImprimirRelatorio.FlatAppearance.BorderSize = 0;
            this.btnImprimirRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnImprimirRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnImprimirRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirRelatorio.Location = new System.Drawing.Point(437, 516);
            this.btnImprimirRelatorio.Name = "btnImprimirRelatorio";
            this.btnImprimirRelatorio.Size = new System.Drawing.Size(115, 35);
            this.btnImprimirRelatorio.TabIndex = 63;
            this.btnImprimirRelatorio.Text = "RELATÓRIO";
            this.btnImprimirRelatorio.UseVisualStyleBackColor = false;
            this.btnImprimirRelatorio.Click += new System.EventHandler(this.btnImprimirRelatorio_Click);
            // 
            // FCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(871, 563);
            this.Controls.Add(this.btnImprimirRelatorio);
            this.Controls.Add(this.btnEditarCurso);
            this.Controls.Add(this.btnCancelarCurso);
            this.Controls.Add(this.btnDeletarCurso);
            this.Controls.Add(this.dgvListarCursos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownCargaHoraria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTurnoCurso);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBoxNomeCurso);
            this.Controls.Add(this.btnSalvarCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCursos";
            this.Text = "FCurso";
            this.Load += new System.EventHandler(this.FCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargaHoraria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarCurso;
        private System.Windows.Forms.TextBox txtBoxNomeCurso;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxTurnoCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownCargaHoraria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.Button btnDeletarCurso;
        private System.Windows.Forms.Button btnCancelarCurso;
        private System.Windows.Forms.Button btnEditarCurso;
        public System.Windows.Forms.DataGridView dgvListarCursos;
        private System.Windows.Forms.Button btnImprimirRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeAlunosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaHorariaDataGridViewTextBoxColumn;
    }
}