using System;
namespace COPE
{
    public class Cama
    {
        public Cama (string color, string tipo, double ancho, double largo)
        {
            Color = color;
            Tipo = tipo;
            Ancho = ancho;
            Largo = largo;
        }
        public string Color { get; set; }
        public string Tipo { get; set; }
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public void MostrarInfo ()
        {
            Console.WriteLine($"Color: {Color}, Tipo: {Tipo}, Ancho: {Ancho}, Largo: {Largo}");
        }
    }
    class Program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Ingrese el color de la cama");
            string Color = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de cama: individual o matrimonial");
            string Tipo = Console.ReadLine();

            Console.WriteLine("Ingrese el ancho de la cama: no debe ser menor a 90 CM ni mayor a 155 CM");
            double Ancho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el largo de la cama: no debe ser menor a 150 CM ni mayor a 220 CM");
            double Largo = Convert.ToDouble(Console.ReadLine());

            Cama cama = new Cama(Color, Tipo, Ancho, Largo);

            if (cama.Ancho >= 90 && cama.Ancho <= 135)
            {
                cama.MostrarInfo();
            } else
            {
                Console.WriteLine("Error, el rango de las medidas no esta permitido(ancho)");
            }

            if (cama.Largo >= 150 && cama.Largo <= 220)
            {
                cama.MostrarInfo();
            }
            else
            {
                Console.WriteLine("Error, el rango de las medidas no esta permitido(largo)");
            }
        }
    }
}