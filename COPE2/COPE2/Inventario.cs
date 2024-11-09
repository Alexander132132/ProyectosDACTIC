using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COPE2
{
    public class Inventario
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            if (!string.IsNullOrWhiteSpace(producto.Nombre) && producto.Precio > 0)
            {
                productos.Add(producto);
                Console.WriteLine($"Producto {producto.Nombre} agregado exitosamente.");
            }
            else
            {
                Console.WriteLine("Datos invalidos, el nombre del producto no puede estar vacio y el precio debe ser positivo.");
            }
        }

        public bool ActualizarPrecio(string nombreProducto, double nuevoPrecio)
        {
            var producto = productos.Find(p => p.Nombre.Equals(nombreProducto, StringComparison.OrdinalIgnoreCase));

            if (producto != null && nuevoPrecio > 0)
            {
                producto.Precio = nuevoPrecio;
                Console.WriteLine($"Nombre del producto: {nombreProducto}, precio actualizado a: {nuevoPrecio}.");
                return true;
            }
            else
            {
                Console.WriteLine("Producto no encontrado o precio no valido.");
                return false;
            }
        }

        public bool EliminarProducto(string nombreProducto)
        {
            var producto = productos.Find(p => p.Nombre == nombreProducto);

            if (producto != null)
            {
                productos.Remove(producto);
                Console.WriteLine($"Producto {nombreProducto} eliminado del inventario.");
                return true;
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
                return false;
            }
        }

        public void ContarProductosPorRangoDePrecio()
        {
            var rangoBajo = productos.Count(p => p.Precio < 100);
            var rangoMedio = productos.Count(p => p.Precio >= 100 && p.Precio <= 500);
            var rangoAlto = productos.Count(p => p.Precio > 500);

            Console.WriteLine($"Productos con precio menor a 100: {rangoBajo}.");
            Console.WriteLine($"Productos con precio entre 100 y 500: {rangoMedio}.");
            Console.WriteLine($"Productos con precio mayor a 500: {rangoAlto}.");
        }

        public void GenerarReporte()
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("El inventario esta vacio.");
                return;
            }
            int TotalProductos = productos.Count;
            var productoMasCaro = productos.OrderByDescending(p => p.Precio).FirstOrDefault();
            var productoMasBarato = productos.OrderBy(p => p.Precio).FirstOrDefault();

            Console.WriteLine("--------------- Reporte del inventario ---------------");
            Console.WriteLine($"Numero total de productos: {TotalProductos}.");
            Console.WriteLine($"Producto mas caro: {productoMasCaro.Nombre} - {productoMasCaro.Precio}.");
            Console.WriteLine($"Producto mas barato: {productoMasBarato.Nombre} - {productoMasBarato.Precio}.");
            Console.WriteLine("------------------------------------------------------");
        }
    }
}