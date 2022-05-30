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
    public partial class FRelatorioMateria : Form
    {
        List<Models.Materia> dt = new List<Models.Materia>();
        public FRelatorioMateria(List<Models.Materia> dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void FRelatorioMateria_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("RelatorioMaterias", dt));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Data", $"{DateTime.Now.Date.Day}/{DateTime.Now.Date.Month}/{DateTime.Now.Date.Year}"));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Hora", $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{ DateTime.Now.Second}"));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
