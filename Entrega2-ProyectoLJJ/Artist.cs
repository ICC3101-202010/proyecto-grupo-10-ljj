using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega2ProyectoLJJ
{
    class Artist
    {
        private string name;
        private string bio;
        private List<Album> albums = new List<Album>();
        private List<Songs> songs = new List<Songs>();
        private string gender;
        private int age;

        public Artist(string name, string bio, string gender, int age, List<Album> albums, List<Songs> songs)
        {
            this.name = name;
            this.bio = bio;
            this.gender = gender;
            this.age = age;
            this.albums = albums;
            this.songs = songs;

        }
        public void Information()
        {
            Console.WriteLine("nombre: " + name + "\n" + "biografia: " + bio + "\n" + "edad: "
                + age + "\n" + "genero musical: " + gender);
        }
        public void AddSong(Songs song)
        {
            songs.Add(song);
        }
        public void AddAlbums(Album album)
        {
            albums.Add(album);
        }
        public void ShowSongs()
        {
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i].getName());
            }
        }
        public void ShowAlbums()
        {
            for (int i = 0; i < albums.Count; i++)
            {
                Console.WriteLine(albums[i].getName());

            }
        }
        public string getName()
        {
            return name;
        }

    }
}