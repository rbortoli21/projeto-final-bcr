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
    public partial class FEditarCurso : Form
    {
        Curso curso;
        public FEditarCurso(Curso curso)
        {
            InitializeComponent();
            this.curso = curso;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTurnoCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void FEditarCurso_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(curso.Nome))
            {
                txtBoxNomeCurso.Text = curso.Nome;
                comboBoxTurnoCurso.Text = curso.Turno;
                numericUpDownCargaHoraria.Value = curso.CargaHoraria;
            }
        }

        private void txtBoxNomeCurso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
