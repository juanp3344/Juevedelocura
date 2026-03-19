using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace folder_videojuego.entidades
{
    public class Categorias
    {
        [Key]
        public int IdCategoria { set; get; }
        public string? Nombre { set; get; }
    }
}
