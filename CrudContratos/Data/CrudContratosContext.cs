using CrudContratos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace CrudContratos.Data
{
    public class CrudContratosContext : IdentityDbContext
    {
        public CrudContratosContext(DbContextOptions<CrudContratosContext> options)
            : base(options)
        {
        }

        public DbSet<CrudContratos.Models.Contratos> Contratos { get; set; } = default!;
        public DbSet<Usuario> Usuario { get; set; } = default!;
    }
}
