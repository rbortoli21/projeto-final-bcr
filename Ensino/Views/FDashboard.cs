using Ensino.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            using (var form = new FCursos())
                form.ListarQuantidadeAlunos(cursoRepository.Obter());

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

            GerarGrafico();


        }

        private void GerarGrafico()
        {
            var cursos = cursoRepository.Obter();
            var listaCursos = new List<string>();
            var listaQtd = new List<int>();

            var repetidos = cursos.GroupBy(g => g.Nome)
            .Select(s => new
            {
                Nome = s.Key,
                Quantidade = s.Sum(c => c.QuantidadeAlunos)
            }).OrderBy(c => c.Nome);
            foreach (var curso in repetidos)
            {
                Console.WriteLine(curso.Nome);
                listaCursos.Add(curso.Nome);
            }
            foreach (var curso in repetidos)
            {
                Console.WriteLine(curso.Quantidade);
                listaQtd.Add(curso.Quantidade);
            }
            graficoPizza.Series[0].ChartType = SeriesChartType.Pie;

            graficoPizza.Series[0].LabelForeColor = Color.Transparent;

            graficoPizza.Legends[0].Title = "Cursos";

            graficoPizza.Series[0].Points.DataBindXY(listaCursos, listaQtd);
        }

        private void alunosQtd_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void graficoPizza_Click(object sender, EventArgs e)
        {

        }
    }
}
