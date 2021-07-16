using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TFOQ.Models
{
    public class Mantimentos
    {
        [Key]
        public int Id { get; set; }
        
        public string Tipo { get; set; }

        public string Marca { get; set; }

        public string Validade { get; set; }

        public int Capacidade { get; set; }

        public int ConteudoAtual { get; set; }




    }
}