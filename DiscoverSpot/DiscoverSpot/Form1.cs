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

       public static string _trackName;


       public static async Task InitializeSpotify()
       {
            string existingToken = "";
            // Check if token was saved previously
            if (File.Exists("access_token.txt"))
            {
                existingToken = File.ReadAllText("access_token.txt");
            }

            if (existingToken == "")
            {
                // No token, do authorization flow
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
            else
            {
                // Reuse existing token
                _spotify = new SpotifyClient(existingToken);
            }
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
            
            // save token so user doesn't have to reauthenticate everytime
            File.WriteAllText("access_token.txt", tokenResponse.AccessToken);

        }

       public static async Task OnErrorReceived(object sender, string error, string state)
       {
           await _server.Stop();
       }
        private async Task CreatePlaylist()
        {
            var user = await _spotify.UserProfile.Current();

            // Generate SpotDiscover playlist
            var request = new PlaylistCreateRequest("SpotDiscover")
            {
                Description = "Daily Discovery Playlist",
                Public = false
            };

            var playlist = await _spotify.Playlists.Create(user.Id, request);
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
            button2.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            // Initialize Spotify when the button's clicked
            await InitializeSpotify();
            var user = await _spotify.UserProfile.Current();
            label3.Text = user.DisplayName;
            // Hide authenticate button
            button1.Hide();
            // Show Display Track button
            button2.Show();
            // Show generate Playlist button
            button3.Show();
            // Show currently signed in label
            label2.Show();
            // Show username label
            label3.Show();
        }
        
        private async void button2_Click(object sender, EventArgs e)
        {
            await GetTrack();
            label1.Text = _trackName;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await CreatePlaylist();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
