namespace Assessment11
{
    partial class Assessment11
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
            this.lblMainText = new System.Windows.Forms.Label();
            this.txtMainText = new System.Windows.Forms.TextBox();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.txtReplaceText = new System.Windows.Forms.TextBox();
            this.btnSearchReplace = new System.Windows.Forms.Button();
            this.lblOccurances = new System.Windows.Forms.Label();
            this.lbOccurances = new System.Windows.Forms.ListBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.cbSpecialCharacters = new System.Windows.Forms.CheckBox();
            this.cbUpper = new System.Windows.Forms.CheckBox();
            this.cbLower = new System.Windows.Forms.CheckBox();
            this.cbSpaces = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblReplaceText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMainText
            // 
            this.lblMainText.AutoSize = true;
            this.lblMainText.Location = new System.Drawing.Point(43, 42);
            this.lblMainText.Name = "lblMainText";
            this.lblMainText.Size = new System.Drawing.Size(68, 16);
            this.lblMainText.TabIndex = 99;
            this.lblMainText.Text = "Main Text:";
            // 
            // txtMainText
            // 
            this.txtMainText.Location = new System.Drawing.Point(46, 62);
            this.txtMainText.Multiline = true;
            this.txtMainText.Name = "txtMainText";
            this.txtMainText.Size = new System.Drawing.Size(539, 114);
            this.txtMainText.TabIndex = 0;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(46, 209);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(200, 22);
            this.txtSearchText.TabIndex = 1;
            // 
            // txtReplaceText
            // 
            this.txtReplaceText.Location = new System.Drawing.Point(385, 209);
            this.txtReplaceText.Name = "txtReplaceText";
            this.txtReplaceText.Size = new System.Drawing.Size(200, 22);
            this.txtReplaceText.TabIndex = 2;
            // 
            // btnSearchReplace
            // 
            this.btnSearchReplace.Location = new System.Drawing.Point(269, 289);
            this.btnSearchReplace.Name = "btnSearchReplace";
            this.btnSearchReplace.Size = new System.Drawing.Size(100, 40);
            this.btnSearchReplace.TabIndex = 3;
            this.btnSearchReplace.Text = "Enter";
            this.btnSearchReplace.UseVisualStyleBackColor = true;
            this.btnSearchReplace.Click += new System.EventHandler(this.btnSearchReplace_Click);
            // 
            // lblOccurances
            // 
            this.lblOccurances.AutoSize = true;
            this.lblOccurances.Location = new System.Drawing.Point(266, 255);
            this.lblOccurances.Name = "lblOccurances";
            this.lblOccurances.Size = new System.Drawing.Size(82, 16);
            this.lblOccurances.TabIndex = 99;
            this.lblOccurances.Text = "Occurances:";
            // 
            // lbOccurances
            // 
            this.lbOccurances.FormattingEnabled = true;
            this.lbOccurances.ItemHeight = 16;
            this.lbOccurances.Location = new System.Drawing.Point(155, 344);
            this.lbOccurances.Name = "lbOccurances";
            this.lbOccurances.Size = new System.Drawing.Size(320, 84);
            this.lbOccurances.TabIndex = 99;
            this.lbOccurances.Tag = "Occurances:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(266, 448);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 16);
            this.lblPassword.TabIndex = 99;
            this.lblPassword.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Red;
            this.txtPassword.Location = new System.Drawing.Point(191, 467);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Enabled = false;
            this.cbNumbers.Location = new System.Drawing.Point(236, 495);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(139, 20);
            this.cbNumbers.TabIndex = 99;
            this.cbNumbers.Text = "Contains Numbers";
            this.cbNumbers.UseVisualStyleBackColor = true;
            // 
            // cbSpecialCharacters
            // 
            this.cbSpecialCharacters.AutoSize = true;
            this.cbSpecialCharacters.Enabled = false;
            this.cbSpecialCharacters.Location = new System.Drawing.Point(236, 521);
            this.cbSpecialCharacters.Name = "cbSpecialCharacters";
            this.cbSpecialCharacters.Size = new System.Drawing.Size(191, 20);
            this.cbSpecialCharacters.TabIndex = 99;
            this.cbSpecialCharacters.Text = "Contains Special Character";
            this.cbSpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // cbUpper
            // 
            this.cbUpper.AutoSize = true;
            this.cbUpper.Enabled = false;
            this.cbUpper.Location = new System.Drawing.Point(236, 547);
            this.cbUpper.Name = "cbUpper";
            this.cbUpper.Size = new System.Drawing.Size(188, 20);
            this.cbUpper.TabIndex = 99;
            this.cbUpper.Text = "Contains Uppercase Letter";
            this.cbUpper.UseVisualStyleBackColor = true;
            // 
            // cbLower
            // 
            this.cbLower.AutoSize = true;
            this.cbLower.Enabled = false;
            this.cbLower.Location = new System.Drawing.Point(236, 573);
            this.cbLower.Name = "cbLower";
            this.cbLower.Size = new System.Drawing.Size(186, 20);
            this.cbLower.TabIndex = 99;
            this.cbLower.Text = "Contains Lowercase Letter";
            this.cbLower.UseVisualStyleBackColor = true;
            // 
            // cbSpaces
            // 
            this.cbSpaces.AutoSize = true;
            this.cbSpaces.Enabled = false;
            this.cbSpaces.Location = new System.Drawing.Point(236, 599);
            this.cbSpaces.Name = "cbSpaces";
            this.cbSpaces.Size = new System.Drawing.Size(154, 20);
            this.cbSpaces.TabIndex = 99;
            this.cbSpaces.Text = "Conatins NO Spaces";
            this.cbSpaces.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(155, 625);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(375, 625);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(46, 183);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(79, 16);
            this.lblSearch.TabIndex = 100;
            this.lblSearch.Text = "Search Text";
            // 
            // lblReplaceText
            // 
            this.lblReplaceText.AutoSize = true;
            this.lblReplaceText.Location = new System.Drawing.Point(383, 183);
            this.lblReplaceText.Name = "lblReplaceText";
            this.lblReplaceText.Size = new System.Drawing.Size(88, 16);
            this.lblReplaceText.TabIndex = 101;
            this.lblReplaceText.Text = "Replace Text";
            // 
            // Assessment11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 703);
            this.Controls.Add(this.lblReplaceText);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbSpaces);
            this.Controls.Add(this.cbLower);
            this.Controls.Add(this.cbUpper);
            this.Controls.Add(this.cbSpecialCharacters);
            this.Controls.Add(this.cbNumbers);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lbOccurances);
            this.Controls.Add(this.lblOccurances);
            this.Controls.Add(this.btnSearchReplace);
            this.Controls.Add(this.txtReplaceText);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.txtMainText);
            this.Controls.Add(this.lblMainText);
            this.MaximumSize = new System.Drawing.Size(650, 750);
            this.MinimumSize = new System.Drawing.Size(650, 750);
            this.Name = "Assessment11";
            this.Text = "Assessment 11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainText;
        private System.Windows.Forms.TextBox txtMainText;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.TextBox txtReplaceText;
        private System.Windows.Forms.Button btnSearchReplace;
        private System.Windows.Forms.Label lblOccurances;
        private System.Windows.Forms.ListBox lbOccurances;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbNumbers;
        private System.Windows.Forms.CheckBox cbSpecialCharacters;
        private System.Windows.Forms.CheckBox cbUpper;
        private System.Windows.Forms.CheckBox cbLower;
        private System.Windows.Forms.CheckBox cbSpaces;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblReplaceText;
    }
}

