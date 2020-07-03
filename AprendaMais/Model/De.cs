using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    public class De
    {
        [Required]
        public int ID_universidade { get; set; }
        [Required]
        public int ID_avaliacao { get; set; }
    }
}
