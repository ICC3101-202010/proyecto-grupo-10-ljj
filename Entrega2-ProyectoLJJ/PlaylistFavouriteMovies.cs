using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2ProyectoLJJ
{
    public class PlaylistFavouriteMovies
    {
        private string name;
        private string privacy;
        private List<Movies> favourite;
        public void AddFavourite(Movies movie)
        {
            favourite.Add(movie);
        }
    }
}
