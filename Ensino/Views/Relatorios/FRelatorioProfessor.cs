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
    public partial class FRelatorioProfessor : Form
    {
        List<Models.Professor> dt = new List<Models.Professor>();
        public FRelatorioProfessor(List<Models.Professor> dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void FRelatorioProfessor_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("RelatorioProfessor", dt));
            this.reportViewer1.RefreshReport();
        }
    }
}
