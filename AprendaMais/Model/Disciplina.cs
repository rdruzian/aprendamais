using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    public enum Nome
    {
        Matematica = 1,
        Portugues = 2,
        Quimica = 3,
        Fisica = 4,
        Biologia = 5,
        Historia = 6,
        Geografia = 7,
        Ingles = 8,
        Espanhol = 9
    }
    public class Disciplina
    {
        public int ID_disciplina { get; set; }
        [Required]
        [Column(TypeName="int")]
        public Nome nome { get; set; }
    }
}
