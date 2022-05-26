﻿using Ensino.Models.Repositories;
using Ensino.Models;
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

namespace Ensino.Views.Turma
{
    public partial class FTurmas : Form
    {
        private readonly ITurmaRepository _turmaRepository;
        private readonly ICursoRepository _cursoRepository;
        private readonly IAlunoRepository _alunoRepository;
        public FTurmas()
        {
            InitializeComponent();
            _turmaRepository = new TurmaRepository();
            _cursoRepository = new CursoRepository();
            _alunoRepository = new AlunoRepository();
        }

        private void PegarDadosParaCadastro(Models.Turma turma)
        {
            turma.Curso = _cursoRepository.Obter().FirstOrDefault(c => c.Nome == comboBoxCurso.Text);
            turma.NomeCurso = turma.Curso.Nome;
            turma.TurnoCurso = _cursoRepository.Obter().FirstOrDefault(c => c.Turno == comboBoxTurno.Text).Turno;
            turma.QtdAlunos = _alunoRepository.Obter().Where(a => a.Turma_Id == turma.Id).Count();
        }

        private void ListarQuantidadeAlunos(List<Models.Turma> alunos)
        {

        }

        private void AtualizarGrid()
        {
            dgvTurmas.DataSource = _turmaRepository.Obter();

            //ListarQuantidadeAlunos(_turmaRepository.Obter());
            dgvTurmas.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var turma = new Models.Turma();
            try
            {
                PegarDadosParaCadastro(turma);
                _turmaRepository.Cadastrar(turma);
            }
            catch (DuplicateWaitObjectException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show($"Turma não pôde ser cadastrada, verifique os campos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Turma cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var id = ObterIdDoDataGridView(dgvTurmas);
            var turma = _turmaRepository.ObterPorId(id);
            try
            {
                var res = MessageBox.Show("Tem certeza que deseja deletar esse aluno? Este aluno será excluido de forma permanente.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res != DialogResult.OK)
                    return;
                _turmaRepository.Deletar(turma);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show($"A turma de {turma.NomeCurso}, no turno {turma.TurnoCurso} não pôde ser deletada, tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"A turma de {turma.NomeCurso}, no turno {turma.TurnoCurso} foi deletada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
        }

        private void FTurmas_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            comboBoxCurso.DataSource = _cursoRepository.Obter().OrderBy(c => c.Nome).Select(c => c.Nome).Distinct().ToList();
        }

        private void comboBoxCurso_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxTurno.DataSource = _cursoRepository.Obter().Where(c => c.Nome == comboBoxCurso.Text).Select(c => c.Turno).Distinct().ToList();
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

    }
}
