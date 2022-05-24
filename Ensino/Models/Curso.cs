using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensino.Models
{
    public class Curso : Object
    {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string Nome { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string Turno { get; set; }
        public int QuantidadeAlunos { get; set; }
        public int CargaHoraria { get; set; }
    }
}
