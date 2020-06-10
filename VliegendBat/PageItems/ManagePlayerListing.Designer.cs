namespace VliegendBat
{
    partial class ManagePlayerListing
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
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRights = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(763, 15);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(83, 46);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "Wijzigingen opslaan";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(852, 15);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(83, 46);
            this.btnRemoveUser.TabIndex = 1;
            this.btnRemoveUser.Text = "Verwijderen";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(13, 32);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(25, 13);
            this.lblIndex.TabIndex = 2;
            this.lblIndex.Text = "--0--";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(65, 30);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(104, 16);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "--Speler Naam--";
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Location = new System.Drawing.Point(674, 15);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(83, 46);
            this.btnShowStatistics.TabIndex = 4;
            this.btnShowStatistics.Text = "Toon Statistieken";
            this.btnShowStatistics.UseVisualStyleBackColor = true;
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rechten:";
            // 
            // cbxRights
            // 
            this.cbxRights.FormattingEnabled = true;
            this.cbxRights.Items.AddRange(new object[] {
            "Gebruiker",
            "Administrator"});
            this.cbxRights.Location = new System.Drawing.Point(540, 28);
            this.cbxRights.Name = "cbxRights";
            this.cbxRights.Size = new System.Drawing.Size(128, 21);
            this.cbxRights.TabIndex = 6;
            // 
            // ManagePlayerListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxRights);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowStatistics);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnSaveChanges);
            this.Name = "ManagePlayerListing";
            this.Size = new System.Drawing.Size(944, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnRemoveUser;
        public System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnShowStatistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRights;
    }
}
