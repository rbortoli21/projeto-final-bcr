using Ensino.Models;
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

namespace Ensino.Views
{
    public partial class FAlunos : Form
    {
        private readonly ICursoRepository cursoRepository;
        public readonly IAlunoRepository alunoRepository;
        public readonly ITurmaRepository turmaRepository;
        public FAlunos()
        {
            InitializeComponent();
            cursoRepository = new CursoRepository();
            alunoRepository = new AlunoRepository();
            turmaRepository = new TurmaRepository();
        }
        //Funções criadas {
        public void AtualizarGrid()
        {
            dgvAlunos.DataSource = alunoRepository.Obter();
            dgvAlunos.Refresh();
            if (ObterIdDoDataGridView(dgvAlunos) != 0)
            {
                btnEditarAluno.Enabled = true;
                btnDeletarAluno.Enabled = true;
            }
            else
            {
                btnEditarAluno.Enabled = false;
                btnDeletarAluno.Enabled = false;
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

        public int GerarTurmaAleatoria(Aluno aluno)
        {
            var turmas = turmaRepository.Obter().Where(t => t.NomeCurso == aluno.NomeCurso).Select(t => t.Id).ToList();
            var random = new Random();
            int index = turmas[random.Next(turmas.Count)];

            return index;
        }

        private void PegarDadosParaCadastro(Aluno aluno)
        {
            aluno.Nome = txtBoxNomeAluno.Text;
            aluno.Responsavel = txtBoxResponsavelAluno.Text;
            aluno.Endereco = txtBoxEnderecoAluno.Text;
            aluno.CPF = txtBoxCPF.Text;
            aluno.Email = txtBoxEmailAluno.Text;
            aluno.NomeCurso = cursoRepository.Obter().Where(c => c.Nome == comboBoxCursoAluno.Text).FirstOrDefault().Nome;
            aluno.Curso_Id = cursoRepository.Obter().Where(c => c.Nome == comboBoxCursoAluno.Text).FirstOrDefault().Id;
            aluno.Turma_Id = GerarTurmaAleatoria(aluno);
            aluno.Telefone = maskedTextBoxTelefoneAluno.Text;
            aluno.TurnoCurso = cursoRepository.Obter().Where(c => c.Turno == comboBoxTurnoCursoAluno.Text).FirstOrDefault().Turno;
            var matricula = new Random();
            aluno.Matricula = matricula.Next(10000000).ToString();

            if (alunoRepository.Obter().Where(c => c.Matricula == matricula.ToString()).Any())
                aluno.Matricula = matricula.Next(10000000).ToString();
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
        //Funções criadas }
        //Form Load (Colocar placeholder no comboBox)
        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        private void FAlunos_Load(object sender, EventArgs e)
        {
            SendMessage(this.comboBoxCursoAluno.Handle, CB_SETCUEBANNER, 0, "Selecione um Curso");
            AtualizarGrid();
            ListarCursosComboBox(comboBoxCursoAluno);
        }

        //Cadastro
        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno();
            try
            {
                PegarDadosParaCadastro(aluno);
                VerificarSeHaCamposVazios();
                LimitarCpfETelefone(txtBoxCPF, maskedTextBoxTelefoneAluno);
                alunoRepository.Cadastrar(aluno);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (DuplicateWaitObjectException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show($"O aluno \"{aluno.Nome}\" não pôde ser cadastrado, verifique os campos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Aluno cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
            LimparCampos();
        }


        //Edição
        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            var id = ObterIdDoDataGridView(dgvAlunos); ;
            var aluno = alunoRepository.ObterPorId(id);
            using (var form = new FEditarAluno(aluno))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var aluno_n = new Aluno
                        {
                            Nome = form.txtBoxNomeAluno.Text,
                            Endereco = form.txtBoxEnderecoAluno.Text,
                            Telefone = form.maskedTextBoxTelefoneAluno.Text,
                            Email = form.txtBoxEmailAluno.Text,
                            Responsavel = form.txtBoxResponsavelAluno.Text,
                            Curso_Id = cursoRepository.Obter().Where(c => c.Nome == form.comboBoxCursoAluno.Text).FirstOrDefault().Id,
                            NomeCurso = form.comboBoxCursoAluno.Text,
                            TurnoCurso = form.comboBoxTurnoCursoAluno.Text,
                        };
                        form.VerificarSeHaCamposVazios();
                        alunoRepository.Alterar(aluno, aluno_n);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"O aluno \"{aluno.Nome}\" não pôde ser alterado, verifique os dados e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show($"O aluno \"{aluno.Nome}\" foi alterado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                }
            }
        }

        //Deleção
        private void btnDeletarAluno_Click(object sender, EventArgs e)
        {
            var id = ObterIdDoDataGridView(dgvAlunos);
            var aluno = alunoRepository.ObterPorId(id);
            try
            {
                var res = MessageBox.Show("Tem certeza que deseja deletar esse aluno? Este aluno será excluido de forma permanente.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res != DialogResult.OK)
                    return;
                alunoRepository.Deletar(aluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show($"O aluno \"{aluno.Nome}\" não pôde ser deletado, tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"O aluno \"{aluno.Nome}\" foi deletado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
            LimparCampos();
        }

        //Cancelar
        private void btnCancelarAluno_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void comboBoxCursoAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            ListarTurnosComboBox(comboBoxTurnoCursoAluno, comboBoxCursoAluno);
        }

        //Limitar CPF
        private void LimitarCpfETelefone(MaskedTextBox cpf, MaskedTextBox telefone)
        {
            if (cpf.Text.Trim().Replace(" ", "").Length < 14)
                throw new DataException("O campo CPF deve possuir 11 caracteres.");
            if (telefone.Text.Trim().Replace(" ", "").Length < 17)
                throw new DataException("O campo Telefone deve possuir 11 caracteres.");
        }

        //Obter id do aluno para editar/deletar
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
            List<Aluno> dt = (List<Aluno>)dgvAlunos.DataSource;
            using (var form = new FRelatorioAluno(dt))
            {
                form.ShowDialog();
            }
        }
    }
}
