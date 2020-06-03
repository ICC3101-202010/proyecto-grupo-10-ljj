using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Gráfica_Entrega_3
{
    public partial class SpotflixForm : Form
    {
        public SpotflixForm()
        {
            InitializeComponent();
        }
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Iniciar Sesión")
            {
                LoginSesionpanel.Show();
                LoginSesionpanel.Dock = DockStyle.Fill;
            }
        }

        private void ADCbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Administración de cuentas")
            {
                ADCpanel.Show();
                ADCpanel.Dock = DockStyle.Fill;
            }
        }

        private void LoginAdminbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Iniciar Sesión como Administrador")
            {
                MainMenupanel.Show();
                MainMenupanel.Dock = DockStyle.Fill;
            }
        }

        private void LoginSesionbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Ingresar")
            {
                LoginSesionProfilepanel.Show();
                LoginSesionProfilepanel.Dock = DockStyle.Fill;
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

        private void LoginSesionProfilebutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Ingresar")
            {
                MainMenupanel.Show();
                MainMenupanel.Dock = DockStyle.Fill;
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
                SeeProfilespanel.Show();
                SeeProfilespanel.Dock = DockStyle.Fill;
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
    }
}
