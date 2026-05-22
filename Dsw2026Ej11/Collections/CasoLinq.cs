using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> ListaLibros = Libro.CrearLista();
    public Libro GetPrimero()
    {
        var primero = ListaLibros.First();
        return primero; // $"Id: {primero.Id}, Título: {primero.Titulo}, Precio: {primero.Precio:C}";
    }

    public Libro GetUltimo()
    {
        var ultimo = ListaLibros.Last();
        return ultimo;
    }


    public decimal GetTotalPrecios()
    {
        var total = ListaLibros.Sum(libro => libro.Precio);
        return total;
    }

    public decimal GetPromedioPrecios()
    {
        var prom = ListaLibros.Average(libro => libro.Precio);
        return prom;
    }

    public List<Libro> GetListById()
    {
        var libros = ListaLibros.Where(libro => libro.Id > 15).ToList();
        return libros;
    }

    public List<string> GetLibros()
    {
        var libros = ListaLibros.Select(libro => $"Titulo: {libro.Titulo} -- Precio: {libro.Precio:C}").ToList();
        return libros;
    }

    public Libro GetMayorPrecio()
    {
        var MasCaro = ListaLibros.OrderByDescending(libro => libro.Precio).First();
        return MasCaro;
    }

    public Libro GetMenorPrecio()
    {
        Libro MasBarato = ListaLibros.OrderBy(libro => libro.Precio).First();
        return MasBarato;
    }

    public List<Libro> GetMayorPromedio()
    {
        var libros = ListaLibros.Where(libro => libro.Precio > GetPromedioPrecios()).ToList();
        return libros;
    }

    public List<Libro> GetOrdenDescendente()
    {
        var ListaOrdenada = ListaLibros.OrderByDescending(libro => libro.Titulo).ToList();
        return ListaOrdenada;
    }

}
