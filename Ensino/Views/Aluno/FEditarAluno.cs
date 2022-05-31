using Ensino.Models;
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
    public partial class FEditarAluno : Form
    {
        Aluno aluno;
        public FEditarAluno(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
        }
        public void VerificarSeHaCamposVazios()
        {
            foreach (Control control in Controls)
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

        private void FEditarAluno_Load(object sender, EventArgs e)
        {
            txtBoxMatriculaAluno.Enabled = false;
            txtBoxCPF.Enabled = false;
            if (!string.IsNullOrEmpty(aluno.Nome))
            {
                txtBoxNomeAluno.Text = aluno.Nome;
                txtBoxCPF.Text = aluno.CPF;
                txtBoxEnderecoAluno.Text = aluno.Endereco;
                txtBoxMatriculaAluno.Text = aluno.Matricula;
                txtBoxResponsavelAluno.Text = aluno.Responsavel;
                using (var form = new FAlunos())
                {
                    form.ListarCursosComboBox(comboBoxCursoAluno);
                }
                comboBoxTurnoCursoAluno.SelectedItem = aluno.TurnoCurso;
                comboBoxCursoAluno.SelectedItem = aluno.NomeCurso;
                txtBoxEmailAluno.Text = aluno.Email;
                maskedTextBoxTelefoneAluno.Text = aluno.Telefone;

            }
        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelarAluno_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxCursoAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var form = new FAlunos())
            {
                form.ListarTurnosComboBox(comboBoxTurnoCursoAluno, comboBoxCursoAluno);
            }
        }
    }
}
