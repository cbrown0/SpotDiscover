﻿namespace DiscoverSpot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.DanceabilityBar = new System.Windows.Forms.TrackBar();
            this.Label_Danceability = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_DanceabilityNumber = new System.Windows.Forms.Label();
            this.ArtistWeightBar = new System.Windows.Forms.TrackBar();
            this.Label_ArtistWeight = new System.Windows.Forms.Label();
            this.Label_ArtistWeightNumber = new System.Windows.Forms.Label();
            this.Label_NumToAdd = new System.Windows.Forms.Label();
            this.NumToAddUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DanceabilityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistWeightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumToAddUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DanceabilityBar
            // 
            this.DanceabilityBar.AutoSize = false;
            this.DanceabilityBar.Location = new System.Drawing.Point(15, 34);
            this.DanceabilityBar.Margin = new System.Windows.Forms.Padding(4);
            this.DanceabilityBar.Name = "DanceabilityBar";
            this.DanceabilityBar.Size = new System.Drawing.Size(173, 22);
            this.DanceabilityBar.TabIndex = 3;
            this.DanceabilityBar.Scroll += new System.EventHandler(this.DanceabilityBar_Scroll);
            // 
            // Label_Danceability
            // 
            this.Label_Danceability.AutoSize = true;
            this.Label_Danceability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Danceability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(182)))));
            this.Label_Danceability.Location = new System.Drawing.Point(16, 11);
            this.Label_Danceability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Danceability.Name = "Label_Danceability";
            this.Label_Danceability.Size = new System.Drawing.Size(97, 17);
            this.Label_Danceability.TabIndex = 4;
            this.Label_Danceability.Text = "Danceability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // Label_DanceabilityNumber
            // 
            this.Label_DanceabilityNumber.AutoSize = true;
            this.Label_DanceabilityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DanceabilityNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(182)))));
            this.Label_DanceabilityNumber.Location = new System.Drawing.Point(197, 39);
            this.Label_DanceabilityNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_DanceabilityNumber.Name = "Label_DanceabilityNumber";
            this.Label_DanceabilityNumber.Size = new System.Drawing.Size(17, 17);
            this.Label_DanceabilityNumber.TabIndex = 6;
            this.Label_DanceabilityNumber.Text = "0";
            // 
            // ArtistWeightBar
            // 
            this.ArtistWeightBar.AutoSize = false;
            this.ArtistWeightBar.Location = new System.Drawing.Point(19, 96);
            this.ArtistWeightBar.Margin = new System.Windows.Forms.Padding(4);
            this.ArtistWeightBar.Maximum = 4;
            this.ArtistWeightBar.Minimum = 1;
            this.ArtistWeightBar.Name = "ArtistWeightBar";
            this.ArtistWeightBar.Size = new System.Drawing.Size(169, 22);
            this.ArtistWeightBar.TabIndex = 7;
            this.ArtistWeightBar.Value = 1;
            this.ArtistWeightBar.Scroll += new System.EventHandler(this.ArtistWeightBar_Scroll);
            // 
            // Label_ArtistWeight
            // 
            this.Label_ArtistWeight.AutoSize = true;
            this.Label_ArtistWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ArtistWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(182)))));
            this.Label_ArtistWeight.Location = new System.Drawing.Point(16, 76);
            this.Label_ArtistWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ArtistWeight.Name = "Label_ArtistWeight";
            this.Label_ArtistWeight.Size = new System.Drawing.Size(101, 17);
            this.Label_ArtistWeight.TabIndex = 8;
            this.Label_ArtistWeight.Text = "Artist Weight";
            // 
            // Label_ArtistWeightNumber
            // 
            this.Label_ArtistWeightNumber.AutoSize = true;
            this.Label_ArtistWeightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ArtistWeightNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(182)))));
            this.Label_ArtistWeightNumber.Location = new System.Drawing.Point(197, 96);
            this.Label_ArtistWeightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ArtistWeightNumber.Name = "Label_ArtistWeightNumber";
            this.Label_ArtistWeightNumber.Size = new System.Drawing.Size(17, 17);
            this.Label_ArtistWeightNumber.TabIndex = 9;
            this.Label_ArtistWeightNumber.Text = "1";
            // 
            // Label_NumToAdd
            // 
            this.Label_NumToAdd.AutoSize = true;
            this.Label_NumToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NumToAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(182)))));
            this.Label_NumToAdd.Location = new System.Drawing.Point(17, 135);
            this.Label_NumToAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_NumToAdd.Name = "Label_NumToAdd";
            this.Label_NumToAdd.Size = new System.Drawing.Size(214, 17);
            this.Label_NumToAdd.TabIndex = 12;
            this.Label_NumToAdd.Text = "Number of Songs to Add (1-100)";
            // 
            // NumToAddUpDown
            // 
            this.NumToAddUpDown.Location = new System.Drawing.Point(19, 154);
            this.NumToAddUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumToAddUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumToAddUpDown.Name = "NumToAddUpDown";
            this.NumToAddUpDown.Size = new System.Drawing.Size(120, 22);
            this.NumToAddUpDown.TabIndex = 13;
            this.NumToAddUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumToAddUpDown.ValueChanged += new System.EventHandler(this.NumToAddUpDown_ValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DiscoverSpot.Properties.Resources.sdTracksNumber;
            this.pictureBox3.Location = new System.Drawing.Point(236, 135);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 62);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DiscoverSpot.Properties.Resources.sdArtist;
            this.pictureBox2.Location = new System.Drawing.Point(236, 76);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 54);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiscoverSpot.Properties.Resources.sdDance1;
            this.pictureBox1.Location = new System.Drawing.Point(236, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 46);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(327, 554);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NumToAddUpDown);
            this.Controls.Add(this.Label_NumToAdd);
            this.Controls.Add(this.Label_ArtistWeightNumber);
            this.Controls.Add(this.Label_ArtistWeight);
            this.Controls.Add(this.ArtistWeightBar);
            this.Controls.Add(this.Label_DanceabilityNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_Danceability);
            this.Controls.Add(this.DanceabilityBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfigurationForm";
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanceabilityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistWeightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumToAddUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label Label_NumToAdd;
        private System.Windows.Forms.NumericUpDown NumToAddUpDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}