namespace DiscoverSpot
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Label_Username = new System.Windows.Forms.Label();
            this.doneimage = new System.Windows.Forms.PictureBox();
            this.spotdiscoverlogo = new System.Windows.Forms.PictureBox();
            this.Button_RefreshPlaylist = new System.Windows.Forms.Button();
            this.Button_configure = new System.Windows.Forms.Button();
            this.Button_GeneratePlaylist = new System.Windows.Forms.Button();
            this.Button_Authenticate = new System.Windows.Forms.Button();
            this.currentusertext = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.doneimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotdiscoverlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentusertext)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Username
            // 
            this.Label_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Username.AutoSize = true;
            this.Label_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.Label_Username.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(173)))), ((int)(((byte)(137)))));
            this.Label_Username.Location = new System.Drawing.Point(998, 61);
            this.Label_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(126, 32);
            this.Label_Username.TabIndex = 5;
            this.Label_Username.Text = "Username";
            this.Label_Username.Visible = false;
            // 
            // doneimage
            // 
            this.doneimage.Image = global::DiscoverSpot.Properties.Resources.done;
            this.doneimage.Location = new System.Drawing.Point(715, 280);
            this.doneimage.Name = "doneimage";
            this.doneimage.Size = new System.Drawing.Size(114, 81);
            this.doneimage.TabIndex = 10;
            this.doneimage.TabStop = false;
            this.doneimage.Visible = false;
            // 
            // spotdiscoverlogo
            // 
            this.spotdiscoverlogo.Image = global::DiscoverSpot.Properties.Resources.sdLogo;
            this.spotdiscoverlogo.Location = new System.Drawing.Point(389, 4);
            this.spotdiscoverlogo.Name = "spotdiscoverlogo";
            this.spotdiscoverlogo.Size = new System.Drawing.Size(391, 255);
            this.spotdiscoverlogo.TabIndex = 8;
            this.spotdiscoverlogo.TabStop = false;
            // 
            // Button_RefreshPlaylist
            // 
            this.Button_RefreshPlaylist.Image = global::DiscoverSpot.Properties.Resources.sdRefresh;
            this.Button_RefreshPlaylist.Location = new System.Drawing.Point(450, 380);
            this.Button_RefreshPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.Button_RefreshPlaylist.Name = "Button_RefreshPlaylist";
            this.Button_RefreshPlaylist.Size = new System.Drawing.Size(260, 110);
            this.Button_RefreshPlaylist.TabIndex = 7;
            this.Button_RefreshPlaylist.UseVisualStyleBackColor = true;
            this.Button_RefreshPlaylist.Visible = false;
            this.Button_RefreshPlaylist.Click += new System.EventHandler(this.Button_RefreshPlaylist_Click);
            // 
            // Button_configure
            // 
            this.Button_configure.Image = global::DiscoverSpot.Properties.Resources.sdConfigure;
            this.Button_configure.Location = new System.Drawing.Point(13, 13);
            this.Button_configure.Name = "Button_configure";
            this.Button_configure.Size = new System.Drawing.Size(140, 72);
            this.Button_configure.TabIndex = 6;
            this.Button_configure.UseVisualStyleBackColor = true;
            this.Button_configure.Visible = false;
            this.Button_configure.Click += new System.EventHandler(this.ButtonConfigure_Click);
            // 
            // Button_GeneratePlaylist
            // 
            this.Button_GeneratePlaylist.Image = global::DiscoverSpot.Properties.Resources.sdGeneratePlaylist;
            this.Button_GeneratePlaylist.Location = new System.Drawing.Point(450, 265);
            this.Button_GeneratePlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.Button_GeneratePlaylist.Name = "Button_GeneratePlaylist";
            this.Button_GeneratePlaylist.Size = new System.Drawing.Size(260, 110);
            this.Button_GeneratePlaylist.TabIndex = 3;
            this.Button_GeneratePlaylist.UseVisualStyleBackColor = true;
            this.Button_GeneratePlaylist.Visible = false;
            this.Button_GeneratePlaylist.Click += new System.EventHandler(this.ButtonGeneratePlaylist_Click);
            // 
            // Button_Authenticate
            // 
            this.Button_Authenticate.Image = global::DiscoverSpot.Properties.Resources.sdAuthenticate;
            this.Button_Authenticate.Location = new System.Drawing.Point(450, 265);
            this.Button_Authenticate.Name = "Button_Authenticate";
            this.Button_Authenticate.Size = new System.Drawing.Size(260, 110);
            this.Button_Authenticate.TabIndex = 0;
            this.Button_Authenticate.UseVisualStyleBackColor = true;
            this.Button_Authenticate.Click += new System.EventHandler(this.ButtonAuth_Click);
            // 
            // currentusertext
            // 
            this.currentusertext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentusertext.Image = global::DiscoverSpot.Properties.Resources.sdCurrentUser;
            this.currentusertext.Location = new System.Drawing.Point(862, 12);
            this.currentusertext.Name = "currentusertext";
            this.currentusertext.Size = new System.Drawing.Size(395, 81);
            this.currentusertext.TabIndex = 9;
            this.currentusertext.TabStop = false;
            this.currentusertext.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1269, 680);
            this.Controls.Add(this.doneimage);
            this.Controls.Add(this.spotdiscoverlogo);
            this.Controls.Add(this.Button_RefreshPlaylist);
            this.Controls.Add(this.Button_configure);
            this.Controls.Add(this.Label_Username);
            this.Controls.Add(this.Button_GeneratePlaylist);
            this.Controls.Add(this.Button_Authenticate);
            this.Controls.Add(this.currentusertext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SpotDiscover";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doneimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotdiscoverlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentusertext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Authenticate;
        private System.Windows.Forms.Button Button_GeneratePlaylist;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Button Button_configure;
        private System.Windows.Forms.Button Button_RefreshPlaylist;
        private System.Windows.Forms.PictureBox spotdiscoverlogo;
        private System.Windows.Forms.PictureBox currentusertext;
        private System.Windows.Forms.PictureBox doneimage;
    }
}

