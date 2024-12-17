namespace Assessment13
{
    partial class ReviewForm
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblExperimentNumber = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblResultWeight = new System.Windows.Forms.Label();
            this.lblResultColor = new System.Windows.Forms.Label();
            this.lblResultVolume = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbDescription = new System.Windows.Forms.ListBox();
            this.btnOpenThePodBayDoors = new System.Windows.Forms.Button();
            this.lblGravity = new System.Windows.Forms.Label();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(40, 74);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(95, 16);
            this.lblStudentName.TabIndex = 99;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblExperimentNumber
            // 
            this.lblExperimentNumber.AutoSize = true;
            this.lblExperimentNumber.Location = new System.Drawing.Point(40, 102);
            this.lblExperimentNumber.Name = "lblExperimentNumber";
            this.lblExperimentNumber.Size = new System.Drawing.Size(128, 16);
            this.lblExperimentNumber.TabIndex = 99;
            this.lblExperimentNumber.Text = "Experiment Number:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(40, 133);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 16);
            this.lblDescription.TabIndex = 99;
            this.lblDescription.Text = "Description:";
            // 
            // lblResultWeight
            // 
            this.lblResultWeight.AutoSize = true;
            this.lblResultWeight.Location = new System.Drawing.Point(43, 341);
            this.lblResultWeight.Name = "lblResultWeight";
            this.lblResultWeight.Size = new System.Drawing.Size(93, 16);
            this.lblResultWeight.TabIndex = 99;
            this.lblResultWeight.Text = "Result Weight:";
            // 
            // lblResultColor
            // 
            this.lblResultColor.AutoSize = true;
            this.lblResultColor.Location = new System.Drawing.Point(43, 378);
            this.lblResultColor.Name = "lblResultColor";
            this.lblResultColor.Size = new System.Drawing.Size(83, 16);
            this.lblResultColor.TabIndex = 99;
            this.lblResultColor.Text = "Result Color:";
            // 
            // lblResultVolume
            // 
            this.lblResultVolume.AutoSize = true;
            this.lblResultVolume.Location = new System.Drawing.Point(43, 411);
            this.lblResultVolume.Name = "lblResultVolume";
            this.lblResultVolume.Size = new System.Drawing.Size(97, 16);
            this.lblResultVolume.TabIndex = 99;
            this.lblResultVolume.Text = "Result Volume:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(224, 522);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbDescription
            // 
            this.lbDescription.FormattingEnabled = true;
            this.lbDescription.ItemHeight = 16;
            this.lbDescription.Location = new System.Drawing.Point(124, 133);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(326, 196);
            this.lbDescription.TabIndex = 99;
            // 
            // btnOpenThePodBayDoors
            // 
            this.btnOpenThePodBayDoors.Location = new System.Drawing.Point(184, 551);
            this.btnOpenThePodBayDoors.Name = "btnOpenThePodBayDoors";
            this.btnOpenThePodBayDoors.Size = new System.Drawing.Size(150, 40);
            this.btnOpenThePodBayDoors.TabIndex = 100;
            this.btnOpenThePodBayDoors.Text = "Open The Pod Bay Doors";
            this.btnOpenThePodBayDoors.UseVisualStyleBackColor = true;
            this.btnOpenThePodBayDoors.Click += new System.EventHandler(this.btnOpenThePodBayDoors_Click);
            // 
            // lblGravity
            // 
            this.lblGravity.AutoSize = true;
            this.lblGravity.Location = new System.Drawing.Point(43, 444);
            this.lblGravity.Name = "lblGravity";
            this.lblGravity.Size = new System.Drawing.Size(52, 16);
            this.lblGravity.TabIndex = 99;
            this.lblGravity.Text = "Gravity:";
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.Location = new System.Drawing.Point(43, 474);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(58, 16);
            this.lblVelocity.TabIndex = 99;
            this.lblVelocity.Text = "Velocity:";
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 603);
            this.Controls.Add(this.lblVelocity);
            this.Controls.Add(this.lblGravity);
            this.Controls.Add(this.btnOpenThePodBayDoors);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResultVolume);
            this.Controls.Add(this.lblResultColor);
            this.Controls.Add(this.lblResultWeight);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblExperimentNumber);
            this.Controls.Add(this.lblStudentName);
            this.MaximumSize = new System.Drawing.Size(550, 650);
            this.MinimumSize = new System.Drawing.Size(550, 650);
            this.Name = "ReviewForm";
            this.Text = "ReviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblExperimentNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblResultWeight;
        private System.Windows.Forms.Label lblResultColor;
        private System.Windows.Forms.Label lblResultVolume;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbDescription;
        private System.Windows.Forms.Button btnOpenThePodBayDoors;
        private System.Windows.Forms.Label lblGravity;
        private System.Windows.Forms.Label lblVelocity;
    }
}