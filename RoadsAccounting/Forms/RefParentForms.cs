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
    public partial class RefParentForms : Form
    {
        protected Boolean isChangedData = false;

        public RefParentForms()
        {
            InitializeComponent();
        }

        protected void writeChangings()
        {
            if (!isChangedData) return;

            if (MessageBox.Show("Вы хотите сохранить изменения?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.updateData();
                this.isChangedData = false;
            }
        }

        virtual internal void updateData() {

        }

        private void RefParentForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.writeChangings();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.writeChangings();
        }
    }
}
