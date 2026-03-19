using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Aplicaciones.Entidades
{
    public class Equipos
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool Disponibilidad { get; set; }
        public string? Color { get; set; }
        public int Marca { get; set; }

        [ForeignKey("Marca")] public Marcas? _Marca { get; set; }
        [NotMapped] public List<Prestamos> Prestamos { get; set; }
    }
}
