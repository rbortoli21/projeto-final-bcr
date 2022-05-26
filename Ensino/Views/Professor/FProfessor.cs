﻿using Ensino.Models.Repositories;
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

namespace Ensino.Views.Professor
{
    public partial class FProfessor : Form
    {
        private readonly IProfessorRepository _professorRepository;
        public FProfessor()
        {
            InitializeComponent();
            _professorRepository = new ProfessorRepository();
        }

        private void AtualizarGrid()
        {
            dgvProfessor.DataSource = _professorRepository.Obter();
            dgvProfessor.Refresh();
            if (ObterIdDoDataGridView(dgvProfessor) != 0)
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

        private void PegarDadosParaCadastro(Models.Professor professor)
        {
            professor.Nome = txtBoxNome.Text;
            professor.Endereco = txtBoxEndereco.Text;
            professor.Email = txtBoxEmail.Text;
            professor.Telefone = maskedTextBoxTelefone.Text;
            professor.CPF = txtBoxCPF.Text;
            professor.Turno = comboBoxTurno.Text;
        }
        public void VerificarSeHaCamposVazios()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    var txtBox = control as TextBox;
                    if (string.IsNullOrEmpty(txtBox.Text))
                        throw new ArgumentNullException("Todos os campos devem ser preenchidos, verifique-os e tente novamente.");
                }
                if(control is ComboBox)
                {
                    var cbBox = control as ComboBox;
                    if (string.IsNullOrEmpty(cbBox.Text))
                        throw new ArgumentNullException("Todos os campos devem ser preenchidos, verifique-os e tente novamente.");
                }
            }
        }
        private void LimitarCpfETelefone(MaskedTextBox cpf, MaskedTextBox telefone)
        {
            if (cpf.Text.Trim().Replace(" ", "").Length < 14)
                throw new DataException("O campo CPF deve possuir 11 caracteres.");
            if (telefone.Text.Trim().Replace(" ", "").Length < 17)
                throw new DataException("O campo Telefone deve possuir 11 caracteres.");
        }

        private void LimparCampos()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    var txtBox = control as TextBox;
                    if (!string.IsNullOrEmpty(txtBox.Text))
                        txtBox.Text = String.Empty;
                }
                if (control is MaskedTextBox)
                {
                    var maskedTextBox = control as MaskedTextBox;
                    if (!string.IsNullOrEmpty(maskedTextBox.Text))
                    {
                        maskedTextBox.Text = string.Empty;
                    }
                }
            }
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var professor = new Models.Professor();
            try
            {
                PegarDadosParaCadastro(professor);
                VerificarSeHaCamposVazios();
                LimitarCpfETelefone(txtBoxCPF, maskedTextBoxTelefone);
                _professorRepository.Cadastrar(professor);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (DuplicateWaitObjectException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show($"Professor não pôde ser cadastrado, verifique os campos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Professor cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var id = ObterIdDoDataGridView(dgvProfessor); ;
            var professor = _professorRepository.ObterPorId(id);
            using (var form = new FEditarProfessor(professor))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var professor_n = new Models.Professor
                        {
                            Nome = form.txtBoxNome.Text,
                            Endereco = form.txtBoxEndereco.Text,
                            Telefone = form.maskedTextBoxTelefone.Text,
                            Email = form.txtBoxEmail.Text,
                        };
                        form.VerificarSeHaCamposVazios();
                        _professorRepository.Alterar(professor, professor_n);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Professor não pôde ser alterado, verifique os dados e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show($"Professor foi alterado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var id = ObterIdDoDataGridView(dgvProfessor);
            var professor = _professorRepository.ObterPorId(id);
            try
            {
                var res = MessageBox.Show("Tem certeza que deseja deletar esse aluno? Este aluno será excluido de forma permanente.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res != DialogResult.OK)
                    return;
                _professorRepository.Deletar(professor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show($"Professor não pôde ser deletado, tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Professor deletado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //placeholder no turno
        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        private void FProfessor_Load(object sender, EventArgs e)
        {
            SendMessage(this.comboBoxTurno.Handle, CB_SETCUEBANNER, 0, "Selecione um Turno");
            AtualizarGrid();
        }
    }
}