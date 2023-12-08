using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DiscoverSpot.Form1;

namespace DiscoverSpot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Check if SpotifyManager.Spotify is not null
            if (SpotifyManager.Spotify != null)
            {
                // The track ID is part of the request path --> it's not treated as query/body parameter
                var track = await SpotifyManager.Spotify.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");
                // Assuming "Name" is the property that contains the track name
                label1.Text = track.Name;   
            }
            else
            {
                // Handle the case where SpotifyManager.Spotify is null
                label1.Text = "Spotify not initialized";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
