using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Model
{
    public class AlternativaPergunta
    {
        [Required]
        public int ID_alternativa { get; set; }
        [Required]
        public int ID_pergunta { get; set; }
        [Required]
        public char Resp_correto { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
        public byte[] figura_A { get; set; }
        public byte[] figura_B { get; set; }
        public byte[] figura_C { get; set; }
        public byte[] figura_D { get; set; }
        public byte[] figura_E { get; set; }
    }
}
