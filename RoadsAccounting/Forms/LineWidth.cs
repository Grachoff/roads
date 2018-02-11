using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoadsAccounting.Forms
{
    public partial class LineWidth : RoadsAccounting.Forms.RefParentForms
    {
        public LineWidth()
        {
            InitializeComponent();
        }

        private void LineWidth_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roadsAccDataSet.line_width". При необходимости она может быть перемещена или удалена.
            this.line_widthTableAdapter.Fill(this.roadsAccDataSet.line_width);
            this.isChangedData = false;
        }

        override internal void updateData()
        {
            this.line_widthTableAdapter.Update(this.roadsAccDataSet);
        }

        private void linewidthBindingSource_AddingNew(object sender, AddingNewEventArgs e)
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
    }
}
