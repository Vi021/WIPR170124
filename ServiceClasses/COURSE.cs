using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WIPR170124.ServiceClasses
{
    internal class COURSE
    {
        public bool IsLetsAndDigs(string text)
        {
            string pattern = "^[a-zA-Z0-9]+$";
            return Regex.IsMatch(text, pattern);
        }

        public bool IsDigits(string text)
        {
            string pattern = "^[0-9]+$";
            return Regex.IsMatch(text, pattern);
        }

        public bool CheckCID(string CID)
        {
            string getStr = "SELECT COUNT(*) FROM CourseTable WHERE CID = @cid";
            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(getStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@cid", CID);

                        if ((int)cmd.ExecuteScalar() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Course error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AddCourse(string CID = null, string CName = null, int Period = 0, string Descr = null)
        {
            try
            {
                if (CID == null || CName == null || Period == 0)
                {
                    return false;
                }
                else
                {
                    using (SqlConnection conn = new MyDB().Connection)
                    {
                        conn.Open();

                        string addStr = null;
                        if (Descr == null)
                        {
                            addStr = "INSERT INTO CourseTable(CID, CName, Period) VALUES (@cid, @cname, @period)";    //when no Description
                        }
                        else
                        {
                            addStr = "INSERT INTO CourseTable VALUES (@cid, @cname, @period, @descr)";
                        }
                        using (SqlCommand cmd = new SqlCommand(addStr, conn))
                        {
                            cmd.Parameters.AddWithValue("@cid", CID);
                            cmd.Parameters.AddWithValue("@cname", CName);
                            cmd.Parameters.AddWithValue("@period", Period);
                            if (Descr != null)
                            {
                                cmd.Parameters.AddWithValue("@descr", Descr);
                            }

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public System.Data.DataTable GetACourse(string CID)
        {
            try
            {
                System.Data.DataTable dT = new System.Data.DataTable();
                using (SqlConnection con = new MyDB().Connection)
                {
                    string getStr = "SELECT * FROM CourseTable WHERE CID = @cid";
                    using (SqlCommand cmd = new SqlCommand(getStr, con))
                    {
                        cmd.Parameters.AddWithValue("@cid", CID);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dT);
                        return dT;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Edit course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new System.Data.DataTable();
            }
        }

        public System.Data.DataTable GetAllCourses(SqlCommand cmd)
        {
            try
            {
                System.Data.DataTable dT = new System.Data.DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dT);
                }

                return dT;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool UpdateCourse(string cID, string cName, int period, string descr)
        {
            try
            {
                using(SqlConnection conn =  new MyDB().Connection)
                {
                    conn.Open();
                    string updateStr = "UPDATE CourseTable SET CName = @cname, Period = @period, Description = @descr WHERE CID = @cid";
                    using(SqlCommand cmd =  new SqlCommand(updateStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@cid", cID);
                        cmd.Parameters.AddWithValue("@cname", cName);
                        cmd.Parameters.AddWithValue("@period", period);
                        cmd.Parameters.AddWithValue("@descr", descr);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RemoveCourse(string CID)
        {
            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();

                    string removeStr = "DELETE FROM CourseTable WHERE CID = @cid";
                    using (SqlCommand cmd = new SqlCommand(removeStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@cid", CID);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Remove error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DoEnroll(string StuID="", string CID="", int Sem=-1)
        {
            try
            {
                int c = 0;
                if (StuID.Length > 0) c += 1;
                if (CID.Length > 0) c += 2;
                if (0 < Sem && Sem < 4) c += 4;

                string checkStr = "SELECT COUNT(*) FROM EnrollTable WHERE ";
                switch (c)
                {
                    case 0:
                        {
                            return false;
                        }
                    case 1:
                        {
                            checkStr += "StuID = @stuid";
                            break;
                        }
                    case 2:
                        {
                            checkStr += "CID = @cid";
                            break;
                        }
                    case 3:
                        {
                            checkStr += "StuID = @stuid AND CID = @cid";
                            break;
                        }
                    case 4:
                        {
                            checkStr += "Sem = @sem";
                            break;
                        }
                    case 5:
                        {
                            checkStr += "StuID = @stuid AND Sem = @sem";
                            break;
                        }
                    case 6:
                        {
                            checkStr += "CID = @cid AND Sem = @sem";
                            break;
                        }
                    case 7:
                        {
                            checkStr += "StuID = @stuid AND CID = @cid AND Sem = @sem";
                            break;
                        }
                }

                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();
                    //string checkStr = "SELECT COUNT(*) FROM EnrollTable WHERE StuID = @stuid and CID = @cid and Sem = @sem";
                    using (SqlCommand cmd = new SqlCommand(checkStr, conn))
                    {
                        if (c == 1 || c == 3 || c == 5 || c == 7) cmd.Parameters.AddWithValue("@stuid", StuID);
                        if (c == 2 || c == 3 || c == 6 || c == 7) cmd.Parameters.AddWithValue("@cid", CID);
                        if (c == 4 || c == 5 || c == 6 || c == 7) cmd.Parameters.AddWithValue("@sem", Sem);

                        if ((int)cmd.ExecuteScalar() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EnrollCourse(string StuID, string CID, int Sem)
        {
            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();
                    string addStr = "INSERT INTO EnrollTable VALUES (@stuid, @cid, @sem)";
                    using (SqlCommand cmd = new SqlCommand(addStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@stuid", StuID);
                        cmd.Parameters.AddWithValue("@cid", CID);
                        cmd.Parameters.AddWithValue("@sem", Sem);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RemoveEnroll(string stuid = "", string cid = "", int sem = -1)
        {
            try
            {
                int c = 0;
                if (stuid.Length > 0) c += 1;
                if (cid.Length > 0) c += 2;
                if (0 < sem && sem < 4) c += 4;

                string removeStr = "DELETE FROM EnrollTable WHERE ";
                switch (c)
                {
                    case 0:
                        {
                            return false;
                        }
                    case 1:
                        {
                            removeStr += "StuID = @stuid";
                            break;
                        }
                    case 2:
                        {
                            removeStr += "CID = @cid";
                            break;
                        }
                    case 3:
                        {
                            removeStr += "StuID = @stuid AND CID = @cid";
                            break;
                        }
                    case 4:
                        {
                            removeStr += "Sem = @sem";
                            break;
                        }
                    case 5:
                        {
                            removeStr += "StuID = @stuid AND Sem = @sem";
                            break;
                        }
                    case 6:
                        {
                            removeStr += "CID = @cid AND Sem = @sem";
                            break;
                        }
                    case 7:
                        {
                            removeStr += "StuID = @stuid AND CID = @cid AND Sem = @sem";
                            break;
                        }
                }

                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(removeStr, conn))
                    {
                        if (c == 1 || c == 3 || c == 5 || c == 7) cmd.Parameters.AddWithValue("@stuid", stuid);
                        if (c == 2 || c == 3 || c == 6 || c == 7) cmd.Parameters.AddWithValue("@cid", cid);
                        if (c == 4 || c == 5 || c == 6 || c == 7) cmd.Parameters.AddWithValue("@sem", sem);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
