using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public int Curso_Id{ get; set; }
        public string NomeCurso{ get; set; }
        public string TurnoCurso { get; set; }
        public int QtdAlunos { get; set; }
    }
}
