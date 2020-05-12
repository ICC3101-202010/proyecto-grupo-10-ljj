using System;
using System.Threading;
using System.Collections.Generic;
using System.Media;
namespace Entrega2ProyectoLJJ
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            User user = new User("", "", "");
            Profile profile = new Profile("", true);
            Dictionary <string, List<Profile>> Users = new Dictionary<string, List<Profile>>();
            Console.WriteLine("Bienvenido al nuevo Spotflix!");
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\C90.wav";
            player.Load();
            player.Play();
            bool exec = true;
            while (exec)
            {
                
                string chosen = ShowOptions(new List<string>() { "Crear Usuario", "Crear Perfil", "Modificar perfil", "Ver los perfiles por usuario", "Seguir", "Sugerencias inteligentes", "Unirme a una party", "Salir" });
                switch (chosen)
                {
                    case "Crear Usuario":
                        Console.WriteLine("Ingrese mail:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Que plan desea para este usuario)(premium or free)");
                        string plan = Console.ReadLine();
                        Console.WriteLine("Ingrese contraseña:");
                        string password = Console.ReadLine();
                        Console.WriteLine("Creando User...");
                        Thread.Sleep(2000);
                        user.CreateUser(plan, email, password);
                        Console.Clear();
                        break;
                    case "Crear Perfil":
                        Console.WriteLine("A que usuario quiere añadirle un perfil?(responda con el mail del usuario)");
                        string email1 = Console.ReadLine();
                        Console.WriteLine("Cual sera el Username de este nuevo Profile?");
                        string username = Console.ReadLine();
                        Console.WriteLine("Sera un profile privado?(true or false)");
                        bool privacy = Convert.ToBoolean(Console.ReadLine());
                        int n = Users.Count;
                        if (n == 0)
                        {
                            user.CreateProfile(username, privacy);
                            Users.Add(email1, user.GetListOfProfiles());
                        }
                        if (n > 0)
                        {
                            foreach (KeyValuePair<string, List<Profile>> a in Users)
                            {
                                if (a.Key == email1)
                                {
                                    Profile profile1 = new Profile(username, privacy);
                                    a.Value.Add(profile1);
                                }
                            }
                            Console.WriteLine("Perfil creado con exito");
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "Modificar perfil":
                        Console.WriteLine("A que usuario desea modificarle un perfil?(responda con el mail del usuario)");
                        string email2 = Console.ReadLine();
                        Console.WriteLine("Que perfil desea modificar?");
                        string perfil1 = Console.ReadLine();
                        Console.WriteLine("Que desea modificar del perfil?(username or privacy)");
                        string answer = Console.ReadLine();
                        foreach(KeyValuePair<string, List<Profile>> a in Users)
                        {
                            if(a.Key == email2)
                            {
                                if(answer == "username")
                                {
                                    Console.WriteLine("Cual seria el nuevo username?");
                                    string username3 = Console.ReadLine();
                                    foreach(Profile b in a.Value)
                                    {
                                        b.ChangeUsername(username3);
                                    }
                                    Console.WriteLine("Se ha cambiado el username correctamente");
                                    Thread.Sleep(1000);
                              
                                }
                                if(answer == "privacy")
                                {
                                   
                                    Console.WriteLine("Desea que el perfil sea privado?(true or false)");
                                    bool privacy3 = Convert.ToBoolean(Console.ReadLine());
                                    foreach (Profile b in a.Value)
                                    {
                                        b.ChangePrivacy(privacy3);
                                    }
                                    Console.WriteLine("Se ha cambiado la privacidad correctamente");
                                    Thread.Sleep(1000);    
                                }
                            }
                        }
                        Console.Clear();
                        break;
                    case "Ver los perfiles por usuario":
                        Console.Clear();
                        foreach(string a in Users.Keys)
                        {
                            Console.WriteLine(a);
                            foreach(List<Profile> b in Users.Values)
                            {
                                foreach(Profile d in b)
                                {
                                    Console.WriteLine($"Username: {d.GetUserName()}, Privacidad: {d.GetPrivacy()}");
                                }
                            }
                        }
                        break;
                    case "Seguir":
                        string chosen1 = ShowOptions(new List<string>() { "Seguir un perfil", "Seguir una playlist de canciones", "Seguir una playlist de peliculas", "Seguir un album", "Seguir un artista", "Seguir un actor"});
                        switch (chosen1)
                        {
                            case "Seguir un perfil":
                                Console.WriteLine("Que perfil desea seguir?");
                                string perfil = Console.ReadLine();
                                profile.AddProfile(perfil);
                                Console.Clear();
                                break;
                            case "Seguir una playlist de canciones":
                                Console.WriteLine("Que playlist desea seguir?");
                                string playlistsong = Console.ReadLine();
                                profile.AddPlaylistSong(playlistsong);
                                Console.Clear();
                                break;
                            case "Seguir una playlist de peliculas":
                                Console.WriteLine("Que playlist desea seguir?");
                                string playlistmovie = Console.ReadLine();
                                profile.AddPlaylistMovie(playlistmovie);
                                Console.Clear();
                                break;
                            case "Seguir un album":
                                Console.WriteLine("Que album desea seguir?");
                                string album = Console.ReadLine();
                                profile.AddAlbum(album);
                                Console.Clear();
                                break;
                            case "Seguir un artista":
                                Console.WriteLine("Que artista desea seguir?");
                                string artist = Console.ReadLine();
                                profile.AddArtist(artist);
                                Console.Clear();
                                break;
                            case "Seguir un actor":
                                Console.WriteLine("Que artista desea seguir?");
                                string actor = Console.ReadLine();
                                profile.AddActor(actor);
                                Console.Clear();
                                break;
                        }
                        break;
                    case "Sugerencias inteligentes":
                        
                        Console.Clear();
                        break;
                    case "Unirme a una party":
                        Console.Clear();
                        break;
                    case "Salir":
                        exec = false;
                        break;
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
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