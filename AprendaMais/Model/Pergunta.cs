using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    public class Pergunta
    {
        [Required]
        public string texto_pergunta { get; set; }
        [Required]
        public int ID_universidade { get; set; }
        [Required]
        public int ID_disciplina { get; set; }
        [Required]
        public int ID_pergunta { get; set; }
    }
}
