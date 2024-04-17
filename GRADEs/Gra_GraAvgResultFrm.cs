using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WIPR170124.GRADEs
{
    public partial class Gra_GraAvgResultFrm : Form
    {
        public Gra_GraAvgResultFrm()
        {
            InitializeComponent();
        }

        Dictionary<string, string> couList = new Dictionary<string, string>();
        private void addColumns()
        {
            string getStr = "SELECT CID, CName FROM CourseTable";
            SqlConnection conn = new MyDB().Connection;
            SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn);

            DataTable dT = new DataTable();
            adapter.Fill(dT);

            foreach (DataRow r in dT.Rows)
            {
                couList.Add(r[0].ToString().Trim(), r[1].ToString().Trim());
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = r[1].ToString().Trim();
                dGV_Result.Columns.Add(col);
                dGV_Result.Columns[col.Name].DefaultCellStyle.Format = "N2";
            }

            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Result";
            dGV_Result.Columns.Add(column);

            dT.Dispose();
        }

        STUDENT stu = new STUDENT();
        Dictionary<string, List<float>> forCalRes = new Dictionary<string, List<float>>();
        private void Filter(string searchStr = "")
        {
            if (dGV_Result.Columns.Count > 0)
            {
                dGV_Result.Columns.Clear();
            }

            string getStr;
            if (searchStr.Length > 0)
            {
                getStr = searchStr;
            }
            else
            {
                getStr = "SELECT StuID, LName, FName from QLSVDB";
            }

            SqlConnection conn = new MyDB().Connection;
            using (SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn))
            {
                DataTable dT = new DataTable();
                adapter.Fill(dT);

                dGV_Result.DataSource = dT;
                addColumns();

                dT.Dispose();
            }

            dGV_Result.Columns["StuID"].HeaderText = "Student ID";
            dGV_Result.Columns["LName"].HeaderText = "Lastname";
            dGV_Result.Columns["FName"].HeaderText = "Firstname";

            foreach (DataGridViewRow row in dGV_Result.Rows)
            {
                string stuid = row.Cells["StuID"].Value.ToString().Trim();
                if (stu.verifyID(stuid))
                {
                    forCalRes.Add(stuid, new List<float>());

                    getStr = $"SELECT DISTINCT CID FROM Grade WHERE StuID = '{stuid}'";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn))
                    {
                        DataTable dT = new DataTable();
                        adapter.Fill(dT);

                        List<string> cids = new List<string>();
                        foreach (DataRow r in dT.Rows)
                        {
                            string cid = r[0].ToString();
                            string cal = $"SELECT AVG(Grade) as Avg FROM Grade WHERE StuID = '{stuid}' AND CID = '{cid}'";
                            using (SqlCommand cmd = new SqlCommand(cal, conn))
                            {
                                conn.Open();

                                // Execute the command and retrieve the average score
                                object result = cmd.ExecuteScalar();
                                if (result != null && result != DBNull.Value)
                                {
                                    // Convert the result to the appropriate data type
                                    forCalRes[stuid].Add((float)Convert.ToDouble(result));
                                    row.Cells[couList[cid]].Value = (float)Convert.ToDouble(result);
                                }

                                conn.Close();
                            }
                        }
                    }

                    float sum = 0;
                    foreach (float f in forCalRes[stuid])
                    {
                        sum += f;
                    }

                    if (forCalRes[stuid].Count > 0)
                    {
                        if (sum / forCalRes[stuid].Count >= 5)
                        {
                            row.Cells["Result"].Value = "Pass";
                        }
                        else
                        {
                            row.Cells["Result"].Value = "Fail";
                        }
                    }
                }
            }
        }

        private void Gra_GraAvgResultFrm_Load(object sender, EventArgs e)
        {
            Filter();
        }

        private void dGV_Result_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV_Result.Columns.Count > 0)
            {
                txtB_StuID.Text = dGV_Result.CurrentRow.Cells["StuID"].Value.ToString().Trim();
                txtB_LName.Text = dGV_Result.CurrentRow.Cells["LName"].Value.ToString().Trim();
                txtB_FName.Text = dGV_Result.CurrentRow.Cells["FName"].Value.ToString().Trim();
            }
        }

        private void bttn_Search_Click(object sender, EventArgs e)
        {
            string searchStr = "SELECT StuID, LName, FName FROM QLSVDB WHERE CONCAT(StuID,FName) LIKE '%" + txtB_Search.Text + "%'";
            //Filter(searchStr);
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {

        }
    }
}



/* TODO:
 * cant just let it recalculates each time call the Filter func, handle that pls
 * search
 * print
 */