using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using WMPLib;

namespace entrega_2_proyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Artist> l_artist = new List<Artist>();
            List<Album> l_album = new List<Album>();
            List<Songs> l_songs = new List<Songs>();
            List<PlaylistSongs> l_pl = new List<PlaylistSongs>();

            bool exec = true;
            while (exec)
            {
                // Pedimos al usuario una de las opciones
                string chosen = ShowOptions(new List<string>() { "Agregar artista", "agregar cancion", "agregar album", "crear playlist","calificar cancion", "salir" });
                switch (chosen)
                {
                    case "Agregar artista":
                        Console.Clear();
                        Console.WriteLine("diga el nombre del artista");
                        string name = Console.ReadLine();
                        Console.WriteLine("de la biografia del artista");
                        string bio = Console.ReadLine();
                        Console.WriteLine("diga el genero musical del artista");
                        string gender = Console.ReadLine();
                        Console.WriteLine("diga la edad del artista");
                        string age1 = Console.ReadLine();
                        int age = Int16.Parse(age1);
                        List<Album> Aalbums = new List<Album>();
                        List<Songs> Asongs = new List<Songs>();
                        Artist artist = new Artist(name, bio, gender, age, Aalbums, Asongs);
                        l_artist.Add(artist);
                        break;
                    case "agregar cancion":
                        Console.Clear();
                        Console.WriteLine("diga el genero de la cancion");
                        string Sgender = Console.ReadLine();
                        Console.WriteLine("diga el nombre de la cancion");
                        string Sname = Console.ReadLine();
                        Console.WriteLine("diga el artista de la cancion");
                        string Sartist = Console.ReadLine();
                        Console.WriteLine("diga el compositor de la cancion");
                        string Scomposer = Console.ReadLine();
                        Console.WriteLine("de la discografia de la cancion");
                        string Sdiscography = Console.ReadLine();
                        Console.WriteLine("de el studio de la cancion");
                        string Sstudio = Console.ReadLine();
                        Console.WriteLine("diga el año de lanzamiento de la cancion");
                        string year = Console.ReadLine();
                        int Syear = Int16.Parse(year);
                        Console.WriteLine("de la letra de la cancion");
                        string Slyrics = Console.ReadLine();
                        Console.WriteLine("diga la duracion de la cancion[en segundos]");
                        string duration = Console.ReadLine();
                        int Sduration = Int16.Parse(duration);
                        Console.WriteLine("diga si la cancion se puede descargar[si] o [no]");
                        string respuesta = Console.ReadLine();
                        if (respuesta == "si")
                        {
                            bool Sdownload = true;
                            Songs song = new Songs(Sgender, Sname, Sartist, Scomposer, Sdiscography, Sstudio, Syear, Slyrics, Sduration, Sdownload, false);
                            l_songs.Add(song);
                        }
                        if (respuesta == "no")
                        {
                            bool Sdownload = false;
                            Songs song = new Songs(Sgender, Sname, Sartist, Scomposer, Sdiscography, Sstudio, Syear, Slyrics, Sduration, Sdownload, false);
                            l_songs.Add(song);
                        }
                        break;
                    case "agregar album":
                        Console.Clear();
                        Console.WriteLine("diga el nombre del album");
                        string Aname = Console.ReadLine();
                        Console.WriteLine("diga el artista autor del album");
                        string Aart = Console.ReadLine();
                        Console.WriteLine("diga el año de lanzamiento del album");
                        string ayear = Console.ReadLine();
                        int Ayear = Int16.Parse(ayear);
                        Album album = new Album(Aname, Aart, Ayear);
                        l_album.Add(album);
                        break;
                    case "crear playlist":
                        Console.Clear();
                        Console.WriteLine("diga el nombre de la playlist");
                        string PLname = Console.ReadLine();
                        Console.WriteLine("diga la privacidad de la playlist[publica] o [privada]");
                        string PLprivacy = Console.ReadLine();
                        List<Songs> PLsongs = new List<Songs>();
                        PlaylistSongs playlist = new PlaylistSongs(PLname, PLprivacy, PLsongs);
                        l_pl.Add(playlist);
                        break;
                    case "salir":
                        exec = false;
                        break;
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
            //creamos playlist de favoritos
            Console.WriteLine("diga el nombre que quiera ponerle a su playlist de favoritos");
            string plfname = Console.ReadLine();
            Console.WriteLine("diga la privacidad de la playlist[publica] o [privada]");
            string plfprivacy = Console.ReadLine();
            List<Songs> songs = new List<Songs>();
            PlaylistFavouritesSongs playlistFavouritesSongs = new PlaylistFavouritesSongs(plfname, plfprivacy, songs);

            //creamos objeto de en cola
            List<Songs> Qsongs = new List<Songs>();
            QueueSongs queueSongs = new QueueSongs(Qsongs);

            //agregar albumes del artista al artista
            for (int i = 0; l_album.Count > i; i++)
            {
                for (int j = 0; l_artist.Count > j; j++)
                {
                    if (l_artist[j].getName() == l_album[i].getArtist())
                    {
                        l_artist[j].AddAlbums(l_album[i]);
                    }
                }
            }
            //agregar canciones del artista al artista
            for (int i = 0; l_songs.Count > i; i++)
            {
                for (int j = 0; l_artist.Count > j; j++)
                {
                    if (l_artist[j].getName() == l_songs[i].getArtist())
                    {
                        l_artist[j].AddSong(l_songs[i]);
                    }
                }
            }
            for (int j = 0; l_artist.Count > j; j++)
            {
                l_artist[j].ShowAlbums();
            }
            bool exec2 = true;
            while (exec2)
            {
                // Pedimos al usuario una de las opciones
                string chosen = ShowOptions(new List<string>() { "Buscar cancion", "Descargar cancion", "agregar cancion a playlist"
                            , "selccionar cancion como favorito", "agregar cancion a en cola","ver playlist","ver favoritos","ver en cola","reproducir cancion","Salir" });
                switch (chosen)
                {
                    case "Buscar cancion":
                        Console.Clear();
                        break;
                    case "Descargar cancion":
                        Console.Clear();
                        Console.WriteLine("diga el nombre de la cancion que quiera descargar");
                        string Dname = Console.ReadLine();
                        Console.WriteLine("diga el nombre del artista de la cancion");
                        string Dart = Console.ReadLine();
                        for (int i = 0; l_songs.Count > i; i++)
                        {
                            if (Dname == l_songs[i].getName() && Dart == l_songs[i].getArtist())
                            {
                                l_songs[i].Download();
                                break;
                            }
                        }
                        break;
                    case "agregar cancion a playlist":
                        Console.Clear();
                        Console.WriteLine("diga el nombre de la cancion que quiera agregar a una playlist");
                        string PLname = Console.ReadLine();
                        Console.WriteLine("diga el nombre del artista de la cancion");
                        string PLart = Console.ReadLine();
                        Console.WriteLine("diga el nombre de la playlist que quiere agregar");
                        string PLpl = Console.ReadLine();
                        for (int i = 0; l_songs.Count > i; i++)
                        {
                            if (PLname == l_songs[i].getName() && PLart == l_songs[i].getArtist())
                            {
                                for (int j = 0; l_pl.Count > j; j++)
                                {
                                    if (PLpl == l_pl[j].getName())
                                    {
                                        l_pl[j].AddSongs(l_songs[i]);
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                    case "selccionar cancion como favorito":
                        Console.Clear();
                        Console.WriteLine("diga el nombre de la cancion que quiera agregar a favoritos");
                        string Fname = Console.ReadLine();
                        Console.WriteLine("diga el nombre del artista de la cancion");
                        string Fart = Console.ReadLine();
                        for (int i = 0; l_songs.Count > i; i++)
                        {
                            if (Fname == l_songs[i].getName() && Fart == l_songs[i].getArtist())
                            {
                                playlistFavouritesSongs.AddFavourite(l_songs[i]);
                                l_songs[i].addFavourite();
                                break;
                            }
                        }
                        break;
                    case "agregar cancion a en cola":
                        Console.Clear();
                        Console.WriteLine("diga el nombre de la cancion que quiera agregar a en cola");
                        string Qname = Console.ReadLine();
                        Console.WriteLine("diga el nombre del artista de la cancion");
                        string Qart = Console.ReadLine();
                        for (int i = 0; l_songs.Count > i; i++)
                        {
                            if (Qname == l_songs[i].getName() && Qart == l_songs[i].getArtist())
                            {
                                queueSongs.AddSongs(l_songs[i]);
                                break;
                            }
                        }
                        Console.WriteLine("no se encontro la cancion");
                        break;
                    case "ver playlist":
                        Console.WriteLine("diga el nombre de la playlist que desea ver");
                        string plname = Console.ReadLine();
                        for (int i = 0; l_pl.Count > i; i++)
                        {
                            if (plname == l_pl[i].getName())
                            {
                                l_pl[i].showSongs();
                                break;
                            }
                        }
                        Console.WriteLine("no se encontro la playlist");
                        Console.Clear();
                        break;
                    case "ver favoritos":
                        Console.Clear();
                        playlistFavouritesSongs.showSongs();
                        break;
                    case "ver en cola":
                        Console.Clear();
                        queueSongs.showSongs();
                        break;
                    case "reproducir cancion":
                        Console.Clear();
                        Console.WriteLine("diga el nombre de la cancion que quiera escuchar");
                        string Rname = Console.ReadLine();
                        for (int i = 0; l_songs.Count > i; i++)
                        {
                            if (Rname == l_songs[i].getName())
                            {
                                l_songs[i].NumberOfUser();
                                bool exec3 = true;
                                while (exec3)
                                {
                                    WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                                    wmp.URL = l_songs[i] + ".wav";
                                    string chosen2 = ShowOptions(new List<string>() { "reproducir", "pausar","adelantar","retroceder","stop", "salir" });
                                    switch (chosen2)
                                    {


                                        case "repruducir":
                                            Console.Clear();
                                            wmp.controls.play();
                                            break;
                                        case "pausar":
                                            Console.Clear();
                                            wmp.controls.pause();            
                                            break;
                                        case "adelantar":
                                            Console.Clear();
                                            wmp.controls.fastForward();
                                            break;
                                        case "retroceder":
                                            Console.Clear();
                                            wmp.controls.fastReverse();
                                            break;
                                        case "stop":
                                            Console.Clear();
                                            wmp.controls.stop();
                                            break;
                                        case "salir":
                                            Console.Clear();
                                            exec3 = false;
                                            break;
                                    }
                                }
                            }
                        }
                        break;
                    case "Salir":
                        exec2 = false;
                        break;
                }
                Thread.Sleep(5000);
                Console.Clear();
            }
            Console.WriteLine(l_songs[0].getUsers());
        }

        private static string ShowOptions(List<string> options)
        {
            int i = 0;
            Console.WriteLine("\n\nSelecciona una opcion:");
            foreach (string option in options)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + option);
                i += 1;
            }
            return options[Convert.ToInt16(Console.ReadLine())];
        }
    }
       
}
