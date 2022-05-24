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

namespace Ensino.Views
{
    public partial class FormRelatorio : Form
    {
        List<object> dt = new List<object>();
        public FormRelatorio(List<object> dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            dt.Add(new Curso());
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource($"{typeof(object)}Relatorio", dt));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
