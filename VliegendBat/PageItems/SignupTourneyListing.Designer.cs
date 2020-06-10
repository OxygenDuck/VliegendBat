namespace VliegendBat
{
    partial class SignupTourneyListing
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
            this.lblIndex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMatchesPlayed = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTourneyName
            // 
            this.lblTourneyName.AutoSize = true;
            this.lblTourneyName.Location = new System.Drawing.Point(95, 27);
            this.lblTourneyName.Name = "lblTourneyName";
            this.lblTourneyName.Size = new System.Drawing.Size(89, 13);
            this.lblTourneyName.TabIndex = 0;
            this.lblTourneyName.Text = "--Tourney Name--";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(3, 37);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(45, 13);
            this.lblIndex.TabIndex = 1;
            this.lblIndex.Text = "--Index--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(132, 47);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "--Status--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wedstrijden Gespeeld:";
            // 
            // lblMatchesPlayed
            // 
            this.lblMatchesPlayed.AutoSize = true;
            this.lblMatchesPlayed.Location = new System.Drawing.Point(759, 37);
            this.lblMatchesPlayed.Name = "lblMatchesPlayed";
            this.lblMatchesPlayed.Size = new System.Drawing.Size(30, 13);
            this.lblMatchesPlayed.TabIndex = 5;
            this.lblMatchesPlayed.Text = "--0/--";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(801, 18);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(114, 51);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Aanmelden";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // SignupTourneyListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblMatchesPlayed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblTourneyName);
            this.Name = "SignupTourneyListing";
            this.Size = new System.Drawing.Size(944, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTourneyName;
        public System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMatchesPlayed;
        private System.Windows.Forms.Button btnSignUp;
    }
}
