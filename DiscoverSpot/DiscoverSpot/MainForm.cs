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

        // DEPRECATED (button was removed)
       private async void ButtonDisplayTrack_Click(object sender, EventArgs e)
       {
            await _spotifyManager.GetTrack();
            label1.Text = _spotifyManager.getTrackID();
       }

       private async void ButtonGeneratePlaylist_Click(object sender, EventArgs e)
       {
            // TODO, make this change based on some tracks pulled from the user...
            //_spotifyManager.setRecommendationSeeds(tracks: new List<string>() { "7EZC6E7UjZe63f1jRmkWxt" });
            await _spotifyManager.CreatePlaylist();
       }

       private void ButtonConfigure_Click(object sender, EventArgs e)
       {
            ConfigurationForm Configuration_form = new ConfigurationForm(_spotifyManager);
            Configuration_form.Show();
       }
    }
}
