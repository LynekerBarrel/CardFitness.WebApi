using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    [Table("Exercicio")]
    public class Exercicio
    {
        [Key]
        public int IDExercicio { get; set; }

        [ForeignKey("Tipo")]
        public int IDTipo { get; set; }
        [JsonIgnore]
        public Tipo Tipo { get; set; }

        [MaxLength(100)]
        [Required]
        public string Descricao { get; set; }
        public string Chave { get; set; }
        public int Status { get; set; }


    }
}

