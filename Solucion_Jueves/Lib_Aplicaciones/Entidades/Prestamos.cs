using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Aplicaciones.Entidades
{
    public class Prestamos
    {
        public int Id { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public string? Estado { get; set; }
        public int Equipo { get; set; }
        public int Cliente { get; set; }

        [ForeignKey("Equipo")] public Equipos? _Equipo { get; set; }
        [ForeignKey("Cliente")] public Clientes? _Cliente { get; set; }
    }
}
