using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WCont_Metas.Client.Data
{
    public class METAS
    {
        [JsonPropertyName("idMet")]
        public int IdMeta { get; set; }
        [JsonPropertyName("nombre")]
        public string? Nombre { get; set; }
        [JsonPropertyName("fecha")]
        public DateTime? Fecha { get; set; }
        [JsonPropertyName("idTarea")]
        public int? IdTarea { get; set; }
    }
}
