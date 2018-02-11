using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using RoadsAccounting.Forms;

namespace RoadsAccounting
{
    public partial class Roads : RefParentForms
    {

        public Roads()
        {
            InitializeComponent();
        }

        override internal void updateData()
        {
            this.roadTableAdapter.Update(this.roadsAccDataSet);
        }

        private void Roads_Load(object sender, EventArgs e)
        {
            this.roadTableAdapter.Fill(this.roadsAccDataSet.road);
            this.isChangedData = false;
        }

        private void roadBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.isChangedData = true;
        }

        private void RoadsGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.isChangedData = true;
        }

        private void RoadsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.isChangedData = true;
        }

    }
}
