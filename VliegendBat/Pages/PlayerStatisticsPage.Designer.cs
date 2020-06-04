namespace VliegendBat
{
    partial class PlayerStatisticsPage
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblStat1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(28, 24);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(79, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "--Player Name--";
            // 
            // lblStat1
            // 
            this.lblStat1.AutoSize = true;
            this.lblStat1.Location = new System.Drawing.Point(31, 58);
            this.lblStat1.Name = "lblStat1";
            this.lblStat1.Size = new System.Drawing.Size(43, 13);
            this.lblStat1.TabIndex = 1;
            this.lblStat1.Text = "--Stats--";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(266, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 213);
            this.panel1.TabIndex = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(130, 220);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(204, 44);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Terug";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // UserStatisticsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStat1);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "UserStatisticsPage";
            this.Size = new System.Drawing.Size(465, 267);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblStat1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
    }
}
