using System;
using System.Collections.Generic;
using WMPLib;
namespace Entrega2ProyectoLJJ
{
    public class Profile
    {
        private string username;
        //private photo
        private bool privacy;
        private List <Profile> FollowProfile = new List<Profile>();
        private List<PlaylistSongs> FollowPlaylistSong = new List<PlaylistSongs>();
        private List<PlaylistMovies> FollowPlaylistMovie = new List<PlaylistMovies>();
        private List<Album> FollowAlbum = new List<Album>();
        private List<Artist> FollowArtist = new List<Artist>();
        private List<Actor> FollowActor = new List<Actor>();
        private List<string> vistas = new List<string>();
        private List<string> escuchadas = new List<string>();
        public Profile(string username, bool privacy)
        {
            this.username = username;
            this.privacy = privacy;
        }
        public void AddProfile(Profile profile)
        {
            FollowProfile.Add(profile);
        }
        public void AddPlaylistSong(PlaylistSongs PlaylistSong)
        {
            FollowPlaylistSong.Add(PlaylistSong);
        }
        public void AddPlaylistMovie(PlaylistMovies PlaylistMovie)
        {
            FollowPlaylistMovie.Add(PlaylistMovie);
        }
        public void AddAlbum(Album album)
        {
            FollowAlbum.Add(album);
        }
        public void AddArtist(Artist artist)
        {
            FollowArtist.Add(artist);
        }
        public void AddActor(Actor actor)
        {
            FollowActor.Add(actor);
        }
        public bool GetPrivacy()
        {
            return privacy;
        }
        public string GetUserName()
        {
            return username;
        }
        public List<Profile> GetFollowProfiles()
        {
            return FollowProfile;
        }
        public void ChangeUsername(string newusername)
        {
            username = newusername;
        }
        public void ChangePrivacy(bool newprivacy)
        {
            privacy = newprivacy;
        }
        public string SuggestionMovie()
        {
            string mensaje = "";
            if(!vistas.Contains("Ciudad de la furia"))
            {
                mensaje += "Ciudad de la furia \n";
            }
            if(!vistas.Contains("Melon vino"))
            {
                mensaje += "Melon vino \n";
            }
            if (!vistas.Contains("Let It Be"))
            {
                mensaje += "Let It Be \n";
            }
            return mensaje;
        }
        public string SuggestionSong()
        {
            string mensaje = "";
            if (!vistas.Contains("The Lion King"))
            {
                mensaje += "The Lion King \n";
            }
            if (!vistas.Contains("Avengers: Endgame"))
            {
                mensaje += "Avengers: Endgame \n";
            }
            if (!vistas.Contains("Black Widow"))
            {
                mensaje += "Black Widow \n";
            }
            return mensaje;
        }
        public void JoinPartySong(string url)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            wmp.URL = url;
            wmp.controls.play();
        }
        public void JoinPartyMovie(string url)
        {
            string mov = url + ".mp4";
            System.Diagnostics.Process.Start(mov);
        }
        public void Vista(string movie)
        {
            vistas.Add(movie);
        }
        public void Escuchada(Songs song)
        {
            escuchadas.Add(song.getName());
        }
    }
}