using System;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace WIPR170124.ServiceClasses
{
    internal class CONTACT
    {
        public bool int_able(string str)
        {
            string pattern = @"^-?\d+$";
            return Regex.IsMatch(str, pattern);
        }

        public bool id_exist(int id)
        {
            using (SqlConnection conn = new MyDB().Connection)
            {
                conn.Open();
                string checkStr = "SELECT COUNT(*) FROM Contacts WHERE ConID = @id";
                using (SqlCommand cmd = new SqlCommand(checkStr, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

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

        public bool name_valid(string str)
        {
            string pattern = @"^[\p{L} ]+$";
            return Regex.IsMatch(str, pattern);
        }
        
        public bool phone_exist(string phone)
        {
            using (SqlConnection conn = new MyDB().Connection)
            {
                conn.Open();
                string checkStr = "SELECT COUNT(*) FROM Contacts WHERE Phone = @phone";
                using (SqlCommand cmd = new SqlCommand(checkStr, conn))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);

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

        public bool AddContact(int id, string fname, string lname, int group, string phone, string email, string addr, MemoryStream pfp)
        {
            if (id >= 0 && fname.Length > 0 && lname.Length > 0 && group >= 0 && phone.Length == 10 && email.Length > 0 && addr.Length > 0)
            {
                string addStr = "INSERT INTO Contacts VALUES (@id, @fname, @lname, @group, @phone, @email, @addr, @pfp, @uid)";

                try
                {
                    if (pfp == null)
                    {
                        Image image = Properties.Resources.profileIcon;

                        if (image != null)
                        {
                            image.Save(pfp, image.RawFormat);
                        }
                    }

                    using (SqlConnection conn = new MyDB().Connection)
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(addStr, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@fname", fname);
                            cmd.Parameters.AddWithValue("@lname", lname);
                            cmd.Parameters.AddWithValue("@group", group);
                            cmd.Parameters.AddWithValue("@phone", phone);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@addr", addr);
                            cmd.Parameters.AddWithValue("@pfp", pfp.ToArray());
                            cmd.Parameters.AddWithValue("@uid", Program._id);

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                return true;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "CONTACT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }
        
        public DataTable GetAContact(int id)
        {
            if (id >= 0)
            {
                DataTable dt = new DataTable("Contacts");
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();
                    string getStr = $"SELECT * FROM Contacts WHERE ConID = {id}";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
                
                return dt;
            }

            return null;
        }

        public DataTable GetContactsFromGroup(int gid)
        {
            if (gid >= 0)
            {
                DataTable dt = new DataTable("Contacts");
                using (SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();
                    string getStr = $"SELECT * FROM Contacts WHERE GID = {gid}";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
                
                return dt;
            }

            return null;
        }

        public bool EditContact(int id, string fname, string lname, int group, string phone, string email, string addr, MemoryStream pfp)
        {
            if (id >= 0 && fname.Length > 0 && lname.Length > 0 && group >= 0 && phone.Length == 10 && email.Length > 0 && addr.Length > 0)
            {
                string addStr = "UPDATE Contacts SET Fname = @fname, Lname = @lname, GID = @group, Phone = @phone, Address = @addr, Email = @email, pfp = @pfp WHERE ConID = @id";

                try
                {
                    if (pfp == null)
                    {
                        Image image = Properties.Resources.profileIcon;

                        if (image != null)
                        {
                            image.Save(pfp, image.RawFormat);
                        }
                    }

                    using (SqlConnection conn = new MyDB().Connection)
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(addStr, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@fname", fname);
                            cmd.Parameters.AddWithValue("@lname", lname);
                            cmd.Parameters.AddWithValue("@group", group);
                            cmd.Parameters.AddWithValue("@phone", phone);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@addr", addr);
                            cmd.Parameters.AddWithValue("@pfp", pfp.ToArray());
                            cmd.Parameters.AddWithValue("@uid", Program._id);

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                return true;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "CONTACT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }
    }
}
