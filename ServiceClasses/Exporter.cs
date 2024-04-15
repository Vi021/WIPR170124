//using Syncfusion.XlsIO;             //installed via NuGet
using Microsoft.Office.Interop.Excel;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace WIPR170124
{
    internal class Exporter
    {
        private string _filename = "";

        public Exporter(string filename)
        {
            this._filename = filename;
        }

        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public bool SL_ToExcelFrom(DataGridView dGV)
        {
            /*
        // https://support.syncfusion.com/kb/article/11327/how-to-export-datagridview-to-excel-in-windows-forms#:~:text=Use%20the%20ImportDataGridView()%20method,column%20header%20and%20cell%20formatting.&text=Step%207%3A%20Use%20the%20following,DataGridView%20to%20Excel%20using%20XlsIO.
        // pay to use

        try
        {
            // Create a new Excel workbook
            //Initialize the Excel Engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Initialize Application
                IApplication application = excelEngine.Excel;

                //Set default version for application
                application.DefaultVersion = ExcelVersion.Excel2013;

                //Create a new workbook
                IWorkbook workbook = application.Workbooks.Create(1);

                //Accessing first worksheet in the workbook
                IWorksheet worksheet = workbook.Worksheets[0];

                // Use the ImportDataGridView() method to export the data from DataGridView to Excel worksheet with its column header and cell formatting
                //Import data from DataGridView control
                worksheet.ImportDataGridView(dGV, 1, 1, true, true);

                //Save as an Excel file
                workbook.SaveAs("C:\\Users\\Admin\\OneDrive\\Documents\\WIPR\\WIPR_w2_17-01-2024\\Exports\\" + _filename + ".xlsx");

                return true;
            }

        }
        catch (Exception exc)
        {
            MessageBox.Show("Failed exporting file: " + exc.Message, "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }


        // Use the following complete code in btnCreate_Click to export data from DataGridView to Excel using XlsIO
        //Initialize the Excel Engine
        using (ExcelEngine excelEngine = new ExcelEngine())
        {
            //Initialize DataGridView control
            DataGridView dataGridView = new DataGridView();

            //Assign data source
            dataGridView.DataSource = GetDataTable();

            //Assign the datagridview size
            dataGridView.Size = new System.Drawing.Size(441, 150);

            //Initialize Application
            IApplication application = excelEngine.Excel;

            //Set default version for application
            application.DefaultVersion = ExcelVersion.Excel2013;

            //Create a new workbook
            IWorkbook workbook = application.Workbooks.Create(1);

            //Accessing first worksheet in the workbook
            IWorksheet worksheet = workbook.Worksheets[0];

            //Import data from DataGridView control
            worksheet.ImportDataGridView(dataGridView, 1, 1, true, true);

            //Save the workbook
            workbook.SaveAs("Output.xlsx");
        }*/

            // https://viblo.asia/p/thao-tac-voi-file-excel-pVYRPj4lG4ng
            //.Save() - Save to existing file
            //.SaveAs() - Save to new file
            try
            {
                // Create a new Excel application
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                
                // To not lauch Excel
                excelApp.Visible = false;

                // Create a new workbook
                Workbook workbook = excelApp.Workbooks.Add();

                // Create a new worksheet
                Worksheet worksheet = workbook.Sheets[1];

                // Set headers from DataGridView
                /*for (int i = 0; i < dGV.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dGV.Columns[i].HeaderText;
                }*/
                worksheet.Cells[1, 1] = "StuID";
                worksheet.Cells[1, 2] = "Firstname";
                worksheet.Cells[1, 3] = "Lastname";
                worksheet.Cells[1, 4] = "Birthdate";
                worksheet.Cells[1, 5] = "Gender";
                worksheet.Cells[1, 6] = "Phone";
                worksheet.Cells[1, 7] = "Address";
                worksheet.Cells[1, 8] = "Mugshot";

                // Copy data from DataGridView to Excel
                for (int i = 0; i < dGV.Rows.Count; i++)
                {
                    /*for (int j = 0; j < dGV.Columns.Count; j++)                       //<> ColumnCount: number of columns DISPLAYED on dGV
                    {
                        worksheet.Cells[i + 2, j + 1] = dGV.Rows[i].Cells[j].Value.ToString();
                    }*/
                    int j = 1;
                    worksheet.Cells[i + 2, j++] = dGV.Rows[i].Cells["StuID"].Value.ToString().Trim();
                    worksheet.Cells[i + 2, j++] = dGV.Rows[i].Cells["FName"].Value.ToString();
                    worksheet.Cells[i + 2, j++] = dGV.Rows[i].Cells["LName"].Value.ToString();
                    worksheet.Cells[i + 2, j++] = ((DateTime)dGV.Rows[i].Cells["BDate"].Value).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                    worksheet.Cells[i + 2, j++] = dGV.Rows[i].Cells["Gender"].Value.ToString();
                    worksheet.Cells[i + 2, j++] = dGV.Rows[i].Cells["Phone"].Value.ToString();
                    worksheet.Cells[i + 2, j++] = dGV.Rows[i].Cells["Address"].Value.ToString();
                    //handling dgv image column
                    object cellValue = dGV.Rows[i].Cells["Mugshot"].Value;
                    if (cellValue != null)
                    {
                        // Convert image to byte[] if cell contains an image
                        if (cellValue is System.Drawing.Image image)
                        {
                            byte[] imageData = ImageToByteArray(image);
                            worksheet.Cells[i + 2, j++].Value = imageData;
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j++].Value = cellValue.ToString();
                        }
                    }
                }

                //Save file
                string fpath = "C:\\Users\\Admin\\OneDrive\\Documents\\WIPR\\WIPR_w2_17-01-2024\\Exports\\" + _filename + ".xlsx";
                if (System.IO.File.Exists(fpath))
                {
                    workbook.Save();
                }
                else
                {
                    workbook.SaveAs(fpath);
                }

                workbook.Close();

                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ToXLSX(System.Data.DataTable dT)
        {
            //overloading
        }
    }
}
