using System;
using System.Collections.Generic;
using System.Text;

namespace entrega_2_proyecto
{
    class Album
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
