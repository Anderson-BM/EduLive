
public class ClaseService : IClaseService
{
    private IClaseRepository _claseRepository;

    public ClaseService(IClaseRepository claseRepository)
    {
        _claseRepository = claseRepository;
    }

    public void CrearClase(Clase clase)
    {
        _claseRepository.Guardar(clase);
    }

    public List<Clase> ObtenerClasesActivas()
    {
        return _claseRepository.ObtenerClases();
    }
}
