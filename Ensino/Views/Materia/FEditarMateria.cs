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
    public partial class FEditarMateria : Form
    {
        Models.Materia materia;
        public FEditarMateria(Models.Materia materia)
        {
            InitializeComponent();
            this.materia = materia;
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
                if (control is ComboBox)
                {
                    var cbBox = control as ComboBox;
                    if (string.IsNullOrEmpty(cbBox.Text))
                        throw new ArgumentNullException();
                }
            }
        }

        private void FEditarMateria_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(materia.Nome))
            {
                txtBoxNome.Text = materia.Nome;
                using (var form = new FMateria())
                {
                    form.ListarCursosComboBox(comboBoxCurso);
                }
                comboBoxCurso.SelectedItem = materia.NomeCurso;
                comboBoxTurno.SelectedItem = materia.NomeTurno;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var form = new FMateria())
                form.ListarProfessoresComboBox(comboBoxProfessor, comboBoxTurno);
        }

        private void comboBoxCurso_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var form = new FMateria())
                form.ListarTurnosComboBox(comboBoxTurno, comboBoxCurso);
        }
    }
}
