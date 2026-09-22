using System;
using Solucion.negocio;

namespace Solucion.Presentacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingrese el código ISBN del libro: ");
            string isbn = Console.ReadLine();

            LibroNegocio negocio = new LibroNegocio();
            Libro libro = negocio.ObtenerLibro(isbn);

            if (libro != null)
            {
                Console.WriteLine($"Título: {libro.Titulo}");
                Console.WriteLine($"Autor: {libro.Autor}");
                Console.WriteLine($"Estado: {(libro.Disponible ? "Disponible" : "Prestado")}");
            }
            else
            {
                Console.WriteLine("Error: El ISBN no puede estar vacío o el libro no fue encontrado.");
            }
        }
    }
}