/*using System;

class Libro
{
    // Propiedades
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Paginas { get; set; }

    // Constructor
    public Libro(string titulo, string autor, int paginas)
    {
        Titulo = titulo;
        Autor = autor;
        Paginas = paginas;
    }

    // Método para mostrar la información del libro
    public void MostrarInformacion()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Páginas: {Paginas}");
    }

    // Método que indica si el libro es largo
    public bool EsLargo()
    {
        return Paginas > 500;
    }
}

class Program
{
    static void Main()
    {
        // Crear instancias de la clase Libro
        Libro libro1 = new Libro("Cien Años de Soledad", "Gabriel García Márquez", 417);
        Libro libro2 = new Libro("Guerra y Paz", "León Tolstói", 1225);

        // Mostrar la información del libro1 y comprobar si es largo
        libro1.MostrarInformacion();
        Console.WriteLine("¿Es largo? " + (libro1.EsLargo() ? "Sí" : "No"));
        Console.WriteLine();

        // Mostrar la información del libro2 y comprobar si es largo
        libro2.MostrarInformacion();
        Console.WriteLine("¿Es largo? " + (libro2.EsLargo() ? "Sí" : "No"));
    }
}
*/