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
            //REQUISITOS CANCIONES
            List<Artist> l_artist = new List<Artist>();
            List<Album> l_album = new List<Album>();
            List<Songs> l_songs = new List<Songs>();
            List<PlaylistSongs> l_pl = new List<PlaylistSongs>();
            // CANCIONES!!!
            Songs CiudadDeLaFuria = new Songs("Ciudad de la furia", "Soda stereo", "Gustavo Cerati", "Rock", "desconocido", 1988, "letra jeje", "5:46", true, false);
            Songs MelonVino = new Songs("Melon vino", "Wos", "Wos", "Rap", "desconocido", 2019, "letra jeje", "3:03", true, false);
            Songs LetItBe = new Songs("Let It Be", "The Beatles", "Paul McCartney", "Rock", "desconocido", 1970, "letra jeje", "4:04", false, false);
            l_songs.Add(CiudadDeLaFuria);
            l_songs.Add(MelonVino);
            l_songs.Add(LetItBe);
            // ALBUMS!!!
            Album DobleVida = new Album("Doble vida", "Soda stereo", 1988);
            Album Caravana = new Album("Caravana", "Wos", 2019);
            Album Letitbe = new Album("Let it be", "The Beatles", 1970);
            l_album.Add(DobleVida);
            l_album.Add(Caravana);
            l_album.Add(Letitbe);
            // ARTISTAS!!!
            List<Album> Aalbums = new List<Album>();
            List<Songs> Asongs = new List<Songs>();
            Asongs.Add(CiudadDeLaFuria);
            Aalbums.Add(DobleVida);
            Artist SodaStereo = new Artist("Soda stereo", "Soda Stereo fue una banda argentina de rock formada en Buenos Aires en 1982\n por Gustavo Cerati, Héctor «Zeta» Bosio y Carlos Alberto Ficicchia «Charly Alberti»,\n considerada como la más exitosa, popular, influyente e importante de las bandas en español\n de todos los tiempos y una leyenda de la música latina.", "Rock", 38, Aalbums, Asongs);
            List<Album> Balbums = new List<Album>();
            List<Songs> Bsongs = new List<Songs>();
            Bsongs.Add(MelonVino);
            Balbums.Add(Caravana);
            Artist Wos = new Artist("Wos", "Valentín Oliva, conocido artísticamente como Wos,\n es un rapero y freestyler argentino.", "Rap", 22, Balbums, Bsongs);
            List<Album> Calbums = new List<Album>();
            List<Songs> Csongs = new List<Songs>();
            Csongs.Add(LetItBe);
            Calbums.Add(Letitbe);
            Artist TheBeatles = new Artist("The Beatles", "The Beatles fue una banda de rock inglesa activa durante la década de 1960,\n y reconocida como la más exitosa comercialmente y la más alabada\n por la crítica en la historia de la música popular y de la música rock.", "Rock", 63, Calbums, Csongs);
            l_artist.Add(SodaStereo);
            l_artist.Add(Wos);
            l_artist.Add(TheBeatles);
            //creamos playlist de favoritos
            List<Songs> songs = new List<Songs>();
            PlaylistFavouritesSongs playlistFavouritesSongs = new PlaylistFavouritesSongs("favoritos", "privada", songs);
            //creamos objeto de en cola
            List<Songs> Qsongs = new List<Songs>();
            QueueSongs queueSongs = new QueueSongs(Qsongs);
            //REQUISITOS MOVIES
            List<Movies> movielist = new List<Movies>();
            List<PlaylistMovies> PL = new List<PlaylistMovies>();
            List<Actor> actors = new List<Actor>();
            //PARTICIPACIÓN DE ACTORES
            List<string> DonaldGloverP = new List<string>();
            List<string> BeyonceP = new List<string>();
            List<string> ScarlettJohannsonP = new List<string>();
            List<string> RobertDownleyP = new List<string>();
            List<string> FlorencePughP = new List<string>();
            DonaldGloverP.Add("Community");
            DonaldGloverP.Add("30 Rock");
            DonaldGloverP.Add("Atlanta");
            BeyonceP.Add("The Pink Panther");
            BeyonceP.Add("Obsessed");
            ScarlettJohannsonP.Add("The Horse Whisperer");
            ScarlettJohannsonP.Add("Lost in Translation");
            ScarlettJohannsonP.Add("Girl with a Pearl Earring");
            RobertDownleyP.Add("Wonder Boys");
            RobertDownleyP.Add("Iron Man");
            FlorencePughP.Add("The Falling");
            FlorencePughP.Add("Lady Macbeth");
            //CATEGORÍAS DE PELÍCULAS
            List<string> categoriesL = new List<string>();
            List<string> categoriesA = new List<string>();
            List<string> categoriesB = new List<string>();
            categoriesL.Add("Musical");
            categoriesL.Add("Animación");
            categoriesA.Add("Superhéroes");
            categoriesA.Add("Acción");
            categoriesA.Add("Ciencia Ficción");
            categoriesB.Add("Cine de superhéroes");
            categoriesB.Add("Acción");
            categoriesB.Add("Aventuras");
            //ACTORES
            Actor DonaldGlover = new Actor("Donald Glover", "Actor, cantante, guionista, director de TV, comediante estadounidense", DonaldGloverP, "Hombre", 36);
            Actor Beyonce = new Actor("Beyonce", "Cantante, compositora, bailarina, actriz, modelo", BeyonceP, "Mujer", 38);
            Actor ScarlettJohansson = new Actor("Scarlett Johannson", "Actriz de cine, cantante, modelo estadounidense", ScarlettJohannsonP, "Mujer", 35);
            Actor RobertDownley = new Actor("Robert Downley Jr.", "Actor, productor, cantante estadounidense", RobertDownleyP, "Hombre", 55);
            Actor FlorencePugh = new Actor("Florence Pugh", "Actriz", FlorencePughP, "Mujer", 24);
            List<Actor> actorsL = new List<Actor>();
            List<Actor> actorsA = new List<Actor>();
            List<Actor> actorsB = new List<Actor>();
            actorsL.Add(DonaldGlover);
            actorsL.Add(Beyonce);
            actorsA.Add(ScarlettJohansson);
            actorsA.Add(RobertDownley);
            actorsB.Add(ScarlettJohansson);
            actors.Add(FlorencePugh);
            actors.Add(DonaldGlover);
            actors.Add(Beyonce);
            actors.Add(ScarlettJohansson);
            actors.Add(RobertDownley);
            actors.Add(FlorencePugh);
            //PELÍCULAS
            Movies TheLionKing = new Movies("The Lion King", categoriesL, actorsL, "Walt Disney Pictures", 2019, "En la Roca del Rey, el rey Mufasa y la reina Sarabi presentan a su hijo recién nacido, Simba, a sus súbditos.Después de la ceremonia, el hermano menor de Mufasa, Scar, se lamenta de que ya no está en la segunda fila para el trono.El mayordomo de Mufasa, Zazú, llega al lugar, anunciando la llegada del rey.Scar intenta comerse a Zazú, pero se ve frustrado por la llegada de Mufasa, quien le pregunta a Scar por qué estuvo ausente en la presentación de Simba, a la que Scar finge habérsele olvidado.Los hermanos tienen una breve discusión, en la que Scar socava la autoridad de Mufasa, pero deja en claro que no desafiará el liderazgo del rey.Eventualmente, Scar se retira del lugar y Zazú le sugiere a Mufasa que por qué no lo exilia del reino antes de que cause problemas, pero Mufasa se niega a hacer tal cosa, ya que Scar es su hermano.", 108);
            Movies AvengersEndgame = new Movies("Avengers: Endgame", categoriesA, actorsA, "Marvel Studios", 2019, "Veintitrés días después de que Thanos hubiera usado el Guantelete del Infinito para desintegrar la mitad de toda la vida en el universo, Capitana Marvel rescata a Tony Stark y Nebula, quienes estaban varados en el espacio exterior en la nave Milano I del fallecido Quill y los lleva de regreso a la Tierra hasta el complejo de Los Vengadores, donde los esperan Natasha Romanoff, Bruce Banner, Steve Rogers, Rocket Raccoon, Thor, Pepper Potts y James Rhodes.Mientras estabilizan a Stark y lo ponen al corriente sobre los eventos que sucedieron mientras estuvo en el espacio exterior, el resto de Los Vengadores localizan por medio de Nebula a un Thanos malherido en un planeta al que este llama 'El Jardín' y deciden ir en su búsqueda con el objetivo de recuperar las Gemas del Infinito y revertir los efectos del chasquido.Consiguen reducirlo pero descubren que las gemas ya no están.Thanos revela que destruyó las gemas para evitar que fueran usadas nuevamente.Thor, enfurecido, lo decapita con la Stormbreaker.", 146);
            Movies BlackWidow = new Movies("Black Widow", categoriesB, actorsB, "Marvel Studios", 2019, "Situada 1 año después de los sucesos de Capitán América: Civil War y antes de Avengers: Infinity War, Natasha Romanoff se encuentra sola y obligada a enfrentar una peligrosa conspiración con lazos con su pasado mientras es buscada por la ley.Perseguida por una fuerza que no se detendrá ante nada para derribarla, Romanoff debe lidiar con su historia como espía y las relaciones rotas que dejó a su paso mucho antes de convertirse en Vengadora.", 144);
            int asw = 0;
            bool exec10 = true;
            while (exec10)
            {
                string chosen10 = ShowOptions(new List<string>() { "Iniciar sesion", "Iniciar sesion como administrador", "Administracion de Cuentas", "Salir"});
                switch (chosen10)
                {
                    case "Iniciar sesion":
                        if (user.GetListOfUser().Count > 0)
                        {
                            Console.WriteLine("Ingrese mail:");
                            string email22 = Console.ReadLine();
                            Console.WriteLine("Ingrese contraseña:");
                            string password22 = Console.ReadLine();
                            foreach (User u in user.GetListOfUser())
                            {
                                if (email22 == u.GetEmail() && password22 == u.GetPassword())
                                {
                                    asw = 1;
                                    Console.WriteLine($"Bienvenido {email22}!");
                                    Console.WriteLine($"Cual perfil desearia utilizar: (Responda con el nombre del perfil)");
                                    foreach(KeyValuePair<string, List<Profile>> h in Users)
                                    {
                                        if(h.Key == email22)
                                        {
                                            foreach(Profile profile2 in h.Value)
                                            {
                                                Console.WriteLine(profile2.GetUserName());
                                            }
                                        }
                                    }
                                    string asw5 = Console.ReadLine();
                                    int number1 = 0;
                                    foreach (KeyValuePair<string, List<Profile>> h in Users)
                                    {
                                        foreach(Profile profile3 in h.Value)
                                        {
                                            if (profile3.GetUserName() == asw5)
                                            {
                                                number1 = 1;
                                                Console.WriteLine($"Bienvenido {asw5}! Que desea hacer?");
                                                Thread.Sleep(2000);
                                                break;
                                            }
                                        }
                                    }
                                    if(number1 == 0)
                                    {
                                        Console.WriteLine("Perfil no valido.");
                                        Thread.Sleep(2000);
                                        break;
                                    }
                                    bool exec = true;
                                    while (exec)
                                    {
                                        string chosen = ShowOptions(new List<string>() { "Seguir", "Sugerencias inteligentes", "Unirme a una party", "Canciones", "Peliculas", "Salir" });
                                        switch (chosen)
                                        {
                                            case "Seguir":
                                                string chosen1 = ShowOptions(new List<string>() { "Seguir un perfil", "Seguir una playlist de canciones", "Seguir una playlist de peliculas", "Seguir un album", "Seguir un artista", "Seguir un actor" });
                                                switch (chosen1)
                                                {
                                                    case "Seguir un perfil":
                                                        Console.WriteLine("Que perfil desea seguir?");
                                                        string perfil = Console.ReadLine();
                                                        int e = 0;
                                                        foreach (KeyValuePair<string, List<Profile>> h in Users)
                                                        {
                                                            foreach (Profile l in h.Value)
                                                            {
                                                                if (l.GetUserName() == perfil)
                                                                {
                                                                    e = 1;
                                                                    profile.AddProfile(l);
                                                                    Console.WriteLine("Perfil seguido con exito");
                                                                    Thread.Sleep(2000);
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        if (e == 0)
                                                        {
                                                            Console.WriteLine("El perfil que desea seguir no existe");
                                                            Thread.Sleep(2000);
                                                        }
                                                        Console.Clear();
                                                        break;
                                                    case "Seguir una playlist de canciones":
                                                        Console.WriteLine("Que playlist desea seguir?");
                                                        string playlistsong = Console.ReadLine();
                                                        int d = 0;
                                                        foreach (PlaylistSongs playlistSongs in l_pl)
                                                        {
                                                            if (playlistSongs.getName() == playlistsong)
                                                            {
                                                                d = 1;
                                                                profile.AddPlaylistSong(playlistSongs);
                                                                Console.WriteLine("Playlist de canciones seguida con exito");
                                                                Thread.Sleep(2000);
                                                                break;
                                                            }
                                                        }
                                                        if (d == 0)
                                                        {
                                                            Console.WriteLine("La playlist que desea seguir no existe");
                                                            Thread.Sleep(2000);
                                                        }
                                                        Console.Clear();
                                                        break;
                                                    case "Seguir una playlist de peliculas":
                                                        Console.WriteLine("Que playlist desea seguir?");
                                                        string playlistmovie = Console.ReadLine();
                                                        int f = 0;
                                                        foreach (PlaylistMovies playlistMovies in PL)
                                                        {
                                                            if (playlistMovies.GetName() == playlistmovie)
                                                            {
                                                                f = 1;
                                                                profile.AddPlaylistMovie(playlistMovies);
                                                                Console.WriteLine("Playlist de peliculas seguida con exito");
                                                                Thread.Sleep(2000);
                                                                break;
                                                            }

                                                        }
                                                        if (f == 0)
                                                        {
                                                            Console.WriteLine("La playlist que desea seguir no existe");
                                                            Thread.Sleep(2000);
                                                        }
                                                        Console.Clear();
                                                        break;
                                                    case "Seguir un album":
                                                        Console.WriteLine("Que album desea seguir?");
                                                        string album = Console.ReadLine();
                                                        int c = 0;
                                                        foreach (Album album1 in l_album)
                                                        {
                                                            if (album1.getName() == album)
                                                            {
                                                                c = 1;
                                                                profile.AddAlbum(album1);
                                                                Console.WriteLine("Album seguido con exito");
                                                                Thread.Sleep(2000);
                                                                break;
                                                            }
                                                        }
                                                        if (c == 0)
                                                        {
                                                            Console.WriteLine("El Album que desea seguir no existe");
                                                            Thread.Sleep(2000);
                                                        }
                                                        Console.Clear();
                                                        break;
                                                    case "Seguir un artista":
                                                        Console.WriteLine("Que artista desea seguir?");
                                                        string artist = Console.ReadLine();
                                                        int a = 0;
                                                        foreach (Artist artist1 in l_artist)
                                                        {
                                                            if (artist1.getName() == artist)
                                                            {
                                                                a = 1;
                                                                profile.AddArtist(artist1);
                                                                Console.WriteLine("Artista seguido con exito");
                                                                Thread.Sleep(2000);
                                                                break;
                                                            }
                                                        }
                                                        if (a == 0)
                                                        {
                                                            Console.WriteLine("El artista que desea seguir no existe");
                                                            Thread.Sleep(2000);
                                                        }
                                                        Console.Clear();
                                                        break;
                                                    case "Seguir un actor":
                                                        Console.WriteLine("Que artista desea seguir?");
                                                        string actor = Console.ReadLine();
                                                        int b = 0;
                                                        foreach (Actor actor2 in actors)
                                                        {
                                                           if (actor2.GetName() == actor)
                                                           {
                                                                b = 1;
                                                                profile.AddActor(actor2);
                                                                Console.WriteLine("Actor seguido con exito");
                                                                Thread.Sleep(2000);
                                                                break;
                                                           }
                                                        }
                                                        if (b == 0)
                                                        {
                                                            Console.WriteLine("El Actor que desea seguir no existe");
                                                            Thread.Sleep(2000);
                                                        }
                                                        Console.Clear();
                                                        break;
                                                }
                                                break;
                                            case "Sugerencias inteligentes":
                                                string chosen2 = ShowOptions(new List<string>() {"Sugerencias de Peliculas", "Sugerencias de Canciones"});
                                                switch (chosen2)
                                                {
                                                    case "Sugerencias de Peliculas":
                                                        Console.Clear();
                                                        Console.WriteLine("En base a lo que usted sigue y ha visto, esta es una lista de peliculas que podrian gustarle:");
                                                        foreach (KeyValuePair<string, List<Profile>> h in Users)
                                                        {
                                                            foreach (Profile profile3 in h.Value)
                                                            {
                                                                if (profile3.GetUserName() == asw5)
                                                                {
                                                                    Console.WriteLine(profile.SuggestionMovie());
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        
                                                        Thread.Sleep(4000);
                                                        break;
                                                    case "Sugerencias de Canciones":
                                                        Console.Clear();
                                                        Console.WriteLine("En base a lo que usted sigue y ha visto, esta es una lista de canciones que podrian gustarle:");
                                                        foreach (KeyValuePair<string, List<Profile>> h in Users)
                                                        {
                                                            foreach (Profile profile3 in h.Value)
                                                            {
                                                                if (profile3.GetUserName() == asw5)
                                                                {
                                                                    Console.WriteLine(profile3.SuggestionSong());
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        Thread.Sleep(4000);
                                                        break;
                                                }
                                                break;
                                            case "Unirme a una party":
                                                Console.Clear();
                                                Console.WriteLine("Quiere unirse a una party de peliculas o canciones?(responda peliculas o canciones)");
                                                string answer12 = Console.ReadLine();
                                                if (answer12 == "canciones")
                                                {
                                                    List<string> nombresprofiles = new List<string>();
                                                    int t = 1;
                                                    if (profile.GetFollowProfiles().Count > 0)
                                                    {
                                                        foreach (Profile f in profile.GetFollowProfiles())
                                                        {
                                                            nombresprofiles.Add(f.GetUserName());
                                                        }
                                                        Console.WriteLine("A que usuario quiere unirse? (Responda con su username)");
                                                        foreach (string y in nombresprofiles)
                                                        {
                                                            Console.WriteLine($"({t}) {y}");
                                                            t += 1;
                                                        }
                                                        string answer11 = Console.ReadLine();
                                                        if (nombresprofiles.Contains(answer11))
                                                        {
                                                            Console.WriteLine($"En estos momentos {answer11} esta escuchando Coronao de El Alfa");
                                                            profile.JoinPartySong("El Alfa El Jefe x Lil Pump - Coronao Now (Video Oficial).wav");
                                                            Console.WriteLine("Si desea parar de escuchar escriba stop:");
                                                            string stop = Console.ReadLine();
                                                            if (stop == "stop")
                                                            {
                                                                WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                                                                wmp.controls.pause();
                                                                break;
                                                            }
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Usuario invalido");
                                                            Thread.Sleep(2000);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Usted no sigue a ningun usuario para poder utilizar esta funcion.");
                                                        Thread.Sleep(2000);
                                                    }
                                                }
                                                if (answer12 == "peliculas")
                                                {
                                                    List<string> nombresprofiles = new List<string>();
                                                    int t = 1;
                                                    if (profile.GetFollowProfiles().Count > 0)
                                                    {
                                                        foreach (Profile f in profile.GetFollowProfiles())
                                                        {
                                                            nombresprofiles.Add(f.GetUserName());
                                                        }
                                                        Console.WriteLine("A que usuario quiere unirse? (Responda con su username)");
                                                        foreach (string y in nombresprofiles)
                                                        {
                                                            Console.WriteLine($"({t}) {y}");
                                                            t += 1;
                                                        }
                                                        string answer11 = Console.ReadLine();
                                                        if (nombresprofiles.Contains(answer11))
                                                        {
                                                            Console.WriteLine($"En estos momentos {answer11} esta viendo tarzan");
                                                            profile.JoinPartyMovie("tarzan-trailer");
                                                            Console.WriteLine("Si desea parar de ver cierre la ventana y luego escriba stop");
                                                            string stop = Console.ReadLine();
                                                            if (stop == "stop")
                                                            {
                                                                break;
                                                            }
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Usuario invalido");
                                                            Thread.Sleep(2000);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Usted no sigue a ningun usuario para poder utilizar esta funcion.");
                                                        Thread.Sleep(2000);
                                                    }

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Respuesta invalida");
                                                }
                                                break;
                                            case "Canciones":
                                                bool exec4 = true;
                                                while (exec4)
                                                {
                                                    // Pedimos al usuario una de las opciones
                                                    string chosen5 = ShowOptions(new List<string>() { "crear playlist","calificar cancion",
                    "Buscar cancion", "Descargar cancion", "agregar cancion a playlist", "selccionar cancion como favorito",
                    "agregar cancion a en cola","ver playlist","ver favoritos","ver en cola","Información","reproducir cancion", "salir" });
                                                    switch (chosen5)
                                                    {
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
                                                            bool exec13 = true;
                                                            while (exec13)
                                                            {
                                                                string chosen13 = ShowOptions(new List<string>() { "Por palabras clave", "Por Artista", "Por evaluación", "Por categoria", "salir" });
                                                                switch (chosen13)
                                                                {
                                                                    case "Por palabras clave":
                                                                        Console.WriteLine("Ingrese palabras clave");
                                                                        string Keys = Console.ReadLine();
                                                                        string[] words = Keys.Split(' ');
                                                                        foreach (var word in words)
                                                                        {
                                                                            //if(word == ||)
                                                                        }
                                                                        Console.Clear();
                                                                        break;
                                                                    case "Por Artista":
                                                                        Console.Clear();
                                                                        bool exec5 = true;
                                                                        while (exec5)
                                                                        {
                                                                            string chosen3 = ShowOptions(new List<string>() { "Por edad", "Genero musical", "nombre", "salir" });
                                                                            switch (chosen3)
                                                                            {
                                                                                case "Por edad":
                                                                                    Console.Clear();
                                                                                    Console.WriteLine("ingrese busqueda");
                                                                                    string edad = Console.ReadLine();
                                                                                    int edad2 = Int16.Parse(edad);
                                                                                    foreach (var artist in l_artist)
                                                                                    {
                                                                                        if (artist.getAge() == edad2)
                                                                                        {
                                                                                            Console.WriteLine("tiene esa edad el artista: " + artist.getName());
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            Console.WriteLine("Ningun resultado coincide con su busqueda");

                                                                                        }
                                                                                    }
                                                                                    break;
                                                                                case "salir":
                                                                                    Console.Clear();
                                                                                    exec13 = false;
                                                                                    break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "Por evaluación":
                                                                        Console.Clear();
                                                                        Console.WriteLine("diga la nota que quira ingresar como parametro y si quiere buscar" +
                                                                            " mayores, menores o iguales(EJ, 2 mayores)");
                                                                        string phr = Console.ReadLine();
                                                                        string[] w = phr.Split(' ');
                                                                        int val = Int16.Parse(w[0]);
                                                                        string crt = w[1];
                                                                        if (crt == "mayores")
                                                                        {
                                                                            foreach (var song in l_songs)
                                                                            {
                                                                                if (song.getQualification() > val)
                                                                                {
                                                                                    Console.WriteLine(song.getName() + " " + song.getQualification());
                                                                                }
                                                                            }
                                                                        }
                                                                        if (crt == "menores")
                                                                        {
                                                                            foreach (var song in l_songs)
                                                                            {
                                                                                if (song.getQualification() < val)
                                                                                {
                                                                                    Console.WriteLine(song.getName() + " " + song.getQualification());
                                                                                }
                                                                            }
                                                                        }
                                                                        if (crt == "iguales")
                                                                        {
                                                                            foreach (var song in l_songs)
                                                                            {
                                                                                if (song.getQualification() == val)
                                                                                {
                                                                                    Console.WriteLine(song.getName() + " " + song.getQualification());
                                                                                }
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "Por categoria":
                                                                        Console.Clear();
                                                                        Console.WriteLine("Ingrese el genero musical");
                                                                        string categ = Console.ReadLine();
                                                                        foreach (var song in l_songs)
                                                                        {
                                                                            if (song.getGender() == categ)
                                                                            {
                                                                                Console.WriteLine(song.getName());
                                                                            }
                                                                        }
                                                                        foreach (var artist in l_artist)
                                                                        {
                                                                            if (artist.getGender() == categ)
                                                                            {
                                                                                Console.WriteLine(artist.getName());
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "salir":
                                                                        Console.Clear();
                                                                        exec4 = false;
                                                                        break;
                                                                }
                                                            }
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
                                                        case "Información":
                                                            Console.Clear();
                                                            Console.WriteLine("diga el nombre de la cancion que quiera ver la informacion");
                                                            string Iname = Console.ReadLine();
                                                            for (int i = 0; l_songs.Count > i; i++)
                                                            {
                                                                if (Iname == l_songs[i].getName())
                                                                {
                                                                    bool exec3 = true;
                                                                    while (exec3)
                                                                    {
                                                                        string chosen14 = ShowOptions(new List<string>() { "Artista","Genero","Compositor","Estudio","Letra",
                                        "Año","Calificacion","Reproducciones","Duracion", "salir" });
                                                                        switch (chosen14)
                                                                        {
                                                                            case "Artista":
                                                                                Console.Clear();
                                                                                Console.WriteLine("El artista es: " + l_songs[i].getArtist());
                                                                                break;
                                                                            case "Genero":
                                                                                Console.Clear();
                                                                                Console.WriteLine("El Genero es: " + l_songs[i].getGender());
                                                                                break;
                                                                            case "Compositor":
                                                                                Console.Clear();
                                                                                Console.WriteLine("El Compositor es: " + l_songs[i].getCompose());
                                                                                break;
                                                                            case "Estudio":
                                                                                Console.Clear();
                                                                                Console.WriteLine("El Estudio es: " + l_songs[i].getStudio());
                                                                                break;
                                                                            case "Letra":
                                                                                Console.Clear();
                                                                                Console.WriteLine("La Letra es: " + l_songs[i].getLyrics());
                                                                                break;
                                                                            case "Año":
                                                                                Console.Clear();
                                                                                Console.WriteLine("El Año es: " + l_songs[i].getYear());
                                                                                break;
                                                                            case "Calificacion":
                                                                                Console.Clear();
                                                                                Console.WriteLine("El artista es: " + l_songs[i].getQualification());
                                                                                break;
                                                                            case "Reproducciones":
                                                                                Console.Clear();
                                                                                Console.WriteLine("La Calificacion es: " + l_songs[i].getReproductions());
                                                                                break;
                                                                            case "Duracion":
                                                                                Console.Clear();
                                                                                Console.WriteLine("La Duracion es: " + l_songs[i].getDuration());
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
                                                        case "reproducir cancion":
                                                            Console.Clear();
                                                            Console.WriteLine("diga el nombre de la cancion que quiera escuchar");
                                                            string Rname = Console.ReadLine();
                                                            for (int i = 0; l_songs.Count > i; i++)
                                                            {
                                                                if (Rname == l_songs[i].getName())
                                                                {
                                                                    l_songs[i].NumberOfUser();
                                                                    l_songs[i].Reproduction();
                                                                    foreach (KeyValuePair<string, List<Profile>> h in Users)
                                                                    {
                                                                        foreach (Profile profile3 in h.Value)
                                                                        {
                                                                            if (profile3.GetUserName() == asw5)
                                                                            {
                                                                                profile3.Escuchada(l_songs[i]);
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    bool exec2 = true;
                                                                    while (exec2)
                                                                    {
                                                                        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                                                                        wmp.URL = l_songs[i] + ".wav";
                                                                        string chosen15 = ShowOptions(new List<string>() { "reproducir", "pausar", "adelantar", "retroceder", "stop", "salir" });
                                                                        switch (chosen15)
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
                                                    string option = Movies.ShowOptions(new List<string>() { "Reproducir película",
                    "Ver listado de películas", "Buscar películas por filtros", "Agregar películas a la cola", "Crear playlist",
                    "Crear playlist de favoritos", "Salir de la plataforma"});
                                                    switch (option)
                                                    {
                                                        case "Reproducir película":
                                                            Console.WriteLine("Ingrese el nombre de la película con extensión .mp4:");
                                                            string mov = Console.ReadLine() + ".mp4";
                                                            foreach (KeyValuePair<string, List<Profile>> h in Users)
                                                            {
                                                                foreach (Profile profile3 in h.Value)
                                                                {
                                                                    if (profile3.GetUserName() == asw5)
                                                                    {
                                                                        profile3.Vista(mov);
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            try
                                                            {
                                                                System.Diagnostics.Process.Start(mov);
                                                            }
                                                            catch
                                                            {
                                                                Console.WriteLine("Hubo un error y no fue posible reproducir el video");
                                                            }
                                                            break;

                                                        case "Ver listado de películas":
                                                            Console.WriteLine("Películas disponibles para ver:");
                                                            int i = 0;
                                                            foreach (Movies Movie in movielist)
                                                            {
                                                                Console.WriteLine(i + ". " + Movie.GetName());
                                                                i += 1;
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
                                                            Movies.Search(filter, movielist);
                                                            break;

                                                        case "Agregar películas a la cola":
                                                            List<Movies> queue = new List<Movies>();
                                                            Console.WriteLine("¿Qué película desea agregar a la cola de reproducción?");
                                                            string election = Console.ReadLine();
                                                            foreach (Movies movie in movielist)
                                                            {
                                                                if (election == movie.GetName())
                                                                {
                                                                    if (queue.Contains(movie))
                                                                    {
                                                                        Console.WriteLine("Esta película ya se encuentra en la cola de reprodución.");
                                                                    }
                                                                    else
                                                                    {
                                                                        queue.Add(movie);
                                                                    }
                                                                }
                                                            }
                                                            bool t = true;
                                                            while (t)
                                                            {
                                                                Console.WriteLine("¿Desea agregar otra película a la cola? presione solamente ENTER para terminar.");
                                                                string election2 = Console.ReadLine();
                                                                if (election2 == "")
                                                                {
                                                                    t = false;
                                                                }
                                                                else
                                                                {
                                                                    foreach (Movies movie in movielist)
                                                                    {
                                                                        if (queue.Contains(movie))
                                                                        {
                                                                            Console.WriteLine("Esta película ya se encuentra en la cola de reprodución.");
                                                                        }
                                                                        else
                                                                        {
                                                                            queue.Add(movie);
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            break;

                                                        case "Crear playlist":
                                                            Console.WriteLine("Nombre de la playlist:");
                                                            string name = Console.ReadLine();
                                                            Console.WriteLine("Privacidad de la playlist: pública/privada");
                                                            string privacy = Console.ReadLine();
                                                            Console.WriteLine("Películas que desea agregar (para terminar, presione ENTER solamente):");
                                                            List<Movies> movies = new List<Movies>();
                                                            bool c = true;
                                                            while (c)
                                                            {
                                                                string movieName = Console.ReadLine();
                                                                if (movieName == "")
                                                                {
                                                                    c = false;
                                                                }
                                                                else
                                                                {
                                                                    foreach (Movies movie in movielist)
                                                                    {
                                                                        if (movieName == movie.GetName())
                                                                        {
                                                                            if (movies.Contains(movie))
                                                                            {
                                                                                Console.WriteLine("Esta película ya se encuentra en la playlist. Intente con otra.");
                                                                            }
                                                                            else
                                                                            {
                                                                                movies.Add(movie);
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            PlaylistMovies playlist = new PlaylistMovies(name, privacy, movies);
                                                            Console.WriteLine("La playlist " + playlist.GetName() + " se ha creado con éxito.");
                                                            PL.Add(playlist);
                                                            break;

                                                        case "Crear playlist de favoritos":
                                                            Console.WriteLine("Nombre de la playlist:");
                                                            string namef = Console.ReadLine();
                                                            Console.WriteLine("Privacidad de la playlist: pública/privada");
                                                            string privacyf = Console.ReadLine();
                                                            Console.WriteLine("Películas que desea agregar (para terminar, presione ENTER solamente):");
                                                            List<Movies> moviesf = new List<Movies>();
                                                            bool d = true;
                                                            while (d)
                                                            {
                                                                string respuesta = Console.ReadLine();
                                                                if (respuesta == "")
                                                                {
                                                                    d = false;
                                                                }
                                                                else
                                                                {
                                                                    foreach (Movies movie in movielist)
                                                                    {
                                                                        if (respuesta == movie.GetName())
                                                                        {
                                                                            if (moviesf.Contains(movie))
                                                                            {
                                                                                Console.WriteLine("Esta película ya se encuentra en la playlist. Intente con otra.");
                                                                            }
                                                                            else
                                                                            {
                                                                                moviesf.Add(movie);
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            PlaylistFavouriteMovies playlistfavourite = new PlaylistFavouriteMovies(namef, privacyf, moviesf);
                                                            Console.WriteLine("La playlist de favoritos " + playlistfavourite.GetName() + " se ha creado con éxito.");
                                                            break;

                                                        case "Salir de la plataforma":
                                                            exec = false;
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
                            }
                            if (asw == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("El email ingresado o la contraseña ingresada no son correctas");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No existe ninguna cuenta creada. Utilize la opcion administracion de cuentas para poder crear una");
                            Thread.Sleep(4000);
                        }
                        break;
                    case "Iniciar sesion como administrador":
                        Console.WriteLine($"Bienvenido Admin! ¿Que desea hacer?");
                        bool exec17 = true;
                        while (exec17)
                        {
                            string chosen = ShowOptions(new List<string>() { "Seguir", "Sugerencias inteligentes", "Unirme a una party", "Canciones", "Peliculas", "Salir" });
                            switch (chosen)
                            {
                                case "Seguir":
                                    string chosen1 = ShowOptions(new List<string>() { "Seguir un perfil", "Seguir una playlist de canciones", "Seguir una playlist de peliculas", "Seguir un album", "Seguir un artista", "Seguir un actor" });
                                    switch (chosen1)
                                    {
                                        case "Seguir un perfil":
                                            Console.WriteLine("Que perfil desea seguir?");
                                            string perfil = Console.ReadLine();
                                            int e = 0;
                                            foreach (KeyValuePair<string, List<Profile>> h in Users)
                                            {
                                                foreach (Profile l in h.Value)
                                                {
                                                    if (l.GetUserName() == perfil)
                                                    {
                                                        e = 1;
                                                        profile.AddProfile(l);
                                                        Console.WriteLine("Perfil seguido con exito");
                                                        Thread.Sleep(2000);
                                                        break;
                                                    }
                                                }
                                            }
                                            if (e == 0)
                                            {
                                                Console.WriteLine("El perfil que desea seguir no existe");
                                                Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                            break;
                                        case "Seguir una playlist de canciones":
                                            Console.WriteLine("Que playlist desea seguir?");
                                            string playlistsong = Console.ReadLine();
                                            int d = 0;
                                            foreach (PlaylistSongs playlistSongs in l_pl)
                                            {
                                                if (playlistSongs.getName() == playlistsong)
                                                {
                                                    d = 1;
                                                    profile.AddPlaylistSong(playlistSongs);
                                                    Console.WriteLine("Playlist de canciones seguida con exito");
                                                    Thread.Sleep(2000);
                                                    break;
                                                }
                                            }
                                            if (d == 0)
                                            {
                                                Console.WriteLine("La playlist que desea seguir no existe");
                                                Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                            break;
                                        case "Seguir una playlist de peliculas":
                                            Console.WriteLine("Que playlist desea seguir?");
                                            string playlistmovie = Console.ReadLine();
                                            int f = 0;
                                            foreach (PlaylistMovies playlistMovies in PL)
                                            {
                                                if (playlistMovies.GetName() == playlistmovie)
                                                {
                                                    f = 1;
                                                    profile.AddPlaylistMovie(playlistMovies);
                                                    Console.WriteLine("Playlist de peliculas seguida con exito");
                                                    Thread.Sleep(2000);
                                                    break;
                                                }

                                            }
                                            if (f == 0)
                                            {
                                                Console.WriteLine("La playlist que desea seguir no existe");
                                                Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                            break;
                                        case "Seguir un album":
                                            Console.WriteLine("Que album desea seguir?");
                                            string album = Console.ReadLine();
                                            int c = 0;
                                            foreach (Album album1 in l_album)
                                            {
                                                if (album1.getName() == album)
                                                {
                                                    c = 1;
                                                    profile.AddAlbum(album1);
                                                    Console.WriteLine("Album seguido con exito");
                                                    Thread.Sleep(2000);
                                                    break;
                                                }
                                            }
                                            if (c == 0)
                                            {
                                                Console.WriteLine("El Album que desea seguir no existe");
                                                Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                            break;
                                        case "Seguir un artista":
                                            Console.WriteLine("Que artista desea seguir?");
                                            string artist = Console.ReadLine();
                                            int a = 0;
                                            foreach (Artist artist1 in l_artist)
                                            {
                                                if (artist1.getName() == artist)
                                                {
                                                    a = 1;
                                                    profile.AddArtist(artist1);
                                                    Console.WriteLine("Artista seguido con exito");
                                                    Thread.Sleep(2000);
                                                    break;
                                                }
                                            }
                                            if (a == 0)
                                            {
                                                Console.WriteLine("El artista que desea seguir no existe");
                                                Thread.Sleep(2000);
                                            }
                                            Console.Clear();
                                            break;
                                        case "Seguir un actor":
                                            Console.WriteLine("Que artista desea seguir?");
                                            string actor = Console.ReadLine();
                                            int b = 0;
                                            foreach (Actor actor2 in actors)
                                            {
                                                if (actor2.GetName() == actor)
                                                {
                                                    b = 1;
                                                    profile.AddActor(actor2);
                                                    Console.WriteLine("Actor seguido con exito");
                                                    Thread.Sleep(2000);
                                                    break;
                                                }
                                            }
                                            if (b == 0)
                                            {
                                                Console.WriteLine("El Actor que desea seguir no existe");
                                                Thread.Sleep(2000);
                                            }
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
                                            Console.WriteLine(profile.SuggestionMovie());
                                            Thread.Sleep(4000);
                                            break;
                                        case "Sugerencias de Canciones":
                                            Console.Clear();
                                            Console.WriteLine("En base a lo que usted sigue y ha visto, esta es una lista de canciones que podrian gustarle:");
                                            Console.WriteLine(profile.SuggestionSong());
                                            Thread.Sleep(4000);
                                            break;
                                    }
                                    break;
                                case "Unirme a una party":
                                    Console.Clear();
                                    Console.WriteLine("Quiere unirse a una party de peliculas o canciones?(responda peliculas o canciones)");
                                    string answer12 = Console.ReadLine();
                                    if (answer12 == "canciones")
                                    {
                                        List<string> nombresprofiles = new List<string>();
                                        int t = 1;
                                        if (profile.GetFollowProfiles().Count > 0)
                                        {
                                            foreach (Profile f in profile.GetFollowProfiles())
                                            {
                                                nombresprofiles.Add(f.GetUserName());
                                            }
                                            Console.WriteLine("A que usuario quiere unirse? (Responda con su username)");
                                            foreach (string y in nombresprofiles)
                                            {
                                                Console.WriteLine($"({t}) {y}");
                                                t += 1;
                                            }
                                            string answer11 = Console.ReadLine();
                                            if (nombresprofiles.Contains(answer11))
                                            {
                                                Console.WriteLine($"En estos momentos {answer11} esta escuchando Coronao de El Alfa");
                                                profile.JoinPartySong("El Alfa El Jefe x Lil Pump - Coronao Now (Video Oficial).wav");
                                                Console.WriteLine("Si desea parar de escuchar escriba stop:");
                                                string stop = Console.ReadLine();
                                                if (stop == "stop")
                                                {
                                                    WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                                                    wmp.controls.pause();
                                                    break;
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Usuario invalido");
                                                Thread.Sleep(2000);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Usted no sigue a ningun usuario para poder utilizar esta funcion.");
                                            Thread.Sleep(2000);
                                        }
                                    }
                                    if (answer12 == "peliculas")
                                    {
                                        List<string> nombresprofiles = new List<string>();
                                        int t = 1;
                                        if (profile.GetFollowProfiles().Count > 0)
                                        {
                                            foreach (Profile f in profile.GetFollowProfiles())
                                            {
                                                nombresprofiles.Add(f.GetUserName());
                                            }
                                            Console.WriteLine("A que usuario quiere unirse? (Responda con su username)");
                                            foreach (string y in nombresprofiles)
                                            {
                                                Console.WriteLine($"({t}) {y}");
                                                t += 1;
                                            }
                                            string answer11 = Console.ReadLine();
                                            if (nombresprofiles.Contains(answer11))
                                            {
                                                Console.WriteLine($"En estos momentos {answer11} esta viendo tarzan");
                                                profile.JoinPartyMovie("tarzan-trailer");
                                                Console.WriteLine("Si desea parar de ver cierre la ventana y luego escriba stop");
                                                string stop = Console.ReadLine();
                                                if (stop == "stop")
                                                {
                                                    break;
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Usuario invalido");
                                                Thread.Sleep(2000);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Usted no sigue a ningun usuario para poder utilizar esta funcion.");
                                            Thread.Sleep(2000);
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Respuesta invalida");
                                    }
                                    break;
                                case "Canciones":
                                    bool exec4 = true;
                                    while (exec4)
                                    {
                                        // Pedimos al usuario una de las opciones
                                        string chosen5 = ShowOptions(new List<string>() { "crear playlist","calificar cancion",
                    "Buscar cancion", "Descargar cancion", "agregar cancion a playlist", "selccionar cancion como favorito",
                    "agregar cancion a en cola","ver playlist","ver favoritos","ver en cola","Información","reproducir cancion", "salir" });
                                        switch (chosen5)
                                        {
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
                                                bool exec13 = true;
                                                while (exec13)
                                                {
                                                    string chosen13 = ShowOptions(new List<string>() { "Por palabras clave", "Por Artista", "Por evaluación", "Por categoria", "salir" });
                                                    switch (chosen13)
                                                    {
                                                        case "Por palabras clave":
                                                            Console.WriteLine("Ingrese palabras clave");
                                                            string Keys = Console.ReadLine();
                                                            string[] words = Keys.Split(' ');
                                                            foreach (var word in words)
                                                            {
                                                                //if(word == ||)
                                                            }
                                                            Console.Clear();
                                                            break;
                                                        case "Por Artista":
                                                            Console.Clear();
                                                            bool exec5 = true;
                                                            while (exec5)
                                                            {
                                                                string chosen3 = ShowOptions(new List<string>() { "Por edad", "Genero musical", "nombre", "salir" });
                                                                switch (chosen3)
                                                                {
                                                                    case "Por edad":
                                                                        Console.Clear();
                                                                        Console.WriteLine("ingrese busqueda");
                                                                        string edad = Console.ReadLine();
                                                                        int edad2 = Int16.Parse(edad);
                                                                        foreach (var artist in l_artist)
                                                                        {
                                                                            if (artist.getAge() == edad2)
                                                                            {
                                                                                Console.WriteLine("tiene esa edad el artista: " + artist.getName());
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Ningun resultado coincide con su busqueda");

                                                                            }
                                                                        }
                                                                        break;
                                                                    case "salir":
                                                                        Console.Clear();
                                                                        exec13 = false;
                                                                        break;
                                                                }
                                                            }
                                                            break;
                                                        case "Por evaluación":
                                                            Console.Clear();
                                                            Console.WriteLine("diga la nota que quira ingresar como parametro y si quiere buscar" +
                                                                " mayores, menores o iguales(EJ, 2 mayores)");
                                                            string phr = Console.ReadLine();
                                                            string[] w = phr.Split(' ');
                                                            int val = Int16.Parse(w[0]);
                                                            string crt = w[1];
                                                            if (crt == "mayores")
                                                            {
                                                                foreach (var song in l_songs)
                                                                {
                                                                    if (song.getQualification() > val)
                                                                    {
                                                                        Console.WriteLine(song.getName() + " " + song.getQualification());
                                                                    }
                                                                }
                                                            }
                                                            if (crt == "menores")
                                                            {
                                                                foreach (var song in l_songs)
                                                                {
                                                                    if (song.getQualification() < val)
                                                                    {
                                                                        Console.WriteLine(song.getName() + " " + song.getQualification());
                                                                    }
                                                                }
                                                            }
                                                            if (crt == "iguales")
                                                            {
                                                                foreach (var song in l_songs)
                                                                {
                                                                    if (song.getQualification() == val)
                                                                    {
                                                                        Console.WriteLine(song.getName() + " " + song.getQualification());
                                                                    }
                                                                }
                                                            }
                                                            break;
                                                        case "Por categoria":
                                                            Console.Clear();
                                                            Console.WriteLine("Ingrese el genero musical");
                                                            string categ = Console.ReadLine();
                                                            foreach (var song in l_songs)
                                                            {
                                                                if (song.getGender() == categ)
                                                                {
                                                                    Console.WriteLine(song.getName());
                                                                }
                                                            }
                                                            foreach (var artist in l_artist)
                                                            {
                                                                if (artist.getGender() == categ)
                                                                {
                                                                    Console.WriteLine(artist.getName());
                                                                }
                                                            }
                                                            break;
                                                        case "salir":
                                                            Console.Clear();
                                                            exec4 = false;
                                                            break;
                                                    }
                                                }
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
                                            case "Información":
                                                Console.Clear();
                                                Console.WriteLine("diga el nombre de la cancion que quiera ver la informacion");
                                                string Iname = Console.ReadLine();
                                                for (int i = 0; l_songs.Count > i; i++)
                                                {
                                                    if (Iname == l_songs[i].getName())
                                                    {
                                                        bool exec3 = true;
                                                        while (exec3)
                                                        {
                                                            string chosen14 = ShowOptions(new List<string>() { "Artista","Genero","Compositor","Estudio","Letra",
                                        "Año","Calificacion","Reproducciones","Duracion", "salir" });
                                                            switch (chosen14)
                                                            {
                                                                case "Artista":
                                                                    Console.Clear();
                                                                    Console.WriteLine("El artista es: " + l_songs[i].getArtist());
                                                                    break;
                                                                case "Genero":
                                                                    Console.Clear();
                                                                    Console.WriteLine("El Genero es: " + l_songs[i].getGender());
                                                                    break;
                                                                case "Compositor":
                                                                    Console.Clear();
                                                                    Console.WriteLine("El Compositor es: " + l_songs[i].getCompose());
                                                                    break;
                                                                case "Estudio":
                                                                    Console.Clear();
                                                                    Console.WriteLine("El Estudio es: " + l_songs[i].getStudio());
                                                                    break;
                                                                case "Letra":
                                                                    Console.Clear();
                                                                    Console.WriteLine("La Letra es: " + l_songs[i].getLyrics());
                                                                    break;
                                                                case "Año":
                                                                    Console.Clear();
                                                                    Console.WriteLine("El Año es: " + l_songs[i].getYear());
                                                                    break;
                                                                case "Calificacion":
                                                                    Console.Clear();
                                                                    Console.WriteLine("El artista es: " + l_songs[i].getQualification());
                                                                    break;
                                                                case "Reproducciones":
                                                                    Console.Clear();
                                                                    Console.WriteLine("La Calificacion es: " + l_songs[i].getReproductions());
                                                                    break;
                                                                case "Duracion":
                                                                    Console.Clear();
                                                                    Console.WriteLine("La Duracion es: " + l_songs[i].getDuration());
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
                                            case "reproducir cancion":
                                                Console.Clear();
                                                Console.WriteLine("diga el nombre de la cancion que quiera escuchar");
                                                string Rname = Console.ReadLine();
                                                for (int i = 0; l_songs.Count > i; i++)
                                                {
                                                    if (Rname == l_songs[i].getName())
                                                    {
                                                        l_songs[i].NumberOfUser();
                                                        l_songs[i].Reproduction();
                                                        bool exec2 = true;
                                                        while (exec2)
                                                        {
                                                              WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                                                              wmp.URL = l_songs[i] + ".wav";
                                                            string chosen15 = ShowOptions(new List<string>() { "reproducir", "pausar", "adelantar", "retroceder", "stop", "salir" });
                                                            switch (chosen15)
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
                                        string option = Movies.ShowOptions(new List<string>() { "Reproducir película",
                    "Ver listado de películas", "Buscar películas por filtros", "Agregar películas a la cola", "Crear playlist",
                    "Crear playlist de favoritos", "Salir de la plataforma"});
                                        switch (option)
                                        {
                                            case "Reproducir película":
                                                Console.WriteLine("Ingrese el nombre de la película con extensión .mp4:");
                                                string mov = Console.ReadLine() + ".mp4";
                                                try
                                                {
                                                    System.Diagnostics.Process.Start(mov);
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Hubo un error y no fue posible reproducir el video");
                                                }
                                                break;

                                            case "Ver listado de películas":
                                                Console.WriteLine("Películas disponibles para ver:");
                                                int i = 0;
                                                foreach (Movies Movie in movielist)
                                                {
                                                    Console.WriteLine(i + ". " + Movie.GetName());
                                                    i += 1;
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
                                                Movies.Search(filter, movielist);
                                                break;

                                            case "Agregar películas a la cola":
                                                List<Movies> queue = new List<Movies>();
                                                Console.WriteLine("¿Qué película desea agregar a la cola de reproducción?");
                                                string election = Console.ReadLine();
                                                foreach (Movies movie in movielist)
                                                {
                                                    if (election == movie.GetName())
                                                    {
                                                        if (queue.Contains(movie))
                                                        {
                                                            Console.WriteLine("Esta película ya se encuentra en la cola de reprodución.");
                                                        }
                                                        else
                                                        {
                                                            queue.Add(movie);
                                                        }
                                                    }
                                                }
                                                bool t = true;
                                                while (t)
                                                {
                                                    Console.WriteLine("¿Desea agregar otra película a la cola? presione solamente ENTER para terminar.");
                                                    string election2 = Console.ReadLine();
                                                    if (election2 == "")
                                                    {
                                                        t = false;
                                                    }
                                                    else
                                                    {
                                                        foreach (Movies movie in movielist)
                                                        {
                                                            if (queue.Contains(movie))
                                                            {
                                                                Console.WriteLine("Esta película ya se encuentra en la cola de reprodución.");
                                                            }
                                                            else
                                                            {
                                                                queue.Add(movie);
                                                            }
                                                        }
                                                    }
                                                }
                                                break;

                                            case "Crear playlist":
                                                Console.WriteLine("Nombre de la playlist:");
                                                string name = Console.ReadLine();
                                                Console.WriteLine("Privacidad de la playlist: pública/privada");
                                                string privacy = Console.ReadLine();
                                                Console.WriteLine("Películas que desea agregar (para terminar, presione ENTER solamente):");
                                                List<Movies> movies = new List<Movies>();
                                                bool c = true;
                                                while (c)
                                                {
                                                    string movieName = Console.ReadLine();
                                                    if (movieName == "")
                                                    {
                                                        c = false;
                                                    }
                                                    else
                                                    {
                                                        foreach (Movies movie in movielist)
                                                        {
                                                            if (movieName == movie.GetName())
                                                            {
                                                                if (movies.Contains(movie))
                                                                {
                                                                    Console.WriteLine("Esta película ya se encuentra en la playlist. Intente con otra.");
                                                                }
                                                                else
                                                                {
                                                                    movies.Add(movie);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                PlaylistMovies playlist = new PlaylistMovies(name, privacy, movies);
                                                Console.WriteLine("La playlist " + playlist.GetName() + " se ha creado con éxito.");
                                                PL.Add(playlist);
                                                break;

                                            case "Crear playlist de favoritos":
                                                Console.WriteLine("Nombre de la playlist:");
                                                string namef = Console.ReadLine();
                                                Console.WriteLine("Privacidad de la playlist: pública/privada");
                                                string privacyf = Console.ReadLine();
                                                Console.WriteLine("Películas que desea agregar (para terminar, presione ENTER solamente):");
                                                List<Movies> moviesf = new List<Movies>();
                                                bool d = true;
                                                while (d)
                                                {
                                                    string respuesta = Console.ReadLine();
                                                    if (respuesta == "")
                                                    {
                                                        d = false;
                                                    }
                                                    else
                                                    {
                                                        foreach (Movies movie in movielist)
                                                        {
                                                            if (respuesta == movie.GetName())
                                                            {
                                                                if (moviesf.Contains(movie))
                                                                {
                                                                    Console.WriteLine("Esta película ya se encuentra en la playlist. Intente con otra.");
                                                                }
                                                                else
                                                                {
                                                                    moviesf.Add(movie);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                PlaylistFavouriteMovies playlistfavourite = new PlaylistFavouriteMovies(namef, privacyf, moviesf);
                                                Console.WriteLine("La playlist de favoritos " + playlistfavourite.GetName() + " se ha creado con éxito.");
                                                break;

                                            case "Salir de la plataforma":
                                                exec8 = false;
                                                break;
                                        }
                                    }
                                    break;
                                case "Salir":
                                    exec17 = false;
                                    break;
                            }
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;
                    case "Administracion de Cuentas":
                        bool exec11 = true;
                        while (exec11)
                        {
                            string chosen = ShowOptions(new List<string>() { "Crear Usuario", "Crear Perfil", "Modificar perfil", "Ver los perfiles por usuario", "Salir" });
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
                                    Console.WriteLine("Para poder usar este usuario, necesita crearle un perfil");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    break;
                                case "Crear Perfil":
                                    Console.WriteLine("A que usuario quiere añadirle un perfil?(responda con el mail del usuario)");
                                    string email1 = Console.ReadLine();
                                    Console.WriteLine("Cual sera el Username de este nuevo Profile?");
                                    string username = Console.ReadLine();
                                    Console.WriteLine("Sera un profile privado?(true or false)");
                                    bool privacy = Convert.ToBoolean(Console.ReadLine());
                                    int n = Users.Keys.Count;
                                    if (n == 0)
                                    {
                                        Profile profile2 = new Profile(username, privacy);
                                        List<Profile> ListOfProfiles = new List<Profile>();
                                        ListOfProfiles.Add(profile2);
                                        Console.WriteLine("Perfil creado con exito");
                                        Thread.Sleep(1000);
                                        Users.Add(email1, ListOfProfiles);
                                    }
                                    if (n > 0)
                                    {
                                        if (Users.ContainsKey(email1))
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
                                        else
                                        {
                                            Profile profile2 = new Profile(username, privacy);
                                            List<Profile> ListOfProfiles = new List<Profile>();
                                            ListOfProfiles.Add(profile2);
                                            Console.WriteLine("Perfil creado con exito");
                                            Thread.Sleep(1000);
                                            Users.Add(email1, ListOfProfiles);
                                        }
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
                                        if (Users.ContainsKey(email2))
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
                                                break;

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
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("No existe dicho perfil.");
                                            Thread.Sleep(1000);
                                        }
                                    }
                                    Console.Clear();
                                    break;
                                case "Ver los perfiles por usuario":
                                    Console.Clear();
                                    foreach (KeyValuePair<string, List<Profile>> a in Users)
                                    {
                                        Console.WriteLine(a.Key);
                                        foreach (Profile b in a.Value)
                                        {
                                            Console.WriteLine($"Username: {b.GetUserName()}, Privacidad: {b.GetPrivacy()}");
                                        }
                                    }
                                    Thread.Sleep(2000);
                                    break;
                                case "Salir":
                                    exec11 = false;
                                    break;
                            }
                        }
                        break;
                    case "Salir":
                        exec10 = false;
                        break;
                        
                }
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