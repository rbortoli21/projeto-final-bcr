using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ensino.Views.Professor
{
    public partial class FEditarProfessor : Form
    {
        Models.Professor professor;
        public FEditarProfessor(Models.Professor professor)
        {
            InitializeComponent();
            this.professor = professor;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
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
                if(control is MaskedTextBox)
                {
                    var txtBox = control as MaskedTextBox;
                    if (!txtBox.MaskCompleted)
                        throw new ArgumentNullException();
                }
            }
        }
        private void FEditarProfessor_Load(object sender, EventArgs e)
        {
            txtBoxCPF.Enabled = false;
            if (!string.IsNullOrEmpty(professor.Nome))
            {
                txtBoxNome.Text = professor.Nome;
                txtBoxCPF.Text = professor.CPF;
                txtBoxEndereco.Text = professor.Endereco;
                txtBoxEmail.Text = professor.Email;
                maskedTextBoxTelefone.Text = professor.Telefone;
                comboBoxTurno.SelectedItem = professor.Turno;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
