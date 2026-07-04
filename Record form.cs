using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyManagementSystem
{
    public partial class Record_form : Form
    {
        public Record_form()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text File|*.txt";
            saveDialog.Title = "Export Records";
            saveDialog.FileName = "TransactionRecords";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveDialog.FileName))
                {
                    sw.WriteLine("===== PROPERTY MANAGEMENT SYSTEM =====");
                    sw.WriteLine("===== TRANSACTION RECORDS =====");
                    sw.WriteLine("Date: " + DateTime.Now.ToString());
                    sw.WriteLine("=======================================");
                    sw.WriteLine();

                    foreach (DataGridViewRow row in dgvrecords.Rows)
                    {
                        if (row.IsNewRow) continue;
                        sw.WriteLine("Name     : " + row.Cells[0].Value);
                        sw.WriteLine("Type     : " + row.Cells[1].Value);
                        sw.WriteLine("Plot No  : " + row.Cells[2].Value);
                        sw.WriteLine("Size     : " + row.Cells[3].Value);
                        sw.WriteLine("Location : " + row.Cells[4].Value);
                        sw.WriteLine("Price    : " + row.Cells[5].Value);
                        sw.WriteLine("Status   : " + row.Cells[6].Value);
                        sw.WriteLine("---------------------------------------");
                    }
                }
                MessageBox.Show("Records exported successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
