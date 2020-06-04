using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Gráfica_Entrega_3
{
    public class Album
    {
        private string name;
        private string artist;
        private int year;
        private string image;

        public Album(string name, string artist, int year)
        {
            this.name = name;
            this.artist = artist;
            this.year = year;
        }
        public void addImage(string image)
        {
            this.image = image;
        }
        public string getArtist()
        {
            return artist;
        }
        public string getName()
        {
            return name;
        }

    }
}