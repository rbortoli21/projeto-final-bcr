namespace Ensino.Views
{
    partial class FormCurso
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
            this.textBoxNomeCurso = new System.Windows.Forms.TextBox();
            this.comboBoxCursoTurno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericCargaHoraria = new System.Windows.Forms.NumericUpDown();
            this.btnCursoSalvar = new System.Windows.Forms.Button();
            this.btnCursoCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCargaHoraria)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNomeCurso
            // 
            this.textBoxNomeCurso.Location = new System.Drawing.Point(12, 40);
            this.textBoxNomeCurso.Name = "textBoxNomeCurso";
            this.textBoxNomeCurso.Size = new System.Drawing.Size(266, 20);
            this.textBoxNomeCurso.TabIndex = 0;
            // 
            // comboBoxCursoTurno
            // 
            this.comboBoxCursoTurno.FormattingEnabled = true;
            this.comboBoxCursoTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.comboBoxCursoTurno.Location = new System.Drawing.Point(12, 93);
            this.comboBoxCursoTurno.Name = "comboBoxCursoTurno";
            this.comboBoxCursoTurno.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCursoTurno.TabIndex = 1;
            this.comboBoxCursoTurno.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carga horária";
            // 
            // numericCargaHoraria
            // 
            this.numericCargaHoraria.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericCargaHoraria.Location = new System.Drawing.Point(13, 147);
            this.numericCargaHoraria.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.numericCargaHoraria.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericCargaHoraria.Name = "numericCargaHoraria";
            this.numericCargaHoraria.Size = new System.Drawing.Size(120, 20);
            this.numericCargaHoraria.TabIndex = 5;
            this.numericCargaHoraria.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnCursoSalvar
            // 
            this.btnCursoSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCursoSalvar.Location = new System.Drawing.Point(407, 344);
            this.btnCursoSalvar.Name = "btnCursoSalvar";
            this.btnCursoSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnCursoSalvar.TabIndex = 6;
            this.btnCursoSalvar.Text = "Salvar";
            this.btnCursoSalvar.UseVisualStyleBackColor = true;
            this.btnCursoSalvar.Click += new System.EventHandler(this.btnCursoSalvar_Click);
            // 
            // btnCursoCancelar
            // 
            this.btnCursoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCursoCancelar.Location = new System.Drawing.Point(323, 344);
            this.btnCursoCancelar.Name = "btnCursoCancelar";
            this.btnCursoCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCursoCancelar.TabIndex = 7;
            this.btnCursoCancelar.Text = "Cancelar";
            this.btnCursoCancelar.UseVisualStyleBackColor = true;
            // 
            // FormCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(494, 379);
            this.Controls.Add(this.btnCursoCancelar);
            this.Controls.Add(this.btnCursoSalvar);
            this.Controls.Add(this.numericCargaHoraria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCursoTurno);
            this.Controls.Add(this.textBoxNomeCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCurso";
            this.Text = "FormCurso";
            this.Load += new System.EventHandler(this.FormCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCargaHoraria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeCurso;
        private System.Windows.Forms.ComboBox comboBoxCursoTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericCargaHoraria;
        private System.Windows.Forms.Button btnCursoSalvar;
        private System.Windows.Forms.Button btnCursoCancelar;
    }
}