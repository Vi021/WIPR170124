using Microsoft.Office.Interop.Excel;
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

namespace WIPR170124.ServiceForms
{
    public partial class ImportFrm : Form
    {
        public ImportFrm()
        {
            InitializeComponent();
        }

        private void ImportFrm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(318, 145);
            pnl_1.Visible = false;
            pnl_1.Enabled = false;

            //"./Folder/File.txt" won't work - bc when run is in .../thisprojectname/bin/Debug
            txtB_FilePN.Text = "C:/Users/Admin/OneDrive/Documents/WIPR/WIPR_w2_17-01-2024/Imports/filename.xlsx";
        }

        private void bttn_Check_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtB_FilePN.Text))
            {
                this.Size = pnl_1.Size;
                pnl_1.Visible = true;
                pnl_1.Enabled = true;
                testLbl.Text = "Yes";
            }
            else
            {
                MessageBox.Show("File not found!", "Import", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
