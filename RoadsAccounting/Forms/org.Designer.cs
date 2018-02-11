namespace RoadsAccounting.Forms
{
    partial class Org
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roadsAccDataSet = new RoadsAccounting.RoadsAccDataSet();
            this.orgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orgTableAdapter = new RoadsAccounting.RoadsAccDataSetTableAdapters.orgTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsAccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orgnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orgBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 378);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // roadsAccDataSet
            // 
            this.roadsAccDataSet.DataSetName = "RoadsAccDataSet";
            this.roadsAccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orgBindingSource
            // 
            this.orgBindingSource.DataMember = "org";
            this.orgBindingSource.DataSource = this.roadsAccDataSet;
            this.orgBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.orgBindingSource_AddingNew);
            // 
            // orgTableAdapter
            // 
            this.orgTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // orgnameDataGridViewTextBoxColumn
            // 
            this.orgnameDataGridViewTextBoxColumn.DataPropertyName = "org_name";
            this.orgnameDataGridViewTextBoxColumn.HeaderText = "Название организации";
            this.orgnameDataGridViewTextBoxColumn.Name = "orgnameDataGridViewTextBoxColumn";
            this.orgnameDataGridViewTextBoxColumn.Width = 400;
            // 
            // Org
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(694, 403);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Org";
            this.Text = "Организации";
            this.Load += new System.EventHandler(this.Org_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsAccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RoadsAccDataSet roadsAccDataSet;
        private System.Windows.Forms.BindingSource orgBindingSource;
        private RoadsAccDataSetTableAdapters.orgTableAdapter orgTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgnameDataGridViewTextBoxColumn;
    }
}
