using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Gráfica_Entrega_3
{
    [Serializable]
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
        }
        public string getName()
        {
            return name;
        }
        public string showSongs()
        {
            string a = "";
            if (songs.Count != 0)
            {
                foreach(var song in songs)
                {
                    a += song.getName() + "\n";
                }
                return a;
            }
            else
            {
                return "Esta playlist aun no tiene canciones";
            }
        }
    }
}