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
        private List <string> FollowProfile = new List<string>();
        private List<string> FollowPlaylistSong = new List<string>();
        private List<string> FollowPlaylistMovie = new List<string>();
        private List<string> FollowAlbum = new List<string>();
        private List<string> FollowArtist = new List<string>();
        private List<string> FollowActor = new List<string>();
        public Profile(string username, bool privacy)
        {
            this.username = username;
            this.privacy = privacy;
        }
        public void AddProfile(string profile)
        {
            FollowProfile.Add(profile);
        }
        public void AddPlaylistSong(string PlaylistSong)
        {
            FollowPlaylistSong.Add(PlaylistSong);
        }
        public void AddPlaylistMovie(string PlaylistMovie)
        {
            FollowPlaylistMovie.Add(PlaylistMovie);
        }
        public void AddAlbum(string album)
        {
            FollowAlbum.Add(album);
        }
        public void AddArtist(string artist)
        {
            FollowArtist.Add(artist);
        }
        public void AddActor(string actor)
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
        public void ChangeUsername(string newusername)
        {
            username = newusername;
        }
        public void ChangePrivacy(bool newprivacy)
        {
            privacy = newprivacy;
        }
        public List<string> SuggestionMovie()
        {
            return FollowActor;
        }
        public List<string> SuggestionSong()
        {
            return FollowArtist;
        }
        public void JoinParty(string url)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            wmp.URL = url;
            wmp.controls.play();
        }
    }
}
