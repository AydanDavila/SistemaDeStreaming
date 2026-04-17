public class SistemaNetflix
{

    /// <summary>
    /// Orquesta el flujo de entrada al sistema, permitiendo la selección de un perfil de usuario
    /// y el acceso al catálogo principal de películas, series y documentales.
    /// </summary>
    public void Menu(Peliculas p1, Series s1, Documental d1, Usuario u1, Usuario u2, Usuario u3)
    {
        Console.Clear();
        Console.WriteLine("=============================================");
        Console.WriteLine("       ¿QUIÉN ESTÁ VIENDO AHORA?            ");
        Console.WriteLine("=============================================");
        Console.WriteLine("1. " + u1.Nombre);
        Console.WriteLine("2. " + u2.Nombre);
        Console.WriteLine("3. " + u3.Nombre);

        Usuario usuarioActual = u1;

        bool perfilValido = false;

        while (perfilValido == false)
        {
            Console.Write("\nSelecciona tu perfil (1, 2 o 3): ");
            string eleccionPerfil = Console.ReadLine();

            if (eleccionPerfil == "1")
            {
                usuarioActual = u1;
                perfilValido = true;
            }
            else if (eleccionPerfil == "2")
            {
                usuarioActual = u2;
                perfilValido = true;
            }
            else if (eleccionPerfil == "3")
            {
                usuarioActual = u3;
                perfilValido = true; 
            }
            else
            {
                Console.WriteLine("Opción inválida. Por favor ingrese un dato válido");
            }
        }

        Console.Clear();
        Console.WriteLine("=============================================");
        Console.WriteLine("      BIENVENIDO A SISTEMA NETFLIX           ");
        Console.WriteLine("=============================================");
        Console.WriteLine($"Usuario: {usuarioActual.Nombre}");
        Console.WriteLine("---------------------------------------------");

        Console.WriteLine("Seleccione el contenido que desea ver:");
        Console.WriteLine("1. Película");
        Console.WriteLine("2. Serie");
        Console.WriteLine("3. Documental");
        Console.WriteLine("0. Salir");

        int opc = 0;
        while (true)
        {
            try
            {
                opc = int.Parse(Console.ReadLine() ?? "0");
                if (opc >= 0 && opc <= 3) break;
                Console.WriteLine("Opción no válida (0-3).");
            }
            catch
            {
                Console.WriteLine("Entrada inválida. Ingrese un número.");
            }
        }

        if (opc == 0)
        {
            Salir();
            return;
        }


        Contenido tipoContenido = p1;
        if (opc == 1)
        {
            tipoContenido = p1;
        }
        else if (opc == 2)
        {
            tipoContenido = s1;
        }
        else if (opc == 3)
        {
            tipoContenido = d1;
        }
        else
        {
            tipoContenido = p1;
        }

        ControlDeReproduccion(tipoContenido);
    }

    private void ControlDeReproduccion(Contenido c)
    {
        bool Reproduciendose = true;

        while (Reproduciendose)
        {
            c.Dibujar();

            string? accion = Console.ReadLine();

            switch (accion)
            {
                case "1":
                    Pausar();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("========= INFORMACIÓN DETALLADA =========");
              
                    MostrarInfo(c);

                    if (c is Peliculas p)
                    {
                        Console.WriteLine($"Director: {p.Director}");
                        Console.WriteLine($"Estudio: {p.Estudio}");
                    }
                    else if (c is Series s)
                    {
                        Console.WriteLine($"Temporadas: {s.NumTemporadas}");
                        Console.WriteLine($"Episodios: {s.NumEpisodios}");
                    }
                    else if (c is Documental d)
                    {
                        Console.WriteLine($"Temática: {d.Tematica}");
                        Console.WriteLine($"Narrador: {d.Narrador}");
                    }

                    Console.WriteLine("==========================================");
                    Console.WriteLine("\nPresiona cualquier tecla para volver...");
                    Console.ReadKey();
                    c.Dibujar();
                    break;
                case "3":
                    Retroceder();
                    Console.ReadKey();
                    break;
                case "4":
                    Adelantar();
                    Console.ReadKey();
                    break;
                case "5":
                    if (c is Series) SiguienteCapitulo();
                    else Console.WriteLine("Opción no disponible para este contenido.");
                    Console.ReadKey();
                    break;
                case "6":
                    if (c is Series) CapituloAnterior();
                    else Console.WriteLine("Opción no disponible para este contenido.");
                    Console.ReadKey();
                    break;
                case "0":
                    Reproduciendose = false;
                    Salir();
                    break;
                default:
                    Console.WriteLine("Acción no reconocida.");
                    break;
            }
        }
    }

    /// <summary>
    /// Simula el inicio de la transmisión del flujo de video, enviando un mensaje visual 
    /// de reproducción a la interfaz de la consola.
    /// </summary>
    public void Reproducir() => Console.WriteLine("► Reproduciendo contenido...");

    /// <summary>
    /// Detiene temporalmente la visualización del contenido actual y notifica 
    /// el estado de pausa en pantalla.
    /// </summary>
    public void Pausar() => Console.WriteLine("▌▌ Contenido pausado.");

    /// <summary>
    /// Simula el desplazamiento hacia adelante en la línea de tiempo del contenido.
    /// </summary>
    public void Adelantar() => Console.WriteLine("»» Adelantando 10 segundos...");

    /// <summary>
    /// Simula el desplazamiento hacia atrás en la línea de tiempo del contenido.
    /// </summary>
    public void Retroceder() => Console.WriteLine("«« Retrocediendo 10 segundos...");

    /// <summary>
    /// Gestiona la transición al siguiente episodio, funcionalidad específica para el objeto de tipo Series.
    /// </summary>
    public void SiguienteCapitulo() => Console.WriteLine("> Cargando siguiente capítulo...");

    /// <summary>
    /// Gestiona el regreso al episodio anterior, funcionalidad específica para el objeto de tipo Series.
    /// </summary>
    public void CapituloAnterior() => Console.WriteLine("< Regresando al capítulo anterior...");

    /// <summary>
    /// Finaliza la ejecución del sistema y muestra un mensaje de cierre al usuario.
    /// </summary>
    public void Salir()
    {
        Console.WriteLine("Gracias por usar el Sistema de Streaming.");
    }
    /// <summary>
    /// Imprime en la consola la información general y técnica completa del contenido seleccionado,
    /// incluyendo título, categoría, año, género y descripción.
    /// </summary>
    public void MostrarInfo(Contenido contenido)

    {
        Console.WriteLine("========= Información =========");
        Console.WriteLine($"Título: {contenido.Titulo}");
        Console.WriteLine($"Categoría: {contenido.Categoria}");
        Console.WriteLine($"Año: {contenido.AnioLanzamiento}");
        Console.WriteLine($"Género: {contenido.Genero}");
        
        Console.WriteLine($"Descripción: {contenido.Descripcion}");
    }
}

