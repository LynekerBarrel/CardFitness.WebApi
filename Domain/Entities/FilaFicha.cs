using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    [Table("FilaFicha")]
    public class FilaFicha
    {
        [Key]
        public int IDFilaFicha { get; set; }

        [ForeignKey("Ficha")]
        public int? IDFicha { get; set; }
        [JsonIgnore]
        public Ficha Ficha { get; set; }

        public int Executado { get; set; }
    }
}
