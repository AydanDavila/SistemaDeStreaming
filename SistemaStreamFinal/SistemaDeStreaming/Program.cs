try
{
	Usuario u1 = new Usuario("Pepe", "pepe12@gmail.com", "KASJHDHAIO", 1234, 19);
    Usuario u2 = new Usuario("Maria Lopez", "m.lopez@yahoo.com", "Password.2024", 5678, 25);
    Usuario u3 = new Usuario("Carlos Ruiz", "cruiz_1985@gmail.com", "Seguridad123", 9012, 21);

    Peliculas p1 = new Peliculas("Mil años de seriedad", "Thriller, Romance", 160, "Un hombre que vive mil años siendo serio.", 999564, 1985, "R16", "Fernando Sánchez", "Universal Studios");

	Series s1 = new Series("Stranger Things", "Ciencia Ficción", 50, "Un grupo de niños descubre sucesos paranormales.", 101, 2016, "PG-13", 4, 34);

    Documental d1 = new Documental( "Nuestro Planeta", "Naturaleza", 60, "Explora la belleza natural de nuestro mundo.", 202, 2019, "TP", "Naturaleza Global", "David Attenborough");

    SistemaNetflix Netflix = new SistemaNetflix();

    Netflix.Menu(p1, s1, d1, u1, u2, u3);
    


}
catch (ArgumentException ex)
{
	Console.WriteLine(ex.Message);
	
	
}
