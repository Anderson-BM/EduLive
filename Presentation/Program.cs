
using System;
using Business;
using DataAccess;

class Program
{
    static void Main(string[] args)
    {
        IClaseRepository claseRepository = new ClaseRepository();
        IClaseService claseService = new ClaseService(claseRepository);

        //  clase ejemplo
        var nuevaClase = new Clase
        {
            Id = 1,
            Nombre = "Clase de Matemáticas",
            Descripcion = "Clase online de Matemáticas para principiantes",
            Estudiantes = new List<Estudiante> { new Estudiante { Id = 1, Nombre = "Juan" } },
            Profesores = new List<Profesor> { new Profesor { Id = 1, Nombre = "Dr. Pérez" } }
        };

        claseService.CrearClase(nuevaClase);
        var clases = claseService.ObtenerClasesActivas();

        foreach (var clase in clases)
        {
            Console.WriteLine($"Clase: {clase.Nombre}, Profesor: {clase.Profesores[0].Nombre}");
        }
    }
}
