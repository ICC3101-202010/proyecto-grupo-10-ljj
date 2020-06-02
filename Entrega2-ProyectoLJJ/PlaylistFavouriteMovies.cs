using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2ProyectoLJJ
{
    public class PlaylistFavouriteMovies
    {
        private string namef;
        private string privacyf;
        private List<Movies> moviesf;
        public PlaylistFavouriteMovies(string namef, string privacyf, List<Movies> moviesf)
        {
            this.namef = namef;
            this.privacyf = privacyf;
            this.moviesf = moviesf;
        }
        public string GetName()
        {
            return namef;
        }
        public void AddFavourite(Movies movie)
        {
            moviesf.Add(movie);
            Console.WriteLine("se añadio cancion: " + movie.GetName() + " a favoritos");
        }
        public void showMovies()
        {
            if (moviesf.Count != 0)
            {
                Console.WriteLine("las peliculas de favoritos son:");
                for (int i = 0; i < moviesf.Count; i++)
                {
                    Console.WriteLine(moviesf[i].GetName());
                }
            }
            else
            {
                Console.WriteLine("no se han añadido peliculas a favoritos");
            }
        }
    }
}