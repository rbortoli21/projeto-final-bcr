
namespace Ensino.Views
{
    partial class FEditarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEditarAluno));
            this.txtBoxCPFAluno = new System.Windows.Forms.Label();
            this.txtBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefoneAluno = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxCursoAluno = new System.Windows.Forms.ComboBox();
            this.txtBoxEnderecoAluno = new System.Windows.Forms.TextBox();
            this.txtBoxResponsavelAluno = new System.Windows.Forms.TextBox();
            this.txtBoxMatriculaAluno = new System.Windows.Forms.TextBox();
            this.txtBoxEmailAluno = new System.Windows.Forms.TextBox();
            this.txtBoxNomeAluno = new System.Windows.Forms.TextBox();
            this.btnSalvarAluno = new System.Windows.Forms.Button();
            this.btnCancelarAluno = new System.Windows.Forms.Button();
            this.comboBoxTurnoCursoAluno = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxCPFAluno
            // 
            this.txtBoxCPFAluno.AutoSize = true;
            this.txtBoxCPFAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCPFAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxCPFAluno.Location = new System.Drawing.Point(14, 136);
            this.txtBoxCPFAluno.Name = "txtBoxCPFAluno";
            this.txtBoxCPFAluno.Size = new System.Drawing.Size(40, 20);
            this.txtBoxCPFAluno.TabIndex = 74;
            this.txtBoxCPFAluno.Text = "CPF";
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBoxCPF.Location = new System.Drawing.Point(18, 160);
            this.txtBoxCPF.Mask = "000,000,000-00";
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.Size = new System.Drawing.Size(195, 24);
            this.txtBoxCPF.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 31);
            this.label7.TabIndex = 73;
            this.label7.Text = "Edição de Aluno";
            // 
            // maskedTextBoxTelefoneAluno
            // 
            this.maskedTextBoxTelefoneAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.maskedTextBoxTelefoneAluno.Location = new System.Drawing.Point(462, 219);
            this.maskedTextBoxTelefoneAluno.Mask = "+55 (00) 00000-0000";
            this.maskedTextBoxTelefoneAluno.Name = "maskedTextBoxTelefoneAluno";
            this.maskedTextBoxTelefoneAluno.Size = new System.Drawing.Size(195, 24);
            this.maskedTextBoxTelefoneAluno.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(458, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Curso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(458, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(228, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Responsável";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(228, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(228, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Matrícula";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(14, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 20);
            this.label15.TabIndex = 66;
            this.label15.Text = "Nome Completo";
            // 
            // comboBoxCursoAluno
            // 
            this.comboBoxCursoAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCursoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxCursoAluno.FormattingEnabled = true;
            this.comboBoxCursoAluno.Location = new System.Drawing.Point(462, 99);
            this.comboBoxCursoAluno.Name = "comboBoxCursoAluno";
            this.comboBoxCursoAluno.Size = new System.Drawing.Size(263, 24);
            this.comboBoxCursoAluno.TabIndex = 60;
            this.comboBoxCursoAluno.SelectedIndexChanged += new System.EventHandler(this.comboBoxCursoAluno_SelectedIndexChanged);
            // 
            // txtBoxEnderecoAluno
            // 
            this.txtBoxEnderecoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEnderecoAluno.Location = new System.Drawing.Point(18, 219);
            this.txtBoxEnderecoAluno.Name = "txtBoxEnderecoAluno";
            this.txtBoxEnderecoAluno.Size = new System.Drawing.Size(195, 24);
            this.txtBoxEnderecoAluno.TabIndex = 64;
            // 
            // txtBoxResponsavelAluno
            // 
            this.txtBoxResponsavelAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxResponsavelAluno.Location = new System.Drawing.Point(232, 160);
            this.txtBoxResponsavelAluno.Name = "txtBoxResponsavelAluno";
            this.txtBoxResponsavelAluno.Size = new System.Drawing.Size(195, 24);
            this.txtBoxResponsavelAluno.TabIndex = 62;
            // 
            // txtBoxMatriculaAluno
            // 
            this.txtBoxMatriculaAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMatriculaAluno.Location = new System.Drawing.Point(232, 99);
            this.txtBoxMatriculaAluno.MaxLength = 15;
            this.txtBoxMatriculaAluno.Name = "txtBoxMatriculaAluno";
            this.txtBoxMatriculaAluno.Size = new System.Drawing.Size(195, 24);
            this.txtBoxMatriculaAluno.TabIndex = 59;
            // 
            // txtBoxEmailAluno
            // 
            this.txtBoxEmailAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmailAluno.Location = new System.Drawing.Point(232, 219);
            this.txtBoxEmailAluno.Name = "txtBoxEmailAluno";
            this.txtBoxEmailAluno.Size = new System.Drawing.Size(195, 24);
            this.txtBoxEmailAluno.TabIndex = 65;
            // 
            // txtBoxNomeAluno
            // 
            this.txtBoxNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeAluno.Location = new System.Drawing.Point(18, 99);
            this.txtBoxNomeAluno.Name = "txtBoxNomeAluno";
            this.txtBoxNomeAluno.Size = new System.Drawing.Size(195, 24);
            this.txtBoxNomeAluno.TabIndex = 58;
            // 
            // btnSalvarAluno
            // 
            this.btnSalvarAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnSalvarAluno.FlatAppearance.BorderSize = 0;
            this.btnSalvarAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalvarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAluno.ForeColor = System.Drawing.Color.White;
            this.btnSalvarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarAluno.Image")));
            this.btnSalvarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAluno.Location = new System.Drawing.Point(565, 303);
            this.btnSalvarAluno.Name = "btnSalvarAluno";
            this.btnSalvarAluno.Size = new System.Drawing.Size(180, 35);
            this.btnSalvarAluno.TabIndex = 75;
            this.btnSalvarAluno.Text = "SALVAR";
            this.btnSalvarAluno.UseVisualStyleBackColor = false;
            this.btnSalvarAluno.Click += new System.EventHandler(this.btnSalvarAluno_Click);
            // 
            // btnCancelarAluno
            // 
            this.btnCancelarAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnCancelarAluno.FlatAppearance.BorderSize = 0;
            this.btnCancelarAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAluno.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarAluno.Location = new System.Drawing.Point(12, 303);
            this.btnCancelarAluno.Name = "btnCancelarAluno";
            this.btnCancelarAluno.Size = new System.Drawing.Size(115, 35);
            this.btnCancelarAluno.TabIndex = 76;
            this.btnCancelarAluno.Text = "CANCELAR";
            this.btnCancelarAluno.UseVisualStyleBackColor = false;
            this.btnCancelarAluno.Click += new System.EventHandler(this.btnCancelarAluno_Click);
            // 
            // comboBoxTurnoCursoAluno
            // 
            this.comboBoxTurnoCursoAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurnoCursoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxTurnoCursoAluno.FormattingEnabled = true;
            this.comboBoxTurnoCursoAluno.Location = new System.Drawing.Point(462, 160);
            this.comboBoxTurnoCursoAluno.Name = "comboBoxTurnoCursoAluno";
            this.comboBoxTurnoCursoAluno.Size = new System.Drawing.Size(263, 24);
            this.comboBoxTurnoCursoAluno.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(458, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "Turno";
            // 
            // FEditarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 350);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxTurnoCursoAluno);
            this.Controls.Add(this.btnCancelarAluno);
            this.Controls.Add(this.btnSalvarAluno);
            this.Controls.Add(this.txtBoxCPFAluno);
            this.Controls.Add(this.txtBoxCPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBoxTelefoneAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxCursoAluno);
            this.Controls.Add(this.txtBoxEnderecoAluno);
            this.Controls.Add(this.txtBoxResponsavelAluno);
            this.Controls.Add(this.txtBoxMatriculaAluno);
            this.Controls.Add(this.txtBoxEmailAluno);
            this.Controls.Add(this.txtBoxNomeAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FEditarAluno";
            this.Text = "FEditarAluno";
            this.Load += new System.EventHandler(this.FEditarAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtBoxCPFAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSalvarAluno;
        private System.Windows.Forms.Button btnCancelarAluno;
        public System.Windows.Forms.MaskedTextBox txtBoxCPF;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxTelefoneAluno;
        public System.Windows.Forms.ComboBox comboBoxCursoAluno;
        public System.Windows.Forms.TextBox txtBoxEnderecoAluno;
        public System.Windows.Forms.TextBox txtBoxResponsavelAluno;
        public System.Windows.Forms.TextBox txtBoxMatriculaAluno;
        public System.Windows.Forms.TextBox txtBoxEmailAluno;
        public System.Windows.Forms.TextBox txtBoxNomeAluno;
        public System.Windows.Forms.ComboBox comboBoxTurnoCursoAluno;
        private System.Windows.Forms.Label label8;
    }
}