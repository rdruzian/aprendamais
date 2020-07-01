using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    [Table("perguntaProva")]
    public class PerguntaProva
    {
        public int ID_prova { get; set; }
        public int ID_pergunta { get; set; }
        public int ID_perguntaProva { get; set; }
    }
}
