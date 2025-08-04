using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudContratos.Models;

namespace CrudContratos.Data
{
    public class CrudContratosContext : DbContext
    {
        public CrudContratosContext (DbContextOptions<CrudContratosContext> options)
            : base(options)
        {
        }

        public DbSet<CrudContratos.Models.Contratos> Contratos { get; set; } = default!;
        public DbSet<Usuario> Usuario { get; set; } = default!;
    }
}
