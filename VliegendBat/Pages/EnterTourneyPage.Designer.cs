namespace VliegendBat
{
    partial class EnterTourneyPage
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
            this.pnlTourneyList = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlTourneyList
            // 
            this.pnlTourneyList.AutoScroll = true;
            this.pnlTourneyList.Location = new System.Drawing.Point(3, 3);
            this.pnlTourneyList.Name = "pnlTourneyList";
            this.pnlTourneyList.Size = new System.Drawing.Size(647, 235);
            this.pnlTourneyList.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(244, 255);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(204, 44);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Terug";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // EnterTourneyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pnlTourneyList);
            this.Name = "EnterTourneyPage";
            this.Size = new System.Drawing.Size(653, 319);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTourneyList;
        private System.Windows.Forms.Button btnReturn;
    }
}
