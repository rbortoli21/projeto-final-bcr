﻿using Ensino.Data;
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
    public partial class FormCurso : Form
    {
        Curso curso;
        public FormCurso(Curso curso)
        {
            InitializeComponent();
            this.curso = curso;
        }

        private void FormCurso_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCursoSalvar_Click(object sender, EventArgs e)
        {
            curso.Nome = textBoxNomeCurso.Text;
            curso.Turno = comboBoxCursoTurno.Text;
            curso.CargaHoraria = (int)numericCargaHoraria.Value;
            using (var db = new DataContext())
                curso.QuantidadeAlunos = db.Alunos.Where(aluno => aluno.Curso.Id == curso.Id).Count();
            MessageBox.Show($"Carga horária: {curso.CargaHoraria}, Nome: {curso.Nome}, Turno: {curso.Turno}, Quantidade: {curso.QuantidadeAlunos}");
        }
    }
}