using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyManagementSystem
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Form1)
                {
                    child.BringToFront();
                    return;
                }
            }

            Form1 f = new Form1();
            f.MdiParent = this;
            f.Text = "Buy a House";
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Text = "Buy a Plot";
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Sell_Propert_form f = new Sell_Propert_form();
            f.MdiParent = this;
            f.Text = "Sell a House";
            f.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Sell_Propert_form f = new Sell_Propert_form();
            f.MdiParent = this;
            f.Text = "Sell a Plot";
            f.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Record_form)
                {
                    child.BringToFront();
                    return;
                }
            }
            Record_form f = new Record_form();
            f.MdiParent = this;
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
