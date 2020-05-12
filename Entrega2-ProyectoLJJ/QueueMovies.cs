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
        public void AddMovies(Movies movie)
        {
            movies.Add(movie);
        }
    }
}
