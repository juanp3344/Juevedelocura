using folder_videojuego.implementaciones;
using folder_videojuego.interfaces;
using folder_videojuego.Metodos;
using System;
using System.Collections.Generic;
using System.Text;

Console.WriteLine("folder_consola");

Console.WriteLine("Conexion de Base de datos hecha correctamente");
IConexion conexion = new Conexion();
conexion.StringConexion = "server=localhost;Integrated Security=True;TrustServerCertificate=true;database=videojuegos;";
var lista_categorias = conexion.Categorias!.ToList();
var lista_productos = conexion.Productos!.ToList();
var lista_ventas = conexion.Ventas!.ToList();


Console.WriteLine("Categorias");
foreach (var c in lista_categorias)
{
    Console.WriteLine($"{c.IdCategoria} - {c.Nombre}");
}

Console.WriteLine("\nProductos");
foreach (var p in lista_productos)
{
    Console.WriteLine($"{p.IdProducto} - {p.Nombre} - {p.Precio}");
}

Console.WriteLine("\nVentas");
foreach (var v in lista_ventas)
{
    Console.WriteLine($"{v.IdVenta} - Producto:{v.IdProducto} - Cantidad:{v.Cantidad}");
}


// Crear servicio
var servicio = new Metodos("server=localhost;database=videojuegos;trusted_connection=true,TrustServerCertificate=true;");


    // 1️⃣ INSERTAR
    servicio.AgregarProductos("Devil may cry", 100000, 2);

    // 2️⃣ LISTAR
    var lista = servicio.ObtenerTodo();
    Console.WriteLine("Lista de productos:");
    foreach (var p in lista)
    {
        Console.WriteLine(p.IdProducto + " " + p.Nombre + " " + p.Precio);
    }

    // 3️⃣ BUSCAR POR ID
    var producto = servicio.ObtenerPorId(1);

    if (producto != null)
    {
        Console.WriteLine("Encontrado: " + producto.Nombre);
    }

    // 4️⃣ ACTUALIZAR
    servicio.ActualizarProducto(2, "Devil May Cry Colletion", 175000);

    // 5️⃣ ELIMINAR
    servicio.EliminarProducto(1);

Console.WriteLine("Fin");