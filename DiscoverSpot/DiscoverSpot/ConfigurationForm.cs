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
            artistsCheckBox.Checked = _spotifyManager.IsConsideringArtist();
        }

        private void DanceabilityBar_Scroll(object sender, EventArgs e)
        {
            Label_DanceabilityNumber.Text = ((double) DanceabilityBar.Value/10).ToString();
            PushFormData();
        }

        private void PushFormData()
        {
            _spotifyManager.setConfigurationData(artistsCheckBox.Checked, Label_DanceabilityNumber.Text);
        }

        private void genereCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PushFormData();
        }

        private void artistsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PushFormData();
        }
    }
}