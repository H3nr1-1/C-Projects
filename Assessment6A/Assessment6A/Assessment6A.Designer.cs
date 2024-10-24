namespace Assessment6A
{
    partial class Assessment6A
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
            this.lblStartOfRange = new System.Windows.Forms.Label();
            this.lblEndOfRange = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.txtRangeStart = new System.Windows.Forms.TextBox();
            this.txtRangeEnd = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblStartOfRange
            // 
            this.lblStartOfRange.AutoSize = true;
            this.lblStartOfRange.Location = new System.Drawing.Point(218, 79);
            this.lblStartOfRange.Name = "lblStartOfRange";
            this.lblStartOfRange.Size = new System.Drawing.Size(92, 16);
            this.lblStartOfRange.TabIndex = 99;
            this.lblStartOfRange.Text = "Start of Range";
            // 
            // lblEndOfRange
            // 
            this.lblEndOfRange.AutoSize = true;
            this.lblEndOfRange.Location = new System.Drawing.Point(215, 142);
            this.lblEndOfRange.Name = "lblEndOfRange";
            this.lblEndOfRange.Size = new System.Drawing.Size(89, 16);
            this.lblEndOfRange.TabIndex = 99;
            this.lblEndOfRange.Text = "End of Range";
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Location = new System.Drawing.Point(215, 208);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(106, 16);
            this.lblNumbers.TabIndex = 99;
            this.lblNumbers.Text = "Number Quantity";
            // 
            // txtRangeStart
            // 
            this.txtRangeStart.Location = new System.Drawing.Point(218, 98);
            this.txtRangeStart.Name = "txtRangeStart";
            this.txtRangeStart.Size = new System.Drawing.Size(100, 22);
            this.txtRangeStart.TabIndex = 0;
            // 
            // txtRangeEnd
            // 
            this.txtRangeEnd.Location = new System.Drawing.Point(218, 161);
            this.txtRangeEnd.Name = "txtRangeEnd";
            this.txtRangeEnd.Size = new System.Drawing.Size(100, 22);
            this.txtRangeEnd.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(221, 227);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(90, 272);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 40);
            this.btnGenerate.TabIndex = 100;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(221, 272);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 101;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(356, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 102;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Assessment6A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 428);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtRangeEnd);
            this.Controls.Add(this.txtRangeStart);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblEndOfRange);
            this.Controls.Add(this.lblStartOfRange);
            this.MaximumSize = new System.Drawing.Size(550, 475);
            this.MinimumSize = new System.Drawing.Size(550, 475);
            this.Name = "Assessment6A";
            this.Text = "Assessment6A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartOfRange;
        private System.Windows.Forms.Label lblEndOfRange;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.TextBox txtRangeStart;
        private System.Windows.Forms.TextBox txtRangeEnd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

