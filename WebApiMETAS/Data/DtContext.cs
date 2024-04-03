using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMETAS.Entity;

namespace WebApiMETAS.Data
{
    public class DtContext:DbContext
    {
        public DtContext(DbContextOptions<DtContext> options): base(options) { }

        public virtual DbSet<METAS> METAs { get; set; }
        public virtual DbSet<TAREAS> TAREAs { get; set; }
    }
}
