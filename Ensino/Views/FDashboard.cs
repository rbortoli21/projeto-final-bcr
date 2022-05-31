using Ensino.Views.Materia;
using Ensino.Views.Professor;
using Ensino.Views.Turma;
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
                textBoxQtdAlunos.Text = alunos.ToString();
            }
            using (var form = new FCursos())
            {
                var cursos = form.cursoRepository.Obter().Count();
                textBoxQtdCurso.Text = cursos.ToString();
            }
            using (var form = new FProfessor())
            {
                var professores = form.professorRepository.Obter().Count();
                textBoxQtdProfessor.Text = professores.ToString();
            }
            using (var form = new FMateria())
            {
                var materias = form.materiaRepository.Obter().Count();
                textBoxQtdMateria.Text = materias.ToString();
            }
            using (var form = new FTurmas())
            {
                var turmas = form.turmaRepository.Obter().Count();
                textBoxQtdTurma.Text = turmas.ToString();
            }
            
        }

        private void alunosQtd_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
