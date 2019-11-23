using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    [Table("FichaExercicio")]
    public class FichaExercicio
    {
        [Key]
        public int IDFichaExercicio { get; set; }

        [ForeignKey("Ficha")]
        public int? IDFicha { get; set; }
        [JsonIgnore]
        public Ficha Ficha { get; set; }

        [ForeignKey("Exercicio")]
        public int? IDExercicio { get; set; }
        [JsonIgnore]
        public Exercicio Exercicio { get; set; }

        public string Repeticao { get; set; }
        public int? Serie { get; set; }
        public decimal? Carga { get; set; }
    }
}
