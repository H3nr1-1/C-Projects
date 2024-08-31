namespace FunnyJoke
{
    partial class frmFunnyJoke
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
            this.txtJoke = new System.Windows.Forms.TextBox();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnPunchLine = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJoke
            // 
            this.txtJoke.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtJoke.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtJoke.Location = new System.Drawing.Point(406, 168);
            this.txtJoke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJoke.Name = "txtJoke";
            this.txtJoke.Size = new System.Drawing.Size(337, 30);
            this.txtJoke.TabIndex = 0;
            this.txtJoke.Text = "Ready for a joke?";
            this.txtJoke.TextChanged += new System.EventHandler(this.txtJoke_TextChanged);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(496, 208);
            this.btnSetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(162, 66);
            this.btnSetup.TabIndex = 1;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnPunchLine
            // 
            this.btnPunchLine.Location = new System.Drawing.Point(496, 280);
            this.btnPunchLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPunchLine.Name = "btnPunchLine";
            this.btnPunchLine.Size = new System.Drawing.Size(162, 66);
            this.btnPunchLine.TabIndex = 2;
            this.btnPunchLine.Text = "Punch Line";
            this.btnPunchLine.UseVisualStyleBackColor = true;
            this.btnPunchLine.Click += new System.EventHandler(this.btnPunchLine_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(496, 354);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 48);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExt
            // 
            this.btnExt.Location = new System.Drawing.Point(496, 408);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(160, 48);
            this.btnExt.TabIndex = 4;
            this.btnExt.Text = "Exit";
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // frmFunnyJoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPunchLine);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.txtJoke);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFunnyJoke";
            this.Text = "funnyJoke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJoke;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnPunchLine;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExt;
    }
}

