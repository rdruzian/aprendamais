using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    public enum Area
    {
        Biologica=1,
        Exatas=2,
        Humanas=3
    }

    public class Aluno
    {
        [Required]
        [StringLength(maximumLength: 30)]
        public string nome { get; set; }
        [Required]
        public char sexo { get; set; }
        [Required]
        public DateTime DataNascimento{ get; set; }
        [Required]
        public Area area { get; set; }
        [StringLength(maximumLength:30)]
        public string Escola { get; set; }
        [Required]
        public int ID_aluno{ get; set; }
    }
}
