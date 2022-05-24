using Ensino.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ensino.Views.Relatorios
{
    public partial class FRelatorioAluno : Form
    {
        List<Aluno> dt = new List<Aluno>();
        public FRelatorioAluno(List<Aluno> dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void FRelatorioAluno_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("AlunoRelatorio", dt));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
