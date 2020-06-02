namespace VliegendBat
{
    partial class ManagePlayerScreen
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
            this.pnlPlayerList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(185, 255);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(204, 44);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Terug";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlPlayerList
            // 
            this.pnlPlayerList.Location = new System.Drawing.Point(3, 3);
            this.pnlPlayerList.Name = "pnlPlayerList";
            this.pnlPlayerList.Size = new System.Drawing.Size(555, 235);
            this.pnlPlayerList.TabIndex = 4;
            // 
            // ManagePlayerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pnlPlayerList);
            this.Name = "ManagePlayerScreen";
            this.Size = new System.Drawing.Size(561, 313);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlPlayerList;
    }
}
