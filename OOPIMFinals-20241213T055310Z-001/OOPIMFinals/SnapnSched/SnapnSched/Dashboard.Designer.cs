namespace SnapnSched
{
    partial class Dashboard
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
            this.AdminProfile = new System.Windows.Forms.PictureBox();
            this.TotalApptLabel = new System.Windows.Forms.Label();
            this.RevenueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpcomingApptTime = new System.Windows.Forms.Label();
            this.UpcomingApptName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminProfile
            // 
            this.AdminProfile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AdminProfile.Location = new System.Drawing.Point(633, 30);
            this.AdminProfile.Name = "AdminProfile";
            this.AdminProfile.Size = new System.Drawing.Size(49, 43);
            this.AdminProfile.TabIndex = 0;
            this.AdminProfile.TabStop = false;
            // 
            // TotalApptLabel
            // 
            this.TotalApptLabel.AutoSize = true;
            this.TotalApptLabel.Location = new System.Drawing.Point(97, 135);
            this.TotalApptLabel.Name = "TotalApptLabel";
            this.TotalApptLabel.Size = new System.Drawing.Size(35, 13);
            this.TotalApptLabel.TabIndex = 1;
            this.TotalApptLabel.Text = "label1";
            this.TotalApptLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RevenueLabel
            // 
            this.RevenueLabel.AutoSize = true;
            this.RevenueLabel.Location = new System.Drawing.Point(239, 135);
            this.RevenueLabel.Name = "RevenueLabel";
            this.RevenueLabel.Size = new System.Drawing.Size(35, 13);
            this.RevenueLabel.TabIndex = 2;
            this.RevenueLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Upcoming Appointment:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UpcomingApptTime
            // 
            this.UpcomingApptTime.AutoSize = true;
            this.UpcomingApptTime.Location = new System.Drawing.Point(623, 157);
            this.UpcomingApptTime.Name = "UpcomingApptTime";
            this.UpcomingApptTime.Size = new System.Drawing.Size(53, 13);
            this.UpcomingApptTime.TabIndex = 4;
            this.UpcomingApptTime.Text = "10:30 AM";
            this.UpcomingApptTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UpcomingApptName
            // 
            this.UpcomingApptName.AutoSize = true;
            this.UpcomingApptName.Location = new System.Drawing.Point(588, 175);
            this.UpcomingApptName.Name = "UpcomingApptName";
            this.UpcomingApptName.Size = new System.Drawing.Size(89, 13);
            this.UpcomingApptName.TabIndex = 5;
            this.UpcomingApptName.Text = "Mark Zuckerberg";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpcomingApptName);
            this.Controls.Add(this.UpcomingApptTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RevenueLabel);
            this.Controls.Add(this.TotalApptLabel);
            this.Controls.Add(this.AdminProfile);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.AdminProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AdminProfile;
        private System.Windows.Forms.Label TotalApptLabel;
        private System.Windows.Forms.Label RevenueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UpcomingApptTime;
        private System.Windows.Forms.Label UpcomingApptName;
    }
}