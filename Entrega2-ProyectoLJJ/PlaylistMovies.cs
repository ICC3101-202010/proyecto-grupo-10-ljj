using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2ProyectoLJJ
{
    public class PlaylistMovies
    {
        private string name;
        private string privacy;
        private List<Movies> movies;
        public PlaylistMovies(string name, string privacy, List<Movies> movies)
        {
            this.name = name;
            this.privacy = privacy;
            this.movies = movies;

        }
        public string GetName()
        {
            return name;
        }
        public void AddMovies(Movies movie)
        {
            movies.Add(movie);
            Console.WriteLine("se añadio la pelicula: " + movie.GetName() + " a favoritos");
        }
        public void showMovies()
        {
            if (movies.Count != 0)
            {
                Console.WriteLine("las peliculas de " + name + " son:");
                for (int i = 0; i < movies.Count; i++)
                {
                    Console.WriteLine(movies[i].GetName());
                }
            }
            else
            {
                Console.WriteLine("no se han añadido peliculas a " + name);
            }
        }
    }
}
