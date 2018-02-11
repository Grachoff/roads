using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoadsAccounting.Forms
{
    public partial class Squares : RoadsAccounting.Forms.RefParentForms
    {
        public Squares()
        {
            InitializeComponent();
        }

        private void Squares_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roadsAccDataSet.line_type". При необходимости она может быть перемещена или удалена.
            this.line_typeTableAdapter.Fill(this.roadsAccDataSet.line_type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roadsAccDataSet.figure_square". При необходимости она может быть перемещена или удалена.
            this.figure_squareTableAdapter.Fill(this.roadsAccDataSet.figure_square);
            this.isChangedData = false;
        }

        override internal void updateData()
        {
            this.figure_squareTableAdapter.Update(this.roadsAccDataSet);
        }

        private void figuresquareBindingSource_AddingNew(object sender, AddingNewEventArgs e)
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
