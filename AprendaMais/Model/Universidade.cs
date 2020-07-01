using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    public class Universidade
    {
        [Required]
        public int ID_universidade { get; set; }
        [Required]
        [Column(TypeName="varchar(20)")]
        public string nome { get; set; }
    }
}
