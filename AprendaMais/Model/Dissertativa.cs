using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Model
{
    public class Dissertativa
    {
        [Required]
        [Key]
        public int ID_pergunta { get; set; }
        public string Resp_Aluno { get; set; }
        [Required]
        public string gabarito1 { get; set; }
        [Required]
        public string gabarito2 { get; set; }
        [Required]
        public string gabarito3 { get; set; }
    }
}
