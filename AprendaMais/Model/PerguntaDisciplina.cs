using AprendaMais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Model
{
    public class PerguntaDisciplina
    {
        public Pergunta Pergunta { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
