using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WIPR170124.CONTACTs_GRORPs;
using WIPR170124.COURSEs;
using WIPR170124.GRADEs;
using WIPR170124.ServiceForms;

namespace WIPR170124
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool Admin = false;

        public bool setAdState
        {
            set { this.Admin = value; }
        }

        private string _email = "";

        public string email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tlTp_1.SetToolTip(mnStrp_1, "Utilities");

            accounToolStripMenuItem.Text = "Users";
            requestsToolStripMenuItem.Enabled = false;
            requestsToolStripMenuItem.Visible = false;

            dGV_Accounts.Enabled = false;
            dGV_Accounts.Visible = false;

            bttn_Done.Enabled = false;
            bttn_Done.Visible = false;

            if (!Admin)
            {
                mnStrp_1.Items.RemoveAt(5);
                mnStrp_1.Items.RemoveAt(4);
                mnStrp_1.Items.RemoveAt(3);
            }
            else
            {
                mnStrp_1.Items.RemoveAt(4);
            }

            /**/
        }


        // STUDENT Add
        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuAddFrm addStuFrm = new StuAddFrm();
            addStuFrm.ShowDialog();

            //this.Close();
        }

        // STUDENT List
        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*StudentList stuListFrm = new StudentList();
            stuListFrm.ShowDialog();*/

            new StudentListFrmV2().ShowDialog();

            //this.Close();
        }

        // STUDENT Edit/ Remove
        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuModifyInfo modifyStudentInfo = new StuModifyInfo();
            modifyStudentInfo.ShowDialog();

        }

        //STUDENT Manage
        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuManageFrm manageStudentFrm = new StuManageFrm();
            manageStudentFrm.ShowDialog();
        }

        // STUDENT Statistics: Birth month
        private void birthMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STUDENTs.StuStatisticFrm sSFrm = new STUDENTs.StuStatisticFrm();
            STUDENT student = new STUDENT();

            string getStr = "SELECT BDate FROM QLSVDB";
            using (SqlCommand cmd = new SqlCommand(getStr))
            {
                DataTable dT = student.GetStudents(cmd);

                // Set the chart title
                sSFrm.chrt_1.Titles.Add("Birth Month Distribution");

                // Add a series to the chart
                Series series = new Series("Birth Months");
                sSFrm.chrt_1.Series.Add(series);

                // Set the chart type to Column
                series.ChartType = SeriesChartType.Column;
                series.Palette = ChartColorPalette.SeaGreen;

                // Bind data to the chart
                Dictionary<int, int> monthFrequency = new Dictionary<int, int>();
                foreach (DataRow row in dT.Rows)
                {
                    DateTime birthdate = (DateTime)row["BDate"];

                    // Extract the month from the birthdate
                    int month = birthdate.Month;

                    // Increment the frequency count for each birth month
                    if (monthFrequency.ContainsKey(month))
                    {
                        monthFrequency[month]++;
                    }
                    else
                    {
                        monthFrequency[month] = 1;
                    }
                }

                // Add data points to the series
                for (int month = 1; month <= 12; month++)
                {
                    int count = monthFrequency.ContainsKey(month) ? monthFrequency[month] : 0;
                    series.Points.AddXY(month.ToString(), count);
                }

                // Add the chart control to your WinForms form
                //sSFrm.chrt_1.Dock = DockStyle.Fill;
                //this.Controls.Add(sSFrm.chrt_1);

                sSFrm.ShowDialog();
            }
        }

        // STUDENT Statistics: Gender
        private void genderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STUDENTs.StuStatisticFrm sSFrm = new STUDENTs.StuStatisticFrm();
            STUDENT student = new STUDENT();

            string getStr = "SELECT Gender FROM QLSVDB";
            using (SqlCommand cmd = new SqlCommand(getStr))
            {
                DataTable dT = student.GetStudents(cmd);

                sSFrm.chrt_1.Titles.Add("Gender Distribution");

                Series series = new Series("Gender");
                sSFrm.chrt_1.Series.Add(series);

                // Set the chart type to Pie
                series.ChartType = SeriesChartType.Pie;
                series.Palette = ChartColorPalette.BrightPastel;

                // Bind data to the chart
                int maleCount = 0, femaleCount = 0, otherCount = 0;
                foreach (DataRow row in dT.Rows)
                {
                    string gender = row["Gender"].ToString().Trim();

                    // Increment the count based on gender
                    if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                    {
                        maleCount++;
                    }
                    else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                    {
                        femaleCount++;
                    }
                    else
                    {
                        otherCount++;
                    }
                }

                // Add data points to the series
                if (maleCount > 0) series.Points.AddXY("Male", maleCount);
                if (femaleCount > 0) series.Points.AddXY("Female", femaleCount);
                if (otherCount > 0) series.Points.AddXY("Others", otherCount);

                /*// Hide labels that have a count of 0
                foreach (DataPoint dataPoint in series.Points)
                {
                    if (dataPoint.YValues[0] == 0)
                    {
                        dataPoint.IsValueShownAsLabel = false;      // not working
                    }
                }
*/
                // Customize appearance
                /*series["PieLabelStyle"] = "Outside";
                series["PieLineColor"] = "Black";*/

                sSFrm.ShowDialog();
            }
        }

        // STUDENT Print
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StuPrintFrm().ShowDialog();
        }


        // COURSE Add
        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cou_AddFrm cAFrm = new Cou_AddFrm();
            cAFrm.ShowDialog();
        }

        // COURSE Remove
        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cou_EditFrm cEFrm = new Cou_EditFrm();
            cEFrm.ShowDialog();
        }

        //COURSE Edit
        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cou_RemoveFrm cRFrm = new Cou_RemoveFrm();
            cRFrm.ShowDialog();
        }

        // COURSE Manage
        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cou_ManageFrm cMFrm = new Cou_ManageFrm();
            cMFrm.ShowDialog();
        }

        // COURSE Print
        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cou_PrintFrm cPFrm = new Cou_PrintFrm();
            cPFrm.ShowDialog();
        }


        // SCORE Add
        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gra_AddFrm gAFrm = new Gra_AddFrm();
            gAFrm.ShowDialog();
        }

        // SCORE Remove
        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gra_RemoveFrm gRFrm = new Gra_RemoveFrm();
            gRFrm.ShowDialog();
        }

        // SCORE Manage: By courses
        private void byCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gra_ManageFrm gMFrm = new Gra_ManageFrm();

            gMFrm.mode = 0;
            gMFrm.ShowDialog();
        }
        // SCORE Manage: By students
        private void byStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gra_ManageFrm gMFrm = new Gra_ManageFrm();

            gMFrm.mode = 1;
            gMFrm.ShowDialog();
        }

        // SCORE Average
        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gra_AverageFrm gAFrm = new Gra_AverageFrm();
            gAFrm.ShowDialog();
        }

        // SCORE Print
        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //TODO
        }

        // SCORE Result: Score Average Result
        private void scoreAverageResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gra_GraAvgResultFrm gGARF = new Gra_GraAvgResultFrm();
            gGARF.ShowDialog();
        }

        // SCORE Result: Statistic Result
        private void statisticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gra_StatisticResultFrm gSRF = new Gra_StatisticResultFrm();
            gSRF.ShowDialog();
        }


        // ADMIN Enabled
        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV_Accounts.Enabled = false;
            dGV_Accounts.Visible = false;

            bttn_Done.Enabled = false;
            bttn_Done.Visible = false;

            if (!Admin)
            {
                mnStrp_1.Items.RemoveAt(4);
            }
        }

        // ADMIN Accounts/Users
        private void accounToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV_Accounts.Enabled = true;
            dGV_Accounts.Visible = true;
            dGV_Accounts.DataSource = null;
            dGV_Accounts.Columns.Clear();
            dGV_Accounts.ReadOnly = true;

            try
            {
                // Mail account
                /*ACCOUNT acc = new ACCOUNT();
                MyDB myDB = new MyDB();

                using (SqlConnection conn = myDB.Connection)
                {
                    string getStr = "SELECT Email, Active, Admin, Request FROM MailAccounts";
                    using (SqlCommand cmd = new SqlCommand(getStr, conn))
                    {
                        dGV_Accounts.DataSource = acc.GetAccounts(cmd);

                        DataGridViewTextBoxColumn tBCol = new DataGridViewTextBoxColumn();
                        tBCol.Name = "Request for";

                        dGV_Accounts.Columns.Add(tBCol);
                        dGV_Accounts.Columns["Request"].Visible = false;

                        int count = dGV_Accounts.RowCount;
                        for (int i = 0; i < count; i++)
                        {
                            int request = (int)dGV_Accounts.Rows[i].Cells["Request"].Value;
                            switch (request)
                            {
                                case 1:
                                    dGV_Accounts.Rows[i].Cells["Request for"].Value = "Account activation";
                                    break;
                                case 2:
                                    dGV_Accounts.Rows[i].Cells["Request for"].Value = "Administration";
                                    break;
                                case -1:
                                    dGV_Accounts.Rows[i].Cells["Request for"].Value = "Account deactivation";
                                    break;
                                case -2:
                                    dGV_Accounts.Rows[i].Cells["Request for"].Value = "Account deletion";
                                    break;
                                default:
                                    dGV_Accounts.Rows[i].Cells["Request for"].Value = "None";
                                    break;
                            }
                        }
                    }
                }*/

                // User (Student, HR)
                using (SqlConnection conn = new MyDB().Connection)
                {
                    string getStr = "SELECT ID, [username] as Username, type as Type, active as Active, request as req FROM [users]";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn))
                    {
                        DataTable dT = new DataTable();

                        int rows_added = adapter.Fill(dT);

                        dGV_Accounts.DataSource = null;
                        dGV_Accounts.Columns.Clear();

                        if (rows_added <= 0)
                        {
                            return;
                        }

                        dGV_Accounts.DataSource = dT;
                        dGV_Accounts.Columns["req"].Visible = false;

                        DataGridViewTextBoxColumn tBCol = new DataGridViewTextBoxColumn();
                        tBCol.Name = "Request";

                        dGV_Accounts.Columns.Add(tBCol);

                        int count = dGV_Accounts.Rows.Count;
                        for (int i = 0; i < count; i++)
                        {
                            if ((int)dGV_Accounts.Rows[i].Cells["ID"].Value == Program._id)
                            {
                                for (int j = 0; j < dGV_Accounts.Columns.Count; j++)
                                {
                                    dGV_Accounts.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(194, 225, 132);
                                }
                            }

                            bool request = (bool)dGV_Accounts.Rows[i].Cells["req"].Value;
                            if (request)
                            {
                                dGV_Accounts.Rows[i].Cells["Request"].Value = "Account activation";
                                dGV_Accounts.Rows[i].Cells["Request"].Style.Font = new System.Drawing.Font(dGV_Accounts.Font, System.Drawing.FontStyle.Bold);
                            }
                            else
                            {
                                dGV_Accounts.Rows[i].Cells["Request"].Value = "None";
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ADMIN Manage Accounts/Users
        private void dGV_Accounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dGV_Accounts.DataSource != null && dGV_Accounts.Columns != null)
            {

                // Accounts
                /*ModifyAccounts modAccFrm = new ModifyAccounts();

                //Email
                modAccFrm.lbl_Email.Text = "Email: " + dGV_Accounts.CurrentRow.Cells["Email"].Value.ToString().Trim();
                modAccFrm.email = dGV_Accounts.CurrentRow.Cells["Email"].Value.ToString();
                //Active
                if (dGV_Accounts.CurrentRow.Cells["Active"].Value.ToString().Contains("True"))
                {
                    modAccFrm.chkB_ActYes.Checked = true;
                }
                else
                {
                    modAccFrm.chkB_ActYes.Checked = false;
                    modAccFrm.chkB_AdmYes.Enabled = false;
                }
                //Admin
                if (dGV_Accounts.CurrentRow.Cells["Admin"].Value.ToString().Contains("True"))
                {

                    modAccFrm.chkB_AdmYes.Checked = true;
                }
                else
                {
                    modAccFrm.chkB_AdmYes.Checked = false;
                }
                //Request
                modAccFrm.lbl_Request.Text = "Request:   " + dGV_Accounts.CurrentRow.Cells["Request for"].Value.ToString().Trim();

                modAccFrm.ShowDialog();*/
            
                // Users
                ModifyUsers mu = new ModifyUsers();

                mu.Text = "Modify user: " + dGV_Accounts.CurrentRow.Cells["Username"].Value.ToString();
                mu._id = dGV_Accounts.CurrentRow.Cells["ID"].Value.ToString();
                mu.req = (bool)dGV_Accounts.CurrentRow.Cells["req"].Value;
                mu.lbl_ID.Text = "ID: " + mu._id;
                mu.chkB_ActYes.Checked = (bool)dGV_Accounts.CurrentRow.Cells["Active"].Value;
                mu.lbl_Request.Text = "Request: " + dGV_Accounts.CurrentRow.Cells["Request"].Value.ToString();

                mu.ShowDialog();
                
                if (mu.DialogResult == DialogResult.OK)
                {
                    accounToolStripMenuItem_Click(sender, e);
                }
            }
        }

        // Admin Human Resource
        private void hUMANRESOURCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CG_MainFrm cgMFrm = new CG_MainFrm();
            cgMFrm.ShowDialog();
        }


        // USER Enabled
        private void requestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV_Accounts.Enabled = true;
            dGV_Accounts.Visible = true;
            dGV_Accounts.DataSource = null;
            dGV_Accounts.Columns.Clear();

            //bttn_Done.Enabled = true;
            //bttn_Done.Visible = true;

            try
            {
                MyDB myDB = new MyDB();
                string getStr = "SELECT Email, Request FROM MailAccounts WHERE Request <> 0";
                using (SqlConnection conn = myDB.Connection)
                {
                    using (SqlCommand cmd = new SqlCommand(getStr, conn))
                    {
                        ACCOUNT acc = new ACCOUNT();

                        dGV_Accounts.DataSource = acc.GetAccounts(cmd);
                        DataGridViewTextBoxColumn tBCol = new DataGridViewTextBoxColumn();
                        tBCol.Name = "Request for";

                        DataGridViewCheckBoxColumn cBCol = new DataGridViewCheckBoxColumn();
                        cBCol.Name = "Accept";

                        dGV_Accounts.Columns.Add(tBCol);
                        dGV_Accounts.Columns.Add(cBCol);
                        dGV_Accounts.Columns["Request"].Visible = false;

                        dGV_Accounts.ReadOnly = false;
                        dGV_Accounts.Columns["Email"].ReadOnly = true;
                        dGV_Accounts.Columns["Request for"].ReadOnly = true;
                        dGV_Accounts.Columns["Accept"].ReadOnly = false;

                        int count = dGV_Accounts.RowCount;
                        for (int i = 0; i < count; i++)
                        {
                            int request = (int)dGV_Accounts.Rows[i].Cells["Request"].Value;
                            switch (request)
                            {
                                case 1:
                                    dGV_Accounts.Rows[i].Cells["Request for"].Value = "Account activation";
                                    break;
                                case 2:
                                    dGV_Accounts.Rows[i].Cells["Request for"].Value = "Administration";
                                    break;
                                case -1:
                                    dGV_Accounts.Rows[i].Cells["Request for"].Value = "Account deactivation";
                                    break;
                                case -2:
                                    dGV_Accounts.Rows[i].Cells["Request for"].Value = "Account deletion";
                                    break;
                                default:
                                    dGV_Accounts.Rows[i].Cells["Request for"].Value = "???";
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // USER Request: Administration
        private void requestForAdministrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to be an Admin?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string updateStr = "UPDATE MailAccounts SET Request = 2 WHERE Email = @email";
                MyDB myDB = new MyDB();
                using (SqlConnection conn = myDB.Connection)
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(updateStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", _email);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Request Administration sent!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed sending request!", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        // AMIN/USER Done --- *EXCLUDED
        private void bttn_Done_Click(object sender, EventArgs e)
        {
            /*DialogResult result = result = MessageBox.Show("Are you certain about these change?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (dGV_Accounts.DataSource != null)
                {
                    try
                    {
                        int count = dGV_Accounts.RowCount;
                        string actStr = "UPDATE MailAccount SET Active = @act, Request = 0 WHERE Email = @email";
                        string admStr = "UPDATE MailAccount SET Admin = @adm, Request = 0 WHERE Email = @email";
                        MyDB myDB = new MyDB();
                        ACCOUNT acc = new ACCOUNT();

                        using (SqlConnection conn = myDB.Connection)
                        {
                            SqlCommand cmd = new SqlCommand("", conn);
                            for (int i = 0; i < count; i++)
                            {
                                if (dGV_Accounts.Rows[i].Cells["Accept"].Value != null)
                                {
                                    if (dGV_Accounts.Rows[i].Cells["Accept"].Value.ToString().Contains("True"))
                                    {
                                        int request = (int)dGV_Accounts.Rows[i].Cells["Request"].Value;
                                        switch (request)
                                        {
                                            case 1:
                                                cmd.CommandText = actStr;
                                                cmd.Parameters.AddWithValue("@act", 1);
                                                break;
                                            case 2:
                                                cmd.CommandText = admStr;
                                                cmd.Parameters.AddWithValue("@adm", 1);
                                                break;
                                            case -1:

                                                break;
                                            case -2:

                                                break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/
        }
    }
}


#region TODO
/*
 * better way to handle when logging in as admin, static?
 * 
 * split to 3 branch:
 *         | -> admin
 *    main | -> user -> |
 *         | -> student -> |
 * 
 * request administration for who?
 * 
 */
#endregion