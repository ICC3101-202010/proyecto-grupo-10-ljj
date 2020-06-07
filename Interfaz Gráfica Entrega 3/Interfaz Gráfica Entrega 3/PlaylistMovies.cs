using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Gráfica_Entrega_3
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
        }
        public string showSongs()
        {
            string a = "";
            if (movies.Count != 0)
            {
                foreach (var movie in movies)
                {
                    a += movie.GetName() + "\n";
                }
                return a;
            }
            else
            {
                return "Esta playlist aun no tiene peliculas";
            }
        }
    }
}
