﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COPE2
{
    public class Producto
    {
        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre del producto: {Nombre}, Precio: {Precio}");
        }
    }
}