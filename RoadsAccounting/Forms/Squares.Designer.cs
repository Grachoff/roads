namespace RoadsAccounting.Forms
{
    partial class Squares
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
            this.figuresquareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.figure_squareTableAdapter = new RoadsAccounting.RoadsAccDataSetTableAdapters.figure_squareTableAdapter();
            this.linetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.line_typeTableAdapter = new RoadsAccounting.RoadsAccDataSetTableAdapters.line_typeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linetypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.squareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsAccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.figuresquareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linetypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.linetypeidDataGridViewTextBoxColumn,
            this.squareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.figuresquareBindingSource;
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
            // figuresquareBindingSource
            // 
            this.figuresquareBindingSource.DataMember = "figure_square";
            this.figuresquareBindingSource.DataSource = this.roadsAccDataSet;
            this.figuresquareBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.figuresquareBindingSource_AddingNew);
            // 
            // figure_squareTableAdapter
            // 
            this.figure_squareTableAdapter.ClearBeforeFill = true;
            // 
            // linetypeBindingSource
            // 
            this.linetypeBindingSource.DataMember = "line_type";
            this.linetypeBindingSource.DataSource = this.roadsAccDataSet;
            // 
            // line_typeTableAdapter
            // 
            this.line_typeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // linetypeidDataGridViewTextBoxColumn
            // 
            this.linetypeidDataGridViewTextBoxColumn.DataPropertyName = "line_type_id";
            this.linetypeidDataGridViewTextBoxColumn.DataSource = this.linetypeBindingSource;
            this.linetypeidDataGridViewTextBoxColumn.DisplayMember = "line_name";
            this.linetypeidDataGridViewTextBoxColumn.HeaderText = "Тип линии";
            this.linetypeidDataGridViewTextBoxColumn.Name = "linetypeidDataGridViewTextBoxColumn";
            this.linetypeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.linetypeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.linetypeidDataGridViewTextBoxColumn.ValueMember = "id";
            this.linetypeidDataGridViewTextBoxColumn.Width = 200;
            // 
            // squareDataGridViewTextBoxColumn
            // 
            this.squareDataGridViewTextBoxColumn.DataPropertyName = "square";
            this.squareDataGridViewTextBoxColumn.HeaderText = "Площадь фигуры";
            this.squareDataGridViewTextBoxColumn.Name = "squareDataGridViewTextBoxColumn";
            this.squareDataGridViewTextBoxColumn.Width = 150;
            // 
            // Squares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(694, 403);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Squares";
            this.Text = "Площадь фигур";
            this.Load += new System.EventHandler(this.Squares_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsAccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.figuresquareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linetypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RoadsAccDataSet roadsAccDataSet;
        private System.Windows.Forms.BindingSource figuresquareBindingSource;
        private RoadsAccDataSetTableAdapters.figure_squareTableAdapter figure_squareTableAdapter;
        private System.Windows.Forms.BindingSource linetypeBindingSource;
        private RoadsAccDataSetTableAdapters.line_typeTableAdapter line_typeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn linetypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn squareDataGridViewTextBoxColumn;
    }
}
