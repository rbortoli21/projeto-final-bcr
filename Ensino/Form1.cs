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
            dgvCursos.DataSource = _cursoRepository.Obter();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    catch (Exception)
                    {
                        MessageBox.Show($"O curso \"{curso.Nome}\" não pôde ser cadastrado, verifique os campos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    MessageBox.Show($"O curso \"{curso.Nome}\" foi cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }     
            }
            AtualizarGrid();
        }
       

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            var curso = cursoBindingSource.Current as Curso;
            MessageBox.Show(curso.Nome);
        }
    }
}
