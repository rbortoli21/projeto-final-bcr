using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string NomeCurso { get; set; }
        public string TurnoCurso { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Matricula { get; set; }
        public string Responsavel { get; set; }
        public int Curso_Id { get; set; }
        public int Turma_Id { get; set; }
        public string Endereco { get; set; }
    }
}
