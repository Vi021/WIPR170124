using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WIPR170124.STUDENTs;

namespace WIPR170124
{
    public partial class StuPrintFrm : Form
    {
        public StuPrintFrm()
        {
            InitializeComponent();
        }

        private DataTable fillStudents(string getStr = "SELECT * FROM QLSVDB")
        {
            try
            {
                STUDENT stud = new STUDENT();

                //string getStr = "SELECT * FROM QLSVDB";
                using (SqlCommand cmd = new SqlCommand(getStr))
                {
                    return stud.GetStudents(cmd);
                }
            }
            catch (Exception exc) { MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
        }

        private void load()
        {
            dGV_1.DataSource = null;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dGV_1.RowTemplate.Height = 50;

            dGV_1.DataSource = fillStudents();
            if (dGV_1.DataSource == null) return;

            picCol = (DataGridViewImageColumn)dGV_1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dGV_1.Columns["StuID"].HeaderText = "Student ID";
            //dGV_1.Columns["StudID"].Name = "Student ID";
            dGV_1.Columns["FName"].HeaderText = "Firstname";
            dGV_1.Columns["FName"].Name = "Firstname";
            dGV_1.Columns["LName"].HeaderText = "Lastname";
            dGV_1.Columns["BDate"].HeaderText = "Birthdate";
            dGV_1.Columns["BDate"].Name = "Birthdate";
            dGV_1.Columns["Mugshot"].HeaderText = "Profile";
        }

        private void PrinterFrm_Load(object sender, EventArgs e)
        {
            lbl_From.Visible = false;
            comB_From.Enabled = false;
            comB_From.Visible = false;
            lbl_To.Visible = false;
            comB_To.Enabled = false;
            comB_To.Visible = false;

            cLB_Gender.Enabled = false;
            cLB_Gender.Visible = false;
            bttn_Done.Enabled = false;
            bttn_Done.Visible = false;

            load();
        }

        private void comB_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dGV_1.DataSource = fillStudents();
            if (comB_Filter.SelectedItem == null) { return; }

            if (comB_Filter.SelectedItem.ToString().Contains("Gender"))
            {
                lbl_From.Visible = false;
                comB_From.Enabled = false;
                comB_From.Visible = false;

                lbl_To.Visible = false;
                comB_To.Enabled = false;
                comB_To.Visible = false;

                cLB_Gender.Enabled = true;
                cLB_Gender.Visible = true;
            }
            // else if (comB_Filter.SelectedIndex == 4)
            //{

            //}
            else
            {
                cLB_Gender.Enabled = false;
                cLB_Gender.Visible = false;
                bttn_Done.Enabled = false;
                bttn_Done.Visible = false;

                lbl_From.Visible = true;
                comB_From.Visible = true;
                comB_From.Items.Clear();

                lbl_To.Visible = true;
                comB_To.Visible = true;
                comB_To.Items.Clear();

                string selected = comB_Filter.SelectedItem.ToString();
                if (selected.Contains("Student ID")) selected = "StuID";
                if (dGV_1.Columns.Contains(selected))
                {
                    int rowcount = dGV_1.Rows.Count;
                    if (rowcount > 0)
                    {
                        if (selected.Contains("Birthdate"))
                        {
                            for (int i = 0; i < rowcount; i++)
                            {
                                string date = dGV_1.Rows[i].Cells[selected].Value.ToString().Trim();
                                comB_From.Items.Add(date.Substring(0, date.Length - 9));
                                comB_To.Items.Add(date.Substring(0, date.Length - 9));
                            }
                        }
                        else
                        {
                            for (int i = 0; i < rowcount; i++)
                            {
                                comB_From.Items.Add(dGV_1.Rows[i].Cells[selected].Value.ToString().Trim());
                                comB_To.Items.Add(dGV_1.Rows[i].Cells[selected].Value.ToString().Trim());
                            }
                        }
                        comB_From.Text = "";
                        comB_From.Enabled = true;
                        comB_To.Text = "";
                        comB_To.Enabled = true;
                    }
                }
                else
                {
                    comB_From.Enabled = false;
                    comB_To.Enabled = false;
                }
            }
            bttn_Done.Enabled = true;
            bttn_Done.Visible = true;
        }

        private void FilterDataGridView(string selected)
        {
            // Get the selected items from the ComboBoxes
            string fromName = comB_From.SelectedItem.ToString().Trim();
            string toName = comB_To.SelectedItem.ToString().Trim();

            // Get the DataTable bound to the DataGridView
            DataTable dataTable = dGV_1.DataSource as DataTable;

            // Filter the DataTable to include rows within the specified range of names
            DataTable filteredTable = dataTable.AsEnumerable()
                .Where(row => string.Compare(row[selected].ToString().Trim(), fromName) >= 0
                           && string.Compare(row[selected].ToString().Trim(), toName) <= 0)
                .CopyToDataTable();

            // Bind the filtered DataTable to the DataGridView
            dGV_1.DataSource = filteredTable;
        }

        private DataTable _FilteredDT = null;
        private void bttn_Done_Click(object sender, EventArgs e)
        {
            try
            {
                if (comB_Filter.SelectedItem.ToString().Contains("Gender"))
                {
                    List<string> selectedGenders = new List<string>();

                    if (cLB_Gender.CheckedItems.Count == 0)
                    {
                        load();
                        return;
                    }

                    foreach (var item in cLB_Gender.CheckedItems)
                    {
                        selectedGenders.Add(item.ToString());
                    }

                    DataTable dT = dGV_1.DataSource as DataTable;
                    if (dT == null) return;

                    DataTable filteredTable = dT.AsEnumerable()
                        .Where(row => selectedGenders.Contains(row["Gender"].ToString().Trim())).CopyToDataTable();

                    /*foreach (DataRow dR in dT.Rows)
                    {
                        string gender = dR["Gender"].ToString().Trim();
                        if (!selectedGenders.Contains(gender))
                        {
                            dR.Delete();        // can cause row error in PrinterFrm
                        }
                    }*/

                    dGV_1.DataSource = filteredTable;
                }
                else
                {
                    string selected = comB_Filter.SelectedItem.ToString();
                    dGV_1.DataSource = fillStudents();
                    if (selected.Contains("Student ID")) selected = "StuID";
                    else if (selected.Contains("Firstname")) selected = "FName";
                    FilterDataGridView(selected);
                }

                _FilteredDT = dGV_1.DataSource as DataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Student List Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            PrinterFrm pFrm = new PrinterFrm();
            pFrm._SourceDT = _FilteredDT;
            pFrm._rdlc = "STUDENTs.StuClassReport";
            pFrm._getStr = "SELECT * FROM QLSVDB";
            pFrm._DSName = "dS_StudentList";
            pFrm._DTName = "Student List";
            pFrm.ShowDialog();
            pFrm.Dispose();
        }
    }
}



/* PROBLEMS
 * Filter combine gender & stuID still bug -> print error in rows
 * case where fromName > toName, handle? - nah
 * 
 */