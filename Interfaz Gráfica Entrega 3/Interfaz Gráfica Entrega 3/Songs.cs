using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Gráfica_Entrega_3
{
    public class Songs
    {
        private string gender;
        private string name;
        private string artist;
        private string composer;
        private string studio;
        private int year;
        private string lyrics;
        private string duration;
        private int reproduction = 0;
        private int users = 0;
        private double qualification = 0;
        private int qualificationCount = 0;
        private bool favourite;
        private bool download;


        public Songs(string name, string artist, string composer, string gender, string studio, int year, string lyrics,
            string duration, bool download, bool favourite)
        {
            this.name = name;
            this.artist = artist;
            this.composer = composer;
            this.gender = gender;
            this.studio = studio;
            this.year = year;
            this.lyrics = lyrics;
            this.duration = duration;
            this.download = download;
            this.favourite = favourite;
        }

        public string getName()
        {
            return name;
        }
        public string getArtist()
        {
            return artist;
        }
        public void Download()
        {
            if (download == true)
            {
                Console.WriteLine("se ha descargado la cancion: " + name);
            }
            else
            {
                Console.WriteLine("la cancion: " + name + " no esta disponible para descargar");
            }
        }
        //public override void search()
        //{
        //    Console.WriteLine("las busquedas se estan implementando, en la suiguiente actualizacion estaran disponibles");
        //}
        public string getDuration()
        {
            return duration;
        }
        public void Reproduction()
        {
            reproduction = reproduction + 1;
        }
        public void NumberOfReproduction()
        {
            Console.WriteLine("esta cancion tiene: " + reproduction + " reproducciones");
        }
        public void addFavourite()
        {
            favourite = true;
        }
        public void NumberOfUser()
        {
            users = users + 1;
        }
        public int getUsers()
        {
            return users;
        }
        public void Qualification(int qualific)
        {
            qualificationCount = qualificationCount + 1;
            qualification = (qualification + qualific) / qualificationCount;
        }
        public string getGender()
        {
            return gender;
        }
        public string getCompose()
        {
            return composer;
        }
        public string getStudio()
        {
            return studio;
        }
        public string getLyrics()
        {
            return lyrics;
        }
        public int getYear()
        {
            return year;
        }
        public double getQualification()
        {
            return qualification;
        }
        public int getReproductions()
        {
            return reproduction;
        }

    }
}
