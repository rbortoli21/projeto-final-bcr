using Ensino.Data;
using Ensino.Models;
using Ensino.Models.Repositories;
using Ensino.Models.Repositories.Interfaces;
using Ensino.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ensino
{
    public partial class Form1 : Form
    {
        private readonly IAlunoRepository _alunoRepository; 
        private readonly ICursoRepository _cursoRepository; 
        public Form1()
        {
            InitializeComponent();
            _alunoRepository = new AlunoRepository();
            _cursoRepository = new CursoRepository();
        }

        private void AtualizarGrid()
        {
            dgvCursos.DataSource = _cursoRepository.Obter();
            dgvCursos.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCursos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AtualizarGrid();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCursos.CurrentRow.Index != -1)
                btnDeletarCurso.Enabled = true;
            btnDeletarCurso.Enabled = false;
        }

        private void btnNovoCurso_Click(object sender, EventArgs e)
        {
            var curso = new Curso();
            using (var form = new FormCurso(curso))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {   
                    try
                    {
                        _cursoRepository.Cadastrar(curso);
                    }
                    catch (DuplicateWaitObjectException)
                    {
                        MessageBox.Show($"O curso \"{curso.Nome}\" já está cadastrado neste Turno, para poder cadastrá-lo novamente, altere o turno.");
                        return;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"O curso \"{curso.Nome}\" não pôde ser cadastrado, verifique os campos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show($"O curso \"{curso.Nome}\" foi cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);      
                }     
            }
            AtualizarGrid();
        }
       
        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvCursos.CurrentRow.Cells[0].Value);
            var curso = _cursoRepository.ObterPorId(id);
            using (var form = new FormCurso(curso))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var curso_n = new Curso
                        {
                            Nome = form.textBoxNomeCurso.Text,
                            Turno = form.comboBoxCursoTurno.Text,
                            CargaHoraria = (int)form.numericCargaHoraria.Value
                        };
                        _cursoRepository.Alterar(curso, curso_n); 
                    }
                    catch (DuplicateWaitObjectException)
                    {
                        MessageBox.Show($"O curso \"{curso.Nome}\" já está cadastrado neste Turno, para poder cadastrá-lo novamente, altere o turno.");
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"O curso \"{curso.Nome}\" não pôde ser alterado, verifique os dados e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show($"O curso \"{curso.Nome}\" foi alterado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            AtualizarGrid();
        }

        private void btnDeletarCurso_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvCursos.CurrentRow.Cells[0].Value);
            var curso = _cursoRepository.ObterPorId(id);
            try
            {
                _cursoRepository.Deletar(curso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show($"O curso \"{curso.Nome}\" não pôde ser deletado, tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"O curso \"{curso.Nome}\" foi deletado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
        }
        
    }
}
