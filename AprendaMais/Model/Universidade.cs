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
        [StringLength(maximumLength:30)]
        public string nome { get; set; }
        [Required]
        [StringLength(maximumLength:2)]
        public string Estado { get; set; }
    }
}
