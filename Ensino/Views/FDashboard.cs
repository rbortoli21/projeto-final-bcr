using Ensino.Models;
using Ensino.Models.Repositories;
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
        private readonly CursoRepository cursoRepository;
        private readonly AlunoRepository alunoRepository;
        private readonly TurmaRepository turmaRepository;
        private readonly MateriaRepository materiaRepository;
        private readonly ProfessorRepository professorRepository;
        public FDashboard()
        {
            InitializeComponent();
            cursoRepository = new CursoRepository();
            alunoRepository = new AlunoRepository();
            turmaRepository = new TurmaRepository();
            materiaRepository = new MateriaRepository();
            professorRepository = new ProfessorRepository();
        }
        private void FDashboard_Load(object sender, EventArgs e)
        {
            var alunos = alunoRepository.Obter().Count();
            textBoxQtdAlunos.Text = alunos.ToString();

            var cursos = cursoRepository.Obter().Count();
            textBoxQtdCurso.Text = cursos.ToString();

            var professores = professorRepository.Obter().Count();
            textBoxQtdProfessor.Text = professores.ToString();

            var materias = materiaRepository.Obter().Count();
            textBoxQtdMateria.Text = materias.ToString();

            var turmas = turmaRepository.Obter().Count();
            textBoxQtdTurma.Text = turmas.ToString();
        }

        private void alunosQtd_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
