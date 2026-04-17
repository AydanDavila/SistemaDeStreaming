public class Usuario
{
    private string? _nombre;
    private string? _email;
    private string? _contraseña;
    private int _pin;
    private int _edad;

    public Usuario(string? nombre, string? email, string? contraseña, int pin, int edad)
    {
        Nombre = nombre;
        Email = email;
        Contraseña = contraseña;
        Pin = pin;
        Edad = edad;
    }

    

public int Edad
{
    get => _edad;
    set
    {
        if (value < 18 || value > 120) 
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Edad no válida.");
        }
        _edad = value;
    }
}

    public string? Nombre
    {
        get { return _nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }
            _nombre = value;
        }
    }


    public string? Email
    {
        get { return _email; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El correo electrónico no puede estar vacío.");
            }
            _email = value;
        }
    }


    public string? Contraseña
    {

        get { return _contraseña; }
        set
        {

            if (string.IsNullOrWhiteSpace(value)||value.Contains(" "))
            {
                throw new ArgumentException("La contraseña no puede estar vacía o contener espacios.");
            }
            _contraseña = value;

        }
    }


    public int Pin
    {
        get
        {
            return _pin;
        }
        set
        {
            if (value.ToString().Count() != 4)
            {
                throw new ArgumentOutOfRangeException ("El PIN debe ser de 4 digitos.");
            }
            _pin = value;
        }
    }
}

