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
        Songs MelonVino = new Songs("Melon vino", "Wos", "Wos", "Rap", "desconocido", 2019, "letra jeej", "3:03", true, false);
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
        List<Songs> Fsongs = new List<Songs>();
        //creamos objeto de en cola
        List<Songs> Qsongs = new List<Songs>();
        //REQUISITOS MOVIES
        List<Movies> movielist = new List<Movies>();
        List<PlaylistMovies> l_plm = new List<PlaylistMovies>();
        List<Actor> actors = new List<Actor>();
        //creamos playlist de favoritos
        List<Movies> Fmovies = new List<Movies>();
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
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        string prf = "";
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
            PlaylistFavouritesSongs playlistFavouritesSongs = new PlaylistFavouritesSongs("favoritos", "privada", Fsongs);
            QueueSongs queueSongs = new QueueSongs(Qsongs);
            QueueMovies queueMovies = new QueueMovies(Qmovies);
            Actor DonaldGlover = new Actor("Donald Glover", "Actor, cantante, guionista, director de TV, comediante estadounidense", DonaldGloverP, "Hombre", 36);
            Actor Beyonce = new Actor("Beyonce", "Cantante, compositora, bailarina, actriz, modelo", BeyonceP, "Mujer", 38);
            Actor ScarlettJohansson = new Actor("Scarlett Johannson", "Actriz de cine, cantante, modelo estadounidense", ScarlettJohannsonP, "Mujer", 35);
            Actor RobertDownley = new Actor("Robert Downley Jr.", "Actor, productor, cantante estadounidense", RobertDownleyP, "Hombre", 55);
            Actor FlorencePugh = new Actor("Florence Pugh", "Actriz", FlorencePughP, "Mujer", 24);
            PlaylistFavouriteMovies playlistFavouritesMovies = new PlaylistFavouriteMovies("favoritos", "privada", Fmovies);
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
            Movies AvengersEndgame = new Movies("Avengers Endgame", categoriesA, actorsA, "Marvel Studios", 2019, "Veintitrés días después de que Thanos hubiera usado el Guantelete del Infinito para desintegrar la mitad de toda la vida en el universo, Capitana Marvel rescata a Tony Stark y Nebula, quienes estaban varados en el espacio exterior en la nave Milano I del fallecido Quill y los lleva de regreso a la Tierra hasta el complejo de Los Vengadores, donde los esperan Natasha Romanoff, Bruce Banner, Steve Rogers, Rocket Raccoon, Thor, Pepper Potts y James Rhodes.Mientras estabilizan a Stark y lo ponen al corriente sobre los eventos que sucedieron mientras estuvo en el espacio exterior, el resto de Los Vengadores localizan por medio de Nebula a un Thanos malherido en un planeta al que este llama 'El Jardín' y deciden ir en su búsqueda con el objetivo de recuperar las Gemas del Infinito y revertir los efectos del chasquido.Consiguen reducirlo pero descubren que las gemas ya no están.Thanos revela que destruyó las gemas para evitar que fueran usadas nuevamente.Thor, enfurecido, lo decapita con la Stormbreaker.", 146);
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
                FailedLoginSesionlabel.Hide();
                InsertMailLoginSesiontextBox.Text = "";
                InsertPasswordLoginSesiontextBox.Text = "";
                MainMenulabel1.Text = "";
                LoginSesionProfilelabel1.Text = "Bienvenido";
                LoginSesionInsertProfilecomboBox.Items.Clear();
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
                MainMenulabel1.Text = "";
                MainMenupanel.Show();
                MainMenupanel.BringToFront();
                MainMenupanel.Dock = DockStyle.Fill;
                MainMenulabel1.Text = "Bienvenido Admin!";
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
                    FailedLoginSesionlabel.Hide();
                    
                    LoginSesionProfilelabel1.Text = "Bienvenido";
                    LoginSesionInsertProfilecomboBox.Items.Clear();
                    string email22 = "";
                    string password22 = "";
                    email22 = InsertMailLoginSesiontextBox.Text;
                    password22 = InsertPasswordLoginSesiontextBox.Text;
                    InsertMailLoginSesiontextBox.Text = "";
                    InsertPasswordLoginSesiontextBox.Text = "";
                    MainMenulabel1.Text = "";
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
                            prf = asw5;
                            MainMenulabel1.Text = "Bienvenido " + asw5;
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
                ProfileFollowedFollowProfilelabel.Hide();
                FollowProfilepanel.Show();
                FollowProfilepanel.BringToFront();
                FollowProfilepanel.Dock = DockStyle.Fill;
                InsertProfileFollowProfilecomboBox.Items.Remove(prf);
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
                PlaylistFollowedFollowPlaylistSongslabel.Hide();
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
                PlaylistFollowedFollowPlaylistMovieslabel.Hide();
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
                InsertArtistFollowArtistcomboBox.Items.Add("Soda stereo");
                InsertArtistFollowArtistcomboBox.Items.Add("Wos");
                InsertArtistFollowArtistcomboBox.Items.Add("The Beatles");
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
                InsertActorFollowActorcomboBox.Items.Add("Donald Glover");
                InsertActorFollowActorcomboBox.Items.Add("Beyonce");
                InsertActorFollowActorcomboBox.Items.Add("Scarlett Johannson");
                InsertActorFollowActorcomboBox.Items.Add("Robert Downley Jr");
                InsertActorFollowActorcomboBox.Items.Add("Florence Pugh");
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
                InsertAlbumFollowAlbumcomboBox.Items.Add("Doble Vida");
                InsertAlbumFollowAlbumcomboBox.Items.Add("Caravana");
                InsertAlbumFollowAlbumcomboBox.Items.Add("Let It Be");
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
                SuggestionsMoviesrichTextBox.Clear();
                foreach (KeyValuePair<string, List<Profile>> h in Users)
                {
                    foreach (Profile profile3 in h.Value)
                    {
                        if (profile3.GetUserName() == prf)
                        {
                            SuggestionsMoviesrichTextBox.Text += profile.SuggestionSong();
                            break;
                        }
                    }
                }
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
                SuggestionsSongsrichTextBox.Clear();
                foreach (KeyValuePair<string, List<Profile>> h in Users)
                {
                    foreach (Profile profile3 in h.Value)
                    {
                        if (profile3.GetUserName() == prf)
                        {
                            SuggestionsSongsrichTextBox.Text += profile3.SuggestionMovie();
                            break;
                        }
                    }
                }
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
                List<string> nombresprofiles = new List<string>();
                foreach (Profile f in profile.GetFollowProfiles())
                {

                    nombresprofiles.Add(f.GetUserName());
                    InsertProfilePartyMoviescomboBox.Items.Add(f.GetUserName());
                }
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
                List<string> nombresprofiles = new List<string>();
                foreach (Profile f in profile.GetFollowProfiles())
                {
                    
                    nombresprofiles.Add(f.GetUserName());
                    InsertProfilePartySongscomboBox.Items.Add(f.GetUserName());
                }
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

                MessageCreatePlaylistSongslabel.Hide();
                InsertPlaylistNameCreatePlaylistSongstextBox.Clear();
                InsertPrivacyCreatePlaylistSongscomboBox.Items.Clear();
                InsertPrivacyCreatePlaylistSongscomboBox.Items.Add("publica");
                InsertPrivacyCreatePlaylistSongscomboBox.Items.Add("privada");
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
                MessageQualifySongslabel.Hide();
                InsertQualificationQualifySongscomboBox.Items.Clear();
                InsertQualificationQualifySongscomboBox.Items.Add("1");
                InsertQualificationQualifySongscomboBox.Items.Add("2");
                InsertQualificationQualifySongscomboBox.Items.Add("3");
                InsertQualificationQualifySongscomboBox.Items.Add("4");
                InsertQualificationQualifySongscomboBox.Items.Add("5");
                InsertQualificationQualifySongscomboBox.Items.Add("6");
                InsertQualificationQualifySongscomboBox.Items.Add("7");
                InsertQualificationQualifySongscomboBox.Items.Add("8");
                InsertQualificationQualifySongscomboBox.Items.Add("9");
                InsertQualificationQualifySongscomboBox.Items.Add("10");
                InsertSongNameQualifySongscomboBox.Items.Clear();
                foreach (var song in l_songs)
                {
                    InsertSongNameQualifySongscomboBox.Items.Add(song.getName());
                }
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

        private void SearchSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Buscar Canción")
            {
                InsertQualificationEvaluationcomboBox.Items.Clear();
                InsertSignEvaluationcomboBox.Items.Clear();
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
                InsertAnswerArtisttextBox.Clear();
                ResultArtistrichTextBox.Clear();
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
                InsertQualificationEvaluationcomboBox.Items.Clear();
                InsertSignEvaluationcomboBox.Items.Clear();
                InsertQualificationEvaluationcomboBox.Items.Add("1");
                InsertQualificationEvaluationcomboBox.Items.Add("2");
                InsertQualificationEvaluationcomboBox.Items.Add("3");
                InsertQualificationEvaluationcomboBox.Items.Add("4");
                InsertQualificationEvaluationcomboBox.Items.Add("5");
                InsertQualificationEvaluationcomboBox.Items.Add("6");
                InsertQualificationEvaluationcomboBox.Items.Add("7");
                InsertQualificationEvaluationcomboBox.Items.Add("8");
                InsertQualificationEvaluationcomboBox.Items.Add("9");
                InsertQualificationEvaluationcomboBox.Items.Add("10");
                InsertSignEvaluationcomboBox.Items.Add("mayores");
                InsertSignEvaluationcomboBox.Items.Add("menores");
                InsertSignEvaluationcomboBox.Items.Add("iguales");
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
                InsertGenderGendertextBox.Clear();
                MessageGenderlabel.Hide();
                InsertSignEvaluationcomboBox.Items.Clear();
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
                MessageAddToPlaylistSongslabel.Hide();
                InsertSongNameAddToPlaylistSongscomboBox.Items.Clear();
                InsertPlaylistNameAddToPlaylistSongscomboBox.Items.Clear();
                foreach (var song in l_songs)
                {
                    InsertSongNameAddToPlaylistSongscomboBox.Items.Add(song.getName());
                }
                foreach(var pl in l_pl)
                {
                    InsertPlaylistNameAddToPlaylistSongscomboBox.Items.Add(pl.getName());
                }
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
                MessageAddToFavouriteSongslabel.Hide();
                InsertSongNameAddToFavouriteSongscomboBox.Items.Clear();
                foreach (var song in l_songs)
                {
                    InsertSongNameAddToFavouriteSongscomboBox.Items.Add(song.getName());
                }
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
                MessageAddToQueueSongslabel.Hide();
                InsertSongNameAddToQueueSongscomboBox.Items.Clear();
                foreach (var song in l_songs)
                {
                    InsertSongNameAddToQueueSongscomboBox.Items.Add(song.getName());
                }
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
                InsertPlaylistNameSeePlaylistSongscomboBox.Items.Clear();
                foreach (var pl in l_pl)
                {
                    InsertPlaylistNameSeePlaylistSongscomboBox.Items.Add(pl.getName());
                }
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
                string a = "";
                foreach (var q in Fsongs)
                {
                    a += q.getName() + "\n";
                }
                ResultSeeFavouriteSongsrichTextBox.Text = a;
                if (Fsongs.Count() == 0)
                {
                    ResultSeeFavouriteSongsrichTextBox.Text = "no se han añadido canciones a favoritos";
                }
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
                string a = "";
                foreach(var q in Qsongs)
                {
                    a += q.getName()+"\n";
                }
                ResultSeeQueueSongsrichTextBox.Text = a;
                if (Qsongs.Count() == 0)
                {
                    ResultSeeQueueSongsrichTextBox.Text = "no se han añadido canciones a la cola";
                }
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
                InsertSongNameInformationSongscomboBox.Items.Clear();
                foreach (var song in l_songs)
                {
                    InsertSongNameInformationSongscomboBox.Items.Add(song.getName());
                } 
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
                InsertNamePlaySongscomboBox.Items.Clear();
                foreach (var song in l_songs)
                {
                    InsertNamePlaySongscomboBox.Items.Add(song.getName());
                }
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
                foreach (var movie in movielist)
                {
                    InsertMovieNamePlayMoviescomboBox.Items.Add(movie.GetName());
                }
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

                InsertQualificationQualifyMoviescomboBox.Items.Clear();
                InsertQualificationQualifyMoviescomboBox.Items.Add("1");
                InsertQualificationQualifyMoviescomboBox.Items.Add("2");
                InsertQualificationQualifyMoviescomboBox.Items.Add("3");
                InsertQualificationQualifyMoviescomboBox.Items.Add("4");
                InsertQualificationQualifyMoviescomboBox.Items.Add("5");
                InsertQualificationQualifyMoviescomboBox.Items.Add("6");
                InsertQualificationQualifyMoviescomboBox.Items.Add("7");
                InsertQualificationQualifyMoviescomboBox.Items.Add("8");
                InsertQualificationQualifyMoviescomboBox.Items.Add("9");
                InsertQualificationQualifyMoviescomboBox.Items.Add("10");
                InsertMovieNameQualifyMoviescomboBox.Items.Clear();
                foreach (var movie in movielist)
                {
                    InsertMovieNameQualifyMoviescomboBox.Items.Add(movie.GetName());
                }
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
                InsertMovieNameInformationMoviescomboBox.Items.Clear();
                foreach (var movie in movielist)
                {
                    InsertMovieNameInformationMoviescomboBox.Items.Add(movie.GetName());
                }
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
                InsertMovieNameAddPlaylistMoviescomboBox.Items.Clear();
                InsertPlaylistNameAddPlaylistMoviescomboBox.Items.Clear();
                foreach (var movie in movielist)
                {
                    InsertMovieNameAddPlaylistMoviescomboBox.Items.Add(movie.GetName());
                }
                foreach (var pl in l_plm)
                {
                    InsertPlaylistNameAddPlaylistMoviescomboBox.Items.Add(pl.GetName());
                }
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
                MessageCreatePlaylistMovieslabel.Hide();
                InsertPlaylistNameCreatePlaylistMoviestextBox.Clear();
                InsertPlaylistPrivacyCreatePlaylistMoviescomboBox.Items.Clear();
                InsertPlaylistPrivacyCreatePlaylistMoviescomboBox.Items.Add("publica");
                InsertPlaylistPrivacyCreatePlaylistMoviescomboBox.Items.Add("privada");
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
                string a = "";
                foreach (var movie in movielist)
                {
                    a += movie.GetName()+ "\n";
                }
                SeeMoviesrichTextBox.Text = a;
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
                InsertPlaylistNameSeePlaylistMoviescomboBox.Items.Clear();
                foreach (var pl in l_plm)
                {
                    InsertPlaylistNameSeePlaylistMoviescomboBox.Items.Add(pl.GetName());
                }
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
                InsertMovienameAddQueueMoviescomboBox.Items.Clear();
                foreach (var movie in movielist)
                {
                    InsertMovienameAddQueueMoviescomboBox.Items.Add(movie.GetName());
                }
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
                string a = "";
                foreach (var q in Fmovies)
                {
                    a += q.GetName() + "\n";
                }
                ResultSeeFavouriteMoviesrichTextBox.Text = a;
                if (Fmovies.Count() == 0)
                {
                    ResultSeeFavouriteMoviesrichTextBox.Text = "no se han añadido peliculas a favoritos";
                }
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
                MessageSelectFavouriteMovieslabel.Hide();
                InsertMovieNameSelectFavouriteMoviescomboBox.Items.Clear();
                foreach (var movie in movielist)
                {
                    InsertMovieNameSelectFavouriteMoviescomboBox.Items.Add(movie.GetName());
                }
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
                string a = "";
                foreach (var q in Qmovies)
                {
                    a += q.GetName() + "\n";
                }
                ResultSeeQueueMoviesrichTextBox.Text = a;
                if (Qmovies.Count() == 0)
                {
                    ResultSeeQueueMoviesrichTextBox.Text = "no se han añadido canciones a la cola";
                }
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
                CreateUserAvisolabel.Hide();
                CreateUserAviso2label1.Hide();
                InsertUserMailtextBox.Text = "";
                InsertUserPasswordtextBox.Text = "";
                InsertPlanTypetextBox.Text = "";
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
                ProfileCreatedlabel.Hide();
                InsertUsernameCreateProfiletextBox.Text = "";
                PrivacyProfileCreateProfiletextBox.Text = "";
                InsertUserCreateProfiletextBox.Text = "";
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

                SeeProfilesrichTextBox.Clear();
                string text = "";
                SeeProfilespanel.Show();
                SeeProfilespanel.BringToFront();
                SeeProfilespanel.Dock = DockStyle.Fill;

                foreach (KeyValuePair<string, List<Profile>> a in Users)
                {
                    text += a.Key + " \n";
                    foreach (Profile d in a.Value)
                    {
                        text+= "Username: "+ d.GetUserName() + "Privacidad: "+ d.GetPrivacy() + "\n";
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
                
                CreateUserAvisolabel.Hide();
                CreateUserAviso2label1.Hide();
                username = InsertUserMailtextBox.Text;
                password = InsertUserPasswordtextBox.Text;
                plan = InsertPlanTypetextBox.Text;
                user.CreateUser(plan, username, password);
                InsertUserMailtextBox.Text = "";
                InsertUserPasswordtextBox.Text = "";
                InsertPlanTypetextBox.Text = "";
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
                ProfileCreatedlabel.Hide();

                profile = InsertUsernameCreateProfiletextBox.Text;
                privacy = Convert.ToBoolean(PrivacyProfileCreateProfiletextBox.Text);
                username1 = InsertUserCreateProfiletextBox.Text;
                InsertUsernameCreateProfiletextBox.Text = "";
                PrivacyProfileCreateProfiletextBox.Text = "";
                InsertUserCreateProfiletextBox.Text = "";
                int n = Users.Keys.Count;
                if (n == 0)
                {
                    Profile profile2 = new Profile(profile, privacy);
                    List<Profile> ListOfProfiles = new List<Profile>();
                    ListOfProfiles.Add(profile2);
                    ProfileCreatedlabel.Show();
                    InsertProfileFollowProfilecomboBox.Items.Add(profile);
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
                                InsertProfileFollowProfilecomboBox.Items.Add(profile);
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
                        InsertProfileFollowProfilecomboBox.Items.Add(profile);
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
                            if (b.Text == "Modificar")
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

        private void WelcomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateCreatePlaylistSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Crear")
            {
                string PLname = InsertPlaylistNameCreatePlaylistSongstextBox.Text;          
                string PLprivacy = InsertPrivacyCreatePlaylistSongscomboBox.Text;
                List<Songs> PLsongs = new List<Songs>();
                PlaylistSongs playlist = new PlaylistSongs(PLname, PLprivacy, PLsongs);
                l_pl.Add(playlist);
                MessageCreatePlaylistSongslabel.Show();
                InsertPlaylistFollowPlaylistSongscomboBox.Items.Add(PLname);
            }
        }

        private void Songspanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QualifyQualifySongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Calificar")
            {
                MessageQualifySongslabel.Hide();
                foreach (var song in l_songs)
                {
                    if(song.getName() == InsertSongNameQualifySongscomboBox.Text)
                    {
                        string cal = InsertQualificationQualifySongscomboBox.Text;
                        int Cal = Int16.Parse(cal);
                        song.Qualification(Cal);
                        MessageQualifySongslabel.Show();
                    }
                }        
            }
        }

        private void AddAddToQueueSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Agregar")
            {
                MessageAddToQueueSongslabel.Hide();
                foreach (var song in l_songs)
                {
                    if (song.getName() == InsertSongNameAddToQueueSongscomboBox.Text)
                    {
                        Qsongs.Add(song);
                        MessageAddToQueueSongslabel.Show();
                    }
                }
            }
        }

        private void AddAddToPlaylistSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Agregar")
            {
                MessageAddToPlaylistSongslabel.Hide();
                foreach (var song in l_songs)
                {
                    foreach(var pl in l_pl)
                    {
                        if (song.getName() == InsertSongNameAddToPlaylistSongscomboBox.Text && pl.getName() == InsertPlaylistNameAddToPlaylistSongscomboBox.Text)
                        {
                            pl.AddSongs(song);
                            MessageAddToPlaylistSongslabel.Show();
                        }
                    }
                }
            }
        }

        private void SeeSeePlaylistSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Ver")
            {
                foreach (var pl in l_pl)
                {
                    if (pl.getName() == InsertPlaylistNameSeePlaylistSongscomboBox.Text)
                    {
                        ResultSeePlaylistSongsrichTextBox.Text = pl.showSongs();
                    }
                }
            }
        }

        private void AddAddToFavouriteSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Agregar")
            {
                MessageAddToFavouriteSongslabel.Hide();
                foreach (var song in l_songs)
                {
                    if (song.getName() == InsertSongNameAddToFavouriteSongscomboBox.Text)
                    {
                        Fsongs.Add(song);
                        MessageAddToFavouriteSongslabel.Show();
                    }
                }
            }
        }

        private void PlayPlaySongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Reproducir")
            {
                foreach (var song in l_songs)
                {
                    if (InsertNamePlaySongscomboBox.Text == song.getName())
                    {
                        song.NumberOfUser();
                        song.Reproduction();

                        wmp.URL = song.getName() + ".wav";
                        wmp.controls.play();
                    }
                }
            }

        }
        private void StopPlaySongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Parar")
            {
                foreach (var song in l_songs)
                {
                    if (InsertNamePlaySongscomboBox.Text == song.getName())
                    {
                        song.NumberOfUser();
                        song.Reproduction();
                        
                        wmp.URL = song.getName() + ".wav";
                        wmp.controls.stop();
                    }
                }
            }
        }

        private void ArtistInformationSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Artista")
            {
                foreach (var song in l_songs)
                {
                    if (song.getName() == InsertSongNameInformationSongscomboBox.Text)
                    {
                        ResultInformationSongsrichTextBox.Text = song.getArtist();
                    }
                }
            }
        }

        private void GenderInformationSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Género")
            {
                foreach (var song in l_songs)
                {
                    if (song.getName() == InsertSongNameInformationSongscomboBox.Text)
                    {
                        ResultInformationSongsrichTextBox.Text = song.getGender();
                    }
                }
            }
        }

        private void CompositorInformationSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Compositor")
            {
                foreach (var song in l_songs)
                {
                    if (song.getName() == InsertSongNameInformationSongscomboBox.Text)
                    {
                        ResultInformationSongsrichTextBox.Text = song.getComposer();
                    }
                }
            }
        }

        private void StudioInformationSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Estudio")
            {
                foreach (var song in l_songs)
                {
                    if (song.getName() == InsertSongNameInformationSongscomboBox.Text)
                    {
                        ResultInformationSongsrichTextBox.Text = song.getStudio();
                    }
                }
            }
        }

        private void LyricsInformationSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Letra")
            {
                foreach (var song in l_songs)
                {
                    if (song.getName() == InsertSongNameInformationSongscomboBox.Text)
                    {
                        ResultInformationSongsrichTextBox.Text = song.getLyrics();
                    }
                }
            }
        }

        private void YearInformationSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Año")
            {
                foreach (var song in l_songs)
                {
                    if (song.getName() == InsertSongNameInformationSongscomboBox.Text)
                    {
                        string a = song.getYear().ToString();
                        ResultInformationSongsrichTextBox.Text = a;
                    }
                }
            }
        }

        private void QualificationInformationSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Calificación")
            {
                foreach (var song in l_songs)
                {
                    if (song.getName() == InsertSongNameInformationSongscomboBox.Text)
                    {
                        string a = song.getQualification().ToString();
                        ResultInformationSongsrichTextBox.Text = a;
                    }
                }
            }
        }

        private void ReproductionsInformationSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Reproducciones")
            {
                foreach (var song in l_songs)
                {
                    if (song.getName() == InsertSongNameInformationSongscomboBox.Text)
                    {
                        string a = song.getReproductions().ToString();
                        ResultInformationSongsrichTextBox.Text = a;
                    }
                }
            }
        }

        private void DurationInformationSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Duración")
            {
                foreach (var song in l_songs)
                {
                    if (song.getName() == InsertSongNameInformationSongscomboBox.Text)
                    { 
                        ResultInformationSongsrichTextBox.Text = song.getDuration();
                    }
                }
            }
        }

        private void SearchGenderbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Buscar")
            {
                MessageGenderlabel.Hide();
                string catego = InsertGenderGendertextBox.Text;
                int ab = 0;
                string a = "";
                foreach (var song in l_songs)
                {
                    if (song.getGender() == catego)
                    {
                        a += song.getName() + "\n";
                        ab = 1;
                    }
                }
                foreach (var artist in l_artist)
                {
                    if (artist.getGender() == catego)
                    {
                        a += artist.getName() + "\n";
                        ab = 1;
                    }
                }
                ResultGenderrichTextBox.Text = a;
                if (ab == 0)
                {
                    MessageGenderlabel.Show();
                }
            }
        }

        private void SearchEvaluationbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Buscar")
            {
                
                InsertSignEvaluationcomboBox.Items.Clear();
                string wq = InsertQualificationEvaluationcomboBox.Text;
                int vall = Int16.Parse(wq);
                string crtt = InsertSignEvaluationcomboBox.Text;
                int ax = 0;
                string a = "";
                if (crtt == "mayores")
                {
                    foreach (var song in l_songs)
                    {
                        if (song.getQualification() > vall)
                        {
                            a += song.getName() + " " + song.getQualification()+"\n";
                            ResultEvaluationrichTextBox.Text = a;
                            ax = 1;
                        }
                    }
                }
                if (crtt == "menores")
                {
                    foreach (var song in l_songs)
                    {
                        if (song.getQualification() < vall)
                        {
                            a += song.getName() + " " + song.getQualification() + "\n";
                            ResultEvaluationrichTextBox.Text = a;
                            ax = 1;
                        }
                    }
                }
                if (crtt == "iguales")
                {
                    foreach (var song in l_songs)
                    {
                        if (song.getQualification() == vall)
                        {
                            a += song.getName() + " " + song.getQualification() + "\n";
                            ResultEvaluationrichTextBox.Text = a;
                            ax = 1;
                        }
                    }
                }
                if (ax == 0)
                {
                    ResultEvaluationrichTextBox.Text = "Su busqueda no coincide";
                }
            }
        }

        private void InsertQualificationEvaluationcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgeArtistbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Por edad")
            {
                try
                {
                    string edad = InsertAnswerArtisttextBox.Text;
                    int edad2 = Int16.Parse(edad);
                    string a = "";
                    foreach (var artist in l_artist)
                    {
                        if (artist.getAge() == edad2)
                        {
                            a += "tiene esa edad el artista: " + artist.getName();
                            ResultArtistrichTextBox.Text = a;
                        }
                    }
                }
                catch
                {
                    ResultArtistrichTextBox.Text = "No se encontro un artista";
                }
            }
        }

        private void GenderArtistbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Por género musical")
            {
                try
                {
                    string gene = InsertAnswerArtisttextBox.Text;
                    string a = "";
                    foreach (var artist in l_artist)
                    {
                        if (artist.getGender() == gene)
                        {
                            a += "ese genero lo toca : " + artist.getName();
                            ResultArtistrichTextBox.Text = a;

                        }
                    }
                }
                catch
                {
                    ResultArtistrichTextBox.Text = "No se encontro un artista";
                }
            }
        }

        private void InsertPlaylistNameCreatePlaylistSongstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateCreatePlaylistMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Crear")
            {
                string PLname = InsertPlaylistNameCreatePlaylistMoviestextBox.Text;
                string PLprivacy = InsertPlaylistPrivacyCreatePlaylistMoviescomboBox.Text;
                List<Movies> PLmovie = new List<Movies>();
                PlaylistMovies playlist = new PlaylistMovies(PLname, PLprivacy, PLmovie);
                l_plm.Add(playlist);
                MessageCreatePlaylistMovieslabel.Show();
                InsertPlaylistFollowPlaylistMoviescomboBox.Items.Add(PLname);
            }
        }

        private void QualifyQualifyMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Calificar")
            {
                foreach (var movie in movielist)
                {
                    if (movie.GetName() == InsertMovieNameQualifyMoviescomboBox.Text)
                    {
                        string cal = InsertQualificationQualifyMoviescomboBox.Text;
                        int Cal = Int16.Parse(cal);
                        movie.Qualification(Cal);
                    }
                }
            }
        }

        private void ActorInformationMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Actores")
            {
                string a = "";
                foreach(var movie in movielist)
                {
                    if (movie.GetName() == InsertMovieNameInformationMoviescomboBox.Text)
                    {
                        foreach (var c in movie.GetActors())
                        {
                            a += c.GetName()+"\n";
                        }
                    }
                }
                ResultInformationMoviesrichTextBox.Text = a;
            }
        }

        private void DurationInformationMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Duración")
            {
                string a = "";
                foreach (var movie in movielist)
                {
                    if (movie.GetName() == InsertMovieNameInformationMoviescomboBox.Text)
                    {
                        int c = movie.GetDuration();
                        a += c.ToString() + " minutos";
                    }
                }
                ResultInformationMoviesrichTextBox.Text = a;
            }
        }

        private void ReproductionsInformationMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Reproducciones")
            {
                string a = "";
                foreach (var movie in movielist)
                {
                    if (movie.GetName() == InsertMovieNameInformationMoviescomboBox.Text)
                    {
                        int c = movie.GetReproductions();
                        a += c.ToString();
                    }
                }
                ResultInformationMoviesrichTextBox.Text = a;
            }
        }

        private void YearInformationMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Año")
            {
                string a = "";
                foreach (var movie in movielist)
                {
                    if (movie.GetName() == InsertMovieNameInformationMoviescomboBox.Text)
                    {
                        int c = movie.GetYear();
                        a += c.ToString();
                    }
                }
                ResultInformationMoviesrichTextBox.Text = a;
            }
        }

        private void QualificationInformationMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Calificación")
            {
                string a = "";
                foreach (var movie in movielist)
                {
                    if (movie.GetName() == InsertMovieNameInformationMoviescomboBox.Text)
                    {
                        double c = movie.GetQualification();
                        a += c.ToString();
                    }
                }
                ResultInformationMoviesrichTextBox.Text = a;
            }
        }

        private void DescriptionInformationMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Descripción")
            {
                foreach (var movie in movielist)
                {
                    if (movie.GetName() == InsertMovieNameInformationMoviescomboBox.Text)
                    {
                        ResultInformationMoviesrichTextBox.Text = movie.GetDescription();
                    }
                }
            }
        }

        private void CategoriesInformationMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Categorías")
            {
                string a = "";
                foreach (var movie in movielist)
                {
                    if (movie.GetName() == InsertMovieNameInformationMoviescomboBox.Text)
                    {
                        foreach (var c in movie.GetCategories())
                        {
                            a += c + "\n";
                        }
                    }
                }
                ResultInformationMoviesrichTextBox.Text = a;
            }
        }

        private void StudioInformationMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Estudio")
            {
                foreach (var movie in movielist)
                {
                    if (movie.GetName() == InsertMovieNameInformationMoviescomboBox.Text)
                    {
                        ResultInformationMoviesrichTextBox.Text = movie.GetStudio();
                    }
                }
            }
        }

        private void AddAddPlaylistMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Agregar")
            {
                foreach (var movie in movielist)
                {
                    foreach (var pl in l_plm)
                    {
                        if (movie.GetName() == InsertMovieNameAddPlaylistMoviescomboBox.Text && pl.GetName() == InsertPlaylistNameAddPlaylistMoviescomboBox.Text)
                        {
                            pl.AddMovies(movie);
                        }
                    }
                }
            }
        }

        private void SeeSeePlaylistMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Ver")
            {
                foreach (var pl in l_plm)
                {
                    if (pl.GetName() == InsertPlaylistNameSeePlaylistMoviescomboBox.Text)
                    {
                        ResultSeePlaylistMoviesrichTextBox.Text = pl.showSongs();
                    }
                }
            }
        }

        private void AddAddQueueMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Agregar")
            {
                foreach (var movie in movielist)
                {
                    if (movie.GetName() == InsertMovienameAddQueueMoviescomboBox.Text)
                    {
                        Qmovies.Add(movie);
                    }
                }
            }
        }

        private void SelectSelectFavouriteMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seleccionar")
            {
                MessageSelectFavouriteMovieslabel.Hide();
                foreach (var movie in movielist)
                {
                    if (movie.GetName() == InsertMovieNameSelectFavouriteMoviescomboBox.Text)
                    {
                        Fmovies.Add(movie);
                        MessageSelectFavouriteMovieslabel.Show();
                    }
                }
            }
        }

        private void InsertMovieNameSelectFavouriteMoviescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PlayPlayMoviesbutton_Click(object sender, EventArgs e)
        {
            string mov = InsertMovieNamePlayMoviescomboBox.Text;
            foreach (var movie in movielist)
            {
                if (movie.GetName() == mov)
                {
                    movie.Reproduction();
                    try
                    {
                        System.Diagnostics.Process.Start(mov + ".mp4");
                    }
                    catch
                    {
                        
                    }
                }
            }
        }

        private void FollowFollowProfilebutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text == "Seguir")
            {
                ProfileFollowedFollowProfilelabel.Hide();
                string perfil = InsertProfileFollowProfilecomboBox.Text;
                foreach (KeyValuePair<string, List<Profile>> h in Users)
                {
                    foreach (Profile l in h.Value)
                    {
                        if (l.GetUserName() == perfil)
                        {
                            profile.AddProfile(l);
                            ProfileFollowedFollowProfilelabel.Show();
                            break;
                        }
                    }
                }
            }
        }

        private void FollowFollowPlaylistSongsbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text == "Seguir")
            {
                PlaylistFollowedFollowPlaylistSongslabel.Hide();
                string playlistsong = InsertPlaylistFollowPlaylistSongscomboBox.Text;
                foreach (PlaylistSongs playlistSongs in l_pl)
                {
                    if (playlistSongs.getName() == playlistsong)
                    {
                        profile.AddPlaylistSong(playlistSongs);
                        PlaylistFollowedFollowPlaylistSongslabel.Show();
                        break;
                    }
                }
            }
        }

        private void FollowFollowPlaylistMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text == "Seguir")
            {
                PlaylistFollowedFollowPlaylistMovieslabel.Hide();
                string playlistmovie = InsertPlaylistFollowPlaylistMoviescomboBox.Text;
                foreach (PlaylistMovies playlistMovies in l_plm)
                {
                    if (playlistMovies.GetName() == playlistmovie)
                    {
                        profile.AddPlaylistMovie(playlistMovies);
                        PlaylistFollowedFollowPlaylistMovieslabel.Show();
                        break;
                    }

                }
            }
        }

        private void FollowFollowArtistbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seguir")
            {
                string artist = InsertArtistFollowArtistcomboBox.Text;
                foreach (Artist artist1 in l_artist)
                {
                    if (artist1.getName() == artist)
                    {
                        profile.AddArtist(artist1);
                        ArtistFollowedFollowArtistlabel.Show();
                        break;
                    }
                }
            }
        }

        private void FollowFollowActorbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seguir")
            {
                string actor = InsertActorFollowActorcomboBox.Text;
                foreach (Actor actor2 in actors)
                {
                    if (actor2.GetName() == actor)
                    {
                        profile.AddActor(actor2);
                        ActorFollowedFollowActorlabel.Show();
                        break;
                    }
                }
            }
        }

        private void FollowFollowAlbumbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Seguir")
            {
                string album = InsertAlbumFollowAlbumcomboBox.Text;
                foreach (Album album1 in l_album)
                {
                    if (album1.getName() == album)
                    {
                        profile.AddAlbum(album1);
                        AlbumFollowedFollowAlbumlabel.Show();
                        break;
                    }
                }
            }
        }

        private void GoPartySongsbutton_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (b.Text == "Unirse")
            {
                Message1PartySongslabel.Show();
                Message2PartySongslabel.Show();
                StopPartySongsbutton.Show();
                profile.JoinPartySong("El Alfa El Jefe x Lil Pump - Coronao Now (Video Oficial).wav");
                if (b.Text == "stop")
                {
                    WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                    wmp.controls.pause();
                }
            }
        }

        private void GoPartyMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Unirse")
            {
                Message1PartyMovieslabel.Show();
                Message2PartyMovieslabel.Show();
                profile.JoinPartyMovie("tarzan-trailer");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void QualificationMoviespanel_Paint(object sender, PaintEventArgs e)
        {

        }
	private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Resolución")
            {
                ResultResolutionMoviesrichTextBox.Clear();
                InsertTypeResolutionMoviestextBox.Clear();
                ResolutionMoviespanel.Show();
                ResolutionMoviespanel.BringToFront();
                ResolutionMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void QualificationMoviespanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchPersonMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Buscar")
            {
                List<Movies> moviesSearched = new List<Movies>();
                string name = InsertPersonNamePersonMoviestextBox.Text;
                foreach (Movies movie in movielist)
                {
                    foreach (Actor actor in movie.GetActors())
                    {
                        if (name == actor.GetName())
                        {
                            if (moviesSearched.Contains(movie) == false)
                            {
                                moviesSearched.Add(movie);
                            }
                        }
                    }
                }
                string a = "";
                foreach(Movies movie in moviesSearched)
                {
           
                    a += movie.GetName()+"\n";
                }
                ResultPersonMoviesrichTextBox.Text = a;
                if (moviesSearched.Count == 0)
                {
                    ResultCharacteristicsMoviesrichTextBox.Text = "No se ha encontrado la busqueda";
                }
            }
        }

        private void PersonSearchMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Persona")
            {
                ResultPersonMoviesrichTextBox.Clear();
                PersonMoviespanel.Show();
                PersonMoviespanel.BringToFront();
                PersonMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void KeywordSearchMoviesbutton_Click(object sender, EventArgs e)
        {

        }

        private void CharacteristicsSearchMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Característicasw de la persona")
            {
                InsertCharacteristicCharacteristicMoviestextBox.Clear();
                InsertCharacteristicCharacteristicMoviescomboBox.Items.Clear();
                ResultCharacteristicsMoviesrichTextBox.Clear();
                InsertCharacteristicCharacteristicMoviescomboBox.Items.Add("Nombre");
                InsertCharacteristicCharacteristicMoviescomboBox.Items.Add("Biografía");
                InsertCharacteristicCharacteristicMoviescomboBox.Items.Add("Participación en películas");
                InsertCharacteristicCharacteristicMoviescomboBox.Items.Add("Sexo");
                InsertCharacteristicCharacteristicMoviescomboBox.Items.Add("Edad");
                CharacteristicsMoviespanel.Show();
                CharacteristicsMoviespanel.BringToFront();
                CharacteristicsMoviespanel.Dock = DockStyle.Fill;
            }
           
        }

        private void InsertCharacteristicCharacteristicMoviestextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CharacteristicsMoviespanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchCharacteristicsMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Buscar")
            {
                List<Movies> moviesSearched = new List<Movies>();
                string option = InsertCharacteristicCharacteristicMoviescomboBox.Text;
                if (option == "Nombre")
                {
                    string name = InsertCharacteristicCharacteristicMoviestextBox.Text;
                    foreach (Movies movie in movielist)
                    {
                        foreach (Actor actor in movie.GetActors())
                        {
                            if (name == actor.GetName())
                            {
                                if (moviesSearched.Contains(movie) == false)
                                {
                                    moviesSearched.Add(movie);
                                }
                            }
                        }
                    }
                }
                if (option == "Biografía")
                {
                    string biography = InsertCharacteristicCharacteristicMoviestextBox.Text;
                    foreach (Movies movie in movielist)
                    {
                        foreach (Actor actor in movie.GetActors())
                        {
                            if (actor.GetBiography().Contains(biography))
                            {
                                if (moviesSearched.Contains(movie) == false)
                                {
                                    moviesSearched.Add(movie);
                                }
                            }
                        }
                    }
                }
                if (option == "Participación en películas")
                {
                    List<string> participation = new List<string>();
                    string p = InsertCharacteristicCharacteristicMoviestextBox.Text;
                    participation.Add(p);
                    foreach (Movies movie in movielist)
                    {
                        foreach (Actor actor in movie.GetActors())
                        {
                            foreach (string p1 in actor.GetParticipation())
                            {
                                foreach (string p2 in participation)
                                {
                                    if (p1 == p2)
                                    {
                                        if (moviesSearched.Contains(movie) == false)
                                        {
                                            moviesSearched.Add(movie);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (option == "Sexo")
                {
                    string gender = InsertCharacteristicCharacteristicMoviestextBox.Text;
                    foreach (Movies movie in movielist)
                    {
                        foreach (Actor actor in movie.GetActors())
                        {
                            if (gender == actor.GetGender())
                            {
                                if (moviesSearched.Contains(movie) == false)
                                {
                                    moviesSearched.Add(movie);
                                }
                            }
                        }
                    }
                }

                if (option == "Edad")
                {
                    int min = Convert.ToInt32(InsertCharacteristicCharacteristicMoviestextBox.Text);
                    foreach (Movies movie in movielist)
                    {
                        foreach (Actor actor in movie.GetActors())
                        {
                            if (min == actor.GetAge())
                            {
                                if (moviesSearched.Contains(movie) == false)
                                {
                                    moviesSearched.Add(movie);
                                }
                            }
                        }
                    }
                }
                string a = "";
                foreach (Movies movie in moviesSearched)
                {

                    a += movie.GetName() + "\n";
                }
                ResultCharacteristicsMoviesrichTextBox.Text = a;
                if (moviesSearched.Count == 0)
                {
                    ResultCharacteristicsMoviesrichTextBox.Text = "No se ha encontrado la busqueda";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SearchResolutionMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Buscar")
            {
                ResultResolutionMoviesrichTextBox.Clear();
                InsertTypeResolutionMoviestextBox.Clear();
                List<Movies> moviesSearched = new List<Movies>();
                string choice = InsertTypeResolutionMoviestextBox.Text;
                foreach (Movies movie in movielist)
                {
                    if (choice == movie.GetResolution())
                    {
                        if (moviesSearched.Contains(movie) == false)
                        {
                            moviesSearched.Add(movie);
                        }
                    }
                }
                string a = "";
                foreach (Movies movie in moviesSearched)
                {

                    a += movie.GetName() + "\n";
                }
                ResultResolutionMoviesrichTextBox.Text = a;
                if (moviesSearched.Count == 0)
                {
                    ResultResolutionMoviesrichTextBox.Text = "No se ha encontrado la busqueda";
                }
            }
        }

        private void CategorieSearchMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Persona")
            {
                ResultCategorieMoviesrichTextBox.Clear();
                InsertCategorieNameCategorieMoviestextBox.Clear();
                CategorieMoviespanel.Show();
                CategorieMoviespanel.BringToFront();
                CategorieMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void SearchCategorieMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Buscar")
            {
                List<Movies> moviesSearched = new List<Movies>();
                string choice = InsertCategorieNameCategorieMoviestextBox.Text;
                foreach (Movies movie in movielist)
                {
                    foreach (string categorie in movie.GetCategories())
                    {
                        if (choice == categorie)
                        {
                            if (moviesSearched.Contains(movie) == false)
                            {
                                moviesSearched.Add(movie);
                            }
                        }
                    }
                }
                string a = "";
                foreach (Movies movie in moviesSearched)
                {

                    a += movie.GetName() + "\n";
                }
                ResultCategorieMoviesrichTextBox.Text = a;
                if (moviesSearched.Count == 0)
                {
                    ResultCategorieMoviesrichTextBox.Text = "No se ha encontrado la busqueda";
                }
            }
        }

        private void QualificationSearchMoviesbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Evaluación")
            {
                ResultQualificationMoviesrichTextBox.Clear();
                InsertMinQualificationMoviescomboBox.Items.Clear();
                InsertMaxQualificationMoviescomboBox.Items.Clear();
                InsertMaxQualificationMoviescomboBox.Items.Add("1");
                InsertMaxQualificationMoviescomboBox.Items.Add("2");
                InsertMaxQualificationMoviescomboBox.Items.Add("3");
                InsertMaxQualificationMoviescomboBox.Items.Add("4");
                InsertMaxQualificationMoviescomboBox.Items.Add("5");
                InsertMaxQualificationMoviescomboBox.Items.Add("6");
                InsertMaxQualificationMoviescomboBox.Items.Add("7");
                InsertMaxQualificationMoviescomboBox.Items.Add("8");
                InsertMaxQualificationMoviescomboBox.Items.Add("9");
                InsertMaxQualificationMoviescomboBox.Items.Add("10");
                InsertMinQualificationMoviescomboBox.Items.Add("1");
                InsertMinQualificationMoviescomboBox.Items.Add("2");
                InsertMinQualificationMoviescomboBox.Items.Add("3");
                InsertMinQualificationMoviescomboBox.Items.Add("4");
                InsertMinQualificationMoviescomboBox.Items.Add("5");
                InsertMinQualificationMoviescomboBox.Items.Add("6");
                InsertMinQualificationMoviescomboBox.Items.Add("7");
                InsertMinQualificationMoviescomboBox.Items.Add("8");
                InsertMinQualificationMoviescomboBox.Items.Add("9");
                InsertMinQualificationMoviescomboBox.Items.Add("10");
                QualificationMoviespanel.Show();
                QualificationMoviespanel.BringToFront();
                QualificationMoviespanel.Dock = DockStyle.Fill;
            }
        }

        private void InsertMinQualificationMoviescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SearchQualificationMoviesbutton_Click(object sender, EventArgs e)
        {
            List<Movies> moviesSearched = new List<Movies>();
            int min = Convert.ToInt32(InsertMinQualificationMoviescomboBox.Text);
            int max = Convert.ToInt32(InsertMaxQualificationMoviescomboBox.Text);
            foreach (Movies movie in movielist)
            {
                if (movie.GetQualification() >= min && movie.GetQualification() <= max)
                {
                    if (moviesSearched.Contains(movie) == false)
                    {
                        moviesSearched.Add(movie);
                    }
                }
            }
            string a = "";
            foreach (Movies movie in moviesSearched)
            {

                a += movie.GetName() + "\n";
            }
            ResultQualificationMoviesrichTextBox.Text = a;
            if (moviesSearched.Count == 0)
            {
                ResultQualificationMoviesrichTextBox.Text = "No se ha encontrado la busqueda";
            }
        }
    }
}

