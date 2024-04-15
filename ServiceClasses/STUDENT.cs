using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WIPR170124
{
    internal class STUDENT
    {
        MyDB myDB = new MyDB();

        public bool OnlyLettersAndSpace(string text)
        {
            string pattern = "^[a-zA-Z ]+$";

            return Regex.IsMatch(text, pattern);
        }

        public bool AddStudent(string stuID, string fName, string lName, DateTime bDate, string gender, string pNumber, string address, MemoryStream pic)
        {
            try
            {
                using (SqlConnection conn = myDB.Connection)
                {
                    conn.Open();

                    string addCmd = "INSERT INTO QLSVDB (StuID, FName, LName, BDate, Gender, Phone, Address, Mugshot) VALUES (@stuid, @fname, @lname, @bdate, @gender, @pnumber, @addr, @pic)";
                    using (SqlCommand cmd = new SqlCommand(addCmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@stuid", stuID);
                        cmd.Parameters.AddWithValue("@fname", fName);
                        cmd.Parameters.AddWithValue("@lname", lName);
                        cmd.Parameters.AddWithValue("@bdate", bDate);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@pnumber", pNumber);
                        cmd.Parameters.AddWithValue("@addr", address);
                        cmd.Parameters.AddWithValue("@pic", pic.ToArray());

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
                MessageBox.Show("An error occurred: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ModifyStudent(string stuID, string fName, string lName, DateTime bDate, string gender, string pNumber, string address, MemoryStream pic)
        {
            try
            {
                using (SqlConnection conn = myDB.Connection)
                {
                    conn.Open();

                    string modifyCmd = $"UPDATE QLSVDB SET Fname = @fname, Lname = @lname, BDate = @bdate, Gender = @gender, Phone = @pnumber, Address = @addr, Mugshot = @pic"
                                        + " WHERE StuID = @stuid";
                    using (SqlCommand cmd = new SqlCommand(modifyCmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@stuid", stuID);
                        cmd.Parameters.AddWithValue("@fname", fName);
                        cmd.Parameters.AddWithValue("@lname", lName);
                        cmd.Parameters.AddWithValue("@bdate", bDate);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@pnumber", pNumber);
                        cmd.Parameters.AddWithValue("@addr", address);
                        cmd.Parameters.AddWithValue("@pic", pic.ToArray());

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
                MessageBox.Show("An error occurred: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RemoveStudent(string stuID)
        {
            try
            {
                using (SqlConnection conn = myDB.Connection)
                {
                    conn.Open();

                    string deleteCmd = $"DELETE FROM QLSVDB WHERE StuId = @value";
                    using (SqlCommand cmd = new SqlCommand(deleteCmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@value", stuID);

                        // Execute the SQL command
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Deleted {stuID} from list!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No rows were deleted.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable GetStudents(SqlCommand cmd)
        {
            cmd.Connection = myDB.Connection;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            return dt;
        }

        public bool verifyID(string stuID)
        {
            try
            {
                using (SqlConnection conn = myDB.Connection)
                {
                    conn.Open();

                    string verifyCmd = "SELECT COUNT(*) FROM QLSVDB WHERE StuID = @value";
                    using (SqlCommand cmd = new SqlCommand(verifyCmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@value", stuID);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            return true;
                        }

                        return false;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable GetEnrolledCourses(string StuID)
        {
            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();
                    string getStr = "SELECT CourseTable.CID, CName, Period, Description, Sem FROM CourseTable, EnrollTable WHERE CourseTable.CID = EnrollTable.CID and StuID = @stuid";
                    using (SqlCommand cmd = new SqlCommand(getStr, conn))
                    {
                        cmd.Parameters.AddWithValue("@stuid", StuID);

                        DataTable dT = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        adapter.Fill(dT);

                        return dT;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}