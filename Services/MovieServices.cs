using Trabajo_Practico_1.Models;

namespace Trabajo_Practico_1.Services;

public static class MovieService{
    static List<Movie> Movies { get; set; }

    static MovieService(){
        Movies = new List<Movie>
        {
            new Movie { Name = "ET, El extraterrestre", Code = "ET", Category = "Ciencia Ficcion", Minutes = 110, Review="Una pelicula fascinante, muy recomendable"},
            new Movie { Name = "El Club de la Pelea", Code = "CLP", Category = "Drama", Minutes = 130, Review="Excelente, una gran joya del cine!"},
            new Movie { Name = "El Secreto de sus Ojos", Code = "SDO", Category = "Drama", Minutes = 147, Review="De Argentina al mundo, ganadora del oscar, IMPRESIONANTE!!!"},
            new Movie { Name = "El Padrino", Code = "ELP", Category = "Drama", Minutes = 185, Review="Una obra maestra, cambio el cine absolutamente"},
            new Movie { Name = "El silencio de los Inocentes", Code = "SLI", Category = "Terror", Minutes = 180, Review="Gran pelicula de terror y excelentemente interpretada!!"},
            new Movie { Name = "Toy Story", Code = "TST", Category = "Animado", Minutes = 115, Review="Una de las mejores animaciones hechas en la historia!"},
            new Movie { Name = "Los Vengadores, La dinastia de Kang", Code = "LVG", Category = "Accion", Minutes = 160, Review="No estrenada, pero promete muchisimo"},
            new Movie { Name = "Rapidos y Furiosos", Code = "RYF", Category = "Accion", Minutes = 143, Review="La mejor saga de peliculas de accion del cine!"},
            new Movie { Name = "Casablanca", Code = "CSB", Category = "Drama", Minutes = 170,Review="Una joya del cine antiguo, del viejo Hollywood"},
            new Movie { Name = "Thor, Amor y Trueno", Code = "TAT", Category = "Superheroe", Minutes = 130, Review="Mi superheroe favorito!!"}
        };
    }

    public static List<Movie> GetAll() => Movies;
    
    public static void Add(Movie obj){
        if(obj == null){
            return;
        }
        Movies.Add(obj);
    }


public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());

   public static void Delete(string code)
{
    var movieToDelete= Get(code);
    if(movieToDelete !=null)
    {
        Movies.Remove(movieToDelete);
    }
}
}


