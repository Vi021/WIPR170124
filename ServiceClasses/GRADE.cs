using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WIPR170124.ServiceClasses
{
    internal class GRADE
    {
        public bool HasGrade(string StuID="", string CID="", int Sem=-1)
        {
            try
            {
                int c = 0;
                if (StuID.Length > 0) c += 1;
                if (CID.Length > 0) c += 2;
                if (0 < Sem && Sem < 4) c += 4;

                string checkStr = "SELECT COUNT(*) FROM Grade WHERE ";
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
                    //string checkStr = "SELECT COUNT(*) FROM Grade WHERE StuID = @stuid and CID = @cid and Sem = @sem";
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

        public DataTable GetGrades(string StuID, string CID, int Sem)
        {
            try
            {
                System.Data.DataTable dT = new System.Data.DataTable();
                using (SqlConnection con = new MyDB().Connection)
                {
                    string getStr = "SELECT * FROM Grade WHERE CID = @cid";
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
                MessageBox.Show(exc.Message, "Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new System.Data.DataTable();
            }
        }

        public DataTable GetAllGrades()
        {
            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();
                    string getStr = "SELECT * FROM Grade";
                    using (SqlCommand cmd = new SqlCommand(getStr, conn))
                    {
                        DataTable dT = new DataTable();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        adapter.Fill(dT);

                        return dT;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }

        }

        public bool AddGrade(string StuID, string CID, int Sem, double grade, string descr = null)
        {
            try
            {
                if (StuID == null || CID == null || (Sem < 1 || Sem > 3))
                {
                    return false;
                }
                else
                {
                    using (SqlConnection conn = new MyDB().Connection)
                    {
                        conn.Open();
                        string addStr = null;
                        if (descr == null)
                        {
                            addStr = "INSERT INTO Grade(StuID, CID, Sem, Grade) VALUES (@stuid, @cid, @sem, @grade)";    //when no Description
                        }
                        else
                        {
                            addStr = "INSERT INTO Grade VALUES (@stuid, @cid, @sem, @grade, @descr)";
                        }
                        using (SqlCommand cmd = new SqlCommand(addStr, conn))
                        {
                            cmd.Parameters.AddWithValue("@stuid", StuID);
                            cmd.Parameters.AddWithValue("@cid", CID);
                            cmd.Parameters.AddWithValue("@sem", Sem);
                            cmd.Parameters.AddWithValue("@grade", grade);
                            if (descr != null)
                            {
                                cmd.Parameters.AddWithValue("@descr", descr);
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
                MessageBox.Show(exc.Message, "Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateGrade(string StuID, string CID, int Sem, float grade)
        {
            try
            {
                if (StuID == null || CID == null || (Sem < 1 || Sem > 3) || (grade < 0 || grade > 10))
                {
                    return false;
                }
                else
                {
                    using (SqlConnection conn = new MyDB().Connection)
                    {
                        conn.Open();
                        string addStr = "UPDATE Grade SET Grade = @grade WHERE StuID = @stuid and CID = @cid and Sem = @sem";
                        using (SqlCommand cmd = new SqlCommand(addStr, conn))
                        {
                            cmd.Parameters.AddWithValue("@stuid", StuID);
                            cmd.Parameters.AddWithValue("@cid", CID);
                            cmd.Parameters.AddWithValue("@sem", Sem);
                            cmd.Parameters.AddWithValue("@grade", grade);

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
                MessageBox.Show(exc.Message, "Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RemoveGrade(string stuid = "", string cid = "", int sem = -1)
        {
            try
            {
                int c = 0;
                if (stuid.Length > 0) c += 1;
                if (cid.Length > 0) c += 2;
                if (0 < sem && sem < 4) c += 4;

                string removeStr = "DELETE FROM Grade WHERE ";
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
                        if (c == 2 || c == 3 || c == 6 || c == 7)  cmd.Parameters.AddWithValue("@cid", cid);
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
                MessageBox.Show(exc.Message, "Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
