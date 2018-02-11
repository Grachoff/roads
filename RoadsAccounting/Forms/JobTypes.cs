using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoadsAccounting
{
    public partial class JobTypes : RoadsAccounting.Forms.RefParentForms
    {
        public JobTypes()
        {
            InitializeComponent();
        }

        private void JobTypes_Load(object sender, EventArgs e)
        {
            this.job_typeTableAdapter.Fill(this.roadsAccDataSet.job_type);
            this.isChangedData = false;
        }

        override internal void updateData()
        {
            this.job_typeTableAdapter.Update(this.roadsAccDataSet);
        }

        private void jobtypeBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.isChangedData = true;
        }

        private void JobTypeGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.isChangedData = true;
        }

        private void JobTypeGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.isChangedData = true;
        }
    }
}
