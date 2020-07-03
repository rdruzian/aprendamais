using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    public class Ser
    {
        [Required]
        public int ID_pergunta { get; set; }
        [Required]
        public int ID_disciplina { get; set; }
    }
}
