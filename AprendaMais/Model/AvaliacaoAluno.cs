using AprendaMais.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Model
{
    public class AvaliacaoAluno
    {
        [Required]
        public int AvaliacaoAlunoID { get; set; }
        [Required]
        public Avaliacao Avaliacao { get; set; }
        [Required]
        public Aluno Aluno { get; set; }
    }
}
