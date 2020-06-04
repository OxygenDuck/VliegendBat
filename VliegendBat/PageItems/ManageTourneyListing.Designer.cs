namespace VliegendBat
{
    partial class ManageTourneyListing
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
            this.btnManageMatches = new System.Windows.Forms.Button();
            this.lblMatchesPlayed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblTourneyName = new System.Windows.Forms.Label();
            this.lblParticipants = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveTourney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageMatches
            // 
            this.btnManageMatches.Location = new System.Drawing.Point(535, 14);
            this.btnManageMatches.Name = "btnManageMatches";
            this.btnManageMatches.Size = new System.Drawing.Size(114, 51);
            this.btnManageMatches.TabIndex = 13;
            this.btnManageMatches.Text = "Beheer Wedstrijden";
            this.btnManageMatches.UseVisualStyleBackColor = true;
            this.btnManageMatches.Click += new System.EventHandler(this.btnManageMatches_Click);
            // 
            // lblMatchesPlayed
            // 
            this.lblMatchesPlayed.AutoSize = true;
            this.lblMatchesPlayed.Location = new System.Drawing.Point(499, 33);
            this.lblMatchesPlayed.Name = "lblMatchesPlayed";
            this.lblMatchesPlayed.Size = new System.Drawing.Size(30, 13);
            this.lblMatchesPlayed.TabIndex = 12;
            this.lblMatchesPlayed.Text = "--0/--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wedstrijden Gespeeld:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(218, 33);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "--Status--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Status:";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(13, 33);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(45, 13);
            this.lblIndex.TabIndex = 8;
            this.lblIndex.Text = "--Index--";
            // 
            // lblTourneyName
            // 
            this.lblTourneyName.AutoSize = true;
            this.lblTourneyName.Location = new System.Drawing.Point(64, 33);
            this.lblTourneyName.Name = "lblTourneyName";
            this.lblTourneyName.Size = new System.Drawing.Size(89, 13);
            this.lblTourneyName.TabIndex = 7;
            this.lblTourneyName.Text = "--Tourney Name--";
            // 
            // lblParticipants
            // 
            this.lblParticipants.AutoSize = true;
            this.lblParticipants.Location = new System.Drawing.Point(354, 33);
            this.lblParticipants.Name = "lblParticipants";
            this.lblParticipants.Size = new System.Drawing.Size(25, 13);
            this.lblParticipants.TabIndex = 15;
            this.lblParticipants.Text = "--0--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Deelnemers:";
            // 
            // btnRemoveTourney
            // 
            this.btnRemoveTourney.Location = new System.Drawing.Point(649, 14);
            this.btnRemoveTourney.Name = "btnRemoveTourney";
            this.btnRemoveTourney.Size = new System.Drawing.Size(114, 51);
            this.btnRemoveTourney.TabIndex = 16;
            this.btnRemoveTourney.Text = "Verwijderen";
            this.btnRemoveTourney.UseVisualStyleBackColor = true;
            // 
            // ManageTourneyListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveTourney);
            this.Controls.Add(this.lblParticipants);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnManageMatches);
            this.Controls.Add(this.lblMatchesPlayed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblTourneyName);
            this.Name = "ManageTourneyListing";
            this.Size = new System.Drawing.Size(766, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageMatches;
        private System.Windows.Forms.Label lblMatchesPlayed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblTourneyName;
        private System.Windows.Forms.Label lblParticipants;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveTourney;
    }
}
