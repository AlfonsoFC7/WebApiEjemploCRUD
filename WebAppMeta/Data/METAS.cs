using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WebAppMeta.Data
{
    public class METAS
    {
        [JsonPropertyName("idMeta")]
        public int idMeta { get; set; }
        [JsonPropertyName("nombre")]
        public string? nombre { get; set; }
        [JsonPropertyName("fecha")]
        public DateTime? fecha { get; set; }
    }
}
