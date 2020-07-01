using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Models
{
    public class AlternativaProva
    {
        [Required]
        [Column(TypeName="varchar(1)")]
        public char Resp_correto{ get; set; }
        public int ID_pergunta{ get; set; }
        [Required]
        [Column("texto")]
        public string Texto { get; set; }
        public int ID_AlternativaProva { get; set; }
    }
}
