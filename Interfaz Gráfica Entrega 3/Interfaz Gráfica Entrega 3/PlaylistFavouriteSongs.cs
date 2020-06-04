using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Gráfica_Entrega_3
{
    public class PlaylistFavouritesSongs
    {
        private string name;
        private string privacy;
        private List<Songs> songs = new List<Songs>();
        public PlaylistFavouritesSongs(string name, string privacy, List<Songs> songs)
        {
            this.name = name;
            this.privacy = privacy;
            this.songs = songs;
        }
        public void AddFavourite(Songs song)
        {
            songs.Add(song);
            Console.WriteLine("se añadio cancion: " + song.getName() + " a favoritos");
        }
        public void showSongs()
        {
            if (songs.Count != 0)
            {
                Console.WriteLine("las canciones de favoritos son:");
                for (int i = 0; i < songs.Count; i++)
                {
                    Console.WriteLine(songs[i].getName());
                }
            }
            else
            {
                Console.WriteLine("no se han añadido canciones a favoritos");
            }
        }
    }
}