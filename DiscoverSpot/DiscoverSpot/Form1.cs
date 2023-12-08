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

namespace DiscoverSpot
{
    public partial class Form1 : Form
    {
        public static class SpotifyManager
        {
            private static EmbedIOAuthServer _server;
            private static SpotifyClient _spotify;

            public static SpotifyClient Spotify
            {
                get { return _spotify; }
            }

            public static async Task InitializeSpotify()
            {
                // Only initialize Spotify if it hasn't been initialized yet
                if (_spotify == null)
                {
                    _server = new EmbedIOAuthServer(new Uri("http://localhost:5543/callback"), 5543);
                    await _server.Start();

                    _server.AuthorizationCodeReceived += OnAuthorizationCodeReceived;
                    _server.ErrorReceived += OnErrorReceived;

                    var request = new LoginRequest(_server.BaseUri, "07d2f610371745aba056026392538495", LoginRequest.ResponseType.Code)
                    {
                        Scope = new List<string> { Scopes.UserReadEmail }
                    };

                    BrowserUtil.Open(request.ToUri());
                }
            }

            private static async Task OnAuthorizationCodeReceived(object sender, AuthorizationCodeResponse response)
            {
                await _server.Stop();

                var config = SpotifyClientConfig.CreateDefault();
                var tokenResponse = await new OAuthClient(config).RequestToken(
                    new AuthorizationCodeTokenRequest(
                        "ClientId", "ClientSecret", response.Code, new Uri("http://localhost:5543/callback")
                    )
                );

                _spotify = new SpotifyClient(tokenResponse.AccessToken);
                // Perform any additional initialization or error handling here
            }

            private static async Task OnErrorReceived(object sender, string error, string state)
            {
                Console.WriteLine($"Aborting authorization, error received: {error}");
                await _server.Stop();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            // Initialize Spotify when the form loads
            await SpotifyManager.InitializeSpotify();
            this.Hide();
            new Form2().Show();
        }
    }
}
