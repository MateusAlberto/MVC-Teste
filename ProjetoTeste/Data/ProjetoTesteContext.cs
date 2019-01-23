using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoTeste.Models
{
    public class ProjetoTesteContext : DbContext
    {
        public ProjetoTesteContext (DbContextOptions<ProjetoTesteContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoTeste.Models.Department> Department { get; set; }
    }
}
