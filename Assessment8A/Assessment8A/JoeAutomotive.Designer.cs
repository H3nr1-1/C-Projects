namespace Assessment8A
{
    partial class JoeAutomotive
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
            this.lblPartsCost = new System.Windows.Forms.Label();
            this.lblLabor = new System.Windows.Forms.Label();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.chkRental = new System.Windows.Forms.CheckBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtRentalDays = new System.Windows.Forms.TextBox();
            this.lblRentalPrice = new System.Windows.Forms.Label();
            this.txtRentalPrice = new System.Windows.Forms.TextBox();
            this.lblLC = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblRC = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLaborCharges = new System.Windows.Forms.Label();
            this.lblPartsCharges = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblRentalCharges = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPartsCost
            // 
            this.lblPartsCost.AutoSize = true;
            this.lblPartsCost.Location = new System.Drawing.Point(77, 48);
            this.lblPartsCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartsCost.Name = "lblPartsCost";
            this.lblPartsCost.Size = new System.Drawing.Size(62, 15);
            this.lblPartsCost.TabIndex = 0;
            this.lblPartsCost.Text = "Parts Cost";
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(265, 48);
            this.lblLabor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(75, 15);
            this.lblLabor.TabIndex = 0;
            this.lblLabor.Text = "Labor Hours";
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(80, 74);
            this.txtParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(76, 20);
            this.txtParts.TabIndex = 0;
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(267, 74);
            this.txtLabor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(76, 20);
            this.txtLabor.TabIndex = 1;
            // 
            // chkRental
            // 
            this.chkRental.AutoSize = true;
            this.chkRental.Location = new System.Drawing.Point(154, 113);
            this.chkRental.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkRental.Name = "chkRental";
            this.chkRental.Size = new System.Drawing.Size(141, 19);
            this.chkRental.TabIndex = 2;
            this.chkRental.Text = "Rental Car Needed?";
            this.chkRental.UseVisualStyleBackColor = true;
            this.chkRental.CheckedChanged += new System.EventHandler(this.chkRental_CheckedChanged);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(77, 146);
            this.lblDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(95, 15);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Number of Days";
            // 
            // txtRentalDays
            // 
            this.txtRentalDays.Location = new System.Drawing.Point(80, 172);
            this.txtRentalDays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRentalDays.Name = "txtRentalDays";
            this.txtRentalDays.Size = new System.Drawing.Size(76, 20);
            this.txtRentalDays.TabIndex = 3;
            // 
            // lblRentalPrice
            // 
            this.lblRentalPrice.AutoSize = true;
            this.lblRentalPrice.Location = new System.Drawing.Point(265, 146);
            this.lblRentalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRentalPrice.Name = "lblRentalPrice";
            this.lblRentalPrice.Size = new System.Drawing.Size(104, 15);
            this.lblRentalPrice.TabIndex = 0;
            this.lblRentalPrice.Text = "Daily Rental Price";
            // 
            // txtRentalPrice
            // 
            this.txtRentalPrice.Location = new System.Drawing.Point(267, 172);
            this.txtRentalPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRentalPrice.Name = "txtRentalPrice";
            this.txtRentalPrice.Size = new System.Drawing.Size(76, 20);
            this.txtRentalPrice.TabIndex = 4;
            // 
            // lblLC
            // 
            this.lblLC.AutoSize = true;
            this.lblLC.Location = new System.Drawing.Point(65, 264);
            this.lblLC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLC.Name = "lblLC";
            this.lblLC.Size = new System.Drawing.Size(91, 15);
            this.lblLC.TabIndex = 0;
            this.lblLC.Text = "Labor Charges:";
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Location = new System.Drawing.Point(65, 297);
            this.lblPC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(87, 15);
            this.lblPC.TabIndex = 0;
            this.lblPC.Text = "Parts Charges:";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(246, 264);
            this.lblT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(78, 15);
            this.lblT.TabIndex = 0;
            this.lblT.Text = "Tax on Parts:";
            // 
            // lblRC
            // 
            this.lblRC.AutoSize = true;
            this.lblRC.Location = new System.Drawing.Point(246, 297);
            this.lblRC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRC.Name = "lblRC";
            this.lblRC.Size = new System.Drawing.Size(95, 15);
            this.lblRC.TabIndex = 0;
            this.lblRC.Text = "Rental Charges:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(151, 333);
            this.lblTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(86, 15);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "Total Charges:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(92, 378);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 32);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(189, 378);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(282, 378);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLaborCharges
            // 
            this.lblLaborCharges.AutoSize = true;
            this.lblLaborCharges.Location = new System.Drawing.Point(165, 264);
            this.lblLaborCharges.Name = "lblLaborCharges";
            this.lblLaborCharges.Size = new System.Drawing.Size(0, 15);
            this.lblLaborCharges.TabIndex = 0;
            // 
            // lblPartsCharges
            // 
            this.lblPartsCharges.AutoSize = true;
            this.lblPartsCharges.Location = new System.Drawing.Point(165, 297);
            this.lblPartsCharges.Name = "lblPartsCharges";
            this.lblPartsCharges.Size = new System.Drawing.Size(0, 15);
            this.lblPartsCharges.TabIndex = 0;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(346, 264);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(0, 15);
            this.lblTax.TabIndex = 0;
            // 
            // lblRentalCharges
            // 
            this.lblRentalCharges.AutoSize = true;
            this.lblRentalCharges.Location = new System.Drawing.Point(346, 297);
            this.lblRentalCharges.Name = "lblRentalCharges";
            this.lblRentalCharges.Size = new System.Drawing.Size(0, 15);
            this.lblRentalCharges.TabIndex = 0;
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.Location = new System.Drawing.Point(243, 332);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(0, 15);
            this.lblTotalCharges.TabIndex = 0;
            // 
            // JoeAutomotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 490);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.lblRentalCharges);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblPartsCharges);
            this.Controls.Add(this.lblLaborCharges);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblRC);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.lblLC);
            this.Controls.Add(this.txtRentalPrice);
            this.Controls.Add(this.lblRentalPrice);
            this.Controls.Add(this.txtRentalDays);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.chkRental);
            this.Controls.Add(this.txtLabor);
            this.Controls.Add(this.txtParts);
            this.Controls.Add(this.lblLabor);
            this.Controls.Add(this.lblPartsCost);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(492, 537);
            this.MinimumSize = new System.Drawing.Size(492, 537);
            this.Name = "JoeAutomotive";
            this.Text = "Joe\'s Automotive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPartsCost;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.CheckBox chkRental;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtRentalDays;
        private System.Windows.Forms.Label lblRentalPrice;
        private System.Windows.Forms.TextBox txtRentalPrice;
        private System.Windows.Forms.Label lblLC;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblRC;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLaborCharges;
        private System.Windows.Forms.Label lblPartsCharges;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblRentalCharges;
        private System.Windows.Forms.Label lblTotalCharges;
    }
}

