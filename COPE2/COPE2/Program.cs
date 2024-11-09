using System;

namespace COPE2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            Console.WriteLine("Bienvenido al sistema de gestion de inventrio");

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nSeleccione una opcion.");
                Console.WriteLine("1. Agregar producto.");
                Console.WriteLine("2. Actualizar el precio del producto.");
                Console.WriteLine("3. Eliminar producto.");
                Console.WriteLine("4. Contar y agrupar productos por precio.");
                Console.WriteLine("5. Mostrar reporte del inventario.");
                Console.WriteLine("6. Salir del programa.");

                int opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del producto.");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio del producto.");
                        if (double.TryParse(Console.ReadLine(), out double precio))
                        {
                            inventario.AgregarProducto(new Producto(nombre, precio));
                        }
                        else
                        {
                            Console.WriteLine("Precio invalido.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el nombre del producto para actualizar el precio.");
                        string nombreActualizar = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo precio.");
                        if (double.TryParse(Console.ReadLine(), out double nuevoPrecio))
                        {
                            inventario.ActualizarPrecio(nombreActualizar, nuevoPrecio);
                        }
                        else
                        {
                            Console.WriteLine("Precio invalido.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el nombre del producto a eliminar.");
                        string nombreEliminar = Console.ReadLine();
                        inventario.Equals(nombreEliminar);
                        break;

                    case 4:
                        inventario.ContarProductosPorRangoDePrecio();
                        break;

                    case 5:
                        inventario.GenerarReporte();
                        break;

                    case 6:
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida, intente de nuevo.");
                        break;
                }
            }
        }
    }
}