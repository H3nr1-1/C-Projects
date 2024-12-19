namespace FinalExam_Instraments
{
    partial class Intraments
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
            this.lstInstruments = new System.Windows.Forms.ListBox();
            this.lstIHaveNoVowels = new System.Windows.Forms.ListBox();
            this.btnRemoveVowels = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstInstruments
            // 
            this.lstInstruments.FormattingEnabled = true;
            this.lstInstruments.ItemHeight = 16;
            this.lstInstruments.Location = new System.Drawing.Point(43, 35);
            this.lstInstruments.Name = "lstInstruments";
            this.lstInstruments.Size = new System.Drawing.Size(288, 100);
            this.lstInstruments.TabIndex = 99;
            // 
            // lstIHaveNoVowels
            // 
            this.lstIHaveNoVowels.FormattingEnabled = true;
            this.lstIHaveNoVowels.ItemHeight = 16;
            this.lstIHaveNoVowels.Location = new System.Drawing.Point(43, 164);
            this.lstIHaveNoVowels.Name = "lstIHaveNoVowels";
            this.lstIHaveNoVowels.Size = new System.Drawing.Size(288, 100);
            this.lstIHaveNoVowels.TabIndex = 99;
            // 
            // btnRemoveVowels
            // 
            this.btnRemoveVowels.Location = new System.Drawing.Point(43, 287);
            this.btnRemoveVowels.Name = "btnRemoveVowels";
            this.btnRemoveVowels.Size = new System.Drawing.Size(100, 40);
            this.btnRemoveVowels.TabIndex = 0;
            this.btnRemoveVowels.Text = "Remove Vowels";
            this.btnRemoveVowels.UseVisualStyleBackColor = true;
            this.btnRemoveVowels.Click += new System.EventHandler(this.btnRemoveVowels_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(231, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Intraments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveVowels);
            this.Controls.Add(this.lstIHaveNoVowels);
            this.Controls.Add(this.lstInstruments);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Intraments";
            this.Text = "Final Exam Instraments";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInstruments;
        private System.Windows.Forms.ListBox lstIHaveNoVowels;
        private System.Windows.Forms.Button btnRemoveVowels;
        private System.Windows.Forms.Button btnExit;
    }
}

