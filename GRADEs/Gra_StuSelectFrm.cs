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
using WIPR170124.STUDENTs;

namespace WIPR170124.GRADEs
{
    public partial class Gra_StuSelectFrm : Form
    {
        public Gra_StuSelectFrm()
        {
            InitializeComponent();
        }

        private bool loaded = false;
        private DataTable DT = new DataTable();
        private void Gra_StuSelectFrm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    string get = "SELECT DISTINCT SID FROM [SPSR]";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(get, conn))
                    {
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

                        comB_1.DataSource = dt;
                        comB_1.DisplayMember = "SID";
                        comB_1.ValueMember = "SID";
                    }

                    get = "SELECT * FROM [SPSR]"; 
                    using (SqlDataAdapter adapter  = new SqlDataAdapter(get, conn))
                    {
                        adapter.Fill(DT);

                        dGV_GraPrint.DataSource = DT;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            loaded = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loaded) return;

            string sid = comB_1.SelectedValue.ToString().Trim();

            dGV_GraPrint.DataSource = DT.AsEnumerable()
                                        .Where(row => row["SID"].ToString().Contains(sid))
                                        .CopyToDataTable();

            PrinterFrm printer = new PrinterFrm();
            printer._SourceDT = dGV_GraPrint.DataSource as DataTable;
            printer._DSName = "DataSet1";
            printer._DTName = (dGV_GraPrint.DataSource as DataTable).TableName;
            printer._rdlc = "GRADEs.AvgScoreReport";
            printer.spsr = true;
            printer.SPSR(sid, dGV_GraPrint.Rows[0].Cells["Lname"].Value.ToString() + " " + dGV_GraPrint.Rows[0].Cells["Fname"].Value.ToString());

            this.Hide();
            printer.ShowDialog();
            this.Show();
        }
    }
}
