using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WebAppMeta.Data
{
    public class TAREAS
    {
        [JsonPropertyName("idTarea")]
        public int idTarea { get; set; }
        [JsonPropertyName("importancia")]
        public bool? importancia { get; set; }
        [JsonPropertyName("nombre")]
        public string? nombre { get; set; }
        [JsonPropertyName("fecha")]
        public DateTime? fecha { get; set; }
        [JsonPropertyName("estado")]
        public bool? estado { get; set; }
        [JsonPropertyName("idMeta")]
        public int? idMeta { get; set; }
    }
}
