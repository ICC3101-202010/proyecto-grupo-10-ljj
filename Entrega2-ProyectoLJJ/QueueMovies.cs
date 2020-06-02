using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2ProyectoLJJ
{
    public class QueueMovies
    {
        private List<Movies> movies;

        public QueueMovies(List<Movies> movies)
        {
            this.movies = movies;
        }

        public void AddMovies(Movies movie)
        {
            movies.Add(movie);
            Console.WriteLine("se añadio la pelicula : " + movie.GetName() + " a en cola");
        }
        public void ShowMovies()
        {
            if (movies.Count != 0)
            {
                Console.WriteLine("las peliculas en cola son: ");
                for (int i = 0; i < movies.Count; i++)
                {
                    Console.WriteLine(movies[i].GetName());
                }
            }
            else
            {
                Console.WriteLine("no se han añadido peliculas a la cola:");
            }
        }
    }
}