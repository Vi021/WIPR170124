using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WIPR170124.GRADEs
{
    public partial class Gra_StatisticResultFrm : Form
    {
        public Gra_StatisticResultFrm()
        {
            InitializeComponent();
        }

        private void load()
        {
            string getStr = "SELECT * FROM AvgGraByCou";
            SqlConnection conn = new MyDB().Connection;
            SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn);
            DataTable dT = new DataTable();

            adapter.Fill(dT);

            foreach (DataRow r in dT.Rows)
            {
                rTB_1.AppendText(r["CName"].ToString().Trim() + ": " + Math.Round(Convert.ToDouble(r["AvgGr"]),2) + "\n");
            }
        }

        private void Gra_StatisticResultFrm_Load(object sender, EventArgs e)
        {
            rTB_1.ReadOnly = true;
            lbl_Pass.Text = "Pass: 25%";
            lbl_Fail.Text = "Fail: 75%";
            load();
        }
    }
}



/* TODO:
 * calculate pass and fail
 * 
 */