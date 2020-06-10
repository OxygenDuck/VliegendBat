namespace VliegendBat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbAdmin = new System.Windows.Forms.GroupBox();
            this.btnManagePlayers = new System.Windows.Forms.Button();
            this.btnManageTourney = new System.Windows.Forms.Button();
            this.btnCreateTourney = new System.Windows.Forms.Button();
            this.grbPlayer = new System.Windows.Forms.GroupBox();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.btnTourneySignup = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grbAdmin.SuspendLayout();
            this.grbPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAdmin
            // 
            this.grbAdmin.Controls.Add(this.btnManagePlayers);
            this.grbAdmin.Controls.Add(this.btnManageTourney);
            this.grbAdmin.Controls.Add(this.btnCreateTourney);
            this.grbAdmin.Location = new System.Drawing.Point(247, 160);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Size = new System.Drawing.Size(200, 151);
            this.grbAdmin.TabIndex = 0;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Administrator";
            // 
            // btnManagePlayers
            // 
            this.btnManagePlayers.Location = new System.Drawing.Point(6, 103);
            this.btnManagePlayers.Name = "btnManagePlayers";
            this.btnManagePlayers.Size = new System.Drawing.Size(188, 36);
            this.btnManagePlayers.TabIndex = 2;
            this.btnManagePlayers.Text = "Beheer Spelers";
            this.btnManagePlayers.UseVisualStyleBackColor = true;
            this.btnManagePlayers.Click += new System.EventHandler(this.btnManagePlayers_Click);
            // 
            // btnManageTourney
            // 
            this.btnManageTourney.Location = new System.Drawing.Point(6, 61);
            this.btnManageTourney.Name = "btnManageTourney";
            this.btnManageTourney.Size = new System.Drawing.Size(188, 36);
            this.btnManageTourney.TabIndex = 1;
            this.btnManageTourney.Text = "Beheer Toernooien";
            this.btnManageTourney.UseVisualStyleBackColor = true;
            this.btnManageTourney.Click += new System.EventHandler(this.btnManageTourney_Click);
            // 
            // btnCreateTourney
            // 
            this.btnCreateTourney.Location = new System.Drawing.Point(6, 19);
            this.btnCreateTourney.Name = "btnCreateTourney";
            this.btnCreateTourney.Size = new System.Drawing.Size(188, 36);
            this.btnCreateTourney.TabIndex = 0;
            this.btnCreateTourney.Text = "Creëer Toernooi";
            this.btnCreateTourney.UseVisualStyleBackColor = true;
            this.btnCreateTourney.Click += new System.EventHandler(this.btnCreateTourney_Click);
            // 
            // grbPlayer
            // 
            this.grbPlayer.Controls.Add(this.btnShowStatistics);
            this.grbPlayer.Controls.Add(this.btnTourneySignup);
            this.grbPlayer.Location = new System.Drawing.Point(453, 160);
            this.grbPlayer.Name = "grbPlayer";
            this.grbPlayer.Size = new System.Drawing.Size(200, 151);
            this.grbPlayer.TabIndex = 1;
            this.grbPlayer.TabStop = false;
            this.grbPlayer.Text = "Speler";
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Location = new System.Drawing.Point(6, 61);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(188, 36);
            this.btnShowStatistics.TabIndex = 4;
            this.btnShowStatistics.Text = "Toon Statistieken";
            this.btnShowStatistics.UseVisualStyleBackColor = true;
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            // 
            // btnTourneySignup
            // 
            this.btnTourneySignup.Location = new System.Drawing.Point(6, 19);
            this.btnTourneySignup.Name = "btnTourneySignup";
            this.btnTourneySignup.Size = new System.Drawing.Size(188, 36);
            this.btnTourneySignup.TabIndex = 3;
            this.btnTourneySignup.Text = "Meedoen aan Toernooi";
            this.btnTourneySignup.UseVisualStyleBackColor = true;
            this.btnTourneySignup.Click += new System.EventHandler(this.btnTourneySignup_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(247, 317);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(406, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Uitloggen";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grbPlayer);
            this.Controls.Add(this.grbAdmin);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(950, 540);
            this.grbAdmin.ResumeLayout(false);
            this.grbPlayer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdmin;
        private System.Windows.Forms.Button btnManagePlayers;
        private System.Windows.Forms.Button btnManageTourney;
        private System.Windows.Forms.Button btnCreateTourney;
        private System.Windows.Forms.GroupBox grbPlayer;
        private System.Windows.Forms.Button btnShowStatistics;
        private System.Windows.Forms.Button btnTourneySignup;
        private System.Windows.Forms.Button btnLogout;
    }
}
