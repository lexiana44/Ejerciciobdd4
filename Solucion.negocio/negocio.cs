using System;
using Solucion.datos;

namespace Solucion.negocio
{
    public class Libro
    {
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponible { get; set; }
    }

    public class LibroNegocio
    {
        private LibroDatos _datos = new LibroDatos();

        public Libro ObtenerLibro(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn)) return null;

            var res = _datos.BuscarPorIsbn(isbn);
            if (res == null) return null;

            return new Libro
            {
                Isbn = res.Value.Isbn,
                Titulo = res.Value.Titulo,
                Autor = res.Value.Autor,
                Disponible = res.Value.Disponible
            };
        }
    }
}