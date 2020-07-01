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
        Humanas=1
    }

    public class Aluno
    {
        [Required]
        [Column(TypeName="varchar(30)")]
        public string nome { get; set; }
        [Required]
        [Column("nascimento")]
        public DateTime DataNascimento{ get; set; }
        [Required]
        [Column(TypeName ="int")]
        public Area area { get; set; }
        
        [Column(TypeName = "varchar(30)")]
        public string Escola { get; set; }
        public int ID_aluno{ get; set; }
    }
}
