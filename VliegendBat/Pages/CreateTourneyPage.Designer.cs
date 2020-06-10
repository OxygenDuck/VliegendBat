namespace VliegendBat
{
    partial class CreateTourneyPage
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnSaveTourney = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(119, 60);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(189, 20);
            this.tbxName.TabIndex = 0;
            // 
            // btnSaveTourney
            // 
            this.btnSaveTourney.Location = new System.Drawing.Point(281, 422);
            this.btnSaveTourney.Name = "btnSaveTourney";
            this.btnSaveTourney.Size = new System.Drawing.Size(179, 51);
            this.btnSaveTourney.TabIndex = 2;
            this.btnSaveTourney.Text = "Creëer";
            this.btnSaveTourney.UseVisualStyleBackColor = true;
            this.btnSaveTourney.Click += new System.EventHandler(this.btnSaveTourney_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naam:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(466, 422);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(179, 51);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Terug";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Location = new System.Drawing.Point(281, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creëer Toernooi";
            // 
            // CreateTourneyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSaveTourney);
            this.Name = "CreateTourneyPage";
            this.Size = new System.Drawing.Size(950, 540);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnSaveTourney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
