namespace VliegendBat
{
    partial class ManageTourneyPage
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlTourneyList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(379, 493);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(204, 44);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Terug";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlTourneyList
            // 
            this.pnlTourneyList.AutoScroll = true;
            this.pnlTourneyList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTourneyList.Location = new System.Drawing.Point(3, 3);
            this.pnlTourneyList.Name = "pnlTourneyList";
            this.pnlTourneyList.Size = new System.Drawing.Size(944, 484);
            this.pnlTourneyList.TabIndex = 2;
            // 
            // ManageTourneyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pnlTourneyList);
            this.Name = "ManageTourneyPage";
            this.Size = new System.Drawing.Size(950, 540);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlTourneyList;
    }
}
