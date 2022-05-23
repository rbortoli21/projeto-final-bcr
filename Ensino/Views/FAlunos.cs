using Ensino.Models.Repositories;
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

namespace Ensino.Views
{
    public partial class FAlunos : Form
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly IAlunoRepository _alunoRepository;
        public FAlunos()
        {
            InitializeComponent();
            _cursoRepository = new CursoRepository();
            _alunoRepository = new AlunoRepository();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        private void FAlunos_Load(object sender, EventArgs e)
        {
            SendMessage(this.comboBoxCursoAluno.Handle, CB_SETCUEBANNER, 0, "Selecione um Curso");
            ListarCursosComboBox();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ListarCursosComboBox()
        {
            var cursosPorNome = _cursoRepository.Obter().OrderBy(c => c.Nome).Select(c => c.Nome);
            comboBoxCursoAluno.DataSource = cursosPorNome;
        }
        
        private void PegarDadosParaCadastro()
        {

        }
    }
}
