namespace RoadsAccounting
{
    partial class Roads
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roads));
            this.RoadsGridView = new System.Windows.Forms.DataGridView();
            this.roadnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadsAccDataSet = new RoadsAccounting.RoadsAccDataSet();
            this.roadTableAdapter = new RoadsAccounting.RoadsAccDataSetTableAdapters.roadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RoadsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsAccDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // RoadsGridView
            // 
            this.RoadsGridView.AutoGenerateColumns = false;
            this.RoadsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoadsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roadnameDataGridViewTextBoxColumn});
            this.RoadsGridView.DataSource = this.roadBindingSource;
            this.RoadsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoadsGridView.Location = new System.Drawing.Point(0, 25);
            this.RoadsGridView.MultiSelect = false;
            this.RoadsGridView.Name = "RoadsGridView";
            this.RoadsGridView.Size = new System.Drawing.Size(539, 294);
            this.RoadsGridView.TabIndex = 0;
            this.RoadsGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoadsGridView_CellValueChanged);
            this.RoadsGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.RoadsGridView_UserDeletedRow);
            // 
            // roadnameDataGridViewTextBoxColumn
            // 
            this.roadnameDataGridViewTextBoxColumn.DataPropertyName = "road_name";
            this.roadnameDataGridViewTextBoxColumn.HeaderText = "Название дороги";
            this.roadnameDataGridViewTextBoxColumn.Name = "roadnameDataGridViewTextBoxColumn";
            this.roadnameDataGridViewTextBoxColumn.Width = 400;
            // 
            // roadBindingSource
            // 
            this.roadBindingSource.DataMember = "road";
            this.roadBindingSource.DataSource = this.roadsAccDataSet;
            this.roadBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.roadBindingSource_AddingNew);
            // 
            // roadsAccDataSet
            // 
            this.roadsAccDataSet.DataSetName = "RoadsAccDataSet";
            this.roadsAccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roadTableAdapter
            // 
            this.roadTableAdapter.ClearBeforeFill = true;
            // 
            // Roads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 319);
            this.Controls.Add(this.RoadsGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Roads";
            this.Text = "Дороги";
            this.Load += new System.EventHandler(this.Roads_Load);
            this.Controls.SetChildIndex(this.RoadsGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RoadsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsAccDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RoadsGridView;
        private RoadsAccDataSet roadsAccDataSet;
        private System.Windows.Forms.BindingSource roadBindingSource;
        private RoadsAccDataSetTableAdapters.roadTableAdapter roadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadnameDataGridViewTextBoxColumn;
    }
}