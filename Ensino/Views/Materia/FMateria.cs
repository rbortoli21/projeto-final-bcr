using Ensino.Models.Repositories;
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

namespace Ensino.Views.Materia
{
    public partial class FMateria : Form
    {
        private readonly IMateriaRepository _materiaRepository;
        public readonly ICursoRepository cursoRepository;
        public readonly IProfessorRepository professorRepository;
        public FMateria()
        {
            InitializeComponent();
            _materiaRepository = new MateriaRepository();
            cursoRepository = new CursoRepository();
            professorRepository = new ProfessorRepository();
        }

        public void ListarCursosComboBox(ComboBox comboBox)
        {
            var cursosPorNome = cursoRepository.Obter().OrderBy(c => c.Nome).Select(c => c.Nome).Distinct().ToList();
            comboBox.DataSource = cursosPorNome;
        }

        public void ListarTurnosComboBox(ComboBox comboBox, ComboBox selecionado)
        {
            var cursoSelecionado = selecionado.Text;
            var turnosPorCurso = cursoRepository.Obter().Where(c => c.Nome == cursoSelecionado).Select(c => c.Turno).Distinct().ToList();
            comboBox.DataSource = turnosPorCurso;
        }

        public void ListarProfessoresComboBox(ComboBox comboBox)
        {

        }

        private void AtualizarGrid()
        {
            dgvMaterias.DataSource = _materiaRepository.Obter();
            dgvMaterias.Refresh();
            if (ObterIdDoDataGridView(dgvMaterias) != 0)
            {
                btnEditar.Enabled = true;
                btnDeletar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
            }
        }

        private void PegarDadosParaCadastro(Models.Materia materia)
        {
            materia.Nome = txtBoxNome.Text;
            materia.NomeProfessor = txtBoxNome.Text;
            materia.NomeCurso = cursoRepository.Obter().Where(c => c.Nome == comboBoxCurso.Text).FirstOrDefault().Nome; 
            materia.NomeTurno = cursoRepository.Obter().Where(c => c.Turno == comboBoxTurno.Text).FirstOrDefault().Turno;
            //materia.Professor_Id = professorRepository.Obter().Where(p => p.N);
            //materia.Curso_Id = txtBoxNome.Text;

        }
        public void VerificarSeHaCamposVazios()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    var txtBox = control as TextBox;
                    if (string.IsNullOrEmpty(txtBox.Text))
                        throw new ArgumentNullException("Todos os campos devem ser preenchidos, verifique-os e tente novamente.");
                }
            }
        }

        private void LimparCampos()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    var txtBox = control as TextBox;
                    if (!string.IsNullOrEmpty(txtBox.Text))
                        txtBox.Text = String.Empty;
                }
                if (control is MaskedTextBox)
                {
                    var maskedTextBox = control as MaskedTextBox;
                    if (!string.IsNullOrEmpty(maskedTextBox.Text))
                    {
                        maskedTextBox.Text = string.Empty;
                    }
                }
            }
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
        private void FMateria_Load(object sender, EventArgs e)
        {
            ListarCursosComboBox(comboBoxCurso);
        }

        private void comboBoxCurso_SelectedValueChanged(object sender, EventArgs e)
        {
            ListarTurnosComboBox(comboBoxTurno, comboBoxCurso);
        }
    }
}
