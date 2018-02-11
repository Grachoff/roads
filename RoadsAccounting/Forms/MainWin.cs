using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoadsAccounting.Forms;

namespace RoadsAccounting
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }



        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox childForm = new AboutBox();
            //childForm.MdiParent = this;
            childForm.Show();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roadsAccDataSet.road". При необходимости она может быть перемещена или удалена.
            this.roadTableAdapter.Fill(this.roadsAccDataSet.road);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roadsAccDataSet.team". При необходимости она может быть перемещена или удалена.
            this.teamTableAdapter.Fill(this.roadsAccDataSet.team);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roadsAccDataSet.job_type". При необходимости она может быть перемещена или удалена.
            this.job_typeTableAdapter.Fill(this.roadsAccDataSet.job_type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roadsAccDataSet.org". При необходимости она может быть перемещена или удалена.
            this.orgTableAdapter.Fill(this.roadsAccDataSet.org);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roadsAccDataSet.job". При необходимости она может быть перемещена или удалена.
            this.jobTableAdapter.Fill(this.roadsAccDataSet.job);

        }


        private void дорогиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roads roads = new Roads();
            //roads.MdiParent = this;
            roads.Show();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void бригадыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teams teams = new Teams();
            //teams.MdiParent = this;
            teams.Show();
        }

        private void MainWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы уверены, что хотите закрыть программу?", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.Yes;
        }

        private void типыЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobTypes jobTypes = new JobTypes();
            jobTypes.Show();
        }

        private void организацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Org org = new Org();
            org.Show();
        }

        private void типыЛинийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineTypes lineTypes = new LineTypes();
            lineTypes.Show();
        }

        private void толщинаЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineWidth lineWidth = new LineWidth();
            lineWidth.Show();
        }

        private void площадиФигурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Squares squares = new Squares();
            squares.Show();
        }
    }
}
