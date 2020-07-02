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
        public char Resp_correto{ get; set; }
        public int ID_pergunta{ get; set; }
        [Required]
        public string Texto { get; set; }
        [Required]
        public string A { get; set; }
        [Required]
        public string B { get; set; }
        [Required]
        public string C { get; set; }
        [Required]
        public string D { get; set; }
        public string E { get; set; }
        public int ID_AlternativaProva { get; set; }
    }
}
