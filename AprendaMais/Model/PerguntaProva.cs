using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    public class PerguntaProva
    {
        [Required]
        public int ID_prova { get; set; }
        [Required]
        public int ID_pergunta { get; set; }
        [Required]
        public int ID_perguntaProva { get; set; }
    }
}
