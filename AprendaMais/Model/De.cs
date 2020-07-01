using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    [Table("de")]
    public class De
    {
        public int ID_universidade { get; set; }
        public int ID_avaliacao { get; set; }
    }
}
