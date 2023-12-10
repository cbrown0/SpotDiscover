using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace DiscoverSpot
{
    public partial class Form1 : Form
    {
       private static EmbedIOAuthServer _server;
       private static SpotifyClient _spotify;
       private static bool _spotifyInitialized = false;
       public static string _trackName;

       public static async Task InitializeSpotify()
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
                Scopes.UserReadEmail
                }
          };

            BrowserUtil.Open(request.ToUri());

            
        }

       public static async Task OnAuthorizationCodeReceived(object sender, AuthorizationCodeResponse response)
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

       public static async Task OnErrorReceived(object sender, string error, string state)
       {
           await _server.Stop();
       }
        private async Task CreatePlaylist()
        {
            var user = await _spotify.UserProfile.Current();

            // Request song recommendations based on the seeds
            var recommendations = await _spotify.Browse.GetRecommendations(new RecommendationsRequest()
            {
                // Need to figure out seeds for recommendations here
                Limit = 30, // Adjust the limit as needed
                Target =
                {
                    { "danceability", "0.8" } // Adjust the target danceability value as needed
                },
                SeedGenres =
                {
                    "soundtracks"
                }
            });

            System.Diagnostics.Debug.WriteLine(string.Join(",\n",recommendations.Tracks.Select(track => track.Name).ToList()));

            // Create SpotDiscover playlist
            var playlistRequest = new PlaylistCreateRequest("SpotDiscover")
            {
                Description = "Daily Discovery Playlist",
                Public = false
            };

            //var createdPlaylist = await _spotify.Playlists.Create(user.Id, playlistRequest);

            //// Add recommended tracks to the playlist
            //var trackUris = recommendations.Tracks.Select(recommendedTrack => recommendedTrack.Uri).ToList();
            //await _spotify.Playlists.AddItems(createdPlaylist.Id, new PlaylistAddItemsRequest(trackUris));
        }


        public async static Task GetTrack()
       {
            // displays track "diskhat1"
            var track = await _spotify.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");

            _trackName = track.Name;
       }

       public Form1()
       {
            InitializeComponent();
       }

       private void Form1_Load(object sender, EventArgs e)
       {

       }

       private async void ButtonAuth_Click(object sender, EventArgs e)
       {
            // Initialize Spotify when the button's clicked
            await InitializeSpotify();

            // Check every 100 milliseconds if spotify has successfully initizaled before making api calls
            while (!_spotifyInitialized)
            {
                await Task.Delay(100);
            }

            // Get user profile
            var user = await _spotify.UserProfile.Current();
            Label_Username.Text = user.DisplayName;

            Button_Authenticate.Hide();
            Button_displayTrack.Show();
            Button_GeneratePlaylist.Show();
            Label_SignedInAs.Show();
            Label_Username.Show();
            Button_configure.Show();
       }

       private async void ButtonDisplayTrack_Click(object sender, EventArgs e)
       {
            await GetTrack();
            label1.Text = _trackName;
       }

       private async void ButtonGeneratePlaylist_Click(object sender, EventArgs e)
       {
            await CreatePlaylist();
       }

        private void ButtonConfigure_Click(object sender, EventArgs e)
        {
            Form2 Configuration_form = new Form2();
            Configuration_form.Show();
        }
    }
}
