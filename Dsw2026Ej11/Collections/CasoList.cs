using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList<T> where T : Alumno
{
    private List<T> _alumnos = new List<T>();

    public void AgregarAlumno(T alumno)
    {
        _alumnos.Add(alumno);
    }

    public List<T> GetAlumnos()
    {
        return _alumnos;
    }

    public string BuscarAlumno(string nombre)
    {
        foreach (Alumno a in _alumnos)
        {
            if (a.Nombre == nombre)
            {
                return a.ToString();
            }
        }
        return "No existe";
    }

    public void EliminarAlumno(T alumno)
    {
        _alumnos.Remove(alumno);
    }

    public void ELiminarIndice(int i)
    {
        if (i < _alumnos.Count && i >= 0)
        {
            _alumnos.RemoveAt(i);
        }
    }
}

