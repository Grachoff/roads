using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoadsAccounting.Forms
{
    public partial class Org : RoadsAccounting.Forms.RefParentForms
    {
        public Org()
        {
            InitializeComponent();
        }

        private void Org_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roadsAccDataSet.org". При необходимости она может быть перемещена или удалена.
            this.orgTableAdapter.Fill(this.roadsAccDataSet.org);
            this.isChangedData = false;
        }

        override internal void updateData()
        {
            this.orgTableAdapter.Update(this.roadsAccDataSet);
        }

        private void orgBindingSource_AddingNew(object sender, AddingNewEventArgs e)
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
