using Lib_Aplicaciones.implementaciones;
using Lib_Aplicaciones.Interfaces;

namespace Uni_Pruebas
{
    [TestClass]
    public sealed class ClientesUnitarios
    {
        [TestMethod]
        public void Ejecutar()
        {
            IConexion conexion = new Conexion();
            conexion.StringConexion = "server=localhost\\DEV;Integrated Security=True;TrustServerCertificate=true;database=db_Prestamos_PC;";
            var lista = conexion.Clientes!.ToList();
            if (lista.Count > 0)
                return;
            throw new Exception();
        }
    }
}
