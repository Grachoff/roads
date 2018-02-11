namespace RoadsAccounting.Forms
{
    partial class LineTypes
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.needsqaureDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.linetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadsAccDataSet = new RoadsAccounting.RoadsAccDataSet();
            this.line_typeTableAdapter = new RoadsAccounting.RoadsAccDataSetTableAdapters.line_typeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linetypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsAccDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.linenameDataGridViewTextBoxColumn,
            this.needsqaureDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.linetypeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 378);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // linenameDataGridViewTextBoxColumn
            // 
            this.linenameDataGridViewTextBoxColumn.DataPropertyName = "line_name";
            this.linenameDataGridViewTextBoxColumn.HeaderText = "Тип линии";
            this.linenameDataGridViewTextBoxColumn.Name = "linenameDataGridViewTextBoxColumn";
            this.linenameDataGridViewTextBoxColumn.Width = 400;
            // 
            // needsqaureDataGridViewCheckBoxColumn
            // 
            this.needsqaureDataGridViewCheckBoxColumn.DataPropertyName = "need_sqaure";
            this.needsqaureDataGridViewCheckBoxColumn.HeaderText = "Площадь обязательна";
            this.needsqaureDataGridViewCheckBoxColumn.Name = "needsqaureDataGridViewCheckBoxColumn";
            this.needsqaureDataGridViewCheckBoxColumn.Width = 130;
            // 
            // linetypeBindingSource
            // 
            this.linetypeBindingSource.DataMember = "line_type";
            this.linetypeBindingSource.DataSource = this.roadsAccDataSet;
            this.linetypeBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.linetypeBindingSource_AddingNew);
            // 
            // roadsAccDataSet
            // 
            this.roadsAccDataSet.DataSetName = "RoadsAccDataSet";
            this.roadsAccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // line_typeTableAdapter
            // 
            this.line_typeTableAdapter.ClearBeforeFill = true;
            // 
            // LineTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(694, 403);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LineTypes";
            this.Text = "Типы линий";
            this.Load += new System.EventHandler(this.LineTypes_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linetypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsAccDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RoadsAccDataSet roadsAccDataSet;
        private System.Windows.Forms.BindingSource linetypeBindingSource;
        private RoadsAccDataSetTableAdapters.line_typeTableAdapter line_typeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn needsqaureDataGridViewCheckBoxColumn;
    }
}
