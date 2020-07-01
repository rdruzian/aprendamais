using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    [Table("ser")]
    public class Ser
    {
        public int ID_pergunta { get; set; }
        public int ID_disciplina { get; set; }
    }
}
