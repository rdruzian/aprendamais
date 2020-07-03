using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    public class Faz
    {
        [Required]
        public int ID_avaliacao { get; set; }
        [Required]
        public int ID_aluno { get; set; }
    }
}
