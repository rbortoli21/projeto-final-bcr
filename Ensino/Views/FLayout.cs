using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Ensino.Views.Turma;
using Ensino.Views.Professor;
using Ensino.Views.Materia;

namespace Ensino.Views
{
    public partial class FLayout : Form
    {
        public FLayout()
        {
            InitializeComponent();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 50;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = false;
            iconMinimize.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormulario(object formulario)
        {
            if (this.painel.Controls.Count > 0)
                this.painel.Controls.RemoveAt(0);
            Form form = formulario as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.painel.Controls.Add(form);
            this.painel.Tag = form;
            form.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FAlunos());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var form = new FCursos())
                form.AtualizarGrid();
            using (var form = new FAlunos())
                form.AtualizarGrid();
            AbrirFormulario(new FDashboard());
        }

        private void painel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = true;
            iconMinimize.Visible = false;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FDashboard());
        }

        private void btnPainelCursos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FCursos());
        }

        private void btnTurmas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FTurmas());
        }

        private void abrirProfessor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FProfessor());
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FMateria());
        }
    }
}
