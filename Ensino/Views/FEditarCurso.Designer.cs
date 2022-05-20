
namespace Ensino.Views
{
    partial class FEditarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEditarCurso));
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCargaHoraria = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTurnoCurso = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxNomeCurso = new System.Windows.Forms.TextBox();
            this.btnEditarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargaHoraria)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(36, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 31);
            this.label7.TabIndex = 54;
            this.label7.Text = "Edição de Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(38, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Carga horária:";
            // 
            // numericUpDownCargaHoraria
            // 
            this.numericUpDownCargaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numericUpDownCargaHoraria.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCargaHoraria.Location = new System.Drawing.Point(42, 162);
            this.numericUpDownCargaHoraria.Maximum = new decimal(new int[] {
            67108864,
            -1022856342,
            48789097,
            0});
            this.numericUpDownCargaHoraria.Name = "numericUpDownCargaHoraria";
            this.numericUpDownCargaHoraria.Size = new System.Drawing.Size(157, 24);
            this.numericUpDownCargaHoraria.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(391, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Turno:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.comboBoxTurnoCurso.Location = new System.Drawing.Point(395, 97);
            this.comboBoxTurnoCurso.Name = "comboBoxTurnoCurso";
            this.comboBoxTurnoCurso.Size = new System.Drawing.Size(157, 24);
            this.comboBoxTurnoCurso.TabIndex = 50;
            this.comboBoxTurnoCurso.SelectedIndexChanged += new System.EventHandler(this.comboBoxTurnoCurso_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(38, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 20);
            this.label15.TabIndex = 49;
            this.label15.Text = "Nome do Curso";
            // 
            // txtBoxNomeCurso
            // 
            this.txtBoxNomeCurso.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeCurso.Location = new System.Drawing.Point(42, 97);
            this.txtBoxNomeCurso.Name = "txtBoxNomeCurso";
            this.txtBoxNomeCurso.Size = new System.Drawing.Size(320, 24);
            this.txtBoxNomeCurso.TabIndex = 48;
            this.txtBoxNomeCurso.TextChanged += new System.EventHandler(this.txtBoxNomeCurso_TextChanged);
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEditarCurso.FlatAppearance.BorderSize = 0;
            this.btnEditarCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCurso.ForeColor = System.Drawing.Color.White;
            this.btnEditarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCurso.Image")));
            this.btnEditarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCurso.Location = new System.Drawing.Point(487, 251);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(180, 35);
            this.btnEditarCurso.TabIndex = 55;
            this.btnEditarCurso.Text = "SALVAR";
            this.btnEditarCurso.UseVisualStyleBackColor = false;
            this.btnEditarCurso.Click += new System.EventHandler(this.btnEditarCurso_Click);
            // 
            // FEditarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(685, 298);
            this.Controls.Add(this.btnEditarCurso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownCargaHoraria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTurnoCurso);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBoxNomeCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FEditarCurso";
            this.Text = "FEditarCurso";
            this.Load += new System.EventHandler(this.FEditarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargaHoraria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnEditarCurso;
        public System.Windows.Forms.NumericUpDown numericUpDownCargaHoraria;
        public System.Windows.Forms.ComboBox comboBoxTurnoCurso;
        public System.Windows.Forms.TextBox txtBoxNomeCurso;
    }
}