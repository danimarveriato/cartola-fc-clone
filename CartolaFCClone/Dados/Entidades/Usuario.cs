using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartolaFCClone.Dados.Entidades
{
    [Table("usuario")]
    public class Usuario
    {
        [Key] // Define a chave primária
        public int codigo { get; set; }
        public string nome { get; set; }
        public string? apelido { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime? data_nascimento { get; set; }
        public string? cidade { get; set; }
        [ForeignKey("time")]
        public int? cod_time_coracao { get; set; }
        public Boolean ind_administrador { get; set; }
    }
}
