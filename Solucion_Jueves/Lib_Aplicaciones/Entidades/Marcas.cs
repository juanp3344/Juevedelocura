using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Aplicaciones.Entidades
{
    public class Marcas
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? PaisOrigen { get; set; }
        public DateTime Fundacion { get; set; }

        [NotMapped] public List<Equipos> Equipos { get; set; }
    }
}
