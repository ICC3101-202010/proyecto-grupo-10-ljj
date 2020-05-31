using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Entrega2ProyectoLJJ
{
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
            Console.WriteLine("se añadio cancion: " + song.getName() + " a en cola");
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