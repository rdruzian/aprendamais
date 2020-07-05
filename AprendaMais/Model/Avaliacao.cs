using AprendaMais.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    public class Avaliacao
    {
        [Required]
        public int nota { get; set; }
        [Required]
        public int ID_aluno { get; set; }
        [Required]
        public int ID_avaliacao { get; set; }
        public int ID_pergunta { get; set; }
        [Required]
        public DateTime data { get; set; }
        public IList<AvaliacaoAluno> Alunos { get; set; }
        public IList<AvaliacaoPergunta> Perguntas{ get; set; }

        public Avaliacao()
        {
            Alunos = new List<AvaliacaoAluno>();
            Perguntas = new List<AvaliacaoPergunta>();
        }
    }
}
