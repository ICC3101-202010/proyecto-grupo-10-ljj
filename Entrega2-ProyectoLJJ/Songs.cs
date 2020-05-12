using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Entrega2ProyectoLJJ
{
    class Songs : Controller
    {
        private string gender;
        private string name;
        private string artist;
        private string composer;
        private string discography;
        private string studio;
        private int year;
        private string lyrics;
        private int duration;
        private int reproduction;
        private int users = 0;
        private int qualification = 0;
        private int qualificationCount = 0;
        private bool favourite;
        private bool download;


        public Songs(string gender, string name, string artist, string composer, string discography, string studio, int year, string lyrics,
            int duration, bool download, bool favourite)
        {
            this.gender = gender;
            this.name = name;
            this.artist = artist;
            this.composer = composer;
            this.discography = discography;
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
        public override string Search()
        { 
            return "las busquedas se estan implementando, en la siguiente actualizacion estaran disponibles";
        }
        public void getDuration()
        {
            Console.WriteLine("la cancion:" + name + "/nduración: " + duration + " segundos");
        }
        public void Reproduction(int reproduction)
        {
            this.reproduction = reproduction;
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
        public int Qualification(int qualific)
        {
            qualificationCount = qualificationCount + 1;
            qualification = (qualification + qualific) / qualificationCount;
            return qualification;
        }
    }
}