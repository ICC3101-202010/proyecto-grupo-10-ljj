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
        public string GetName()
        {
            return name;
        }
        public void AddMovies(Movies movie)
        {
            movies.Add(movie);
        }
        public void TypeOfPrivacy(PlaylistMovies p, string privacy)
        {
            if (privacy == "publica" || privacy == "pública" || privacy == "privada")
            {
                this.privacy = privacy;
                Console.WriteLine("La lista " + p.GetName() + "ahora es " + privacy + "\n");
            }
            else
            {
                Console.WriteLine("ERROR. La privacidad ingresada no es válida.\n");
            }
        }
        public PlaylistMovies(string name, string privacy, List<Movies> movies)
        {
            this.name = name;
            this.privacy = privacy;
            this.movies = movies;
        }
    }
}
