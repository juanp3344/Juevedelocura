using Lib_Aplicaciones.implementaciones;
using Lib_Aplicaciones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_Pruebas
{
    [TestClass]
    public sealed class MarcasUnitarios
    {
        [TestMethod]
        public void Ejecutar()
        {
            IConexion conexion = new Conexion();
            conexion.StringConexion = "server=localhost\\DEV;Integrated Security=True;TrustServerCertificate=true;database=db_Prestamos_PC;";
            var lista = conexion.Marcas!.ToList();
            if (lista.Count > 0)
                return;
            throw new Exception();
        }
    }
}
