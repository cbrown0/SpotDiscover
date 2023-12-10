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
            this.genreCheckBox = new System.Windows.Forms.CheckBox();
            this.artistsCheckBox = new System.Windows.Forms.CheckBox();
            this.DanceabilityBar = new System.Windows.Forms.TrackBar();
            this.Label_Dancability = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_DanceabilityNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DanceabilityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // genreCheckBox
            // 
            this.genreCheckBox.AutoSize = true;
            this.genreCheckBox.Location = new System.Drawing.Point(196, 15);
            this.genreCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genreCheckBox.Name = "genreCheckBox";
            this.genreCheckBox.Size = new System.Drawing.Size(104, 20);
            this.genreCheckBox.TabIndex = 0;
            this.genreCheckBox.Text = "Inherit Genre";
            this.genreCheckBox.UseVisualStyleBackColor = true;
            this.genreCheckBox.CheckedChanged += new System.EventHandler(this.genereCheckBox_CheckedChanged);
            // 
            // artistsCheckBox
            // 
            this.artistsCheckBox.AutoSize = true;
            this.artistsCheckBox.Location = new System.Drawing.Point(196, 43);
            this.artistsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.artistsCheckBox.Name = "artistsCheckBox";
            this.artistsCheckBox.Size = new System.Drawing.Size(103, 20);
            this.artistsCheckBox.TabIndex = 1;
            this.artistsCheckBox.Text = "Inherit Artists";
            this.artistsCheckBox.UseVisualStyleBackColor = true;
            this.artistsCheckBox.CheckedChanged += new System.EventHandler(this.artistsCheckBox_CheckedChanged);
            // 
            // DancibilityBar
            // 
            this.DanceabilityBar.AutoSize = false;
            this.DanceabilityBar.Location = new System.Drawing.Point(16, 98);
            this.DanceabilityBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DanceabilityBar.Name = "DancibilityBar";
            this.DanceabilityBar.Size = new System.Drawing.Size(173, 22);
            this.DanceabilityBar.TabIndex = 3;
            this.DanceabilityBar.Scroll += new System.EventHandler(this.DanceabilityBar_Scroll);
            // 
            // Label_Dancability
            // 
            this.Label_Dancability.AutoSize = true;
            this.Label_Dancability.Location = new System.Drawing.Point(17, 75);
            this.Label_Dancability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Dancability.Name = "Label_Dancability";
            this.Label_Dancability.Size = new System.Drawing.Size(82, 16);
            this.Label_Dancability.TabIndex = 4;
            this.Label_Dancability.Text = "Danceability";
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
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 554);
            this.Controls.Add(this.Label_DanceabilityNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_Dancability);
            this.Controls.Add(this.DanceabilityBar);
            this.Controls.Add(this.artistsCheckBox);
            this.Controls.Add(this.genreCheckBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConfigurationForm";
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanceabilityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox genreCheckBox;
        private System.Windows.Forms.CheckBox artistsCheckBox;
        private System.Windows.Forms.TrackBar DanceabilityBar;
        private System.Windows.Forms.Label Label_Dancability;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_DanceabilityNumber;
    }
}