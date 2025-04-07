
public class ClaseRepository : IClaseRepository
{
    private List<Clase> clases = new List<Clase>();

    public void Guardar(Clase clase)
    {
        clases.Add(clase);
    }

    public List<Clase> ObtenerClases()
    {
        return clases;
    }
}
