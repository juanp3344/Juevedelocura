
using Lib_Aplicaciones.Entidades;
using Lib_Aplicaciones.implementaciones;
using Lib_Aplicaciones.Interfaces;
using Lib_Aplicaciones.Logico;

Console.WriteLine("cns_presentacion");
Console.WriteLine("Conexion de Base de datos");

IConexion conexion = new Conexion();
conexion.StringConexion = "server=localhost\\DEV;Integrated Security=True;TrustServerCertificate=true;database=db_Prestamos_PC;";
var lista_Clientes = conexion.Clientes!.ToList(); 
var lista_Equipos = conexion.Equipos!.ToList(); 
var lista_Marcas = conexion.Marcas!.ToList(); 
var lista_Prestamos = conexion.Prestamos!.ToList();

var metodos = new Metodos();
metodos.CrearPrestamo(7, lista_Equipos);

var buscarPorId = metodos.BuscarEquipo(2, lista_Equipos);
if (buscarPorId == null)
{
    Console.WriteLine("Equipo no existe");
}
else
{
    Console.WriteLine($"{buscarPorId.Id} - {buscarPorId.Color} - {buscarPorId.Descripcion } - {buscarPorId.Disponibilidad} - {buscarPorId.Marca}");
}



Console.WriteLine("Final");
