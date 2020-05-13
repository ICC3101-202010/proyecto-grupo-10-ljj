using System;
using System.Threading;
using System.Collections.Generic;
using WMPLib;
namespace Entrega2ProyectoLJJ
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            User user = new User("", "", "");
            Profile profile = new Profile("", true);
            Dictionary<string, List<Profile>> Users = new Dictionary<string, List<Profile>>();
            Console.WriteLine("Bienvenido al nuevo Spotflix!");
            List<Artist> l_artist = new List<Artist>();
            List<Album> l_album = new List<Album>();
            List<Songs> l_songs = new List<Songs>();
            List<Movies> l_movies = new List<Movies>();
            List<PlaylistSongs> l_pl = new List<PlaylistSongs>();
            List<PlaylistMovies> l_pl1 = new List<PlaylistMovies>();
            List<string> movielist = new List<string>();
            List<List<string>> PL = new List<List<string>>();
            //creamos playlist de favoritos
            List<Songs> songs = new List<Songs>();
            PlaylistFavouritesSongs playlistFavouritesSongs = new PlaylistFavouritesSongs("favourite", "privada", songs);
            //creamos objeto de en cola
            List<Songs> Qsongs = new List<Songs>();
            QueueSongs queueSongs = new QueueSongs(Qsongs);
            bool exec = true;
            while (exec)
            {
                string chosen = ShowOptions(new List<string>() { "Crear Usuario", "Crear Perfil", "Modificar perfil", "Ver los perfiles por usuario", "Seguir", "Sugerencias inteligentes", "Unirme a una party", "Canciones", "Peliculas", "Salir" });
                switch (chosen)
                {
                    case "Crear Usuario":
                        Console.WriteLine("Ingrese mail:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Que plan desea para este usuario(premium o free)");
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
                        foreach (KeyValuePair<string, List<Profile>> a in Users)
                        {
                            if (a.Key == email2)
                            {
                                if (answer == "username")
                                {
                                    Console.WriteLine("Cual seria el nuevo username?");
                                    string username3 = Console.ReadLine();
                                    foreach (Profile b in a.Value)
                                    {
                                        b.ChangeUsername(username3);
                                    }
                                    Console.WriteLine("Se ha cambiado el username correctamente");
                                    Thread.Sleep(1000);

                                }
                                if (answer == "privacy")
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
                        foreach (string a in Users.Keys)
                        {
                            Console.WriteLine(a);
                            foreach (List<Profile> b in Users.Values)
                            {
                                foreach (Profile d in b)
                                {
                                    Console.WriteLine($"Username: {d.GetUserName()}, Privacidad: {d.GetPrivacy()}");
                                }
                            }
                        }
                        Thread.Sleep(2000);
                        break;
                    case "Seguir":
                        string chosen1 = ShowOptions(new List<string>() { "Seguir un perfil", "Seguir una playlist de canciones", "Seguir una playlist de peliculas", "Seguir un album", "Seguir un artista", "Seguir un actor" });
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
                        string chosen2 = ShowOptions(new List<string>() { "Sugerencias de Peliculas", "Sugerencias de Canciones" });
                        switch (chosen2)
                        {
                            case "Sugerencias de Peliculas":
                                Console.Clear();
                                Console.WriteLine("En base a lo que usted sigue y ha visto, esta es una lista de peliculas que podrian gustarle:");
                                foreach (string a in profile.SuggestionMovie())
                                {
                                    Console.WriteLine(a);
                                }
                                Thread.Sleep(2000);
                                break;
                            case "Sugerencias de Canciones":
                                Console.Clear();
                                Console.WriteLine("En base a lo que usted sigue y ha visto, esta es una lista de canciones que podrian gustarle:");
                                foreach (string a in profile.SuggestionSong())
                                {
                                    Console.WriteLine(a);
                                }
                                Thread.Sleep(2000);
                                break;
                        }
                        break;
                    case "Unirme a una party":
                        Console.Clear();
                        Console.WriteLine("A que usuario quiere unirse?");
                        string chosen3 = ShowOptions(new List<string>() { "Lucas", "Joaquin", "Jose Tomas" });
                        switch (chosen3)
                        {
                            case "Lucas":
                                Console.Clear();
                                Console.WriteLine("En estos momentos Lucas esta escuchando Coronao de El Alfa");
                                profile.JoinParty("El Alfa El Jefe x Lil Pump - Coronao Now (Video Oficial).wav");
                                Console.WriteLine("Si desea parar de escuchar escriba stop:");
                                string stop = Console.ReadLine();
                                if (stop == "stop")
                                {
                                    WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                                    wmp.controls.stop();
                                    break;
                                }
                                break;
                            case "Joaquin":
                                Console.Clear();
                                Console.WriteLine("En estos momentos Joaquin esta escuchando Coronao de El Alfa");
                                profile.JoinParty("El Alfa El Jefe x Lil Pump - Coronao Now (Video Oficial).wav");
                                Console.WriteLine("Si desea parar de escuchar escriba stop:");
                                string stop1 = Console.ReadLine();
                                if (stop1 == "stop")
                                {
                                    WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                                    wmp.controls.stop();
                                    break;
                                }
                                break;
                            case "Jose Tomas":
                                Console.Clear();
                                Console.WriteLine("En estos momentos Jose Tomas esta escuchando Coronao de El Alfa");
                                profile.JoinParty("El Alfa El Jefe x Lil Pump - Coronao Now (Video Oficial).wav");
                                Console.WriteLine("Si desea parar de escuchar escriba stop:");
                                string stop2 = Console.ReadLine();
                                if (stop2 == "stop")
                                {
                                    WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                                    wmp.controls.stop();
                                    break;
                                }
                                break;
                        }
                        break;
                    case "Canciones":
                        bool exec4 = true;
                        while (exec4)
                        {

                            string chosen5 = ShowOptions(new List<string>() { "Agregar artista", "agregar cancion", "agregar album", "crear playlist","calificar cancion",
                    "Buscar cancion", "Descargar cancion", "agregar cancion a playlist", "selccionar cancion como favorito",
                    "agregar cancion a en cola","ver playlist","ver favoritos","ver en cola","reproducir cancion", "salir" });
                            switch (chosen5)
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
                                    Console.WriteLine("diga el nombre de la cancion (recuerde que debe tener el mismo nombre que aparece en el archivo)");
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
                                        //agregar canciones del artista al artista
                                        for (int j = 0; l_artist.Count > j; j++)
                                        {
                                            if (l_artist[j].getName() == song.getArtist())
                                            {
                                                l_artist[j].AddSong(song);
                                            }
                                        }
                                    }
                                    if (respuesta == "no")
                                    {
                                        bool Sdownload = false;
                                        Songs song = new Songs(Sgender, Sname, Sartist, Scomposer, Sdiscography, Sstudio, Syear, Slyrics, Sduration, Sdownload, false);
                                        l_songs.Add(song);
                                        //agregar canciones del artista al artista
                                        for (int j = 0; l_artist.Count > j; j++)
                                        {
                                            if (l_artist[j].getName() == song.getArtist())
                                            {
                                                l_artist[j].AddSong(song);
                                            }
                                        }
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
                                    //agregar albumes del artista al artista
                                    for (int j = 0; l_artist.Count > j; j++)
                                    {
                                        if (l_artist[j].getName() == album.getArtist())
                                        {
                                            l_artist[j].AddAlbums(album);
                                        }
                                    }
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
                                case "calificar cancion":
                                    Console.Clear();
                                    Console.WriteLine("diga el nombre de la cancion");
                                    string caname = Console.ReadLine();
                                    Console.WriteLine("diga el artista de la cancion");
                                    string caart = Console.ReadLine();
                                    for (int i = 0; l_songs.Count > i; i++)
                                    {
                                        if (caname == l_songs[i].getName() && caart == l_songs[i].getArtist())
                                        {
                                            Console.WriteLine("de la calificacion");
                                            string cal = Console.ReadLine();
                                            int Cal = Int16.Parse(cal);
                                            l_songs[i].Qualification(Cal);
                                            break;
                                        }
                                    }
                                    break;
                                case "Buscar cancion":
                                    Console.Clear();
                                    l_songs[0].Search();
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
                                    string Plname = Console.ReadLine();
                                    Console.WriteLine("diga el nombre del artista de la cancion");
                                    string PLart = Console.ReadLine();
                                    Console.WriteLine("diga el nombre de la playlist que quiere agregar");
                                    string PLpl = Console.ReadLine();
                                    for (int i = 0; l_songs.Count > i; i++)
                                    {
                                        if (Plname == l_songs[i].getName() && PLart == l_songs[i].getArtist())
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
                                case "seleccionar cancion como favorito":
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
                                case "agregar cancion en cola":
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
                                    break;
                                case "ver playlist":
                                    Console.Clear();
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
                                            bool exec2 = true;
                                            while (exec2)
                                            {
                                                WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                                                wmp.URL = l_songs[i].getName() + ".wav";
                                                wmp.controls.play();
                                                string chosen7 = ShowOptions(new List<string>() { "pausar", "adelantar", "retroceder", "stop", "salir" });
                                                switch (chosen7)
                                                {
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
                                                        exec2 = false;
                                                        break;

                                                }
                                            }
                                        }
                                    }
                                    break;
                                case "salir":
                                    exec4 = false;
                                    break;
                            }
                        }
                        break;
                    case "Peliculas":
                        bool exec8 = true;
                        while (exec8)
                        {
                            string chosen6 = ShowOptions(new List<string>() {"Agregar película", "Reproducir película",
                    "Ver listado de películas", "Buscar películas por filtros", "Agregar películas a la cola", "Crear playlist",
                    "Crear playlist de favoritos","Ver playlist", "Salir de la plataforma" });
                            switch (chosen6)
                            {
                                case "Agregar película":
                                    List<string> l_categories = new List<string>();
                                    List<string> l_Aparticipation = new List<string>();
                                    List<Actor> l_actors = new List<Actor>();
                                    Console.WriteLine("Nombre de la apelícula:");
                                    string Mname = Console.ReadLine();
                                    Console.WriteLine("Categoría(s) a la(s) que pertenece:");
                                    string Mcategorie = Console.ReadLine();
                                    l_categories.Add(Mcategorie);
                                    Console.WriteLine("Ingrese más categorías si así lo desea (presione ENTER solamente para terminar");
                                    while (true)
                                    {
                                        string Mcategorie2 = Console.ReadLine();
                                        if (Mcategorie2 == "")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            l_categories.Add(Mcategorie2);
                                        }
                                    }
                                    Console.WriteLine("Género al que pertenece:");
                                    string Mgender = Console.ReadLine();
                                    Console.WriteLine("Actor(es) que participa(n) en la película:");
                                    Console.WriteLine("Nombre del actor:");
                                    string Aname = Console.ReadLine();
                                    Console.WriteLine("Breve biografía del actor:");
                                    string Abiography = Console.ReadLine();
                                    Console.WriteLine("Película(s) en las que ha participado:");
                                    string Amovie = Console.ReadLine();
                                    Console.WriteLine("Ingrese más películas en caso de ser necesario (presione ENTER solamente para terminar)");
                                    while (true)
                                    {
                                        string Amovie2 = Console.ReadLine();
                                        if (Amovie2 == "")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            l_Aparticipation.Add(Amovie2);
                                        }
                                    }
                                    Console.WriteLine("Género en el que trabaja el actor:");
                                    string Agender = Console.ReadLine();
                                    Console.WriteLine("Edad del actor:");
                                    int Aage = Convert.ToInt32(Console.ReadLine());
                                    Actor actor = new Actor(Aname, Abiography, l_Aparticipation, Agender, Aage);
                                    l_actors.Add(actor);
                                    Console.WriteLine("¿hay más actores en esta película? [si]/[no]");
                                    while (true)
                                    {
                                        string actor2 = Console.ReadLine();
                                        if (actor2 == "no")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nombre del actor:");
                                            string Aname2 = Console.ReadLine();
                                            Console.WriteLine("Breve biografía del actor:");
                                            string Abiography2 = Console.ReadLine();
                                            Console.WriteLine("Película(s) en las que ha participado:");
                                            string Amovie2 = Console.ReadLine();
                                            Console.WriteLine("Ingrese más películas en caso de ser necesario (presione ENTER solamente para terminar)");
                                            while (true)
                                            {
                                                string Amovie3 = Console.ReadLine();
                                                if (Amovie3 == "")
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    l_Aparticipation.Add(Amovie3);
                                                }
                                            }
                                            Console.WriteLine("Género en el que trabaja el actor:");
                                            string Agender2 = Console.ReadLine();
                                            Console.WriteLine("Edad del actor:");
                                            int Aage2 = Convert.ToInt32(Console.ReadLine());
                                            Actor Actor = new Actor(Aname, Abiography, l_Aparticipation, Agender, Aage);
                                            l_actors.Add(Actor);
                                        }
                                    }
                                    Console.WriteLine("Estudio que realizó la película:");
                                    string Mstudio = Console.ReadLine();
                                    Console.WriteLine("Año en que se terminó de producir la película:");
                                    int Myear = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Breve descripción de la película:");
                                    string Mdescription = Console.ReadLine();
                                    Console.WriteLine("Duración [en segundos] de la película:");
                                    int Mduration = Convert.ToInt32(Console.ReadLine());
                                    Movies pelicula = new Movies(Mname, l_categories, Mgender, l_actors, Mstudio, Myear, Mdescription, Mduration);
                                    l_movies.Add(pelicula);
                                    break;
                                case "Reproducir película":
                                    Console.WriteLine("Ingrese el nombre de la película (recuerde que la película debe tener el mismo nombre que el archivo multimedia de la carpeta Debug:");
                                    string mov = Console.ReadLine() + ".mp4";
                                    System.Diagnostics.Process.Start(mov);
                                    break;
                                case "Ver listado de películas":
                                    Console.WriteLine("Películas disponibles para ver:");
                                    foreach (Movies Movie in l_movies)
                                    {
                                        Console.WriteLine(Movie.GetName());
                                    }
                                    break;
                                case "Buscar películas por filtros":
                                    List<string> filter = new List<string>();
                                    Console.WriteLine("¿Qué filtro desea aplicar?");
                                    string choice = Movies.ShowOptions(new List<string>() { "Palabras clave", "Persona",
                        "Características de la persona", "Resolución", "Evaluación", "Categoría"});
                                    filter.Add(choice);
                                    while (true)
                                    {
                                        Console.WriteLine("¿desea aplicar otro filtro?");

                                        string choice2 = Movies.ShowOptions(new List<string>() { "Palabras clave", "Persona",
                            "Características de la persona", "Resolución", "Evaluación", "Categoría", "NO APLICAR MÁS FILTROS"});
                                        if (choice2 == "NO APLICAR MÁS FILTROS")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            filter.Add(choice2);
                                        }
                                    }
                                    Movies M = new Movies("name", filter, "gender", new List<Actor>(), "studio", 3, "description", 10);
                                    M.Search();
                                    break;
                                case "Agregar películas a la cola":
                                    List<string> queue = new List<string>();
                                    Console.WriteLine("¿Qué película desea agregar a la cola de reproducción?");
                                    string election = Console.ReadLine();
                                    while (true)
                                    {
                                        Console.WriteLine("¿Desea agregar otra película a la cola? presione solamente ENTER para terminar.");
                                        string election2 = Console.ReadLine();
                                        if (election2 == "")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            queue.Add(election2);
                                        }
                                    }
                                    break;
                                case "Crear playlist":
                                    Console.Clear();
                                    Console.WriteLine("diga el nombre de la playlist");
                                    string PLname1 = Console.ReadLine();
                                    Console.WriteLine("diga la privacidad de la playlist[publica] o [privada]");
                                    string PLprivacy1 = Console.ReadLine();
                                    List<Movies> PLmovies1 = new List<Movies>();
                                    PlaylistMovies playlist1 = new PlaylistMovies(PLname1, PLprivacy1, PLmovies1);
                                    l_pl1.Add(playlist1);
                                    break;
                                case "Crear playlist de favoritos":
                                    Console.WriteLine("Nombre de la playlist:");
                                    string namef = Console.ReadLine();
                                    Console.WriteLine("Privacidad de la playlist: pública/privada");
                                    string privacyf = Console.ReadLine();
                                    Console.WriteLine("Películas que desea agregar:");
                                    List<string> mf = new List<string>();
                                    while (true)
                                    {
                                        string respuesta = Console.ReadLine();
                                        if (respuesta == "")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            mf.Add(respuesta);
                                        }
                                    }
                                    break;
                                case "Ver playlist":
                                    Console.Clear();
                                    Console.WriteLine("diga el nombre de la playlist que desea ver");
                                    string plname = Console.ReadLine();
                                    for (int i = 0; l_pl1.Count > i; i++)
                                    {
                                        if (plname == l_pl1[i].GetName())
                                        {
                                            l_pl1[i].showMovies();
                                            break;
                                        }
                                    }
                                    break;
                                case "Salir Peliculas":
                                    exec8 = false;
                                    break;
                            }
                        }
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
        private static void SearchTo(string search)
        {

        }
    }
}