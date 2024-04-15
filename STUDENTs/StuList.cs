using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR170124
{
    public partial class StuList : Form
    {
        STUDENT student = new STUDENT();

        public StuList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            
            this.qLSVDBTableAdapter.Fill(this.wIPR_170124DataSet.QLSVDB);

            SqlCommand cmd = new SqlCommand("SELECT * FROM QLSVDB");
            
            DGV_StuInfo.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            
            DGV_StuInfo.RowTemplate.Height = 50;
            DGV_StuInfo.DataSource = student.GetStudents(cmd);
            
            picCol = (DataGridViewImageColumn)DGV_StuInfo.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            
            DGV_StuInfo.AllowUserToAddRows = false;
        }

        private void but_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QLSVDB");

            DGV_StuInfo.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            
            DGV_StuInfo.RowTemplate.Height = 50;
            DGV_StuInfo.DataSource = student.GetStudents(cmd);
            
            picCol = (DataGridViewImageColumn)DGV_StuInfo.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            
            DGV_StuInfo.AllowUserToAddRows = false;
        }

        private void DGV_StuInfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StuModifyInfo msiFrm = new StuModifyInfo();

            msiFrm.txtBox_stuID.Text = DGV_StuInfo.CurrentRow.Cells[0].Value.ToString().Trim();
            msiFrm.txtBox_stuLName.Text = DGV_StuInfo.CurrentRow.Cells[1].Value.ToString();
            msiFrm.txtBox_stuFName.Text = DGV_StuInfo.CurrentRow.Cells[2].Value.ToString();
            if (DGV_StuInfo.CurrentRow.Cells[4].Value.ToString().Contains("Male"))
            {
                msiFrm.Gender_Male.Checked = true;
            }
            else if (DGV_StuInfo.CurrentRow.Cells[4].Value.ToString().Contains("Female"))
            {
                msiFrm.Gender_Female.Checked = true;
            }
            else
            {
                msiFrm.Gender_Others.Checked = true;
            }
            msiFrm.txtBox_stuPNumber.Text = DGV_StuInfo.CurrentRow.Cells[5].Value.ToString();
            msiFrm.txtBox_stuAddress.Text = DGV_StuInfo.CurrentRow.Cells[6].Value.ToString();
            MemoryStream image = new MemoryStream(DGV_StuInfo.CurrentRow.Cells[7].Value as byte[]);
            msiFrm.picBox_stuPic.BackgroundImage = Image.FromStream(image);

            msiFrm.Show();

            msiFrm.DaTi_stuBrthDate.Value = ((DateTime)DGV_StuInfo.CurrentRow.Cells[3].Value).Date;         //why? - bc of Load, it overides the bdate when show()
        }
    }
}