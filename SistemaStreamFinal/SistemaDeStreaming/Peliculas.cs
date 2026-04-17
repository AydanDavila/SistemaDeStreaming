public class Peliculas : Contenido
{
    private string? _director;
    private string? _estudio;
    public Peliculas(string? titulo, string? genero, int duracionMinutos, string? descripcion, int id, int anioLanzamiento, string? categoria, string? director, string? estudio) : base(titulo, genero, duracionMinutos, descripcion, id, anioLanzamiento, categoria)
    {
        Director = director;
        Estudio = estudio;
    }

    public string? Director
    {
        get => _director;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El nombre del director no puede estar en blanco");
            }
            _director = value;
        }
    }
    public string? Estudio
    {
        get => _estudio;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El nombre del estudio no puede estar en blanco");
            }
            _estudio = value;
        }
    }
    /// <summary>
    /// Sobrescribe la representación visual para incluir los controles específicos de 
    /// reproducción y las opciones de navegación propias de este tipo de contenido.
    /// </summary>
    public override void Dibujar()
    {
        base.Dibujar();
        Console.WriteLine("\n [1] ▌▌ Pausar   [2] i Información    [3] «« Retroceder    [4] »» Adelantar     [0] ⏹️ Salir");
        Console.Write("\nElige una opción: ");
        Console.WriteLine("==================================================");
    }
}
