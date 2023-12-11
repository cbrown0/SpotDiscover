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

        private string _danceability = "0.8";
        private string _artistweight = "0";
        private decimal _numtoadd = 30;

        public spotifyManager()
        {

            // initial values for everything... even if empty, just in case
            _recommendationData = new RecommendationsRequest()
            {
                Limit = 30, // Adjust the limit as needed
                Target =
                {
                    { "danceability", "0.8" } // Adjust the target danceability value as needed
                }
            };
        }

        public async void PlaylistTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            await RefreshPlaylist();
        }

        public async Task RefreshPlaylist()
        {
            System.Diagnostics.Debug.WriteLine("Refresh\n");

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

        
        public string getTrackID()
        {
            return _trackID;
        }
        

        // data used later when generating tracks, set by configure form
        public void setConfigurationData(string danceability, string artistweight, decimal numtoadd)
        {
            _danceability = danceability;
            _artistweight = artistweight;
            _numtoadd = numtoadd;
        }

        public string getDanceability()
        {
            return _danceability;
        }

        public string getArtistWeight()
        {
            return _artistweight;
        }

        public decimal getNumToAdd()
        {
            return _numtoadd;
        }

        public void setRecommendationSeeds(string trackIds, string artistIds)
        {
            System.Diagnostics.Debug.WriteLine("Track IDs:" + trackIds);

            _recommendationData = new RecommendationsRequest()
            {
                Limit = Decimal.ToInt32(_numtoadd),
                Target = { { "danceability", _danceability } },
                SeedArtists = {artistIds},
                SeedTracks = {trackIds}
            };
        }

        public async Task InitializeSpotify()
        {
            _server = new EmbedIOAuthServer(new Uri("http://localhost:5543/callback"), 5543);
            await _server.Start();

            _server.AuthorizationCodeReceived += OnAuthorizationCodeReceived;
            _server.ErrorReceived += OnErrorReceived;

            //client ID goes in second field of LoginRequest
            var request = new LoginRequest(_server.BaseUri, "457d687267f447f39d58af721581f1b8", LoginRequest.ResponseType.Code)
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
                    "457d687267f447f39d58af721581f1b8", "f29c99014e624450b6c3f88a7c67a931", response.Code, new Uri("http://localhost:5543/callback")
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
            int artistweight = Int32.Parse(_artistweight);

            // Grab top artists within the past month
            var artistRequest = new PersonalizationTopRequest()
            {
                Limit = artistweight,
                Offset = 0,
                TimeRangeParam = PersonalizationTopRequest.TimeRange.ShortTerm
            };
            var topArtists = await _spotify.Personalization.GetTopArtists(artistRequest);
            // Return only the IDs not the full URI
            return topArtists.Items.Select(a => a.Id).ToList();
        }
        public async Task<List<string>> GetTopTrack()
        {
            int trackweight = 5 - Int32.Parse(_artistweight);

            // Grab top tracks within the past month
            var trackRequest = new PersonalizationTopRequest()
            {
                Limit = trackweight,
                Offset = 0,
                TimeRangeParam = PersonalizationTopRequest.TimeRange.ShortTerm
            };
            var topTrack = await _spotify.Personalization.GetTopTracks(trackRequest);

            // Return only the IDs not the full URI
            return topTrack.Items.Select(a => a.Id).ToList();
        }
    }
}
