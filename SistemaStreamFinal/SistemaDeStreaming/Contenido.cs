public abstract class Contenido
{
    private string? _titulo;
    private string? _genero;
    private int _duracionMinutos;
    private string? _descripcion;
    private int _id;
    private int _anioLanzamiento;
    private const int AnioMinimo = 1920;
    private string? _categoria;


    protected Contenido(string? titulo, string? genero, int duracionMinutos, string? descripcion, int id, int anioLanzamiento, string? categoria)
    {
        Titulo = titulo;
        Genero = genero;
        DuracionMinutos = duracionMinutos;
        Descripcion = descripcion;
        Id = id;
        AnioLanzamiento = anioLanzamiento;
        Categoria = categoria;
    }

    public string? Titulo
    {
        get
        {
            return _titulo;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El título no puede estar vacío.");
            }
            _titulo = value;
        }
    }

    public string? Genero
    {
        get => _genero;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El género no puede estar vacío.");
            }
            _genero = value;
        }
    }
    public int DuracionMinutos
    {
        get { return _duracionMinutos; }
        set
        {
            if (value <= 5)
            {
                throw new ArgumentOutOfRangeException("La duración debe ser mayor a 5 minutos.");
            }
            _duracionMinutos = value;
        }
    }


    public string? Descripcion
    {
        get => _descripcion;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("La descripción no puede estar vacía.");
            }
            _descripcion = value;
        }

    }

    public int Id
    {
        get => _id;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "El ID no puede ser negativo");
            }
            _id = value;
        }

    }

    public int AnioLanzamiento
    {
        get => _anioLanzamiento;
        set
        {
            int AnioActual = DateTime.Now.Year;
            if (value < AnioMinimo || value > AnioActual)
            {
                throw new ArgumentOutOfRangeException($"El año de lanzamiento debe estar entre {AnioMinimo} y {AnioActual}");
            }
            _anioLanzamiento = value;
        }
    }

    public string? Categoria
    {
        get => _categoria;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"La categoria no puede estar vacio");
            }
            _categoria = value;
        }
    }

    /// <summary>
    /// Método virtual encargado de limpiar la pantalla y generar la estructura visual básica
    /// (encabezado) con el título del contenido actual.
    /// </summary>
    public virtual void Dibujar()
    {
        Console.Clear();
        Console.WriteLine("==================================================");
        Console.WriteLine($"| {Titulo ?? "Desconocido",-35} |");
        Console.WriteLine("==================================================");
    }

}