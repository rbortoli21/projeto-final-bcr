using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Turno { get; set; }
        [Required]
        public int QuantidadeAlunos { get; set; }
        [Required]
        public int CargaHoraria { get; set; }
    }
}
