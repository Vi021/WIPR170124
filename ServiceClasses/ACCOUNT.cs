using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR170124
{
    internal class ACCOUNT
    {
        // return ex(ist), ac(tivate), ad(min)
        public (bool, bool, bool) AccountType(string email, string pass)
        {
            try
            {
                MyDB myDB = new MyDB();
                using (SqlConnection conn = myDB.Connection)
                {
                    conn.Open();

                    string getStr = "SELECT * FROM MailAccounts WHERE Email = @email";
                    using (SqlCommand cmd = new SqlCommand(getStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                var Pass = dt.Rows[0]["Password"];
                                if (Pass != null)
                                {
                                    if (new PassHasher().VerifyPassword(pass, Pass.ToString()))
                                    {
                                        if (dt.Rows[0]["Active"].ToString().Contains("True") && dt.Rows[0]["Admin"].ToString().Trim().Contains("True"))
                                        {
                                            return (true, true, true);
                                        }
                                        if (dt.Rows[0]["Active"].ToString().Contains("True") && dt.Rows[0]["Admin"].ToString().Contains("False"))
                                        {
                                            return (true, true, false);
                                        }
                                        if (dt.Rows[0]["Active"].ToString().Contains("False") && dt.Rows[0]["Admin"].ToString().Contains("True"))
                                        {
                                            return (true, false, true);
                                        }
                                    }
                                }
                            }

                            return (false, false, false);
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, false, false);
            }
        }

        public DataTable GetAccounts(SqlCommand cmd)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            
            adapter.Fill(dt);

            return dt;
        }

        public void ModifyAccounts(SqlCommand cmd)
        {
            //
        }
    }
}
