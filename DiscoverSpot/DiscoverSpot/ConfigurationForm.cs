using Swan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscoverSpot
{
    public partial class ConfigurationForm : Form
    {
        spotifyManager _spotifyManager;

        public ConfigurationForm(spotifyManager spotifyManager)
        {
            InitializeComponent();
            _spotifyManager = spotifyManager;
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            // makes form display accurate data when it first opens
            Label_DanceabilityNumber.Text = _spotifyManager.getDanceability();
            DanceabilityBar.Value = (int) (Convert.ToDouble(_spotifyManager.getDanceability()) * 10);
            ArtistWeightBar.Value = Int32.Parse(_spotifyManager.getArtistWeight());
        }

        private void PushFormData()
        {
            _spotifyManager.setConfigurationData(Label_DanceabilityNumber.Text, Label_ArtistWeightNumber.Text);
        }

        private void ArtistWeightBar_Scroll(object sender, EventArgs e)
        {
            Label_ArtistWeightNumber.Text = ArtistWeightBar.Value.ToString();
            PushFormData();
        }

        private void DanceabilityBar_Scroll(object sender, EventArgs e)
        {
            Label_DanceabilityNumber.Text = ((double)DanceabilityBar.Value/10).ToString();
            PushFormData();
        }
    }
}