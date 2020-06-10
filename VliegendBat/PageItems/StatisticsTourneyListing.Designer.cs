namespace VliegendBat
{
    partial class StatisticsTourneyListing
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
            this.lblTourneyName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTourneyName
            // 
            this.lblTourneyName.AutoSize = true;
            this.lblTourneyName.Location = new System.Drawing.Point(19, 20);
            this.lblTourneyName.Name = "lblTourneyName";
            this.lblTourneyName.Size = new System.Drawing.Size(89, 13);
            this.lblTourneyName.TabIndex = 0;
            this.lblTourneyName.Text = "--Tourney Name--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status: ";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(443, 20);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(42, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "--state--";
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Location = new System.Drawing.Point(140, 48);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(35, 13);
            this.lblGamesPlayed.TabIndex = 4;
            this.lblGamesPlayed.Text = "--0/x--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wedstrijden gespeeld: ";
            // 
            // StatisticsTourneyListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGamesPlayed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTourneyName);
            this.Name = "StatisticsTourneyListing";
            this.Size = new System.Drawing.Size(505, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTourneyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Label label3;
    }
}
