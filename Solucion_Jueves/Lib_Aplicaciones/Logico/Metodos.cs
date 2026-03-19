using Lib_Aplicaciones.Entidades;
using Lib_Aplicaciones.implementaciones;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Aplicaciones.Logico
{
    public class Metodos
    {
        public Equipos BuscarEquipo(int id, List<Equipos> equipo)
        {
            return equipo.FirstOrDefault(e => e.Id == id);
        }

        /*public bool EquipoDisponible(int id)
        {
            var equipo = variable;
            return equipo != null && equipo.Disponibilidad;
        }*/

        public int ContarDisponibles(List<Equipos> equipo)
        {
            return equipo.Count(e => e.Disponibilidad);
        }

        public void CrearPrestamo(int equipoId, List<Equipos>? equipos)
        {
            var equipo = BuscarEquipo(equipoId, equipos);

            if (equipo == null)
            {
                Console.WriteLine("Equipo no existe");
                return;
            }

            if (!equipo.Disponibilidad)
            {
                Console.WriteLine("Equipo no disponible");
                return;
            }

            equipo.Disponibilidad = false;

            Console.WriteLine("Préstamo realizado");
        }



    }
}
