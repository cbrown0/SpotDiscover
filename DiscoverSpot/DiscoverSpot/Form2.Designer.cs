namespace DiscoverSpot
{
    partial class Form2
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.DancibilityBar = new System.Windows.Forms.TrackBar();
            this.Label_Dancability = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_DancabilityNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DancibilityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(147, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Inherit Genre";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(147, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Inherit Artists";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // DancibilityBar
            // 
            this.DancibilityBar.AutoSize = false;
            this.DancibilityBar.Location = new System.Drawing.Point(12, 80);
            this.DancibilityBar.Name = "DancibilityBar";
            this.DancibilityBar.Size = new System.Drawing.Size(130, 18);
            this.DancibilityBar.TabIndex = 3;
            this.DancibilityBar.Scroll += new System.EventHandler(this.DancibilityBar_Scroll);
            // 
            // Label_Dancability
            // 
            this.Label_Dancability.AutoSize = true;
            this.Label_Dancability.Location = new System.Drawing.Point(13, 61);
            this.Label_Dancability.Name = "Label_Dancability";
            this.Label_Dancability.Size = new System.Drawing.Size(59, 13);
            this.Label_Dancability.TabIndex = 4;
            this.Label_Dancability.Text = "Dancability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // Label_DancabilityNumber
            // 
            this.Label_DancabilityNumber.AutoSize = true;
            this.Label_DancabilityNumber.Location = new System.Drawing.Point(149, 84);
            this.Label_DancabilityNumber.Name = "Label_DancabilityNumber";
            this.Label_DancabilityNumber.Size = new System.Drawing.Size(13, 13);
            this.Label_DancabilityNumber.TabIndex = 6;
            this.Label_DancabilityNumber.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 450);
            this.Controls.Add(this.Label_DancabilityNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_Dancability);
            this.Controls.Add(this.DancibilityBar);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form2";
            this.Text = "Configure";
            ((System.ComponentModel.ISupportInitialize)(this.DancibilityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TrackBar DancibilityBar;
        private System.Windows.Forms.Label Label_Dancability;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_DancabilityNumber;
    }
}