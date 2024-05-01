//using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WIPR170124.STUDENTs;

namespace WIPR170124.GRADEs
{
    public partial class Gra_GraAvgResultFrm : Form
    {
        internal DataTable baseTable = new DataTable("Average Score Result");

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

                /*DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = r[1].ToString().Trim();
                dGV_Result.Columns.Add(col);
                dGV_Result.Columns[col.Name].DefaultCellStyle.Format = "N2";*/

                DataColumn col2 = new DataColumn();
                col2.ColumnName = r[1].ToString().Trim();
                baseTable.Columns.Add(col2);
            }

            /*DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Result";
            dGV_Result.Columns.Add(column);*/


            baseTable.Columns.Add(new DataColumn("Average Score"));
            baseTable.Columns.Add(new DataColumn("Result"));

            dT.Dispose();
        }

        STUDENT stu = new STUDENT();
        Dictionary<string, List<float>> forCalRes = new Dictionary<string, List<float>>();
        internal void Filler()
        {
            if (dGV_Result.Columns.Count > 0)
            {
                dGV_Result.Columns.Clear();
            }

            string getStr = "SELECT StuID as [Student ID], LName as Lastname, FName as Firstname FROM QLSVDB";

            SqlConnection conn = new MyDB().Connection;
            using (SqlDataAdapter adpt = new SqlDataAdapter(getStr, conn))
            {
                adpt.Fill(baseTable);
                addColumns();
            }

            foreach (DataRow row in baseTable.Rows)
            {
                string stuid = row["Student ID"].ToString().Trim();
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
                                    float score = (float)Convert.ToDouble(result);
                                    forCalRes[stuid].Add(score);
                                    row[couList[cid]] = score;
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
                        double avg = sum / forCalRes[stuid].Count;
                        row["Average Score"] = Math.Round(avg, 2);

                        if (avg >= 9)
                        {
                            row["Result"] = "Excellent";
                        }
                        else if (avg >= 7)
                        {
                            row["Result"] = "Good";
                        }
                        else if (avg >= 5)
                        {
                            row["Result"] = "Average";
                        }
                        else
                        {
                            row["Result"] = "Fail";
                        }
                    }
                }
            }

            dGV_Result.DataSource = baseTable;

            /*using (SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn))
            {
                DataTable dT = new DataTable();
                adapter.Fill(dT);

                dGV_Result.DataSource = dT;
                addColumns();
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
                                    float score = (float)Convert.ToDouble(result);
                                    forCalRes[stuid].Add(score);
                                    row.Cells[couList[cid]].Value = score;
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
                        double avg = sum / forCalRes[stuid].Count;
                        if (avg >= 9)
                        {
                            row.Cells["Result"].Value = "Excellent";
                        }
                        else if (avg >= 7)
                        {
                            row.Cells["Result"].Value = "Good";
                        }
                        else if (avg >= 5)
                        {
                            row.Cells["Result"].Value = "Average";
                        }
                        else
                        {
                            row.Cells["Result"].Value = "Fail";
                        }
                    }
                }
            }*/
        }

        private void Filler2(string searchStr)
        {
            try
            {
                if (dGV_Result.Rows.Count > 0)
                {
                    if (baseTable.AsEnumerable().Any(row => row["StudentID"].ToString().Contains(searchStr) || row["Firstname"].ToString().Contains(searchStr)))
                    {
                        dGV_Result.DataSource = baseTable.AsEnumerable().Where(row => row["StudentID"].ToString().Contains(searchStr) || row["Firstname"].ToString().Contains(searchStr)).CopyToDataTable();
                    }
                    else
                    {
                        MessageBox.Show("No result found", "Average Score Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("There is nothing to search..", "Average Score Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Average Score Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load()
        {
            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();
                    string getStr = "SELECT * FROM ASR";
                    using (SqlDataAdapter adpt = new SqlDataAdapter(getStr, conn))
                    {
                        adpt.Fill(baseTable);
                        dGV_Result.DataSource = baseTable;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Gra_GraAvgResultFrm_Load(object sender, EventArgs e)
        {
            txtB_StuID.Enabled = false;
            txtB_FName.Enabled = false;
            txtB_LName.Enabled = false;

            //Filler();
            load();
            dGV_Result.DefaultCellStyle.Format = "N2";
            dGV_Result.Columns["C01"].HeaderText = "Lap trinh tren Window";
            dGV_Result.Columns["C02"].HeaderText = "Ky thuat lap trinh";
            dGV_Result.Columns["C03"].HeaderText = "Co so du lieu";
            dGV_Result.Columns["C04"].HeaderText = "He dieu hanh";
            dGV_Result.Columns["C05"].HeaderText = "Dai so tuyen tinh";
            dGV_Result.Columns["C06"].HeaderText = "Vat ly 1";
            dGV_Result.Columns["C07"].HeaderText = "The chat 2";
            dGV_Result.Columns["C08"].HeaderText = "Toan 1";
        }

        private void dGV_Result_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dGV_Result.Columns.Count > 0)
                {
                    txtB_StuID.Text = dGV_Result.CurrentRow.Cells["StudentID"].Value.ToString().Trim();
                    txtB_LName.Text = dGV_Result.CurrentRow.Cells["Lastname"].Value.ToString().Trim();
                    txtB_FName.Text = dGV_Result.CurrentRow.Cells["Firstname"].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Average Score Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttn_Search_Click(object sender, EventArgs e)
        {
            string searchStr = txtB_Search.Text;
            if (txtB_Search.Text.Length <= 0)
            {
                dGV_Result.DataSource = baseTable;
            }
            else
            {
                Filler2(searchStr);
            }
        }

        /*bool CheckIfTableExists(string tableName, SqlConnection connection)
        {
            // SQL query to check if the table exists
            string query = "IF OBJECT_ID('" + tableName + "', 'U') IS NOT NULL SELECT 1 ELSE SELECT 0";

            // Execute the query
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                return Convert.ToInt32(command.ExecuteScalar()) == 1;
            }
        }

        void CreateTableFromDataTable(string tableName, DataTable dataTable, SqlConnection connection)
        {
            // SQL query to create table based on DataTable structure
            string createTableQuery = "CREATE TABLE " + tableName + " (";

            // Add columns from DataTable to createTableQuery
            foreach (DataColumn column in dataTable.Columns)
            {
                createTableQuery += column.ColumnName + " VARCHAR(MAX), "; // Adjust data types as needed
            }

            // Remove the trailing comma and space
            createTableQuery = createTableQuery.TrimEnd(',', ' ') + ")";

            // Execute the query to create the table
            using (SqlCommand command = new SqlCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }


        public void toSQlTable()
        {
            // Assuming dataTable is your dynamically changing DataTable
            DataTable dataTable = GetDynamicDataTable(); // Get your dynamic DataTable

            // Connect to your SQL database
            using (SqlConnection connection = new MyDB().Connection)
            {
                connection.Open();

                // Check if the SQL table exists
                bool sqlTableExists = CheckIfTableExists(tableName, connection);

                // If the SQL table does not exist, create it based on the DataTable structure
                if (!sqlTableExists)
                {
                    CreateTableFromDataTable(tableName, dataTable, connection);
                }
                else
                {
                    // Compare the structure of the SQL table with the DataTable
                    CompareTableStructureAndUpdate(tableName, dataTable, connection);
                }

                // Transfer data from the DataTable to the SQL table
                TransferDataToSqlTable(dataTable, tableName, connection);
            }

        }*/

        public DataTable toSqlTable()
        {
            //https://stackoverflow.com/a/13624935

            SqlConnection con = new MyDB().Connection;

            con.Open();

            string sql = "CREATE TABLE [ASR] (";
            foreach (DataColumn column in baseTable.Columns)
            {
                sql += "[" + column.ColumnName + "] " + "nvarchar(50)" + ",";
            }
            sql = sql.TrimEnd(new char[] { ',' }) + ")";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cmd.ExecuteNonQuery();

            DataTable dT = new DataTable();
            using (var adapter = new SqlDataAdapter("SELECT * FROM [ASR]", con))
            using (var builder = new SqlCommandBuilder(adapter))
            {
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.Update(dT);
                // adapter.Update(ds.Tables[0]); (Incase u have a data-set)
            }
            con.Close();

            return dT;
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {
            /*DataSet dS = new DataSet();
            dS.DataSetName = "dS_ASR";
            dS.Tables.Add(dGV_Result.DataSource as DataTable);*/

            PrinterFrm printer = new PrinterFrm();
            printer._SourceDT = dGV_Result.DataSource as DataTable;
            printer._DSName = "dS_ASR";
            printer._DTName = (dGV_Result.DataSource as DataTable).TableName;
            printer._rdlc = "GRADEs.AvgScoreResult";
            printer.ShowDialog();
        }
    }
}



/* TODO:
 * print
 */