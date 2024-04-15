using Microsoft.Office.Interop.Excel;           //installed via NuGet
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR170124.ServiceClasses
{
    internal class Importer
    {
        /*public System.Data.DataTable SL_FromExcel(Range excelRange)            //why? - bc Microsoft.Office.Interop.Excel also has DataTable
        {
            // https://www.freecodespot.com/blog/csharp-import-excel/

            DataRow row;
            System.Data.DataTable dt = new System.Data.DataTable();
            int rowCount = excelRange.Rows.Count; //get row count of excel data

            int colCount = excelRange.Columns.Count; // get column count of excel data

            //Get the first Column of excel file which is the Column Name
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    dt.Columns.Add(excelRange.Cells[i, j].Value2.ToString());
                }
                break;
            }

            //Get Row Data of Excel
            int col;//this variable is used for row index number
            for (int i = 2; i <= rowCount; i++) //loop for available row of excel data
            {
                row = dt.NewRow(); //assign new row to DataTable
                /*rowCounter = 0;
                for (int j = 1; j <= colCount; j++) //loop for available column of excel data
                {
                    //check if cell is empty
                    if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                    {
                        row[rowCounter] = excelRange.Cells[i, j].Value2.ToString();
                        //
                    }
                    else
                    {
                        row[i] = "";
                    }
                    rowCounter++;
                }
                col = 1;
                row[col - 1] = excelRange.Cells[i, col++].Value2.ToString();
                row[col - 1] = excelRange.Cells[i, col++].Value2.ToSting();
                row[col - 1] = excelRange.Cells[i, col++].Value2.ToString();
                row[col - 1] = (DateTime)excelRange[i, col++].Value2.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                row[col - 1] = excelRange.Cells[i, col++].Value2.ToString();
                row[col - 1] = excelRange.Cells[i, col++].Value2.ToString();
                row[col - 1] = excelRange.Cells[i, col++].Value2.ToString();
                row[col - 1] = excelRange.Cells[i, col++].Value2.ToString();

                dt.Rows.Add(row); //add row to DataTable
            }

            return dt;
        }*/

        public System.Data.DataTable SL_FromExcel(DataGridView dGV, string filePath)
        {
            System.Data.DataTable dT = new System.Data.DataTable();

            //sad

            return dT;
        }

    }
}
