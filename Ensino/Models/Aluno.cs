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
        [Required(AllowEmptyStrings = true)]
        public string Nome { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string NomeCurso { get; set; }
        public string CPF { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string Telefone { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string Responsavel { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string Matricula { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string Endereco { get; set; }
        [Required]
        public Curso Curso { get; set; }
    }
}
