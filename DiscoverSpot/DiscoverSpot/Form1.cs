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
            Button_displayTrack.Show();
            Button_GeneratePlaylist.Show();
            Label_SignedInAs.Show();
            Label_Username.Show();
            Button_configure.Show();
       }

       private async void ButtonDisplayTrack_Click(object sender, EventArgs e)
       {
            await _spotifyManager.GetTrack();
            label1.Text = _spotifyManager.getTrackName();
       }

       private async void ButtonGeneratePlaylist_Click(object sender, EventArgs e)
       {
            await _spotifyManager.CreatePlaylist();
       }

       private void ButtonConfigure_Click(object sender, EventArgs e)
       {
            Form2 Configuration_form = new Form2(_spotifyManager);
            Configuration_form.Show();
       }
    }
}
