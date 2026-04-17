public class Documental : Contenido
{
    private string? _tematica;
    private string? _narrador;

    public Documental(string? titulo, string? genero, int duracionMinutos, string? descripcion, int id, int anioLanzamiento, string? categoria, string? tematica, string? narrador) : base(titulo, genero, duracionMinutos, descripcion, id, anioLanzamiento, categoria)
    {
        Tematica = tematica;
        Narrador = narrador;
    }

    public string? Tematica
    {
        get => _tematica;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Este campo no puede estar vacío");
            }
            _tematica = value;
        }
    }
    public string? Narrador
    {
        get => _narrador;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Este campo no puede estar vacío");
            }
            _narrador = value;
        }
    }

    /// <summary>
    /// Sobrescribe la representación visual para incluir los controles específicos de 
    /// reproducción y las opciones de navegación propias de este tipo de contenido.
    /// </summary>
    public override void Dibujar()
    {
        base.Dibujar();
        Console.WriteLine("\n [1] ▌▌ Pausar   [2] i Información    [3] «« Retroceder    [4] »» Adelantar    [0] ⏹️ Salir");
        Console.Write("\nElige una opción: ");
        Console.WriteLine("==================================================");
    }

}

