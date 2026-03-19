using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace folder_videojuego.entidades
{
    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int IdCategoria { get; set; }
    }
}
