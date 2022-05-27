
namespace Ensino.Views.Relatorios
{
    partial class FRelatorioCurso
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CursoBindingSource
            // 
            this.CursoBindingSource.DataSource = typeof(Ensino.Models.Curso);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 0;
            reportDataSource1.Name = "CursoRelatorio";
            reportDataSource1.Value = this.CursoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ensino.Relatorios.RelatorioCursos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(675, 588);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // AlunoBindingSource
            // 
            this.AlunoBindingSource.DataSource = typeof(Ensino.Models.Aluno);
            // 
            // FRelatorioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(675, 588);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRelatorioCurso";
            this.Text = "Relatório Curso";
            this.Load += new System.EventHandler(this.FRelatorioCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CursoBindingSource;
        private System.Windows.Forms.BindingSource AlunoBindingSource;
    }
}