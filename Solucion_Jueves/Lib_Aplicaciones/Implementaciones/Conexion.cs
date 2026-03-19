
using Lib_Aplicaciones.Entidades;
using Lib_Aplicaciones.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lib_Aplicaciones.implementaciones
{
    public class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Clientes>? Clientes { get; set; }
        public DbSet<Equipos>? Equipos { get; set; }
        public DbSet<Marcas>? Marcas { get; set; }
        public DbSet<Prestamos>? Prestamos { get; set; }
    }
}
