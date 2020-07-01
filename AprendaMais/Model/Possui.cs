using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    [Table("possui")]
    public class Possui
    {
        public int ID_perguntaProva { get; set; }
        public int ID_pergunta { get; set; }
    }
}
