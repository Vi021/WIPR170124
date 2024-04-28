using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using System.IO;

namespace WIPR170124.ServiceClasses
{
    internal class GROUP
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
                string checkStr = "SELECT COUNT(*) FROM Groups WHERE ID = @id";
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

        public bool AddGroup(int id, string name)
        {
            if (id >= 0 && name.Length > 0)
            {
                string addStr = "INSERT INTO Groups VALUES (@id, @fname, @uid)";

                try
                {
                    using (SqlConnection conn = new MyDB().Connection)
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(addStr, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@fname", name);
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
                    MessageBox.Show(e.Message, "GROUP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public bool EditGroup(int id, string name, int uid)
        {
            if (id >= 0 && name.Length > 0 && uid >= 0)
            {
                string addStr = "UPDATE Groups SET GName = @name WHERE ID = @id";

                try
                {
                    using (SqlConnection conn = new MyDB().Connection)
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(addStr, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@name", name);

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                return true;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "GROUP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public DataTable GetGroups(SqlCommand cmd)
        {
            DataTable dt = new DataTable("Groups");
            try
            {
                cmd.Connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GROUP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public bool RemoveGroup(int gid, int uid = -1)
        {
            try
            {
                using (SqlConnection conn = new MyDB().Connection)
                {
                    string removeStr = $"DELETE FROM Groups WHERE ID = {gid}";
                    if (uid >= 0 && new USER().id_exist(uid))
                    {
                        removeStr += $" AND UID = {uid}";
                    }

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(removeStr, conn))
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "GROUP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
