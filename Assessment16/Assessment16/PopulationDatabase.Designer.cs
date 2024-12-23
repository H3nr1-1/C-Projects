namespace Assessment16
{
    partial class PopulationDatabase
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
            this.components = new System.ComponentModel.Container();
            this.dgvPopulation = new System.Windows.Forms.DataGridView();
            this.populationDBDataSet = new Assessment16.PopulationDBDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Assessment16.PopulationDBDataSetTableAdapters.TableTableAdapter();
            this.cityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.btnPopAsc = new System.Windows.Forms.Button();
            this.btnPopDesc = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnTotalPop = new System.Windows.Forms.Button();
            this.btnAvgPop = new System.Windows.Forms.Button();
            this.btnHighestPop = new System.Windows.Forms.Button();
            this.btnLowestPop = new System.Windows.Forms.Button();
            this.txtCityID = new System.Windows.Forms.TextBox();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtCityPopulation = new System.Windows.Forms.TextBox();
            this.lblCityID = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblCityPopulation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopulation
            // 
            this.dgvPopulation.AutoGenerateColumns = false;
            this.dgvPopulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopulation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityIDDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn});
            this.dgvPopulation.DataSource = this.tableBindingSource;
            this.dgvPopulation.Location = new System.Drawing.Point(220, 31);
            this.dgvPopulation.Name = "dgvPopulation";
            this.dgvPopulation.RowHeadersWidth = 51;
            this.dgvPopulation.RowTemplate.Height = 24;
            this.dgvPopulation.Size = new System.Drawing.Size(608, 438);
            this.dgvPopulation.TabIndex = 0;
            // 
            // populationDBDataSet
            // 
            this.populationDBDataSet.DataSetName = "PopulationDBDataSet";
            this.populationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.populationDBDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // cityIDDataGridViewTextBoxColumn
            // 
            this.cityIDDataGridViewTextBoxColumn.DataPropertyName = "City_ID";
            this.cityIDDataGridViewTextBoxColumn.HeaderText = "City_ID";
            this.cityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityIDDataGridViewTextBoxColumn.Name = "cityIDDataGridViewTextBoxColumn";
            this.cityIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(220, 556);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(353, 556);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(486, 556);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(619, 556);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(752, 556);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSortBy.Location = new System.Drawing.Point(77, 31);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(55, 18);
            this.lblSortBy.TabIndex = 99;
            this.lblSortBy.Text = "Sort By:";
            // 
            // btnPopAsc
            // 
            this.btnPopAsc.Location = new System.Drawing.Point(12, 71);
            this.btnPopAsc.Name = "btnPopAsc";
            this.btnPopAsc.Size = new System.Drawing.Size(186, 23);
            this.btnPopAsc.TabIndex = 0;
            this.btnPopAsc.Text = "Population Asc.";
            this.btnPopAsc.UseVisualStyleBackColor = true;
            this.btnPopAsc.Click += new System.EventHandler(this.btnPopAsc_Click);
            // 
            // btnPopDesc
            // 
            this.btnPopDesc.Location = new System.Drawing.Point(13, 133);
            this.btnPopDesc.Name = "btnPopDesc";
            this.btnPopDesc.Size = new System.Drawing.Size(185, 23);
            this.btnPopDesc.TabIndex = 1;
            this.btnPopDesc.Text = "Population Desc.";
            this.btnPopDesc.UseVisualStyleBackColor = true;
            this.btnPopDesc.Click += new System.EventHandler(this.btnPopDesc_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(13, 195);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(185, 23);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnTotalPop
            // 
            this.btnTotalPop.Location = new System.Drawing.Point(13, 257);
            this.btnTotalPop.Name = "btnTotalPop";
            this.btnTotalPop.Size = new System.Drawing.Size(185, 23);
            this.btnTotalPop.TabIndex = 3;
            this.btnTotalPop.Text = "Total Population";
            this.btnTotalPop.UseVisualStyleBackColor = true;
            this.btnTotalPop.Click += new System.EventHandler(this.btnTotalPop_Click);
            // 
            // btnAvgPop
            // 
            this.btnAvgPop.Location = new System.Drawing.Point(13, 319);
            this.btnAvgPop.Name = "btnAvgPop";
            this.btnAvgPop.Size = new System.Drawing.Size(185, 23);
            this.btnAvgPop.TabIndex = 4;
            this.btnAvgPop.Text = "Average Population";
            this.btnAvgPop.UseVisualStyleBackColor = true;
            this.btnAvgPop.Click += new System.EventHandler(this.btnAvgPop_Click);
            // 
            // btnHighestPop
            // 
            this.btnHighestPop.Location = new System.Drawing.Point(13, 381);
            this.btnHighestPop.Name = "btnHighestPop";
            this.btnHighestPop.Size = new System.Drawing.Size(185, 23);
            this.btnHighestPop.TabIndex = 5;
            this.btnHighestPop.Text = "Highest Population";
            this.btnHighestPop.UseVisualStyleBackColor = true;
            this.btnHighestPop.Click += new System.EventHandler(this.btnHighestPop_Click);
            // 
            // btnLowestPop
            // 
            this.btnLowestPop.Location = new System.Drawing.Point(13, 443);
            this.btnLowestPop.Name = "btnLowestPop";
            this.btnLowestPop.Size = new System.Drawing.Size(185, 23);
            this.btnLowestPop.TabIndex = 6;
            this.btnLowestPop.Text = "Lowest Population";
            this.btnLowestPop.UseVisualStyleBackColor = true;
            this.btnLowestPop.Click += new System.EventHandler(this.btnLowestPop_Click);
            // 
            // txtCityID
            // 
            this.txtCityID.Location = new System.Drawing.Point(220, 508);
            this.txtCityID.Name = "txtCityID";
            this.txtCityID.Size = new System.Drawing.Size(150, 22);
            this.txtCityID.TabIndex = 7;
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(448, 508);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(150, 22);
            this.txtCityName.TabIndex = 8;
            // 
            // txtCityPopulation
            // 
            this.txtCityPopulation.Location = new System.Drawing.Point(676, 508);
            this.txtCityPopulation.Name = "txtCityPopulation";
            this.txtCityPopulation.Size = new System.Drawing.Size(150, 22);
            this.txtCityPopulation.TabIndex = 9;
            // 
            // lblCityID
            // 
            this.lblCityID.AutoSize = true;
            this.lblCityID.Location = new System.Drawing.Point(217, 489);
            this.lblCityID.Name = "lblCityID";
            this.lblCityID.Size = new System.Drawing.Size(45, 16);
            this.lblCityID.TabIndex = 99;
            this.lblCityID.Text = "City ID";
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(448, 488);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(69, 16);
            this.lblCityName.TabIndex = 99;
            this.lblCityName.Text = "City Name";
            // 
            // lblCityPopulation
            // 
            this.lblCityPopulation.AutoSize = true;
            this.lblCityPopulation.Location = new System.Drawing.Point(676, 488);
            this.lblCityPopulation.Name = "lblCityPopulation";
            this.lblCityPopulation.Size = new System.Drawing.Size(96, 16);
            this.lblCityPopulation.TabIndex = 99;
            this.lblCityPopulation.Text = "City Population";
            // 
            // PopulationDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 628);
            this.Controls.Add(this.lblCityPopulation);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.lblCityID);
            this.Controls.Add(this.txtCityPopulation);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.txtCityID);
            this.Controls.Add(this.btnLowestPop);
            this.Controls.Add(this.btnHighestPop);
            this.Controls.Add(this.btnAvgPop);
            this.Controls.Add(this.btnTotalPop);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnPopDesc);
            this.Controls.Add(this.btnPopAsc);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPopulation);
            this.MaximumSize = new System.Drawing.Size(900, 675);
            this.MinimumSize = new System.Drawing.Size(900, 675);
            this.Name = "PopulationDatabase";
            this.Text = "Population Database";
            this.Load += new System.EventHandler(this.PopulationDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopulation;
        private PopulationDBDataSet populationDBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private PopulationDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.Button btnPopAsc;
        private System.Windows.Forms.Button btnPopDesc;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnTotalPop;
        private System.Windows.Forms.Button btnAvgPop;
        private System.Windows.Forms.Button btnHighestPop;
        private System.Windows.Forms.Button btnLowestPop;
        private System.Windows.Forms.TextBox txtCityID;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtCityPopulation;
        private System.Windows.Forms.Label lblCityID;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblCityPopulation;
    }
}

