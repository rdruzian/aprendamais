using AprendaMais.Model;
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
        public string enunciado { get; set; }
        public int ID_universidade { get; set; }
        [Required]
        public int ID_disciplina { get; set; }
        [Required]
        public int ID_pergunta { get; set; }
        public byte[] Figura { get; set; }
        [Required]
        public bool dissertativa { get; set; }
        [Required]
        public int ID_alternativa { get; set; }
        public IList<AvaliacaoPergunta> Avaliacoes{ get; set; }
        public IList<PerguntaDisciplina> Disciplinas { get; set; }

        public Pergunta()
        {
            Avaliacoes = new List<AvaliacaoPergunta>();
            Disciplinas = new List<PerguntaDisciplina>();
        }
    }
}
