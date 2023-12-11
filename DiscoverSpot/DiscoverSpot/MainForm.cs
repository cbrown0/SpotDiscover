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

            // Check every 100 milliseconds if spotify has successfully initizaled before making api calls
            while (!_spotifyManager.IsInitialized())
            {
                await Task.Delay(100);
            }

            Label_Username.Text = _spotifyManager.getUserName();

            Button_Authenticate.Hide();
            Button_GeneratePlaylist.Show();
            Label_SignedInAs.Show();
            Label_Username.Show();
            Button_configure.Show();
       }

        private async void ButtonGeneratePlaylist_Click(object sender, EventArgs e)
        {
            try
            {
            var topArtists = await _spotifyManager.GetTopArtist();
            var topTracks = await _spotifyManager.GetTopTrack();
            _spotifyManager.setRecommendationSeeds(artistIds: string.Join(",", topArtists), trackIds: string.Join(",", topTracks));
            await _spotifyManager.CreatePlaylist(); 
            } catch (APITooManyRequestsException ex)
            {
                MessageBox.Show("Hit rate limit. Please wait " + ex.RetryAfter + " seconds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            Button_RefreshPlaylist.Show();
            // Button changes text indicating successfully playlist creation
            Button_GeneratePlaylist.Text = "Success!";
            await Task.Delay(5000);
            Button_GeneratePlaylist.Text = "Generate Playlist";
        }

       private void ButtonConfigure_Click(object sender, EventArgs e)
       {
            ConfigurationForm Configuration_form = new ConfigurationForm(_spotifyManager);
            Configuration_form.Show();
       }

        private async void Button_RefreshPlaylist_Click(object sender, EventArgs e)
        {
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
