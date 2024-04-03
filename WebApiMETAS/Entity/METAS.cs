using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMETAS.Entity
{
    public class METAS
    {
        [Key]
        public int IdMeta { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
    }
}
