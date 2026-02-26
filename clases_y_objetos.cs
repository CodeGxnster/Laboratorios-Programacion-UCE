using System;

namespace Clases_y_objetos
{
    public class Articulo
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }
    }

    // matricula, nombre, edad, carrera.
    public class Estudiante
    {
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio de Artículos ---");
            Articulo[] articulos = new Articulo[2];

            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine($"\nIngrese los datos para el artículo {i + 1}:");

                Console.Write("Nombre: ");
                articulos[i].Nombre = Console.ReadLine();

                Console.Write("Precio: ");
                articulos[i].Precio = double.Parse(Console.ReadLine());

                Console.Write("Categoría: ");
                articulos[i].Categoria = Console.ReadLine();
            }

            Console.WriteLine("\n--- Datos de los Artículos Ingresados ---");
            for (int i = 0; i < articulos.Length; i++)
            {
                Console.WriteLine($"\nArtículo {i + 1}:");
                Console.WriteLine($"  Nombre: {articulos[i].Nombre}");
                Console.WriteLine($"  Precio: {articulos[i].Precio}");
                Console.WriteLine($"  Categoría: {articulos[i].Categoria}");
            }

            // Ejercicio b)
            Console.WriteLine("\n--- Ejercicio de Estudiantes");
            Estudiante[] estudiantes = new Estudiante[5];

            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i] = new Estudiante();
                Console.WriteLine($"\nIngrese los datos para el estudiante {i + 1}:");

                Console.Write("Matrícula: ");
                estudiantes[i].Matricula = Console.ReadLine();

                Console.Write("Nombre: ");
                estudiantes[i].Nombre = Console.ReadLine();

                Console.Write("Edad: ");
                estudiantes[i].Edad = int.Parse(Console.ReadLine());

                Console.Write("Carrera: ");
                estudiantes[i].Carrera = Console.ReadLine();
            }

            Console.WriteLine("\n--- Datos de los Estudiantes Ingresados ---");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"\nEstudiante {i + 1}:");
                Console.WriteLine($"  Matrícula: {estudiantes[i].Matricula}");
                Console.WriteLine($"  Nombre: {estudiantes[i].Nombre}");
                Console.WriteLine($"  Edad: {estudiantes[i].Edad}");
                Console.WriteLine($"  Carrera: {estudiantes[i].Carrera}");
            }
        }
    }
}
