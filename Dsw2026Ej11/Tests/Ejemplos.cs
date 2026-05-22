using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var alumnos = new CasoList<Alumno>();
        var alumno1 = new Alumno(123, "Valentin", 7.88);
        var alumno2 = new Alumno(456, "Maria", 8.99);
        var alumno3 = new Alumno(789, "Juan", 9.00);

        alumnos.AgregarAlumno(alumno1);
        alumnos.AgregarAlumno(alumno2);
        alumnos.AgregarAlumno(alumno3);

        Console.WriteLine("Listado de alumnos:");
        foreach (Alumno a in alumnos.GetAlumnos())
        {
            Console.WriteLine(a.ToString());
        }
        Console.WriteLine(alumnos.BuscarAlumno("Maria"));
        Console.WriteLine(alumnos.BuscarAlumno("Pedro"));
        Console.WriteLine("Eliminar a Maria");
        alumnos.EliminarAlumno(alumno2);
        Console.WriteLine("Listado de alumnos después de eliminar a Maria:");
        foreach (Alumno a in alumnos.GetAlumnos())
        {
            Console.WriteLine(a.ToString());
        }
        alumnos.ELiminarIndice(0);
        Console.WriteLine("Listado de alumnos después de eliminar el primer elemento:");
        foreach (Alumno a in alumnos.GetAlumnos())
        {
            Console.WriteLine(a.ToString());
        }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var alumnos = new CasoDictionary<Alumno>();
        var alumno1 = new Alumno(123, "Valentin", 7.88);
        var alumno2 = new Alumno(456, "Maria", 8.99);
        var alumno3 = new Alumno(789, "Juan", 9.00);

        alumnos.AgregarAlumno(123, alumno1);
        alumnos.AgregarAlumno(456, alumno2);
        alumnos.AgregarAlumno(789, alumno3);

        Console.WriteLine("Listado de alumnos:");
        foreach (var a in alumnos.GetAlumnos())
        {
            Console.WriteLine(a.Value.ToString());
        }
        Console.WriteLine("Consulta Alumno 456:");
        Console.WriteLine(alumnos.BuscarAlumno(456));
        Console.WriteLine("Consulta Alumno 777:");
        Console.WriteLine(alumnos.BuscarAlumno(777));

        Console.WriteLine("Eliminar Alumno 456:");
        alumnos.EliminarAlumno(456);
        Console.WriteLine("Listado de alumnos:");
        foreach (var a in alumnos.GetAlumnos())
        {
            Console.WriteLine(a.Value.ToString());
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var Libros = new CasoLinq();

        Console.WriteLine("----Primer Libro de la Lista----");
        var PrimerLibro = Libros.GetPrimero();
        Console.WriteLine($"Id: {PrimerLibro.Id} Titulo: {PrimerLibro.Titulo} Precio: {PrimerLibro.Precio:C}");

        Console.WriteLine("----Ultimo Libro de la Lista----");
        var UltimoLibro = Libros.GetUltimo();
        Console.WriteLine($"Id: {UltimoLibro.Id} Titulo: {UltimoLibro.Titulo} Precio: {UltimoLibro.Precio:C}");

        Console.WriteLine("----Suma de Precios----");
        var precios = Libros.GetTotalPrecios();
        Console.WriteLine(precios.ToString("C"));

        Console.WriteLine("----Precio Promedio----");
        var promedio = Libros.GetPromedioPrecios();
        Console.WriteLine(promedio.ToString("C"));

        Console.WriteLine("----Libros con ID > 15----");
        var Id15 = Libros.GetListById();
        foreach (var libro in Id15)
        {
            Console.WriteLine($"Id: {libro.Id} Titulo: {libro.Titulo} Precio: {libro.Precio:C}");
        }

        Console.WriteLine("----Lista de Libros----");
        var lista = Libros.GetLibros();
        foreach (string libro in lista)
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("----Libro Mas Caro----");
        var LibroCaro = Libros.GetMayorPrecio();
        Console.WriteLine($"Id: {LibroCaro.Id} Titulo: {LibroCaro.Titulo} Precio: {LibroCaro.Precio:C}");

        Console.WriteLine("----Libro Mas Barato----");
        var Barato = Libros.GetMenorPrecio();
        Console.WriteLine($"Id: {Barato.Id} Titulo: {Barato.Titulo} Precio: {Barato.Precio:C}");

        Console.WriteLine("----Libros Mas Caros Que Promedio----");
        var libros_caros = Libros.GetMayorPromedio();
        foreach (var libro in libros_caros)
        {
            Console.WriteLine($"Id: {libro.Id} Titulo: {libro.Titulo} Precio: {libro.Precio:C}");
        }

        Console.WriteLine("----Recorrido Descendente----");
        var descendente = Libros.GetOrdenDescendente();
        foreach (var libro in descendente)
        {
            Console.WriteLine($"Titulo: {libro.Titulo} Id: {libro.Id} Precio: {libro.Precio:C}");
        }
    }
}
