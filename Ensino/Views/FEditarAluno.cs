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

        private void FEditarAluno_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(aluno.Nome))
            {
                txtBoxNomeAluno.Text = aluno.Nome;
                txtBoxCPF.Text = aluno.CPF;
                txtBoxCPF.Enabled = false;
                txtBoxEnderecoAluno.Text = aluno.Endereco;
                txtBoxMatriculaAluno.Text = aluno.Matricula;
                txtBoxMatriculaAluno.Enabled = false;
                txtBoxResponsavelAluno.Text = aluno.Responsavel;
                using(var form = new FAlunos())
                    form.ListarCursosComboBox(comboBoxCursoAluno);
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
    }
}
