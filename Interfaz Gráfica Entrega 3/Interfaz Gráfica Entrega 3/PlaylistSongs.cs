using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Gráfica_Entrega_3
{
    public class PlaylistSongs
    {
        private string name;
        private string privacy;
        public List<Songs> songs = new List<Songs>();
        public PlaylistSongs(string name, string privacy, List<Songs> songs)
        {
            this.name = name;
            this.privacy = privacy;
            this.songs = songs;

        }
        public void AddSongs(Songs song)
        {
            songs.Add(song);
            Console.WriteLine("se añadio cancion: " + song.getName() + " a:" + name);
        }
        public string getName()
        {
            return name;
        }
        public void showSongs()
        {
            if (songs.Count != 0)
            {
                Console.WriteLine("las canciones de la playlist: " + name + "son:");
                for (int i = 0; i < songs.Count; i++)
                {
                    Console.WriteLine(songs[i].getName());
                }
            }
            else
            {
                Console.WriteLine("no se han añadido canciones a:" + name);
            }
        }
    }
}