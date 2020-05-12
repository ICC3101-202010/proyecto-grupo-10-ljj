using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Movies_Entrega_2
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
