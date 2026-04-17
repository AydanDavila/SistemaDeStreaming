public class Series : Contenido
{
    private int _numTemporadas;
    private int _numEpisodios;

    public Series(string? titulo, string? genero, int duracionMinutos, string? descripcion, int id, int anioLanzamiento, string categoria, int numTemporadas, int numEpisodios) : base(titulo, genero, duracionMinutos, descripcion, id, anioLanzamiento, categoria)
    {
        NumTemporadas = numTemporadas;
        NumEpisodios = numEpisodios;
    }


    public int NumTemporadas
    {
        get => _numTemporadas;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Número de temporadas inválido");
            }
            _numTemporadas = value;
        }
    }
    public int NumEpisodios
    {
        get => _numEpisodios;
        set
        {
            if (value < 1)
            {

                throw new ArgumentOutOfRangeException("Cantidad de episodios inválida");
            }
            _numEpisodios = value;
        }
    }

    /// <summary>
    /// Sobrescribe la representación visual para incluir los controles específicos de 
    /// reproducción y las opciones de navegación propias de este tipo de contenido.
    /// </summary>
    public override void Dibujar()
    {
        base.Dibujar();
        Console.WriteLine("\n [1] ▌▌ Pausar    [2] i Información      [3] «« Retroceder    ");
        Console.WriteLine(" [4] »» Adelantar      [5] > Siguiente Capítulo     [6] < Capítulo anterior       [0] ⏹️ Salir");
        Console.Write("\nElige una opción: ");
        Console.WriteLine("==================================================");

    }
    
}

