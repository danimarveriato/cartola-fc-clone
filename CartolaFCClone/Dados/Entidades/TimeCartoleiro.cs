using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartolaFCClone.Dados.Entidades
{
    [Table("time_cartoleiro")]
    public class TimeCartoleiro
    {
        [Key]
        public int codigo { get; set; }
        [ForeignKey("usuario")]
        public int codigo_cartoleiro { get; set; }
        public string nome_time { get; set; }
        public int? cod_goleiro { get; set; }
        public int? cod_zagueiro_1 { get; set; }
        public int? cod_zagueiro_2 { get; set; }
        public int? cod_lateral_1 { get; set; }
        public int? cod_lateral_2 { get; set; }
        public int? cod_meio_1 { get; set; }
        public int? cod_meio_2 { get; set; }
        public int? cod_meio_3 { get; set; }
        public int? cod_atacante_1 { get; set; }
        public int? cod_atacante_2 { get; set; }
        public int? cod_atacante_3 { get; set; }
        public Boolean ind_time_escalado { get; set; }
    }
}
