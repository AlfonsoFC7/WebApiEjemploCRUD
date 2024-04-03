using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMETAS.Entity
{
    public class TAREAS
    {
        [Key]
        public int IdTarea { get; set; }
        public bool Importancia { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
        public int IdMeta { get; set; }
    }
}
