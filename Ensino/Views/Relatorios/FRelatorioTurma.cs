﻿using System;
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
    public partial class FRelatorioTurma : Form
    {
        List<Models.Turma> dt = new List<Models.Turma>();
        public FRelatorioTurma(List<Models.Turma> dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void FRelatorioTurma_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("RelatorioTurma", dt));
            this.reportViewer1.RefreshReport();

        }
    }
}
