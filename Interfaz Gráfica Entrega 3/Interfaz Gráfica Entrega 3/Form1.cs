using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using WMPLib;
using System.Windows.Forms;

namespace Interfaz_Gráfica_Entrega_3
{
    public partial class SpotflixForm : Form
    {
        User user = new User("", "", "");
        Profile profile = new Profile("", true);
        Dictionary<string, List<Profile>> Users = new Dictionary<string, List<Profile>>();
        //REQUISITOS CANCIONES
        List<Artist> l_artist = new List<Artist>();
        List<Album> l_album = new List<Album>();
        List<Songs> l_songs = new List<Songs>();
        List<PlaylistSongs> l_pl = new List<PlaylistSongs>();
        // CANCIONES!!!
        Songs CiudadDeLaFuria = new Songs("Ciudad de la furia", "Soda stereo", "Gustavo Cerati", "Rock", "desconocido", 1988, "letra jeje", "5:46", true, false);
        Songs MelonVino = new Songs("Melon vino", "Wos", "Wos", "Rap", "desconocido", 2019, "letra jeje", "3:03", true, false);
        Songs LetItBe = new Songs("Let It Be", "The Beatles", "Paul McCartney", "Rock", "desconocido", 1970, "letra jeje", "4:04", false, false);
        // ALBUMS!!!
        Album DobleVida = new Album("Doble vida", "Soda stereo", 1988);
        Album Caravana = new Album("Caravana", "Wos", 2019);
        Album Letitbe = new Album("Let it be", "The Beatles", 1970);
        // ARTISTAS!!!
        List<Album> Aalbums = new List<Album>();
        List<Songs> Asongs = new List<Songs>();
        List<Album> Balbums = new List<Album>();
        List<Songs> Bsongs = new List<Songs>();
        List<Album> Calbums = new List<Album>();
        List<Songs> Csongs = new List<Songs>();
        //creamos playlist de favoritos
        List<Songs> songs = new List<Songs>();
        //creamos objeto de en cola
        List<Songs> Qsongs = new List<Songs>();
        //REQUISITOS MOVIES
        List<Movies> movielist = new List<Movies>();
        List<PlaylistMovies> l_plm = new List<PlaylistMovies>();
        List<Actor> actors = new List<Actor>();
        //creamos playlist de favoritos
        List<Movies> movies = new List<Movies>();
        //creamos objeto de en cola
        List<Movies> Qmovies = new List<Movies>();
        //PARTICIPACIÓN DE ACTORES
        List<string> DonaldGloverP = new List<string>();
        List<string> BeyonceP = new List<string>();
        List<string> ScarlettJohannsonP = new List<string>();
        List<string> RobertDownleyP = new List<string>();
        List<string> FlorencePughP = new List<string>();
        //CATEGORÍAS DE PELÍCULAS
        List<string> categoriesL = new List<string>();
        List<string> categoriesA = new List<string>();
        List<string> categoriesB = new List<string>();
        //ACTORES
        List<Actor> actorsL = new List<Actor>();
        List<Actor> actorsA = new List<Actor>();
        List<Actor> actorsB = new List<Actor>();
       
        public SpotflixForm()
        {
            l_songs.Add(CiudadDeLaFuria);
            l_songs.Add(MelonVino);
            l_songs.Add(LetItBe);
            l_album.Add(DobleVida);
            l_album.Add(Caravana);
            l_album.Add(Letitbe);
            Asongs.Add(CiudadDeLaFuria);
            Aalbums.Add(DobleVida);
            Bsongs.Add(MelonVino);
            Balbums.Add(Caravana);
            Csongs.Add(LetItBe);
            Calbums.Add(Letitbe);
            Artist SodaStereo = new Artist("Soda stereo", "Soda Stereo fue una banda argentina de rock formada en Buenos Aires en 1982\n por Gustavo Cerati, Héctor «Zeta» Bosio y Carlos Alberto Ficicchia «Charly Alberti»,\n considerada como la más exitosa, popular, influyente e importante de las bandas en español\n de todos los tiempos y una leyenda de la música latina.", "Rock", 38, Aalbums, Asongs);
            l_artist.Add(SodaStereo);
            Artist Wos = new Artist("Wos", "Valentín Oliva, conocido artísticamente como Wos,\n es un rapero y freestyler argentino.", "Rap", 22, Balbums, Bsongs);
            l_artist.Add(Wos);
            Artist TheBeatles = new Artist("The Beatles", "The Beatles fue una banda de rock inglesa activa durante la década de 1960,\n y reconocida como la más exitosa comercialmente y la más alabada\n por la crítica en la historia de la música popular y de la música rock.", "Rock", 63, Calbums, Csongs);
            l_artist.Add(TheBeatles);
            PlaylistFavouritesSongs playlistFavouritesSongs = new PlaylistFavouritesSongs("favoritos", "privada", songs);
            QueueSongs queueSongs = new QueueSongs(Qsongs);
            QueueMovies queueMovies = new QueueMovies(Qmovies);
            Actor DonaldGlover = new Actor("Donald Glover", "Actor, cantante, guionista, director de TV, comediante estadounidense", DonaldGloverP, "Hombre", 36);
            Actor Beyonce = new Actor("Beyonce", "Cantante, compositora, bailarina, actriz, modelo", BeyonceP, "Mujer", 38);
            Actor ScarlettJohansson = new Actor("Scarlett Johannson", "Actriz de cine, cantante, modelo estadounidense", ScarlettJohannsonP, "Mujer", 35);
            Actor RobertDownley = new Actor("Robert Downley Jr.", "Actor, productor, cantante estadounidense", RobertDownleyP, "Hombre", 55);
            Actor FlorencePugh = new Actor("Florence Pugh", "Actriz", FlorencePughP, "Mujer", 24);
            PlaylistFavouriteMovies playlistFavouritesMovies = new PlaylistFavouriteMovies("favoritos", "privada", movies);
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
            categoriesL.Add("Musical");
            categoriesL.Add("Animación");
            categoriesA.Add("Superhéroes");
            categoriesA.Add("Acción");
            categoriesA.Add("Ciencia Ficción");
            categoriesB.Add("Cine de superhéroes");
            categoriesB.Add("Acción");
            categoriesB.Add("Aventuras");
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
            Movies TheLionKing = new Movies("The Lion King", categoriesL, actorsL, "Walt Disney Pictures", 2019, "En la Roca del Rey, el rey Mufasa y la reina Sarabi presentan a su hijo recién nacido, Simba, a sus súbditos.Después de la ceremonia, el hermano menor de Mufasa, Scar, se lamenta de que ya no está en la segunda fila para el trono.El mayordomo de Mufasa, Zazú, llega al lugar, anunciando la llegada del rey.Scar intenta comerse a Zazú, pero se ve frustrado por la llegada de Mufasa, quien le pregunta a Scar por qué estuvo ausente en la presentación de Simba, a la que Scar finge habérsele olvidado.Los hermanos tienen una breve discusión, en la que Scar socava la autoridad de Mufasa, pero deja en claro que no desafiará el liderazgo del rey.Eventualmente, Scar se retira del lugar y Zazú le sugiere a Mufasa que por qué no lo exilia del reino antes de que cause problemas, pero Mufasa se niega a hacer tal cosa, ya que Scar es su hermano.", 108);
            Movies AvengersEndgame = new Movies("Avengers: Endgame", categoriesA, actorsA, "Marvel Studios", 2019, "Veintitrés días después de que Thanos hubiera usado el Guantelete del Infinito para desintegrar la mitad de toda la vida en el universo, Capitana Marvel rescata a Tony Stark y Nebula, quienes estaban varados en el espacio exterior en la nave Milano I del fallecido Quill y los lleva de regreso a la Tierra hasta el complejo de Los Vengadores, donde los esperan Natasha Romanoff, Bruce Banner, Steve Rogers, Rocket Raccoon, Thor, Pepper Potts y James Rhodes.Mientras estabilizan a Stark y lo ponen al corriente sobre los eventos que sucedieron mientras estuvo en el espacio exterior, el resto de Los Vengadores localizan por medio de Nebula a un Thanos malherido en un planeta al que este llama 'El Jardín' y deciden ir en su búsqueda con el objetivo de recuperar las Gemas del Infinito y revertir los efectos del chasquido.Consiguen reducirlo pero descubren que las gemas ya no están.Thanos revela que destruyó las gemas para evitar que fueran usadas nuevamente.Thor, enfurecido, lo decapita con la Stormbreaker.", 146);
            Movies BlackWidow = new Movies("Black Widow", categoriesB, actorsB, "Marvel Studios", 2019, "Situada 1 año después de los sucesos de Capitán América: Civil War y antes de Avengers: Infinity War, Natasha Romanoff se encuentra sola y obligada a enfrentar una peligrosa conspiración con lazos con su pasado mientras es buscada por la ley.Perseguida por una fuerza que no se detendrá ante nada para derribarla, Romanoff debe lidiar con su historia como espía y las relaciones rotas que dejó a su paso mucho antes de convertirse en Vengadora.", 144);
            movielist.Add(TheLionKing);
            movielist.Add(AvengersEndgame);
            movielist.Add(BlackWidow);
            InitializeComponent();
        }
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Iniciar Sesión")
            {
                LoginSesionpanel.Show();
                LoginSesionpanel.BringToFront();
                LoginSesionpanel.Dock = DockStyle.Fill;
            }
        }

        private void ADCbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Administración de cuentas")
            {
                ADCpanel.Show();
                ADCpanel.BringToFront();
                ADCpanel.Dock = DockStyle.Fill;
            }
        }

        private void LoginAdminbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Iniciar Sesión como Administrador")
            {
                MainMenupanel.Show();
                MainMenupanel.BringToFront();
                MainMenupanel.Dock = DockStyle.Fill;
            }
        }

        private void LoginSesionbutton_Click(object sender, EventArgs e)
        {
            string asw5 = "";
            int asw = 0;
            Button b = (Button)sender;
            if (b.Text == "Iniciar Sesión")
            {
                if (user.GetListOfUser().Count > 0)
                {
                    string email22 = "";
                    string password22 = "";
                    email22 = InsertMailLoginSesiontextBox.Text;
                    password22 = InsertPasswordLoginSesiontextBox.Text;
                    foreach (User u in user.GetListOfUser())
                    {
                        if (email22 == u.GetEmail() && password22 == u.GetPassword())
                        {
                            asw = 1;
                            FailedLoginSesionlabel.Hide();
                            LoginSesionProfilepanel.Show();
                            LoginSesionProfilepanel.BringToFront();
                            LoginSesionProfilepanel.Dock = DockStyle.Fill;
                            LoginSesionProfilelabel1.Text += " " + email22;
                            foreach (KeyValuePair<string, List<Profile>> h in Users)
                            {
                                if (h.Key == email22)
                                {
                                    foreach (Profile profile2 in h.Value)
                                    {
                                        LoginSesionInsertProfilecomboBox.Items.Add(profile2.GetUserName());
                                    }
                                }
                            }
                            

                           
                        }

                    }
                }
            }
            if (asw == 0)
            {
                FailedLoginSesionlabel.Show();
            }
            if (b.Text == "Ingresar")
            {
                asw5 = LoginSesionInsertProfilecomboBox.Text;
                MainMenupanel.Show();
                MainMenupanel.BringToFront();
                MainMenupanel.Dock = DockStyle.Fill;

                foreach (KeyValuePair<string, List<Profile>> h in Users)
                {
                    foreach (Profile profile3 in h.Value)
                    {
                        if (profile3.GetUserName() == asw5)
                        {
                            MainMenulabel1.Text += " " + asw5;
                            break;
                        }
                    }
                }
            }
        }

        private void BackLoginSesionbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                LoginSesionpanel.Hide();
            }
        }

        private void BackLoginSesionProfilebutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                LoginSesionProfilepanel.Hide();
            }
        }

        private void FollowMainMenubutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seguir")
            {
                Followpanel.Show();
                Followpanel.BringToFront();
                Followpanel.Dock = DockStyle.Fill;
            }
        }

        private void LogoutMainMenubutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Cerrar Sesión")
            {
                MainMenupanel.Hide();
            }
        }

        private void BackFollowbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                Followpanel.Hide();
            }
        }

        private void FollowProfileFollowbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seguir Perfil")
            {
                FollowProfilepanel.Show();
                FollowProfilepanel.BringToFront();
                FollowProfilepanel.Dock = DockStyle.Fill;
            }
        }

        private void BackFollowProfilebutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                FollowProfilepanel.Hide();
            }
        }

        private void FollowPlaylistSongsFollowbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seguir Playlist de Canciones")
            {
                FollowPlaylistSongspanel.Show();
                FollowPlaylistSongspanel.BringToFront();
                FollowPlaylistSongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackFollowPlaylistSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                FollowPlaylistSongspanel.Hide();
            }
        }

        private void FollowPlaylistMoviesFollowbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seguir Playlist de Películas")
            {
                FollowPlaylistMoviespanel.Show();
                FollowPlaylistMoviespanel.BringToFront();
                FollowPlaylistMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackFollowPlaylistMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                FollowPlaylistMoviespanel.Hide();
            }
        }

        private void FollowArtistFollowbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seguir Artista")
            {
                FollowArtistpanel.Show();
                FollowArtistpanel.BringToFront();
                FollowArtistpanel.Dock = DockStyle.Fill;
            }
        }

        private void BackFollowArtistbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                FollowArtistpanel.Hide();
            }
        }

        private void FollowActorFollowbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seguir Actor")
            {
                FollowActorpanel.Show();
                FollowActorpanel.BringToFront();
                FollowActorpanel.Dock = DockStyle.Fill;
            }
        }

        private void BackFollowActorbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                FollowActorpanel.Hide();
            }
        }

        private void FollowAlbumFollowbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seguir Álbum")
            {
                FollowAlbumpanel.Show();
                FollowAlbumpanel.BringToFront();
                FollowAlbumpanel.Dock = DockStyle.Fill;
            }
        }

        private void BackFollowAlbumbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                FollowAlbumpanel.Hide();
            }
        }

        private void SuggestionsMainMenubutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Sugerencias inteligentes")
            {
                InteligentSuggestionspanel.Show();
                InteligentSuggestionspanel.BringToFront();
                InteligentSuggestionspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackInteligentSuggestionsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                InteligentSuggestionspanel.Hide();
            }
        }

        private void MoviesInteligentSuggestionsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Sugerencias de Películas")
            {
                SuggestionsMoviespanel.Show();
                SuggestionsMoviespanel.BringToFront();
                SuggestionsMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSuggestionsMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SuggestionsMoviespanel.Hide();
            }
        }

        private void SongsInteligentSuggestionsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Sugerencias de Canciones")
            {
                SuggestionsSongspanel.Show();
                SuggestionsSongspanel.BringToFront();
                SuggestionsSongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSuggestionsSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SuggestionsSongspanel.Hide();
            }
        }

        private void JoinPartyMainMenubutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Unirme a una party")
            {
                JoinPartypanel.Show();
                JoinPartypanel.BringToFront();
                JoinPartypanel.Dock = DockStyle.Fill;
            }
        }

        private void BackJoinPartybutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                JoinPartypanel.Hide();
            }
        }

        private void JoinPartyMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "de Películas")
            {
                PartyMoviespanel.Show();
                PartyMoviespanel.BringToFront();
                PartyMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackPartyMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                PartyMoviespanel.Hide();
            }
        }

        private void JoinPartySongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "de Canciones")
            {
                PartySongspanel.Show();
                PartySongspanel.BringToFront();
                PartySongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackPartySongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                PartySongspanel.Hide();
            }
        }

        private void SongsMainMenubutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Canciones")
            {
                Songspanel.Show();
                Songspanel.BringToFront();
                Songspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                Songspanel.Hide();
            }
        }

        private void CreatePlaylistSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Crear Playlist")
            {
                CreatePlaylistSongspanel.Show();
                CreatePlaylistSongspanel.BringToFront();
                CreatePlaylistSongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackCreatePlaylistSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                CreatePlaylistSongspanel.Hide();
            }
        }

        private void QualifySongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Calificar Canción")
            {
                QualifySongspanel.Show();
                QualifySongspanel.BringToFront();
                QualifySongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackQualifySongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                QualifySongspanel.Hide();
            }
        }

        private void DownloadSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Descargar Canción")
            {
                DownloadSongspanel.Show();
                DownloadSongspanel.BringToFront();
                DownloadSongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackDownloadSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                DownloadSongspanel.Hide();
            }
        }

        private void SearchSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Buscar Canción")
            {
                SearchSongspanel.Show();
                SearchSongspanel.BringToFront();
                SearchSongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSearchSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SearchSongspanel.Hide();
            }
        }

        private void KeywordSearchSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Por palabras clave")
            {
                Keywordpanel.Show();
                Keywordpanel.BringToFront();
                Keywordpanel.Dock = DockStyle.Fill;
            }
        }

        private void BackKeywordbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                Keywordpanel.Hide();

            }
        }

        private void ArtistSearchSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Por Artista")
            {
                Artistpanel.Show();
                Artistpanel.BringToFront();
                Artistpanel.Dock = DockStyle.Fill;
            }
        }

        private void BackArtistbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                Artistpanel.Hide();
            }
        }

        private void EvaluationSearchSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Por Evaluación")
            {
                Evaluationpanel.Show();
                Evaluationpanel.BringToFront();
                Evaluationpanel.Dock = DockStyle.Fill;
            }
        }

        private void BackEvaluationbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                Evaluationpanel.Hide();
            }
        }

        private void CategoriesSearchSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Por Categoría")
            {
                Genderpanel.Show();
                Genderpanel.BringToFront();
                Genderpanel.Dock = DockStyle.Fill;
            }
        }

        private void BackGenderbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                Genderpanel.Hide();
            }
        }

        private void AddToPlaylistSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Agregar Canción a una Playlist")
            {
                AddToPlaylistSongspanel.Show();
                AddToPlaylistSongspanel.BringToFront();
                AddToPlaylistSongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackAddToPlaylistSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                AddToPlaylistSongspanel.Hide();
            }
        }

        private void SelectFavouriteSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seleccionar Canción como Favorito")
            {
                AddToFavouriteSongspanel.Show();
                AddToFavouriteSongspanel.BringToFront();
                AddToFavouriteSongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackAddToFavouriteSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                AddToFavouriteSongspanel.Hide();
            }
        }

        private void AddToQueueSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Agregar Canción a la Cola")
            {
                AddToQueueSongspanel.Show();
                AddToQueueSongspanel.BringToFront();
                AddToQueueSongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackAddToQueueSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                AddToQueueSongspanel.Hide();
            }
        }

        private void SeePlaylistSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Ver Playlist")
            {
                SeePlaylistSongspanel.Show();
                SeePlaylistSongspanel.BringToFront();
                SeePlaylistSongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSeePlaylistSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SeePlaylistSongspanel.Hide();
            }
        }

        private void SeeFavouriteSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Ver Favoritos")
            {
                SeeFavouriteSongspanel.Show();
                SeeFavouriteSongspanel.BringToFront();
                SeeFavouriteSongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSeeFavouriteSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SeeFavouriteSongspanel.Hide();
            }
        }

        private void SeeQueueSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Ver en Cola")
            {
                SeeQueueSongspanel.Show();
                SeeQueueSongspanel.BringToFront();
                SeeQueueSongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSeeQueueSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SeeQueueSongspanel.Hide();
            }
        }

        private void InformationSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Información")
            {
                InformationSongspanel.Show();
                InformationSongspanel.BringToFront();
                InformationSongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackInformationSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                InformationSongspanel.Hide();
            }
        }

        private void PlaySongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Reproducir Canción")
            {
                PlaySongspanel.Show();
                PlaySongspanel.BringToFront();
                PlaySongspanel.Dock = DockStyle.Fill;
            }
        }

        private void BackPlaySongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                PlaySongspanel.Hide();
            }
        }

        private void MoviesMainMenubutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Películas")
            {
                MoviesMainMenupanel.Show();
                MoviesMainMenupanel.BringToFront();
                MoviesMainMenupanel.Dock = DockStyle.Fill;
            }
        }

        private void BackMoviesMainMenubutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                MoviesMainMenupanel.Hide();
            }
        }

        private void PlayMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Reproducir Películas")
            {
                PlayMoviespanel.Show();
                PlayMoviespanel.BringToFront();
                PlayMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackPlayMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                PlayMoviespanel.Hide();
            }
        }

        private void QualifyMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Calificar Película")
            {
                QualifyMoviespanel.Show();
                QualifyMoviespanel.BringToFront();
                QualifyMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackQualifyMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                QualifyMoviespanel.Hide();
            }
        }

        private void InformationMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Información")
            {
                InformationMoviespanel.Show();
                InformationMoviespanel.BringToFront();
                InformationMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackInformationMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                InformationMoviespanel.Hide();
            }
        }

        private void AddToPlaylistMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Agregar Películas a una Playlist")
            {
                AddPlaylistMoviespanel.Show();
                AddPlaylistMoviespanel.BringToFront();
                AddPlaylistMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackAddPlaylistMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                AddPlaylistMoviespanel.Hide();
            }
        }

        private void CreatePlaylistMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Crear Playlist")
            {
                CreatePlaylistMoviespanel.Show();
                CreatePlaylistMoviespanel.BringToFront();
                CreatePlaylistMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackCreatePlaylistMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                CreatePlaylistMoviespanel.Hide();
            }
        }

        private void SeeMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Ver Listado de Películas")
            {
                SeeMoviespanel.Show();
                SeeMoviespanel.BringToFront();
                SeeMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSeeMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SeeMoviespanel.Hide();
            }
        }

        private void SearchMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Buscar Películas por Filtros")
            {
                SearchMoviespanel.Show();
                SearchMoviespanel.BringToFront();
                SearchMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSearchMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SearchMoviespanel.Hide();
            }
        }

        private void SeePlaylistMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Ver Playlist")
            {
                SeePlaylistMoviespanel.Show();
                SeePlaylistMoviespanel.BringToFront();
                SeePlaylistMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSeePlaylistMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SeePlaylistMoviespanel.Hide();
            }
        }

        private void AddQueueMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Agregar Películas a la Cola")
            {
                AddQueueMoviespanel.Show();
                AddQueueMoviespanel.BringToFront();
                AddQueueMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackAddQueueMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                AddQueueMoviespanel.Hide();
            }
        }

        private void SeeFavouriteMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Ver Favoritos")
            {
                SeeFavouriteMoviespanel.Show();
                SeeFavouriteMoviespanel.BringToFront();
                SeeFavouriteMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSeeFavouriteMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SeeFavouriteMoviespanel.Hide();
            }
        }

        private void SelectFavouriteMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seleccionar Película como Favorito")
            {
                SelectFavouriteMoviespanel.Show();
                SelectFavouriteMoviespanel.BringToFront();
                SelectFavouriteMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSelectFavouriteMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SelectFavouriteMoviespanel.Hide();
            }
        }

        private void SeeQueueMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Ver Lista en Cola")
            {
                SeeQueueMoviespanel.Show();
                SeeQueueMoviespanel.BringToFront();
                SeeQueueMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void BackSeeQueueMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SeeQueueMoviespanel.Hide();
            }
        }

        private void ExitADCbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Salir")
            {
                ADCpanel.Hide();
            }
        }

        private void CreateUserbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Crear Usuario")
            {
                CreateUserpanel.Show();
                CreateUserpanel.BringToFront();
                CreateUserpanel.Dock = DockStyle.Fill;
            }
        }

        private void BackCreateUserbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                CreateUserpanel.Hide();
            }
        }

        private void CreareProfilebutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Crear Perfil")
            {
                CreateProfilepanel.Show();
                CreateProfilepanel.BringToFront();
                CreateProfilepanel.Dock = DockStyle.Fill;
            }
        }

        private void BackCreateProfilebutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                CreateProfilepanel.Hide();
            }
        }

        private void ChangeProfilebutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Modificar Perfil")
            {
                ChangeProfilepanel.Show();
                ChangeProfilepanel.BringToFront();
                ChangeProfilepanel.Dock = DockStyle.Fill;
            }
        }

        private void BackChangeProfilebutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                ChangeProfilepanel.Hide();
            }
        }

        private void ViewProfilesbutton_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            if (b.Text == "Ver Perfiles por Usuario")
            {
                string text = "";
                SeeProfilespanel.Show();
                SeeProfilespanel.BringToFront();
                SeeProfilespanel.Dock = DockStyle.Fill;

                foreach (KeyValuePair<string, List<Profile>> a in Users)
                {
                    text += a.Key + " \n";
                    foreach (Profile d in a.Value)
                    {
                        text+= "Username: "+ d.GetUserName() + "Privacidad: "+ d.GetPrivacy();
                    }
                }
                SeeProfilesrichTextBox.Text += text;
            }
        }

        private void BackSeeProfilesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Volver")
            {
                SeeProfilespanel.Hide();
            }
        }

        private void CreateUbutton_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string plan = "";
            int asw = 0;
            Button b = (Button)sender;
            if (b.Text == "Crear")
            {
                username = InsertUserMailtextBox.Text;
                password = InsertUserPasswordtextBox.Text;
                plan = InsertPlanTypetextBox.Text;
                user.CreateUser(plan, username, password);
                CreateUserAvisolabel.Show();
                CreateUserAviso2label1.Show();
            }
        }

        private void CreatePbutton_Click(object sender, EventArgs e)
        {
            string username1 = "";
            string profile = "";
            bool privacy = true;
            Button b = (Button)sender;
            if (b.Text == "Crear")
            {
                profile = InsertUsernameCreateProfiletextBox.Text;
                privacy = Convert.ToBoolean(PrivacyProfileCreateProfiletextBox.Text);
                username1 = InsertUserCreateProfiletextBox.Text;
                int n = Users.Keys.Count;
                if (n == 0)
                {
                    Profile profile2 = new Profile(profile, privacy);
                    List<Profile> ListOfProfiles = new List<Profile>();
                    ListOfProfiles.Add(profile2);
                    ProfileCreatedlabel.Show();
                    Users.Add(username1, ListOfProfiles);
                }
                if (n > 0)
                {
                    if (Users.ContainsKey(username1))
                    {
                        foreach (KeyValuePair<string, List<Profile>> a in Users)
                        {
                            if (a.Key == username1)
                            {
                                Profile profile1 = new Profile(profile, privacy);
                                a.Value.Add(profile1);
                            }
                        }
                        ProfileCreatedlabel.Show();
                    }
                    else
                    {
                        Profile profile2 = new Profile(profile, privacy);
                        List<Profile> ListOfProfiles = new List<Profile>();
                        ListOfProfiles.Add(profile2);
                        ProfileCreatedlabel.Show();
                        Users.Add(username1, ListOfProfiles);
                    }
                }
            }
        }

        private void ChangePbutton_Click(object sender, EventArgs e)
        {
            string username2 = "";
            string profile2 = "";
            string change = "";
            string newprofile = "";
            bool newprivacy = true;
            Button b = (Button)sender;
            if (b.Text == "Buscar perfil")
            {
                username2 = InsertUsernameChangeProfiletextBox.Text;
                profile2 = InsertProfileChangeProfiletextBox.Text;
                change = InsertChooseChangeProfiletextBox.Text;
                ChangePbutton.Show();
                foreach (KeyValuePair<string, List<Profile>> a in Users)
                {
                    if (Users.ContainsKey(username2))
                    {
                        if (change == "Usuario")
                        {
                            InsertNewUsernameChangeProfilelabel.Show();
                            InsertNewUsernameChangeProfiletextBox.Show();
                            newprofile = InsertNewUsernameChangeProfiletextBox.Text;
                            if (b.Text == "Modificar")
                            {
                                foreach (Profile c in a.Value)
                                {
                                    c.ChangeUsername(newprofile);
                                }
                                UseranemChangedChangeProfilelabel.Show();
                                break;
                            }

                        }
                        if (change == "Privacidad")
                        {

                            InsertNewUsernameChangeProfilelabel.Show();
                            InsertNewPrivacyChangeProfiletextBox.Show();
                            newprivacy = Convert.ToBoolean(InsertNewPrivacyChangeProfiletextBox.Text);
                            if(b.Text == "Modificar")
                            {
                                foreach (Profile c in a.Value)
                                {
                                    c.ChangePrivacy(newprivacy);
                                }
                                PrivacyChangedChangeProfilelabel.Show();
                                break;
                            }
                        }
                    }
                    else
                    {
                        FailProfileChangelabel.Show();
                        
                    }
                }
            }
        }
    }
}

