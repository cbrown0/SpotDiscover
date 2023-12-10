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
    public partial class Form2 : Form
    {
        spotifyManager _spotifyManager;

        public Form2(spotifyManager spotifyManager)
        {
            InitializeComponent();
            _spotifyManager = spotifyManager;
        }

        private void DancibilityBar_Scroll(object sender, EventArgs e)
        {
            Label_DancabilityNumber.Text = ((double) DancibilityBar.Value/10).ToString();
        }
    }
}
