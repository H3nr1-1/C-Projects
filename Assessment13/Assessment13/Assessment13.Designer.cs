namespace Assessment13
{
    partial class Assessment13
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
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblExperimentNumber = new System.Windows.Forms.Label();
            this.txtExperimentNumber = new System.Windows.Forms.TextBox();
            this.lbExperimentDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblResultWeight = new System.Windows.Forms.Label();
            this.txtResultWeight = new System.Windows.Forms.TextBox();
            this.lblResultColor = new System.Windows.Forms.Label();
            this.cmbResultColor = new System.Windows.Forms.ComboBox();
            this.lblResultVolume = new System.Windows.Forms.Label();
            this.txtResultVolume = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbExperiments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(47, 38);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(95, 16);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(204, 32);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(276, 22);
            this.txtStudentName.TabIndex = 0;
            // 
            // lblExperimentNumber
            // 
            this.lblExperimentNumber.AutoSize = true;
            this.lblExperimentNumber.Location = new System.Drawing.Point(47, 64);
            this.lblExperimentNumber.Name = "lblExperimentNumber";
            this.lblExperimentNumber.Size = new System.Drawing.Size(128, 16);
            this.lblExperimentNumber.TabIndex = 99;
            this.lblExperimentNumber.Text = "Experiment Number:";
            // 
            // txtExperimentNumber
            // 
            this.txtExperimentNumber.Location = new System.Drawing.Point(204, 61);
            this.txtExperimentNumber.Name = "txtExperimentNumber";
            this.txtExperimentNumber.Size = new System.Drawing.Size(276, 22);
            this.txtExperimentNumber.TabIndex = 1;
            // 
            // lbExperimentDescription
            // 
            this.lbExperimentDescription.AutoSize = true;
            this.lbExperimentDescription.Location = new System.Drawing.Point(47, 93);
            this.lbExperimentDescription.Name = "lbExperimentDescription";
            this.lbExperimentDescription.Size = new System.Drawing.Size(148, 16);
            this.lbExperimentDescription.TabIndex = 99;
            this.lbExperimentDescription.Text = "Experiment Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(205, 90);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(275, 94);
            this.txtDescription.TabIndex = 2;
            // 
            // lblResultWeight
            // 
            this.lblResultWeight.AutoSize = true;
            this.lblResultWeight.Location = new System.Drawing.Point(47, 198);
            this.lblResultWeight.Name = "lblResultWeight";
            this.lblResultWeight.Size = new System.Drawing.Size(93, 16);
            this.lblResultWeight.TabIndex = 99;
            this.lblResultWeight.Text = "Result Weight:";
            // 
            // txtResultWeight
            // 
            this.txtResultWeight.Location = new System.Drawing.Point(204, 192);
            this.txtResultWeight.Name = "txtResultWeight";
            this.txtResultWeight.Size = new System.Drawing.Size(276, 22);
            this.txtResultWeight.TabIndex = 3;
            // 
            // lblResultColor
            // 
            this.lblResultColor.AutoSize = true;
            this.lblResultColor.Location = new System.Drawing.Point(47, 230);
            this.lblResultColor.Name = "lblResultColor";
            this.lblResultColor.Size = new System.Drawing.Size(83, 16);
            this.lblResultColor.TabIndex = 99;
            this.lblResultColor.Text = "Result Color:";
            // 
            // cmbResultColor
            // 
            this.cmbResultColor.FormattingEnabled = true;
            this.cmbResultColor.Location = new System.Drawing.Point(205, 222);
            this.cmbResultColor.Name = "cmbResultColor";
            this.cmbResultColor.Size = new System.Drawing.Size(275, 24);
            this.cmbResultColor.TabIndex = 4;
            // 
            // lblResultVolume
            // 
            this.lblResultVolume.AutoSize = true;
            this.lblResultVolume.Location = new System.Drawing.Point(47, 260);
            this.lblResultVolume.Name = "lblResultVolume";
            this.lblResultVolume.Size = new System.Drawing.Size(97, 16);
            this.lblResultVolume.TabIndex = 99;
            this.lblResultVolume.Text = "Result Volume:";
            // 
            // txtResultVolume
            // 
            this.txtResultVolume.Location = new System.Drawing.Point(204, 253);
            this.txtResultVolume.Name = "txtResultVolume";
            this.txtResultVolume.Size = new System.Drawing.Size(276, 22);
            this.txtResultVolume.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(50, 309);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(138, 309);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(226, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(314, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(402, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbExperiments
            // 
            this.lbExperiments.FormattingEnabled = true;
            this.lbExperiments.ItemHeight = 16;
            this.lbExperiments.Location = new System.Drawing.Point(50, 357);
            this.lbExperiments.Name = "lbExperiments";
            this.lbExperiments.Size = new System.Drawing.Size(430, 180);
            this.lbExperiments.TabIndex = 12;
            this.lbExperiments.DoubleClick += new System.EventHandler(this.lbExperiments_DoubleClick);
            // 
            // Assessment13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 603);
            this.Controls.Add(this.lbExperiments);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtResultVolume);
            this.Controls.Add(this.lblResultVolume);
            this.Controls.Add(this.cmbResultColor);
            this.Controls.Add(this.lblResultColor);
            this.Controls.Add(this.txtResultWeight);
            this.Controls.Add(this.lblResultWeight);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbExperimentDescription);
            this.Controls.Add(this.txtExperimentNumber);
            this.Controls.Add(this.lblExperimentNumber);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.MaximumSize = new System.Drawing.Size(550, 650);
            this.MinimumSize = new System.Drawing.Size(550, 650);
            this.Name = "Assessment13";
            this.Text = "Assessment13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblExperimentNumber;
        private System.Windows.Forms.TextBox txtExperimentNumber;
        private System.Windows.Forms.Label lbExperimentDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblResultWeight;
        private System.Windows.Forms.TextBox txtResultWeight;
        private System.Windows.Forms.Label lblResultColor;
        private System.Windows.Forms.ComboBox cmbResultColor;
        private System.Windows.Forms.Label lblResultVolume;
        private System.Windows.Forms.TextBox txtResultVolume;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbExperiments;
    }
}

