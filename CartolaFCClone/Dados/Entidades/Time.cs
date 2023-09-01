using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartolaFCClone.Dados.Entidades
{
    [Table("time")]
    public class Time
    {
        [Key]
        public int codigo { get; set; }
        public string nome { get; set; }
        public string? logomarca { get; set; }
        public string? estado { get; set; }
        public string? cidade { get; set; }
        public bool status { get; set; }
    }
}
