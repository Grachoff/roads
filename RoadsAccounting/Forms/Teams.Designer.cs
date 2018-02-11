namespace RoadsAccounting.Forms
{
    partial class Teams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teams));
            this.TeamsGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadsAccDataSet = new RoadsAccounting.RoadsAccDataSet();
            this.teamTableAdapter = new RoadsAccounting.RoadsAccDataSetTableAdapters.teamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsAccDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamsGridView
            // 
            this.TeamsGridView.AutoGenerateColumns = false;
            this.TeamsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.teamnameDataGridViewTextBoxColumn});
            this.TeamsGridView.DataSource = this.teamBindingSource;
            this.TeamsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamsGridView.Location = new System.Drawing.Point(0, 0);
            this.TeamsGridView.Name = "TeamsGridView";
            this.TeamsGridView.Size = new System.Drawing.Size(649, 421);
            this.TeamsGridView.TabIndex = 3;
            this.TeamsGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.TeamsGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // teamnameDataGridViewTextBoxColumn
            // 
            this.teamnameDataGridViewTextBoxColumn.DataPropertyName = "team_name";
            this.teamnameDataGridViewTextBoxColumn.HeaderText = "Название бригады";
            this.teamnameDataGridViewTextBoxColumn.Name = "teamnameDataGridViewTextBoxColumn";
            this.teamnameDataGridViewTextBoxColumn.Width = 400;
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "team";
            this.teamBindingSource.DataSource = this.roadsAccDataSet;
            this.teamBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.teamBindingSource_AddingNew);
            // 
            // roadsAccDataSet
            // 
            this.roadsAccDataSet.DataSetName = "RoadsAccDataSet";
            this.roadsAccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 421);
            this.Controls.Add(this.TeamsGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Teams";
            this.Text = "Бригады";
            this.Load += new System.EventHandler(this.Teams_Load);
            this.Controls.SetChildIndex(this.TeamsGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.TeamsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsAccDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TeamsGridView;
        private RoadsAccDataSet roadsAccDataSet;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private RoadsAccDataSetTableAdapters.teamTableAdapter teamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamnameDataGridViewTextBoxColumn;
    }
}