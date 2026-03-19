using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Aplicaciones.Entidades
{
    public class Clientes
    {

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Correo { get; set; }

        [NotMapped] public List<Prestamos> Prestamos { get; set; }
    }
}
