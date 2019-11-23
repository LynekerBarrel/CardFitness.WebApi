using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    [Table("Ficha")]
    public class Ficha
    {
        [Key]
        public int IDFicha { get; set; }
        [MaxLength(100)]
        [Required]
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public int Status { get; set; }
        public int DiaSeq { get; set; }
    }
}
