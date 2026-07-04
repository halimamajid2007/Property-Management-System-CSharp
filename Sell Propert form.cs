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
    public partial class Sell_Propert_form : Form
    {
        public Sell_Propert_form()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deal finalized successfully!", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
