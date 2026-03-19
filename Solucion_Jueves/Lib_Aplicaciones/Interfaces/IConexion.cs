using Lib_Aplicaciones.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Aplicaciones.Interfaces
{
    public interface IConexion
    {
        public string? StringConexion { get; set; }
        public DbSet<Clientes>? Clientes { get; set; }
        public DbSet<Equipos>? Equipos { get; set; }
        public DbSet<Marcas>? Marcas { get; set; }
        public DbSet<Prestamos>? Prestamos { get; set; }
    }
}
