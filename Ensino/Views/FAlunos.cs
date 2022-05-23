using Ensino.Models;
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

namespace Ensino.Views
{
    public partial class FAlunos : Form
    {
        private readonly ICursoRepository _cursoRepository;
        public readonly IAlunoRepository _alunoRepository;
        public FAlunos()
        {
            InitializeComponent();
            _cursoRepository = new CursoRepository();
            _alunoRepository = new AlunoRepository();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        public void AtualizarGrid()
        {
            dgvAlunos.DataSource = _alunoRepository.Obter();
            dgvAlunos.Refresh();
        }

        private void LimparCampos()
        {
            txtBoxNomeAluno.Text = String.Empty;
            txtBoxCPF.Text = String.Empty;
            txtBoxEnderecoAluno.Text = String.Empty;
            txtBoxResponsavelAluno.Text = String.Empty;
            comboBoxCursoAluno.Text = String.Empty;
            txtBoxEmailAluno.Text = String.Empty;
            maskedTextBoxTelefoneAluno.Text = String.Empty;
        }

        private void PegarDadosParaCadastro(Aluno aluno)
        {
            aluno.Nome = txtBoxNomeAluno.Text;
            aluno.Responsavel = txtBoxResponsavelAluno.Text;
            aluno.Endereco = txtBoxEnderecoAluno.Text;
            aluno.CPF = txtBoxCPF.Text;
            aluno.Curso = _cursoRepository.Obter().Where(c => c.Nome == comboBoxCursoAluno.Text).FirstOrDefault();
            aluno.NomeCurso = aluno.Curso.Nome;
            aluno.Email = txtBoxEmailAluno.Text;
            var matricula = new Random();
            aluno.Matricula = matricula.Next(10000000).ToString();
            if (_alunoRepository.Obter().Where(c => c.Matricula == matricula.ToString()).Any())
                aluno.Matricula = matricula.Next(10000000).ToString();
            aluno.Telefone = maskedTextBoxTelefoneAluno.Text;
        }
        public void ListarCursosComboBox(ComboBox comboBox)
        {
            var cursosPorNome = _cursoRepository.Obter().OrderBy(c => c.Nome).Select(c => c.Nome).ToList();
            comboBox.DataSource = cursosPorNome;
        }
        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        private void FAlunos_Load(object sender, EventArgs e)
        {
            SendMessage(this.comboBoxCursoAluno.Handle, CB_SETCUEBANNER, 0, "Selecione um Curso");
            AtualizarGrid();
            ListarCursosComboBox(comboBoxCursoAluno);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //Cadastro
        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno();
            try
            {
                PegarDadosParaCadastro(aluno);
                _alunoRepository.Cadastrar(aluno);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos, verifique-os e tente novamente.");
                return;
            }
            catch (DuplicateWaitObjectException)
            {
                MessageBox.Show($"O aluno \"{aluno.Nome}\" já está cadastrado.");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show($"O aluno \"{aluno.Nome}\" não pôde ser cadastrado, verifique os campos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AtualizarGrid();
                return;
            }
            MessageBox.Show($"O aluno \"{aluno.Nome}\" foi cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
            LimparCampos();
        }

        //Edição
        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvAlunos.CurrentRow.Cells[0].Value);
            var aluno = _alunoRepository.ObterPorId(id);
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
                            Curso = _cursoRepository.Obter().Where(c => c.Nome == form.comboBoxCursoAluno.Text).FirstOrDefault(),
                            NomeCurso = form.comboBoxCursoAluno.Text
                        };
                        _alunoRepository.Alterar(aluno, aluno_n);
                    }
                    catch (DuplicateWaitObjectException)
                    {
                        MessageBox.Show($"O aluno \"{aluno.Nome}\" já está cadastrado.");
                        return;
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

        //DELEÇÃO
        private void btnDeletarAluno_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvAlunos.CurrentRow.Cells[0].Value);
            var aluno = _alunoRepository.ObterPorId(id);
            try
            {
                var res = MessageBox.Show("Tem certeza que deseja deletar esse aluno? Este aluno será excluido de forma permanente.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res != DialogResult.OK)
                    return;
                _alunoRepository.Deletar(aluno);
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

        private void btnCancelarAluno_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox text = control as TextBox;
                    if (!string.IsNullOrEmpty(text.Text))
                        LimparCampos();
                }
            }
        }
    }
}
