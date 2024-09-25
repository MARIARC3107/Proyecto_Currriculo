using Microsoft.EntityFrameworkCore;
using Proyecto_curriculo.Models;

namespace Proyecto_curriculo.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<perfil_egreso> perfil_egreso { get; set; }
        public DbSet<Saber> Saber { get; set; }
        public DbSet<ATProfesionales> ATProfesionales { get; set; }
        public DbSet<AProfesional> AProfesional { get; set; }
        public DbSet<PActuacion> PActuacion { get; set; }
        public DbSet<VAgregado> VAgregado { get; set; }
        public DbSet<Competencias> Competencias { get; set; }
        public DbSet<Res_aprendizaje> Res_aprendizaje { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
    }
}
