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
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Responsavel { get; set; }
        [Required]
        public string Matricula { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public Curso Curso { get; set; }
    }
}
