using folder_videojuego.entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace folder_videojuego.interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }

        DbSet<Categorias>? Categorias { get; set; }
        DbSet<Productos>? Productos { get; set; }
        DbSet<Ventas>? Ventas { get; set; }
    }
}