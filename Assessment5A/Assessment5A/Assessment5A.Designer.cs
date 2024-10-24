namespace Assessment5A
{
    partial class Assessment5A
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
            this.lblEnterPSI = new System.Windows.Forms.Label();
            this.txtPsi = new System.Windows.Forms.TextBox();
            this.lblBar = new System.Windows.Forms.Label();
            this.lbChart = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPSI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterPSI
            // 
            this.lblEnterPSI.AutoSize = true;
            this.lblEnterPSI.Location = new System.Drawing.Point(124, 58);
            this.lblEnterPSI.Name = "lblEnterPSI";
            this.lblEnterPSI.Size = new System.Drawing.Size(105, 16);
            this.lblEnterPSI.TabIndex = 0;
            this.lblEnterPSI.Text = "Enter PSI (1-100)";
            // 
            // txtPsi
            // 
            this.txtPsi.Location = new System.Drawing.Point(127, 89);
            this.txtPsi.Name = "txtPsi";
            this.txtPsi.Size = new System.Drawing.Size(100, 22);
            this.txtPsi.TabIndex = 0;
            // 
            // lblBar
            // 
            this.lblBar.AutoSize = true;
            this.lblBar.Location = new System.Drawing.Point(127, 162);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(69, 16);
            this.lblBar.TabIndex = 0;
            this.lblBar.Text = "Bar Value:";
            // 
            // lbChart
            // 
            this.lbChart.FormattingEnabled = true;
            this.lbChart.ItemHeight = 16;
            this.lbChart.Location = new System.Drawing.Point(130, 204);
            this.lbChart.Name = "lbChart";
            this.lbChart.Size = new System.Drawing.Size(197, 164);
            this.lbChart.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(127, 409);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 40);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(257, 409);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(389, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPSI
            // 
            this.lblPSI.AutoSize = true;
            this.lblPSI.Location = new System.Drawing.Point(127, 130);
            this.lblPSI.Name = "lblPSI";
            this.lblPSI.Size = new System.Drawing.Size(69, 16);
            this.lblPSI.TabIndex = 0;
            this.lblPSI.Text = "PSI Value:";
            // 
            // Assessment5A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 530);
            this.Controls.Add(this.lblPSI);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbChart);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.txtPsi);
            this.Controls.Add(this.lblEnterPSI);
            this.Name = "Assessment5A";
            this.Text = "Assessment5A";
            this.Load += new System.EventHandler(this.Assessment5A_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterPSI;
        private System.Windows.Forms.TextBox txtPsi;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.ListBox lbChart;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPSI;
    }
}

