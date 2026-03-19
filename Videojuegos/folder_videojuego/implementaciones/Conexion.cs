using folder_videojuego.interfaces;
using folder_videojuego.entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace folder_videojuego.implementaciones
{
    public class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Categorias>? Categorias { get; set; }
        public DbSet<Productos>? Productos { get; set; }
        public DbSet<Ventas>? Ventas { get; set; }
    }
}