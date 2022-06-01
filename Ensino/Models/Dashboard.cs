using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models
{
    class Dashboard
    {
        public List<string> Curso { get; set; }
        public List<string> Turno { get; set; }
        public int Alunos { get; set; }
        public int Professores { get; set; }
        public int Materias { get; set; }
        public int Turmas { get; set; }
    }
}
