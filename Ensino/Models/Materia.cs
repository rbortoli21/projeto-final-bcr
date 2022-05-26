using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Curso_Id { get; set; }
        public string NomeCurso { get; set; }
        public string NomeTurno { get; set; }
        public int Professor_Id { get; set; }
        public string NomeProfessor { get; set; }
    }
}
