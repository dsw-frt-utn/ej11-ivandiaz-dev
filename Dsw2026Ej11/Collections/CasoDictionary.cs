using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary<T> where T : Alumno
{
    private Dictionary<int, T> _alumnos = new Dictionary<int, T>();

    public void AgregarAlumno(int legajo, T alumno)
    {
        _alumnos[legajo] = alumno;
    }

    public string BuscarAlumno(int legajo)
    {
        foreach (var alumno in _alumnos)
        {
            if (alumno.Key == legajo)
            {
                return alumno.Value.ToString();
            }
        }
        return "No existe";
    }

    public Dictionary<int, T> GetAlumnos()
    {
        return _alumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        foreach (var alumno in _alumnos)
        {
            if (alumno.Key == legajo)
            {
                _alumnos.Remove(legajo);
            }
        }
    }


}
