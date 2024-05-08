using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR170124.CONTACT_GROUPs
{
    public partial class Con_CouGraListFrm : Form
    {
        public Con_CouGraListFrm()
        {
            InitializeComponent();
        }

        internal string _name = "";
        internal int id = -1;
        private void Con_CouGraListFrm_Load(object sender, EventArgs e)
        {
            if (_name.Length > 0 && id > 0)
            {
                this.Text += " " + _name + $" (ID: {id})";
                loader();
            }
        }

        private void loader()
        {
            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();
                    string get = $"SELECT CID as [Course ID], CName as [Course Name], Sem as Semester, AvgGr as [Average Score] FROM tea_cou JOIN AvgGraByCou ON course_id = CID WHERE contact_id = {id}";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(get, conn))
                    {
                        DataTable dT = new DataTable();

                        adapter.Fill(dT);

                        dGV_List.DataSource = dT;
                        dGV_List.Columns["Average Score"].DefaultCellStyle.Format = "N2";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Courses List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
