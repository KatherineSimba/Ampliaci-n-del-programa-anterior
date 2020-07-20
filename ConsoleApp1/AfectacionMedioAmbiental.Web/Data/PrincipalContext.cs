using Microsoft.EntityFrameworkCore;
using AfectacionMedioAmbiental.Web.Models;

namespace AfectacionMedioAmbiental.Web.Data
{
    public class PrincipalContext : DbContext
    {
        public PrincipalContext (DbContextOptions<PrincipalContext> options)
            : base(options)
        {
        }

        public DbSet<Celular> Celulares { get; set; }
        public DbSet<Persona> Personas { get; set; }
    }
}
