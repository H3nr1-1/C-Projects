namespace Assessment10
{
    partial class Assessment10
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbHigher = new System.Windows.Forms.ListBox();
            this.lbLower = new System.Windows.Forms.ListBox();
            this.lblHigherValues = new System.Windows.Forms.Label();
            this.lblLowerValues = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHigherCount = new System.Windows.Forms.Label();
            this.lblLowerCount = new System.Windows.Forms.Label();
            this.lblEqualCount = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadComparisonFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbHigher
            // 
            this.lbHigher.FormattingEnabled = true;
            this.lbHigher.ItemHeight = 16;
            this.lbHigher.Location = new System.Drawing.Point(63, 284);
            this.lbHigher.Name = "lbHigher";
            this.lbHigher.Size = new System.Drawing.Size(200, 100);
            this.lbHigher.TabIndex = 99;
            // 
            // lbLower
            // 
            this.lbLower.FormattingEnabled = true;
            this.lbLower.ItemHeight = 16;
            this.lbLower.Location = new System.Drawing.Point(290, 284);
            this.lbLower.Name = "lbLower";
            this.lbLower.Size = new System.Drawing.Size(200, 100);
            this.lbLower.TabIndex = 99;
            // 
            // lblHigherValues
            // 
            this.lblHigherValues.AutoSize = true;
            this.lblHigherValues.Location = new System.Drawing.Point(116, 265);
            this.lblHigherValues.Name = "lblHigherValues";
            this.lblHigherValues.Size = new System.Drawing.Size(92, 16);
            this.lblHigherValues.TabIndex = 99;
            this.lblHigherValues.Text = "Higher Values";
            // 
            // lblLowerValues
            // 
            this.lblLowerValues.AutoSize = true;
            this.lblLowerValues.Location = new System.Drawing.Point(344, 265);
            this.lblLowerValues.Name = "lblLowerValues";
            this.lblLowerValues.Size = new System.Drawing.Size(88, 16);
            this.lblLowerValues.TabIndex = 99;
            this.lblLowerValues.Text = "Lower Values";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(226, 47);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(100, 40);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(119, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(332, 420);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHigherCount
            // 
            this.lblHigherCount.AutoSize = true;
            this.lblHigherCount.Location = new System.Drawing.Point(118, 166);
            this.lblHigherCount.Name = "lblHigherCount";
            this.lblHigherCount.Size = new System.Drawing.Size(97, 16);
            this.lblHigherCount.TabIndex = 99;
            this.lblHigherCount.Text = "Higher Count: 0";
            // 
            // lblLowerCount
            // 
            this.lblLowerCount.AutoSize = true;
            this.lblLowerCount.Location = new System.Drawing.Point(344, 166);
            this.lblLowerCount.Name = "lblLowerCount";
            this.lblLowerCount.Size = new System.Drawing.Size(93, 16);
            this.lblLowerCount.TabIndex = 99;
            this.lblLowerCount.Text = "Lower Count: 0";
            // 
            // lblEqualCount
            // 
            this.lblEqualCount.AutoSize = true;
            this.lblEqualCount.Location = new System.Drawing.Point(223, 212);
            this.lblEqualCount.Name = "lblEqualCount";
            this.lblEqualCount.Size = new System.Drawing.Size(95, 16);
            this.lblEqualCount.TabIndex = 99;
            this.lblEqualCount.Text = " Equal Count: 0";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnLoadComparisonFile
            // 
            this.btnLoadComparisonFile.Location = new System.Drawing.Point(226, 93);
            this.btnLoadComparisonFile.Name = "btnLoadComparisonFile";
            this.btnLoadComparisonFile.Size = new System.Drawing.Size(100, 60);
            this.btnLoadComparisonFile.TabIndex = 100;
            this.btnLoadComparisonFile.Text = "Load New File";
            this.btnLoadComparisonFile.UseVisualStyleBackColor = true;
            this.btnLoadComparisonFile.Click += new System.EventHandler(this.btnLoadComparisonFile_Click);
            // 
            // Assessment10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 603);
            this.Controls.Add(this.btnLoadComparisonFile);
            this.Controls.Add(this.lblEqualCount);
            this.Controls.Add(this.lblLowerCount);
            this.Controls.Add(this.lblHigherCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.lblLowerValues);
            this.Controls.Add(this.lblHigherValues);
            this.Controls.Add(this.lbLower);
            this.Controls.Add(this.lbHigher);
            this.MaximumSize = new System.Drawing.Size(560, 650);
            this.MinimumSize = new System.Drawing.Size(560, 650);
            this.Name = "Assessment10";
            this.Text = "Assessment10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbHigher;
        private System.Windows.Forms.ListBox lbLower;
        private System.Windows.Forms.Label lblHigherValues;
        private System.Windows.Forms.Label lblLowerValues;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHigherCount;
        private System.Windows.Forms.Label lblLowerCount;
        private System.Windows.Forms.Label lblEqualCount;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnLoadComparisonFile;
    }
}

