namespace Ensino.Views
{
    partial class FDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDashboard));
            this.graficoPizza = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxQtdProfessor = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQtdTurma = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxQtdMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQtdCurso = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.textBoxQtdAlunos = new System.Windows.Forms.TextBox();
            this.alunosQtd = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.turmaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.turmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.graficoPizza)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoPizza
            // 
            this.graficoPizza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graficoPizza.BackColor = System.Drawing.Color.Lavender;
            this.graficoPizza.BackSecondaryColor = System.Drawing.Color.PowderBlue;
            this.graficoPizza.BorderlineColor = System.Drawing.Color.Black;
            this.graficoPizza.BorderSkin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.graficoPizza.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            this.graficoPizza.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            this.graficoPizza.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 60;
            chartArea1.Area3DStyle.Rotation = 60;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Lavender;
            chartArea1.Name = "ChartArea1";
            this.graficoPizza.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Lavender;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend1.IsTextAutoFit = false;
            legend1.MaximumAutoSize = 60F;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.graficoPizza.Legends.Add(legend1);
            this.graficoPizza.Location = new System.Drawing.Point(12, 260);
            this.graficoPizza.Name = "graficoPizza";
            this.graficoPizza.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.graficoPizza.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(111)))), ((int)(((byte)(255))))),
        System.Drawing.Color.DarkSlateBlue,
        System.Drawing.Color.MidnightBlue,
        System.Drawing.Color.MediumBlue,
        System.Drawing.Color.CornflowerBlue,
        System.Drawing.Color.RoyalBlue,
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.SkyBlue,
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.LightSteelBlue,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.Teal,
        System.Drawing.Color.Aquamarine,
        System.Drawing.Color.MediumTurquoise,
        System.Drawing.Color.MediumSeaGreen,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.ForestGreen,
        System.Drawing.Color.DarkSlateGray,
        System.Drawing.Color.DarkKhaki,
        System.Drawing.Color.Indigo,
        System.Drawing.Color.PaleVioletRed,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Pink,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.Brown,
        System.Drawing.Color.Snow};
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficoPizza.Series.Add(series1);
            this.graficoPizza.Size = new System.Drawing.Size(846, 398);
            this.graficoPizza.TabIndex = 65;
            this.graficoPizza.Text = "Gráfico";
            this.graficoPizza.Click += new System.EventHandler(this.graficoPizza_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxQtdProfessor);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(372, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 164);
            this.panel2.TabIndex = 88;
            // 
            // textBoxQtdProfessor
            // 
            this.textBoxQtdProfessor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxQtdProfessor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQtdProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxQtdProfessor.Location = new System.Drawing.Point(-1, 133);
            this.textBoxQtdProfessor.Name = "textBoxQtdProfessor";
            this.textBoxQtdProfessor.ReadOnly = true;
            this.textBoxQtdProfessor.Size = new System.Drawing.Size(122, 19);
            this.textBoxQtdProfessor.TabIndex = 63;
            this.textBoxQtdProfessor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Professores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Turmas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxQtdTurma
            // 
            this.textBoxQtdTurma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxQtdTurma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQtdTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxQtdTurma.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxQtdTurma.Location = new System.Drawing.Point(-1, 133);
            this.textBoxQtdTurma.Name = "textBoxQtdTurma";
            this.textBoxQtdTurma.ReadOnly = true;
            this.textBoxQtdTurma.Size = new System.Drawing.Size(122, 19);
            this.textBoxQtdTurma.TabIndex = 66;
            this.textBoxQtdTurma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(19, 40);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(82, 86);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 60;
            this.pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBoxQtdMateria);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Location = new System.Drawing.Point(520, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 164);
            this.panel4.TabIndex = 86;
            // 
            // textBoxQtdMateria
            // 
            this.textBoxQtdMateria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxQtdMateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQtdMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxQtdMateria.Location = new System.Drawing.Point(-1, 133);
            this.textBoxQtdMateria.Name = "textBoxQtdMateria";
            this.textBoxQtdMateria.ReadOnly = true;
            this.textBoxQtdMateria.Size = new System.Drawing.Size(122, 19);
            this.textBoxQtdMateria.TabIndex = 65;
            this.textBoxQtdMateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Matérias";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(19, 40);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(82, 86);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 58;
            this.pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxQtdCurso);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(224, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 164);
            this.panel1.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 64;
            this.label1.Text = "Cursos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxQtdCurso
            // 
            this.textBoxQtdCurso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxQtdCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQtdCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxQtdCurso.Location = new System.Drawing.Point(-1, 133);
            this.textBoxQtdCurso.Name = "textBoxQtdCurso";
            this.textBoxQtdCurso.ReadOnly = true;
            this.textBoxQtdCurso.Size = new System.Drawing.Size(122, 19);
            this.textBoxQtdCurso.TabIndex = 63;
            this.textBoxQtdCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // panel21
            // 
            this.panel21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel21.Controls.Add(this.textBoxQtdAlunos);
            this.panel21.Controls.Add(this.alunosQtd);
            this.panel21.Controls.Add(this.pictureBox4);
            this.panel21.Location = new System.Drawing.Point(76, 12);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(122, 164);
            this.panel21.TabIndex = 84;
            // 
            // textBoxQtdAlunos
            // 
            this.textBoxQtdAlunos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxQtdAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQtdAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxQtdAlunos.Location = new System.Drawing.Point(-1, 133);
            this.textBoxQtdAlunos.Name = "textBoxQtdAlunos";
            this.textBoxQtdAlunos.ReadOnly = true;
            this.textBoxQtdAlunos.Size = new System.Drawing.Size(122, 19);
            this.textBoxQtdAlunos.TabIndex = 62;
            this.textBoxQtdAlunos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alunosQtd
            // 
            this.alunosQtd.AutoSize = true;
            this.alunosQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alunosQtd.ForeColor = System.Drawing.Color.Black;
            this.alunosQtd.Location = new System.Drawing.Point(30, 4);
            this.alunosQtd.Name = "alunosQtd";
            this.alunosQtd.Size = new System.Drawing.Size(59, 18);
            this.alunosQtd.TabIndex = 1;
            this.alunosQtd.Text = "Alunos";
            this.alunosQtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(19, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(82, 86);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxQtdTurma);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Location = new System.Drawing.Point(671, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 164);
            this.panel3.TabIndex = 87;
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(110, 87);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(615, 296);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 89;
            this.logo.TabStop = false;
            // 
            // turmaBindingSource1
            // 
            this.turmaBindingSource1.DataSource = typeof(Ensino.Models.Turma);
            // 
            // turmaBindingSource
            // 
            this.turmaBindingSource.DataSource = typeof(Ensino.Models.Turma);
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(Ensino.Models.Aluno);
            // 
            // FDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 670);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.graficoPizza);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDashboard";
            this.Text = "InicioResumen";
            this.Load += new System.EventHandler(this.FDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graficoPizza)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource turmaBindingSource1;
        private System.Windows.Forms.BindingSource turmaBindingSource;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoPizza;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxQtdProfessor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQtdTurma;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxQtdMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQtdCurso;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox textBoxQtdAlunos;
        private System.Windows.Forms.Label alunosQtd;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.PictureBox logo;
    }
}