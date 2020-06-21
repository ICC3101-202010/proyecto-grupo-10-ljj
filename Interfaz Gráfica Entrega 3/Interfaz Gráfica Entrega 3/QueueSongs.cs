using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Gráfica_Entrega_3
{
    [Serializable]
    public class QueueSongs
    {
        private List<Songs> songs = new List<Songs>();
        public QueueSongs(List<Songs> songs)
        {
            this.songs = songs;
        }
        public void AddSongs(Songs song)
        {
            songs.Add(song);
            
        }
        public void showSongs()
        {
            if (songs.Count != 0)
            {
                Console.WriteLine("las canciones en cola son: ");
                for (int i = 0; i < songs.Count; i++)
                {
                    Console.WriteLine(songs[i].getName());
                }
            }
            else
            {
                Console.WriteLine("no se han añadido en cola:");
            }
        }

    }

}