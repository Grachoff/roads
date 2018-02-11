using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadsAccounting.Forms
{
    public partial class Teams : RefParentForms
    {
        override internal void updateData()
        {
            this.teamTableAdapter.Update(this.roadsAccDataSet);
        }

        public Teams()
        {
            InitializeComponent();
        }

        private void Teams_Load(object sender, EventArgs e)
        {
            this.teamTableAdapter.Fill(this.roadsAccDataSet.team);
            this.isChangedData = false;
        }

        private void teamBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.isChangedData = true;
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.isChangedData = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.isChangedData = true;
        }
    }
}
