namespace FinalExam_Music
{
    partial class Music
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMusicians = new System.Windows.Forms.ListBox();
            this.lblPopCount = new System.Windows.Forms.Label();
            this.lblMetalCount = new System.Windows.Forms.Label();
            this.lblCountryCount = new System.Windows.Forms.Label();
            this.lblOtherCount = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMusicians
            // 
            this.lstMusicians.FormattingEnabled = true;
            this.lstMusicians.ItemHeight = 16;
            this.lstMusicians.Location = new System.Drawing.Point(34, 31);
            this.lstMusicians.Name = "lstMusicians";
            this.lstMusicians.Size = new System.Drawing.Size(243, 260);
            this.lstMusicians.TabIndex = 0;
            // 
            // lblPopCount
            // 
            this.lblPopCount.AutoSize = true;
            this.lblPopCount.Location = new System.Drawing.Point(34, 321);
            this.lblPopCount.Name = "lblPopCount";
            this.lblPopCount.Size = new System.Drawing.Size(72, 16);
            this.lblPopCount.TabIndex = 99;
            this.lblPopCount.Text = "Pop Count:";
            // 
            // lblMetalCount
            // 
            this.lblMetalCount.AutoSize = true;
            this.lblMetalCount.Location = new System.Drawing.Point(34, 364);
            this.lblMetalCount.Name = "lblMetalCount";
            this.lblMetalCount.Size = new System.Drawing.Size(80, 16);
            this.lblMetalCount.TabIndex = 99;
            this.lblMetalCount.Text = "Metal Count:";
            // 
            // lblCountryCount
            // 
            this.lblCountryCount.AutoSize = true;
            this.lblCountryCount.Location = new System.Drawing.Point(34, 407);
            this.lblCountryCount.Name = "lblCountryCount";
            this.lblCountryCount.Size = new System.Drawing.Size(92, 16);
            this.lblCountryCount.TabIndex = 99;
            this.lblCountryCount.Text = "Country Count:";
            // 
            // lblOtherCount
            // 
            this.lblOtherCount.AutoSize = true;
            this.lblOtherCount.Location = new System.Drawing.Point(34, 450);
            this.lblOtherCount.Name = "lblOtherCount";
            this.lblOtherCount.Size = new System.Drawing.Size(79, 16);
            this.lblOtherCount.TabIndex = 99;
            this.lblOtherCount.Text = "Other Count:";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(34, 486);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(202, 486);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 543);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.lblOtherCount);
            this.Controls.Add(this.lblCountryCount);
            this.Controls.Add(this.lblMetalCount);
            this.Controls.Add(this.lblPopCount);
            this.Controls.Add(this.lstMusicians);
            this.MaximumSize = new System.Drawing.Size(340, 590);
            this.MinimumSize = new System.Drawing.Size(340, 590);
            this.Name = "Music";
            this.Text = "Final Exam Music";
            this.Load += new System.EventHandler(this.Music_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMusicians;
        private System.Windows.Forms.Label lblPopCount;
        private System.Windows.Forms.Label lblMetalCount;
        private System.Windows.Forms.Label lblCountryCount;
        private System.Windows.Forms.Label lblOtherCount;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnExit;
    }
}

