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
    public partial class FDashboard : Form
    {
        public FDashboard()
        {
            InitializeComponent();
        }
        private void FDashboard_Load(object sender, EventArgs e)
        {
            using (var form = new FAlunos())
            {
                var alunos = form.alunoRepository.Obter().Count();
                alunosQtd.Text = alunos.ToString();
            }
            using (var form = new FCursos())
            {
                var cursos = form.cursoRepository.Obter().Count();
                cursosQtd.Text = cursos.ToString();
            }
        }

    }
}
