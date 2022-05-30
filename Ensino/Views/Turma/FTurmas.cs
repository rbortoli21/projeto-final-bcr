using Ensino.Models.Repositories;
using Ensino.Models;
using Ensino.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ensino.Views.Relatorios;

namespace Ensino.Views.Turma
{
    public partial class FTurmas : Form
    {
        public readonly ITurmaRepository turmaRepository;
        private readonly ICursoRepository _cursoRepository;
        private readonly IAlunoRepository _alunoRepository;
        public FTurmas()
        {
            InitializeComponent();
            turmaRepository = new TurmaRepository();
            _cursoRepository = new CursoRepository();
            _alunoRepository = new AlunoRepository();
        }

        public void VerificarSeHaCamposVazios()
        {
            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    var cbBox = control as ComboBox;
                    if (string.IsNullOrEmpty(cbBox.Text))
                        throw new ArgumentNullException();
                }
            }
        }

        private void PegarDadosParaCadastro(Models.Turma turma)
        {
            VerificarSeHaCamposVazios();
            turma.Curso_Id = _cursoRepository.Obter().FirstOrDefault(c => c.Nome == comboBoxCurso.Text).Id;
            turma.NomeCurso = _cursoRepository.Obter().FirstOrDefault(c => c.Nome == comboBoxCurso.Text).Nome;
            turma.TurnoCurso = _cursoRepository.Obter().FirstOrDefault(c => c.Turno == comboBoxTurno.Text).Turno;
        }

        private void ListarQuantidadeAlunos(List<Models.Turma> turmas)
        {
            foreach(var turma in turmas)
                turma.QtdAlunos = _alunoRepository.Obter().Where(a => a.Turma_Id == turma.Id).Count();   
        }

        private void AtualizarGrid()
        {
            dgvTurmas.DataSource = turmaRepository.Obter();
            ListarQuantidadeAlunos(turmaRepository.Obter());
            dgvTurmas.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var turma = new Models.Turma();
            try
            {
                PegarDadosParaCadastro(turma);
                turmaRepository.Cadastrar(turma);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos, verifique-os e tente novamente.");
                return;
            }
            catch (DuplicateWaitObjectException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show($"Turma não pôde ser cadastrada, verifique os campos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Turma cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var id = ObterIdDoDataGridView(dgvTurmas);
            var turma = turmaRepository.ObterPorId(id);
            try
            {
                var res = MessageBox.Show("Tem certeza que deseja deletar esse aluno? Este aluno será excluido de forma permanente.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res != DialogResult.OK)
                    return;
                turmaRepository.Deletar(turma);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show($"A turma de {turma.NomeCurso}, no turno {turma.TurnoCurso} não pôde ser deletada, tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"A turma de {turma.NomeCurso}, no turno {turma.TurnoCurso} foi deletada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
        }

        private void FTurmas_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            comboBoxCurso.DataSource = _cursoRepository.Obter().OrderBy(c => c.Nome).Select(c => c.Nome).Distinct().ToList();
        }

        private void comboBoxCurso_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxTurno.DataSource = _cursoRepository.Obter().Where(c => c.Nome == comboBoxCurso.Text).Select(c => c.Turno).Distinct().ToList();
        }
        private int ObterIdDoDataGridView(DataGridView dgv)
        {
            if (dgv.Rows.Count != 0)
            {
                var cells = dgv.CurrentRow.Cells;
                foreach (DataGridViewCell cell in cells)
                {
                    if (dgv.Columns[cell.ColumnIndex].HeaderText == "Id")
                        return Convert.ToInt32(dgv.CurrentRow.Cells[cell.ColumnIndex].Value);
                }
            }
            return Convert.ToInt32(null);

        }

        private void btnImprimirRelatorio_Click(object sender, EventArgs e)
        {
            List<Models.Turma> turmas = (List<Models.Turma>)dgvTurmas.DataSource;
            using (var form = new FRelatorioTurma(turmas))
                form.ShowDialog();
        }
    }
}
