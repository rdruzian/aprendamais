using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    [Table("contem")]
    public class Contem
    {
        public int ID_pergunta { get; set; }
        public int ID_avaliacao { get; set; }
    }
}
