using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    public class Disciplina
    {
        [Required]
        public int ID_disciplina { get; set; }
        [Required]
        [StringLength(maximumLength:10)]
        public string nome { get; set; }
    }
}
