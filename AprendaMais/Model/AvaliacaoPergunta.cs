using AprendaMais.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Model
{
    public class AvaliacaoPergunta
    {
        [Required]
        public int AvaliacaoPerguntaID { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public Pergunta Pergunta{ get; set; }
    }
}
