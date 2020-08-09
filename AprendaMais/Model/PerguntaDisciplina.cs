using AprendaMais.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Model
{
    public class PerguntaDisciplina
    {
        [Required]
        public int PerguntaDisciplinaID { get; set; }
        public Pergunta Pergunta { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
