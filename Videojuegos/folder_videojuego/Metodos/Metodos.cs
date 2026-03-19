using folder_videojuego.entidades;
using folder_videojuego.implementaciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace folder_videojuego.Metodos
{
    public class Metodos
    {
        private Conexion db;
        public Metodos(string conexion)
        {
            db = new Conexion();
            db.StringConexion = conexion;
        }

        //Metodo de insertar datos
        public void AgregarProductos(string? Nombre, decimal Precio, int IdCategoria)
        {
            var Productos = new Productos()
            {
                Nombre = Nombre,
                Precio = Precio,
                IdCategoria = IdCategoria,
            };

            db.Set<Productos>().Add(Productos);
            db.SaveChanges();
        }

        //Metodo de enlistar todo
        public List<Productos> ObtenerTodo()
        {
            return db.Set<Productos>().ToList();
        }

        //Metodo de buscar por id
        public Productos? ObtenerPorId(int IdProducto)
        {
            return db.Set<Productos>().Find(IdProducto);
        }

        //Metodo de actualizar
        public void ActualizarProducto(int IdProducto, string Nombre, decimal Precio)
        {
            var producto = db.Productos!.Find(IdProducto);

            if (producto != null)
            {
                producto.Nombre = Nombre;
                producto.Precio = Precio;
                db.SaveChanges();
            }
        }

        //Metodo de eliminar
        public void EliminarProducto(int IdProducto)
        {
            var producto = db.Productos!.Find(IdProducto);

            if (producto != null)
            {
                db.Productos.Remove(producto);
                db.SaveChanges();
            }
        }

    }

}
