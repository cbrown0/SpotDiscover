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
            this.Button_Authenticate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_GeneratePlaylist = new System.Windows.Forms.Button();
            this.Label_SignedInAs = new System.Windows.Forms.Label();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Button_configure = new System.Windows.Forms.Button();
            this.Button_RefreshPlaylist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Authenticate
            // 
            this.Button_Authenticate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Authenticate.Location = new System.Drawing.Point(329, 201);
            this.Button_Authenticate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Authenticate.Name = "Button_Authenticate";
            this.Button_Authenticate.Size = new System.Drawing.Size(328, 105);
            this.Button_Authenticate.TabIndex = 0;
            this.Button_Authenticate.Text = "Authenticate with Spotify";
            this.Button_Authenticate.UseVisualStyleBackColor = true;
            this.Button_Authenticate.Click += new System.EventHandler(this.ButtonAuth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(413, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "SpotDiscover";
            // 
            // Button_GeneratePlaylist
            // 
            this.Button_GeneratePlaylist.Location = new System.Drawing.Point(329, 201);
            this.Button_GeneratePlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_GeneratePlaylist.Name = "Button_GeneratePlaylist";
            this.Button_GeneratePlaylist.Size = new System.Drawing.Size(328, 105);
            this.Button_GeneratePlaylist.TabIndex = 3;
            this.Button_GeneratePlaylist.Text = "Generate Playlist";
            this.Button_GeneratePlaylist.UseVisualStyleBackColor = true;
            this.Button_GeneratePlaylist.Visible = false;
            this.Button_GeneratePlaylist.Click += new System.EventHandler(this.ButtonGeneratePlaylist_Click);
            // 
            // Label_SignedInAs
            // 
            this.Label_SignedInAs.AutoSize = true;
            this.Label_SignedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SignedInAs.Location = new System.Drawing.Point(679, 101);
            this.Label_SignedInAs.Name = "Label_SignedInAs";
            this.Label_SignedInAs.Size = new System.Drawing.Size(317, 36);
            this.Label_SignedInAs.TabIndex = 4;
            this.Label_SignedInAs.Text = "Currently Signed in as:";
            this.Label_SignedInAs.Visible = false;
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.Location = new System.Drawing.Point(773, 140);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(150, 36);
            this.Label_Username.TabIndex = 5;
            this.Label_Username.Text = "Username";
            this.Label_Username.Visible = false;
            // 
            // Button_configure
            // 
            this.Button_configure.Location = new System.Drawing.Point(17, 16);
            this.Button_configure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_configure.Name = "Button_configure";
            this.Button_configure.Size = new System.Drawing.Size(100, 28);
            this.Button_configure.TabIndex = 6;
            this.Button_configure.Text = "Configure";
            this.Button_configure.UseVisualStyleBackColor = true;
            this.Button_configure.Visible = false;
            this.Button_configure.Click += new System.EventHandler(this.ButtonConfigure_Click);
            // 
            // Button_RefreshPlaylist
            // 
            this.Button_RefreshPlaylist.Location = new System.Drawing.Point(329, 382);
            this.Button_RefreshPlaylist.Name = "Button_RefreshPlaylist";
            this.Button_RefreshPlaylist.Size = new System.Drawing.Size(328, 105);
            this.Button_RefreshPlaylist.TabIndex = 7;
            this.Button_RefreshPlaylist.Text = "Refresh Playlist";
            this.Button_RefreshPlaylist.UseVisualStyleBackColor = true;
            this.Button_RefreshPlaylist.Visible = false;
            this.Button_RefreshPlaylist.Click += new System.EventHandler(this.Button_RefreshPlaylist_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Button_RefreshPlaylist);
            this.Controls.Add(this.Button_configure);
            this.Controls.Add(this.Label_Username);
            this.Controls.Add(this.Label_SignedInAs);
            this.Controls.Add(this.Button_GeneratePlaylist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Authenticate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "SpotDiscover";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Authenticate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_GeneratePlaylist;
        private System.Windows.Forms.Label Label_SignedInAs;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Button Button_configure;
        private System.Windows.Forms.Button Button_RefreshPlaylist;
    }
}

