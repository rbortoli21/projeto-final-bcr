using Ensino.Models.Repositories;
using Ensino.Models.Repositories.Interfaces;
using Ensino.Views.Relatorios;
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
        public readonly MateriaRepository materiaRepository;
        public readonly CursoRepository cursoRepository;
        public readonly ProfessorRepository professorRepository;
        public FMateria()
        {
            InitializeComponent();
            materiaRepository = new MateriaRepository();
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
        public void ListarProfessoresComboBox(ComboBox comboBox, ComboBox texto)
        => comboBox.DataSource = professorRepository.Obter().Where(p => p.Turno == texto.Text).Select(p => p.Nome).ToList();
        private void AtualizarGrid()
        {
            var query = from c in materiaRepository.Obter() orderby c.Id select c;
            dgvMaterias.DataSource = query.ToList();
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
            VerificarSeHaCamposVazios();
            materia.Nome = txtBoxNome.Text;
            materia.NomeProfessor = comboBoxProfessor.Text;
            materia.NomeCurso = cursoRepository.Obter().Where(c => c.Nome == comboBoxCurso.Text).FirstOrDefault().Nome;
            materia.NomeTurno = cursoRepository.Obter().Where(c => c.Turno == comboBoxTurno.Text).FirstOrDefault().Turno;
            materia.Professor_Id = professorRepository.Obter().FirstOrDefault(p => p.Nome == materia.NomeProfessor).Id;
            materia.Curso_Id = cursoRepository.Obter().FirstOrDefault(c => c.Nome == materia.NomeCurso).Id;
        }
        public void VerificarSeHaCamposVazios()
        {
            foreach (Control control in Controls)
            {
                if (control.Name != textBoxPesquisa.Name)
                {
                    if (control is TextBox)
                    {
                        var txtBox = control as TextBox;
                        if (string.IsNullOrEmpty(txtBox.Text))
                            throw new ArgumentNullException();
                    }
                    if (control is ComboBox)
                    {
                        var cbBox = control as ComboBox;
                        if (string.IsNullOrEmpty(cbBox.Text))
                        {
                            throw new ArgumentNullException();
                        }
                    }
                }
            }
        }
        private void LimparCampos()
        {
            foreach (Control control in Controls)
            {
                if (control.Name != textBoxPesquisa.Name)
                {
                    if (control is TextBox)
                    {
                        var txtBox = control as TextBox;
                        if (!string.IsNullOrWhiteSpace(txtBox.Text))
                            txtBox.Text = String.Empty;
                    }
                    if (control is MaskedTextBox)
                    {
                        var maskedTextBox = control as MaskedTextBox;
                        if (!string.IsNullOrWhiteSpace(maskedTextBox.Text))
                        {
                            maskedTextBox.Text = string.Empty;
                        }
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

        //colocar placeholder no comboBox do professor 
        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        private void FMateria_Load(object sender, EventArgs e)
        {
            SendMessage(this.comboBoxProfessor.Handle, CB_SETCUEBANNER, 0, "Selecione um Professor");
            AtualizarGrid();
            ListarCursosComboBox(comboBoxCurso);
        }
        private void comboBoxCurso_SelectedValueChanged(object sender, EventArgs e)
        => ListarTurnosComboBox(comboBoxTurno, comboBoxCurso);
        private void comboBoxTurno_SelectedValueChanged(object sender, EventArgs e)
        => ListarProfessoresComboBox(comboBoxProfessor, comboBoxTurno);
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var materia = new Models.Materia();
            try
            {
                PegarDadosParaCadastro(materia);
                materiaRepository.Cadastrar(materia);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (ArgumentNullException)
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
                MessageBox.Show($"A matéria não pôde ser cadastrada, verifique os campos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Matéria cadastrada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
            LimparCampos();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var id = ObterIdDoDataGridView(dgvMaterias); ;
            var materia = materiaRepository.ObterPorId(id);
            using (var form = new FEditarMateria(materia))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        form.VerificarSeHaCamposVazios();
                        var materia_n = new Models.Materia
                        {
                            Nome = form.txtBoxNome.Text,
                            NomeProfessor = form.comboBoxProfessor.Text,
                            NomeTurno = form.comboBoxTurno.Text,
                            NomeCurso = form.comboBoxCurso.Text,
                            Curso_Id = cursoRepository.Obter().Where(c => c.Nome == form.comboBoxCurso.Text).FirstOrDefault().Id,
                            Professor_Id = professorRepository.Obter().FirstOrDefault(p => p.Nome == form.comboBoxProfessor.Text).Id
                        };
                        materiaRepository.Alterar(materia, materia_n);
                    }
                    catch (ArgumentNullException)
                    {
                        MessageBox.Show("Todos os campos devem ser preenchidos, verifique-os e tente novamente.");
                        return;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"A matéria não pôde ser alterada, verifique os dados e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show($"A matéria foi alterada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                }
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var id = ObterIdDoDataGridView(dgvMaterias);
            var materia = materiaRepository.ObterPorId(id);
            try
            {
                var res = MessageBox.Show("Tem certeza que deseja deletar essa matéria? Esta matéria será excluido de forma permanente.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res != DialogResult.OK)
                    return;
                materiaRepository.Deletar(materia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show($"A matéria não pôde ser deletada, tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"A matéria foi deletada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
            LimparCampos();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        => LimparCampos();
        private void btnImprimirRelatorio_Click(object sender, EventArgs e)
        {
            List<Models.Materia> materias = (List<Models.Materia>)dgvMaterias.DataSource;
            using (var form = new FRelatorioMateria(materias))
                form.ShowDialog();
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            dgvMaterias.DataSource = materiaRepository.BuscaPorTexto(textBoxPesquisa);
            dgvMaterias.Refresh();
        }
    }
}
