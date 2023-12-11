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
    public partial class MainForm : Form
    {
       private spotifyManager _spotifyManager;

       public MainForm()
       {
            InitializeComponent();
            _spotifyManager = new spotifyManager();
       }

       private void MainForm_Load(object sender, EventArgs e)
       {

       }

       private async void ButtonAuth_Click(object sender, EventArgs e)
       {
            // Initialize Spotify when the button's clicked
            await _spotifyManager.InitializeSpotify();

            // Check every 100 milliseconds if spotify has successfully initialized before making api calls
            while (!_spotifyManager.IsInitialized())
            {
                await Task.Delay(100);
            }

            //After the user authorizes, change form appearance to allow playlist creation/configuration
            Label_Username.Text = _spotifyManager.getUserName();

            Button_Authenticate.Hide();
            Button_GeneratePlaylist.Show();
            Label_Username.Show();
            Button_configure.Show();
            currentusertext.Show();
       }

        private async void ButtonGeneratePlaylist_Click(object sender, EventArgs e)
        {
            // Catch any rate limit errors
            try
            {
                var topArtists = await _spotifyManager.GetTopArtist();
                var topTracks = await _spotifyManager.GetTopTrack();
                _spotifyManager.setRecommendationSeeds(artistIds: string.Join(",", topArtists), trackIds: string.Join(",", topTracks));
                //delay to prevent getting rate limited
                await Task.Delay(1000);
                await _spotifyManager.CreatePlaylist(); 
            } catch (APITooManyRequestsException ex)
            {
                MessageBox.Show("Hit rate limit. Please wait " + ex.RetryAfter + " seconds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Button changes text indicating successfully playlist creation
            Button_RefreshPlaylist.Show();
            doneimage.Show();
            await Task.Delay(8000);
            doneimage.Hide();
        }

       private void ButtonConfigure_Click(object sender, EventArgs e)
       {
            ConfigurationForm Configuration_form = new ConfigurationForm(_spotifyManager);
            Configuration_form.Show();
       }

        private async void Button_RefreshPlaylist_Click(object sender, EventArgs e)
        {
            // Catch any rate limit errors
            try
            {
                await _spotifyManager.RefreshPlaylist();
            } catch (APITooManyRequestsException ex)
            {
                MessageBox.Show("Hit rate limit. Please wait " + ex.RetryAfter + " seconds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
