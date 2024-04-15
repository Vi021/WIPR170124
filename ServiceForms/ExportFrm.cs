using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR170124
{
    public partial class ExportFrm : Form
    {
        public ExportFrm()
        {
            InitializeComponent();
        }

        internal string filename = "StudentList";
        internal string filetype = "";

        private void bttn_Export_Click(object sender, EventArgs e)
        {
            if (txtB_Filename.Text.Length > 0)
            {
                erPr_Filename.Clear();
                //if (name format?) { }
                filename = txtB_Filename.Text;
                if (comB_SaveAs.SelectedIndex > -1)
                {
                    int ind = comB_SaveAs.SelectedIndex;
                    if (comB_SaveAs.Items.IndexOf(".xlsx") == ind)
                    {
                        erPr_SaveAs.Clear();
                        filetype = ".xlsx";
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else if (comB_SaveAs.Items.IndexOf(".txt") == ind)
                    {
                        filetype = ".txt";
                        MessageBox.Show("Haven't handled yet..");
                    }
                    else if (comB_SaveAs.Items.IndexOf(".docx") == ind)
                    {
                        filetype = ".docx";
                        MessageBox.Show("Haven't handled yet..");
                    }
                    else if (comB_SaveAs.Items.IndexOf(".pdf") == ind)
                    {
                        filetype = ".pdf";
                        MessageBox.Show("Haven't handled yet..");
                    }
                }
                else
                {
                    erPr_SaveAs.SetError(comB_SaveAs, "Must choose a file type");
                }
            }
            else
            {
                erPr_Filename.SetError(txtB_Filename, "Filename can't be blank");
            }
        }

        private void ExportFrm_Load(object sender, EventArgs e)
        {
            txtB_Filename.Text = filename;
        }
    }
}
