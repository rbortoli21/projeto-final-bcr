using Ensino.Data;
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
    public partial class FCursos : Form
    {
        public readonly CursoRepository cursoRepository;
        public readonly AlunoRepository alunoRepository;
        public FCursos()
        {
            InitializeComponent();
            cursoRepository = new CursoRepository();
            alunoRepository = new AlunoRepository();
        }
        public void AtualizarGrid()
        {
            dgvListarCursos.DataSource = cursoRepository.Obter();
            dgvListarCursos.Refresh();
            if (ObterIdDoDataGridView(dgvListarCursos) != 0)
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
        public void ListarQuantidadeAlunos(List<Models.Curso> cursos)
        {
            foreach (var curso in cursos)
                cursoRepository.ListarAlunos(curso);
        }
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        private void FCursos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            ListarQuantidadeAlunos(cursoRepository.Obter());
            SendMessage(this.comboBoxTurnoCurso.Handle, CB_SETCUEBANNER, 0, "Selecione um Turno");
        }

        //Cadastro
        private void btnNovoCurso_Click(object sender, EventArgs e)
        {
            var curso = new Curso();
            try
            {
                PegarDadosParaCadastro(curso);
                cursoRepository.Cadastrar(curso);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos, verifique-os e tente novamente.");
                return;
            }
            catch (DuplicateWaitObjectException)
            {
                MessageBox.Show($"O curso \"{curso.Nome}\" já está cadastrado neste Turno, para poder cadastrá-lo novamente, altere o turno.");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show($"O curso \"{curso.Nome}\" não pôde ser cadastrado, verifique os campos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AtualizarGrid();
                return;
            }
            MessageBox.Show($"O curso \"{curso.Nome}\" foi cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
            LimparCampos();
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
                    if (control is MaskedTextBox)
                    {
                        var txtBox = control as MaskedTextBox;
                        if (!txtBox.MaskCompleted)
                            throw new ArgumentNullException();
                    }
                }
            }
        }

        private void PegarDadosParaCadastro(Curso curso)
        {
            VerificarSeHaCamposVazios();
            curso.Nome = txtBoxNomeCurso.Text;
            curso.Turno = comboBoxTurnoCurso.Text;
            curso.CargaHoraria = (int)numericUpDownCargaHoraria.Value;
        }
        //Edição
        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvListarCursos.CurrentRow.Cells[0].Value);
            var curso = cursoRepository.ObterPorId(id);
            using (var form = new FEditarCurso(curso))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var curso_n = new Curso
                        {
                            Nome = form.txtBoxNomeCurso.Text,
                            Turno = form.comboBoxTurnoCurso.Text,
                            CargaHoraria = (int)form.numericUpDownCargaHoraria.Value
                        };
                        cursoRepository.Alterar(curso, curso_n);
                    }
                    catch (DuplicateWaitObjectException)
                    {
                        MessageBox.Show($"O curso \"{curso.Nome}\" já está cadastrado neste Turno, para poder cadastrá-lo novamente, altere o turno.");
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show($"O curso \"{curso.Nome}\" não pôde ser alterado, verifique os dados e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show($"O curso \"{curso.Nome}\" foi alterado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                }
            }
        }
        //Deleção
        private void btnDeletarCurso_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvListarCursos.CurrentRow.Cells[0].Value);
            var curso = cursoRepository.ObterPorId(id);
            try
            {
                cursoRepository.Deletar(curso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show($"O curso \"{curso.Nome}\" não pôde ser deletado, tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"O curso \"{curso.Nome}\" foi deletado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
            LimparCampos();
        }
        private void btnCancelarCurso_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxNomeCurso.Text))
            {
                txtBoxNomeCurso.Text = String.Empty;
                numericUpDownCargaHoraria.Value = decimal.Zero;
            }
        }
        private void LimparCampos()
        {
            if (!string.IsNullOrEmpty(txtBoxNomeCurso.Text))
            {
                txtBoxNomeCurso.Text = String.Empty;
                numericUpDownCargaHoraria.Value = decimal.Zero;
            }
        }
        private void btnImprimirRelatorio_Click(object sender, EventArgs e)
        {
            List<Curso> dt = (List<Curso>)dgvListarCursos.DataSource;
            using (var form = new FRelatorioCurso(dt))
                form.ShowDialog();
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

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            dgvListarCursos.DataSource = cursoRepository.BuscaPorTexto(textBoxPesquisa);
            dgvListarCursos.Refresh();
        }
    }
}
