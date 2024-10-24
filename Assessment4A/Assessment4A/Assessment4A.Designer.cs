namespace Assessment4A
{
    partial class Assessment4A
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
            this.lblNumberToConvert = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAnswerShown = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumberToConvert
            // 
            this.lblNumberToConvert.AutoSize = true;
            this.lblNumberToConvert.Location = new System.Drawing.Point(256, 128);
            this.lblNumberToConvert.Name = "lblNumberToConvert";
            this.lblNumberToConvert.Size = new System.Drawing.Size(241, 16);
            this.lblNumberToConvert.TabIndex = 0;
            this.lblNumberToConvert.Text = "What number would you like to convert?";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(319, 147);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(97, 22);
            this.txtInput.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(173, 252);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(316, 252);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 40);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(461, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAnswerShown
            // 
            this.lblAnswerShown.AutoSize = true;
            this.lblAnswerShown.Location = new System.Drawing.Point(256, 195);
            this.lblAnswerShown.Name = "lblAnswerShown";
            this.lblAnswerShown.Size = new System.Drawing.Size(54, 16);
            this.lblAnswerShown.TabIndex = 0;
            this.lblAnswerShown.Text = "Answer:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(316, 195);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 16);
            this.lblAnswer.TabIndex = 6;
            // 
            // Assessment4A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblAnswerShown);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblNumberToConvert);
            this.Name = "Assessment4A";
            this.Text = "Assessment4A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberToConvert;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAnswerShown;
        private System.Windows.Forms.Label lblAnswer;
    }
}

