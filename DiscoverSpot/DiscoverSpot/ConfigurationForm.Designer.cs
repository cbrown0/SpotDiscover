namespace DiscoverSpot
{
    partial class ConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DanceabilityBar = new System.Windows.Forms.TrackBar();
            this.Label_Danceability = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_DanceabilityNumber = new System.Windows.Forms.Label();
            this.ArtistWeightBar = new System.Windows.Forms.TrackBar();
            this.Label_ArtistWeight = new System.Windows.Forms.Label();
            this.Label_ArtistWeightNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DanceabilityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistWeightBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DanceabilityBar
            // 
            this.DanceabilityBar.AutoSize = false;
            this.DanceabilityBar.Location = new System.Drawing.Point(16, 98);
            this.DanceabilityBar.Margin = new System.Windows.Forms.Padding(4);
            this.DanceabilityBar.Name = "DanceabilityBar";
            this.DanceabilityBar.Size = new System.Drawing.Size(173, 22);
            this.DanceabilityBar.TabIndex = 3;
            this.DanceabilityBar.Scroll += new System.EventHandler(this.DanceabilityBar_Scroll);
            // 
            // Label_Danceability
            // 
            this.Label_Danceability.AutoSize = true;
            this.Label_Danceability.Location = new System.Drawing.Point(17, 75);
            this.Label_Danceability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Danceability.Name = "Label_Danceability";
            this.Label_Danceability.Size = new System.Drawing.Size(82, 16);
            this.Label_Danceability.TabIndex = 4;
            this.Label_Danceability.Text = "Danceability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // Label_DanceabilityNumber
            // 
            this.Label_DanceabilityNumber.AutoSize = true;
            this.Label_DanceabilityNumber.Location = new System.Drawing.Point(199, 103);
            this.Label_DanceabilityNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_DanceabilityNumber.Name = "Label_DanceabilityNumber";
            this.Label_DanceabilityNumber.Size = new System.Drawing.Size(14, 16);
            this.Label_DanceabilityNumber.TabIndex = 6;
            this.Label_DanceabilityNumber.Text = "0";
            // 
            // ArtistWeightBar
            // 
            this.ArtistWeightBar.AutoSize = false;
            this.ArtistWeightBar.Location = new System.Drawing.Point(20, 160);
            this.ArtistWeightBar.Margin = new System.Windows.Forms.Padding(4);
            this.ArtistWeightBar.Maximum = 5;
            this.ArtistWeightBar.Name = "ArtistWeightBar";
            this.ArtistWeightBar.Size = new System.Drawing.Size(173, 22);
            this.ArtistWeightBar.TabIndex = 7;
            this.ArtistWeightBar.Scroll += new System.EventHandler(this.ArtistWeightBar_Scroll);
            // 
            // Label_ArtistWeight
            // 
            this.Label_ArtistWeight.AutoSize = true;
            this.Label_ArtistWeight.Location = new System.Drawing.Point(17, 140);
            this.Label_ArtistWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ArtistWeight.Name = "Label_ArtistWeight";
            this.Label_ArtistWeight.Size = new System.Drawing.Size(81, 16);
            this.Label_ArtistWeight.TabIndex = 8;
            this.Label_ArtistWeight.Text = "Artist Weight";
            // 
            // Label_ArtistWeightNumber
            // 
            this.Label_ArtistWeightNumber.AutoSize = true;
            this.Label_ArtistWeightNumber.Location = new System.Drawing.Point(199, 160);
            this.Label_ArtistWeightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ArtistWeightNumber.Name = "Label_ArtistWeightNumber";
            this.Label_ArtistWeightNumber.Size = new System.Drawing.Size(14, 16);
            this.Label_ArtistWeightNumber.TabIndex = 9;
            this.Label_ArtistWeightNumber.Text = "0";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 554);
            this.Controls.Add(this.Label_ArtistWeightNumber);
            this.Controls.Add(this.Label_ArtistWeight);
            this.Controls.Add(this.ArtistWeightBar);
            this.Controls.Add(this.Label_DanceabilityNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_Danceability);
            this.Controls.Add(this.DanceabilityBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfigurationForm";
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanceabilityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistWeightBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar DanceabilityBar;
        private System.Windows.Forms.Label Label_Danceability;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_DanceabilityNumber;
        private System.Windows.Forms.TrackBar ArtistWeightBar;
        private System.Windows.Forms.Label Label_ArtistWeight;
        private System.Windows.Forms.Label Label_ArtistWeightNumber;
    }
}