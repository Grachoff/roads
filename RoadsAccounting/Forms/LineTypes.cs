using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoadsAccounting.Forms
{
    public partial class LineTypes : RoadsAccounting.Forms.RefParentForms
    {
        public LineTypes()
        {
            InitializeComponent();
        }

        private void LineTypes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roadsAccDataSet.line_type". При необходимости она может быть перемещена или удалена.
            this.line_typeTableAdapter.Fill(this.roadsAccDataSet.line_type);
            this.isChangedData = false;
        }
        override internal void updateData()
        {
            this.line_typeTableAdapter.Update(this.roadsAccDataSet);
        }

        private void linetypeBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.isChangedData = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.isChangedData = true;
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.isChangedData = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.isChangedData = true;
        }
    }
}
