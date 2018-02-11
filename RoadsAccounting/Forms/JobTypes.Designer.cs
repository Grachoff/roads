namespace RoadsAccounting
{
    partial class JobTypes
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.JobTypeGridView = new System.Windows.Forms.DataGridView();
            this.jobtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadsAccDataSet = new RoadsAccounting.RoadsAccDataSet();
            this.job_typeTableAdapter = new RoadsAccounting.RoadsAccDataSetTableAdapters.job_typeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.JobTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsAccDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // JobTypeGridView
            // 
            this.JobTypeGridView.AutoGenerateColumns = false;
            this.JobTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobTypeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.type_name});
            this.JobTypeGridView.DataSource = this.jobtypeBindingSource;
            this.JobTypeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobTypeGridView.Location = new System.Drawing.Point(0, 25);
            this.JobTypeGridView.Name = "JobTypeGridView";
            this.JobTypeGridView.Size = new System.Drawing.Size(727, 373);
            this.JobTypeGridView.TabIndex = 3;
            this.JobTypeGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobTypeGridView_CellValueChanged);
            this.JobTypeGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.JobTypeGridView_UserDeletedRow);
            // 
            // jobtypeBindingSource
            // 
            this.jobtypeBindingSource.DataMember = "job_type";
            this.jobtypeBindingSource.DataSource = this.roadsAccDataSet;
            this.jobtypeBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.jobtypeBindingSource_AddingNew);
            // 
            // roadsAccDataSet
            // 
            this.roadsAccDataSet.DataSetName = "RoadsAccDataSet";
            this.roadsAccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // job_typeTableAdapter
            // 
            this.job_typeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // type_name
            // 
            this.type_name.DataPropertyName = "type_name";
            this.type_name.HeaderText = "Тип задачи";
            this.type_name.Name = "type_name";
            this.type_name.Width = 400;
            // 
            // JobTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(727, 398);
            this.Controls.Add(this.JobTypeGridView);
            this.Name = "JobTypes";
            this.Text = "Типы задач";
            this.Load += new System.EventHandler(this.JobTypes_Load);
            this.Controls.SetChildIndex(this.JobTypeGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.JobTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsAccDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView JobTypeGridView;
        private RoadsAccDataSet roadsAccDataSet;
        private System.Windows.Forms.BindingSource jobtypeBindingSource;
        private RoadsAccDataSetTableAdapters.job_typeTableAdapter job_typeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_name;
    }
}
