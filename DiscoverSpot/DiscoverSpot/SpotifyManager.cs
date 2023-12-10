using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace DiscoverSpot
{
    public class spotifyManager
    {
        private static EmbedIOAuthServer _server;
        private static SpotifyClient _spotify;
        private static bool _spotifyInitialized = false;
        private string _trackID;
        private SpotifyAPI.Web.PrivateUser _user;
        private RecommendationsRequest _recommendationData;
        private System.Timers.Timer _playlistTimer;
        private FullPlaylist createdPlaylist;
        private List<string> trackUris;

        private bool _considerGenre = false;
        private bool _considerArtist = false;
        private string _danceability = "0.8";

        public spotifyManager()
        {

            // initial values for everything... even if empty, just in case
            _recommendationData = new RecommendationsRequest()
            {
                Limit = 30, // Adjust the limit as needed
                Target =
                {
                    { "danceability", "0.8" } // Adjust the target danceability value as needed
                },
                // Commented out just so it doesn't interfere with top seeded artists
                /*SeedGenres =
                {
                    "acoustic"
                },
                SeedTracks =
                {
                    "7EZC6E7UjZe63f1jRmkWxt" // The Cranberries "Zombie" because I needed a default value and happened to be listening to it
                }*/
            };
        }

        public async void PlaylistTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            await RefreshPlaylist();
        }

        public async Task RefreshPlaylist()
        {
            System.Diagnostics.Debug.WriteLine("Test\n");

            // Request song recommendations based on the seeds
            var recommendations = await _spotify.Browse.GetRecommendations(_recommendationData);

            // Add recommended tracks to the playlist
            trackUris = recommendations.Tracks.Select(recommendedTrack => recommendedTrack.Uri).ToList();
            await _spotify.Playlists.ReplaceItems(createdPlaylist.Id, new PlaylistReplaceItemsRequest(trackUris));
        }

        public bool IsInitialized()
        {
            return _spotifyInitialized;
        }

        public string getUserName()
        {
            return _user.DisplayName;
        }

        public async Task GetTrack()
        {
            // displays track "diskhat1"
            // TODO: get from top items
            var track = await _spotify.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");

            _trackID = track.Id;
        }

        public string getTrackID()
        {
            return _trackID;
        }

        // data used later when generating tracks, set by configure form
        public void setConfigurationData(bool considerArtist, bool considerGenre, string danceability)
        {
            _considerArtist = considerArtist;
            _considerGenre = considerGenre;
            _danceability = danceability;
        }

        public bool IsConsideringArtist()
        {
            return _considerArtist;
        }

        public bool IsConsideringGenre()
        {
            return _considerGenre;
        }

        public string getDanceability()
        {
            return _danceability;
        }

        public void setRecommendationSeeds(string trackIds = null, string genres = null, string artistIds = null)
        {
            string artistString = artistIds;
            string trackString = trackIds;
            if (trackIds == null && artistIds == null && genres == null)
            {
                MessageBox.Show("At least one seed must be set from tracks, artists, or genres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if (genres != null && _considerGenre) genreString = genres.Aggregate((a, x) => a + "," + x);
            //if(artists != null && _considerArtist) artistString = artists.Aggregate((a, x) => a + "," + x);
            _recommendationData = new RecommendationsRequest()
            {
                Limit = 30,
                Target = { { "danceability", _danceability } },
                //SeedGenres = {genreString},
                SeedArtists = {artistString},
                SeedTracks = {trackString}
            };
        }

        public async Task InitializeSpotify()
        {
            _server = new EmbedIOAuthServer(new Uri("http://localhost:5543/callback"), 5543);
            await _server.Start();

            _server.AuthorizationCodeReceived += OnAuthorizationCodeReceived;
            _server.ErrorReceived += OnErrorReceived;

            //client ID goes in second field of LoginRequest
            var request = new LoginRequest(_server.BaseUri, "07d2f610371745aba056026392538495", LoginRequest.ResponseType.Code)
            {
                Scope = new List<string> {
                Scopes.UserTopRead,
                Scopes.PlaylistModifyPrivate,
                Scopes.PlaylistModifyPublic,
                Scopes.UserReadEmail,
                Scopes.UserReadPrivate
                }
            };

            BrowserUtil.Open(request.ToUri());

            // Check every 100 milliseconds if spotify has successfully initizaled before making api calls
            while (!_spotifyInitialized)
            {
                await Task.Delay(100);
            }

            // Get user profile
            _user = await _spotify.UserProfile.Current();
        }

        public async Task OnAuthorizationCodeReceived(object sender, AuthorizationCodeResponse response)
        {
            await _server.Stop();

            //client ID goes in first field of AuthorizationCodeTokenRequest
            //client secret goes in second field of AuthorizationCodeTokenRequest
            var config = SpotifyClientConfig.CreateDefault();
            var tokenResponse = await new OAuthClient(config).RequestToken(
                new AuthorizationCodeTokenRequest(
                    "07d2f610371745aba056026392538495", "469e5c1e0ad64a42a77fe116099330f3", response.Code, new Uri("http://localhost:5543/callback")
                )
            );
            // save token in _spotify
            _spotify = new SpotifyClient(tokenResponse.AccessToken);
            _spotifyInitialized = true;
        }

        public async Task OnErrorReceived(object sender, string error, string state)
        {
            await _server.Stop();
        }
        public async Task CreatePlaylist()
        {
            var user = await _spotify.UserProfile.Current();

            // Request song recommendations based on the seeds
            var recommendations = await _spotify.Browse.GetRecommendations(_recommendationData);

            System.Diagnostics.Debug.WriteLine(string.Join(",\n", recommendations.Tracks.Select(track => track.Name).ToList()));

            // Create SpotDiscover playlist
            var playlistRequest = new PlaylistCreateRequest("SpotDiscover")
            {
                Description = "Daily Discovery Playlist",
                Public = false
            };

            createdPlaylist = await _spotify.Playlists.Create(user.Id, playlistRequest);

            // Add recommended tracks to the playlist
            trackUris = recommendations.Tracks.Select(recommendedTrack => recommendedTrack.Uri).ToList();
            await _spotify.Playlists.AddItems(createdPlaylist.Id, new PlaylistAddItemsRequest(trackUris));

            // 24 hour timer
            _playlistTimer = new System.Timers.Timer(60 * 60 * 1000 * 24);
            // Refresh playlist after set time only works if program is left open
            _playlistTimer.Elapsed += PlaylistTimer_Elapsed;
            _playlistTimer.Enabled = true;
        }

        public async Task<List<string>> GetTopArtist()
        {
            // Grab top 5 artists within the past month
            var artistRequest = new PersonalizationTopRequest()
            {
                Limit = 2,
                Offset = 0,
                TimeRangeParam = PersonalizationTopRequest.TimeRange.ShortTerm
            };
            var topArtists = await _spotify.Personalization.GetTopArtists(artistRequest);
            // Return only the IDs not the full URI
            return topArtists.Items.Select(a => a.Id).ToList();
        }
        public async Task<List<string>> GetTopTrack()
        {
            // Grab top 5 tracks within the past month
            var trackRequest = new PersonalizationTopRequest()
            {
                Limit = 3,
                Offset = 0,
                TimeRangeParam = PersonalizationTopRequest.TimeRange.ShortTerm
            };
            var topTrack = await _spotify.Personalization.GetTopArtists(trackRequest);
            // Return only the IDs not the full URI
            return topTrack.Items.Select(a => a.Id).ToList();
        }
    }
}
