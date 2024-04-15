using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WIPR170124.ServiceClasses;
using WIPR170124.ServiceForms;

namespace WIPR170124
{
    public partial class StudentListFrmV2 : Form
    {
        STUDENT student = new STUDENT();

        public StudentListFrmV2()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QLSVDB");

            dGV_StuInfo.DataSource = student.GetStudents(cmd);

            dGV_StuInfo.Columns["StuID"].HeaderText = "Student ID";
            dGV_StuInfo.Columns["FName"].HeaderText = "Firstname";
            dGV_StuInfo.Columns["LName"].HeaderText = "Lastname";
            dGV_StuInfo.Columns["BDate"].HeaderText = "Birthdate";
            dGV_StuInfo.Columns["Mugshot"].HeaderText = "Profile";

            dGV_StuInfo.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            
            dGV_StuInfo.RowTemplate.Height = 50;
            dGV_StuInfo.DataSource = student.GetStudents(cmd);
            
            picCol = (DataGridViewImageColumn)dGV_StuInfo.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;


            dGV_StuInfo.AllowUserToAddRows = false;
        }

        private void DGV_StuInfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StuModifyInfo msiFrm = new StuModifyInfo();

            msiFrm.txtBox_stuID.Text = dGV_StuInfo.CurrentRow.Cells[0].Value.ToString().Trim();
            msiFrm.txtBox_stuFName.Text = dGV_StuInfo.CurrentRow.Cells[1].Value.ToString();
            msiFrm.txtBox_stuLName.Text = dGV_StuInfo.CurrentRow.Cells[2].Value.ToString();
            if (dGV_StuInfo.CurrentRow.Cells[4].Value.ToString().Contains("Male"))
            {
                msiFrm.Gender_Male.Checked = true;
            }
            else if (dGV_StuInfo.CurrentRow.Cells[4].Value.ToString().Contains("Female"))
            {
                msiFrm.Gender_Female.Checked = true;
            }
            else
            {
                msiFrm.Gender_Others.Checked = true;
            }
            msiFrm.txtBox_stuPNumber.Text = dGV_StuInfo.CurrentRow.Cells[5].Value.ToString();
            msiFrm.txtBox_stuAddress.Text = dGV_StuInfo.CurrentRow.Cells[6].Value.ToString();
            MemoryStream image = new MemoryStream(dGV_StuInfo.CurrentRow.Cells[7].Value as byte[]);
            msiFrm.picBox_stuPic.BackgroundImage = Image.FromStream(image);

            msiFrm.Show();

            msiFrm.DaTi_stuBrthDate.Value = ((DateTime)dGV_StuInfo.CurrentRow.Cells[3].Value).Date;         //why? - bc of Load, it overides the bdate when show()
        }

        private void bttn_Export_Click(object sender, EventArgs e)
        {
            ExportFrm expoFrm = new ExportFrm();
            expoFrm.ShowDialog();                                       //not .Show(), why? - bc it shows the form as a modal dialog box, which means the code will wait at this line until the dialog is closed
            if (expoFrm.DialogResult == DialogResult.OK)
            {
                string filename = expoFrm.filename;
                string filetype = expoFrm.filetype;

                //MessageBox.Show(filename + ", " + filetype);
                
                Exporter expo = new Exporter(filename);

                if (filetype.Contains(".xlsx"))
                {
                    if (expo.SL_ToExcelFrom(dGV_StuInfo))
                    {
                        MessageBox.Show("Exported as a .xlsx file", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //...
            }
        }

        private void bttn_Import_Click(object sender, EventArgs e)
        {
            /*ImportFrm impoFrm = new ImportFrm();
            impoFrm.ShowDialog();*//*

            dGV_StuInfo.DataSource = null;
            dGV_StuInfo.Columns.Clear();

            string file = ""; //variable for the Excel File Location
            DialogResult result = oFD_1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Check if Result == "OK".
            {
                file = oFD_1.FileName; //get the filename with the location of the file
                readExcel(file);
                //MessageBox.Show("Unhandled..", "Import", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                *//*try
                {
                    //Create Object for Microsoft.Office.Interop.Excel that will be use to read excel file
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(file);
                    Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];
                    Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;

                    dGV_StuInfo.DataSource = new Importer().SL_FromExcel(excelRange);

                    //close and clean excel process
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Marshal.ReleaseComObject(excelRange);
                    Marshal.ReleaseComObject(excelWorksheet);
                    //quit apps
                    excelWorkbook.Close();
                    Marshal.ReleaseComObject(excelWorkbook);
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message, "Import", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*//*
            }*/


            oFD_1.Title = "Excel File to Edit";
            oFD_1.FileName = "";
            oFD_1.Filter = "Excel File|*.xlsx;*.xls";

            if (oFD_1.ShowDialog() == DialogResult.OK)
            {
                string sFileName = oFD_1.FileName;

                if (sFileName.Trim() != "")
                {
                    readExcel(sFileName);
                }
            }
        }
        private bool ContainsNumber(string input)
        {
            return input.Any(char.IsDigit);
        }
        private void readExcel(string filePath)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Sheets[1]; // Assuming data is in the first sheet
                Microsoft.Office.Interop.Excel.Range range = worksheet.UsedRange;

                System.Data.DataTable dataTable = new System.Data.DataTable();
                for (int row = 1; row <= range.Rows.Count; row++)
                {
  
                    DataRow dataRow = dataTable.NewRow();
                    for (int col = 1; col <= range.Columns.Count; col++)
                    {
                        if (row == 1)
                            dataTable.Columns.Add(range.Cells[1, col].Value2?.ToString() ?? ""); // Handle null values
                        else
                            dataRow[col - 1] = range.Cells[row, col].Value2?.ToString() ?? ""; // Handle null values
                    }
                    if (ContainsNumber(dataRow["fname"].ToString()))
                    {
                        MessageBox.Show($"Name can't contain number (row:{row})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (row > 1)
                            dataTable.Rows.Add(dataRow);
                    }
                }

                dGV_StuInfo.DataSource = dataTable;

                workbook.Close(true);
                excelApp.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading Excel file: {ex.Message}");
            }
        }

        private void but_Refresh_Click(object sender, EventArgs e)
        {
            /*SqlCommand cmd = new SqlCommand("SELECT * FROM QLSVDB");

            dGV_StuInfo.DataSource = student.GetStudents(cmd);

            dGV_StuInfo.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dGV_StuInfo.RowTemplate.Height = 50;
            dGV_StuInfo.DataSource = student.GetStudents(cmd);

            picCol = (DataGridViewImageColumn)dGV_StuInfo.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dGV_StuInfo.AllowUserToAddRows = false;*/

            this.StudentList_Load(sender, e);
        }

        private bool verif(string id, string fname, string lname, string bdate, string gender, string gmail/*, string sdt, string addr, int index*/)
        {
            if (id == "" || fname == "" || lname == "" || bdate == "" || gender == "" || gmail == "" /*|| sdt == "" || addr == ""*/)
            {
                MessageBox.Show("Có dòng dữ liệu trống ", "Import Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(id, "^[0-9]+$"))
            {
                MessageBox.Show("ID chỉ bao gồm số: ID: " + id, "Import Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /*else if (!Regex.IsMatch(fname, "^[a-zA-Z\\s]+$") || !Regex.IsMatch(lname, "^[a-zA-Z\\s]+$"))
            {
                MessageBox.Show("Tên chỉ bao gồm kí tự và khoảng trắng, ID: " + id, "Import Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            /*else if (gender.Trim() != "Male" && gender.Trim() != "Female" && gender.Trim() != "Other")
            {
                MessageBox.Show("Giới tính chỉ bao gồm các dữ liệu (Male, Female, Other), ID: " + id, "Import Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            /*else if (!Regex.IsMatch(sdt, "^[0-9]+$"))
            {
                MessageBox.Show("Số điện thoại chỉ bao gồm số, ID: " + id, "Import Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            else
            {
                return true;
            }

            return false;
        }

        private void bttn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming you have a connection string defined
                //string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; // Replace with your actual connection string
                //string file = "D:/Nam_2/HK2/Programming_Windows/Day_10/QLSV/Image/user_3177440.png";
                //Image image = Image.FromFile(file);
                //byte[] imageBytes = ImageToByteArray(image);
                using (SqlConnection connection = new MyDB().Connection)
                {
                    connection.Open();

                    // Assuming your table name is "YourTableName"
                    string tableName = "TempStu";

                    // Create a SQL command to insert data into the table
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        foreach (DataGridViewRow row in dGV_StuInfo.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                // Assuming your columns are named "Column1", "Column2", etc.
                                string column1Value = row.Cells["id"].Value?.ToString() ?? "";
                                string column2Value = row.Cells["fname"].Value?.ToString() ?? "";
                                string column3Value = row.Cells["lname"].Value?.ToString() ?? "";
                                string column4Value = row.Cells["bdate"].Value?.ToString() ?? "";
                                string column5Value = row.Cells[4].Value?.ToString() ?? "";
                                string column6Value = row.Cells["email"].Value?.ToString() ?? "";
                                /*string column7Value = row.Cells["Số điện thoại"].Value?.ToString() ?? "";
                                string column8Value = row.Cells["Địa chỉ"].Value?.ToString() ?? "";*/

                                if (verif(column1Value, column2Value, column3Value, column4Value, column5Value, column6Value/*, column7Value, column8Value, row.Index*/) == false)
                                {
                                    return;
                                }

                            }

                        }

                        foreach (DataGridViewRow row in dGV_StuInfo.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                // Assuming your columns are named "Column1", "Column2", etc.
                                string column1Value = row.Cells["id"].Value?.ToString() ?? "";
                                string column2Value = row.Cells["fname"].Value?.ToString() ?? "";
                                string column3Value = row.Cells["lname"].Value?.ToString() ?? "";
                                string column4Value = row.Cells["bdate"].Value?.ToString() ?? "";
                                string column5Value = row.Cells[4].Value?.ToString() ?? "";
                                string column6Value = row.Cells["email"].Value?.ToString() ?? "";
                                /*string column7Value = row.Cells["Số điện thoại"].Value?.ToString() ?? "";
                                string column8Value = row.Cells["Địa chỉ"].Value?.ToString() ?? "";*/

                                // Convert Column 4 value to DateTime object
                                if (DateTime.TryParse(column4Value, out DateTime dateValue))
                                {
                                    column4Value = dateValue.ToString("yyyy-MM-dd");
                                }



                                // Adjust the query to match your actual table columns
                                string insertQuery = $"INSERT INTO {tableName} (id, fname, lname, bdate, gender, email)" /*, phone, address, picture)"*/ +
                                    $" VALUES (@Column1, @Column2, @Column3, @Column4, @Column5, @Column6)"; //, @Column7, @Column8, @column9)";


                                command.CommandText = insertQuery;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@Column1", column1Value);
                                command.Parameters.AddWithValue("@Column2", column2Value);
                                command.Parameters.AddWithValue("@Column3", column3Value);
                                command.Parameters.AddWithValue("@Column4", column4Value);
                                command.Parameters.AddWithValue("@Column5", column5Value);
                                command.Parameters.AddWithValue("@Column6", column6Value);
                                /*command.Parameters.AddWithValue("@Column7", column7Value);
                                command.Parameters.AddWithValue("@Column8", column8Value);
                                command.Parameters.AddWithValue("@Column9", imageBytes);*/

                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                // MessageBox.Show($"Error saving data to SQL: {ex.Message}");
                MessageBox.Show("Primary key error or data type not match.\n" + ex.Message, "Import Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}