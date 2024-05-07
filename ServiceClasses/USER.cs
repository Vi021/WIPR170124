using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WIPR170124.ServiceClasses
{
    internal class USER
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
                string checkStr = "SELECT COUNT(*) FROM dbo.[users] WHERE ID = @id";
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

        public bool username_exist(string username)
        {
            using (SqlConnection conn = new MyDB().Connection)
            {
                conn.Open();
                string checkStr = "SELECT COUNT(*) FROM dbo.[users] WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(checkStr, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

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

        public int is_active(string username)
        {
            using (SqlConnection conn = new MyDB().Connection)
            {
                conn.Open();
                string checkStr = $"SELECT active, request FROM dbo.[users] WHERE username = '{username}'";
                using (SqlDataAdapter adapter = new SqlDataAdapter(checkStr, conn))
                {
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    if (dt.Columns.Count> 0 &&dt.Rows.Count > 0)
                    {
                        if ((bool)dt.Rows[0]["active"] && !(bool)dt.Rows[0]["request"])
                        {
                            return 1;
                        }
                        else if (!(bool)dt.Rows[0]["active"] && (bool)dt.Rows[0]["request"])
                        {
                            return 0;
                        }
                        else if (!(bool)dt.Rows[0]["active"] && !(bool)dt.Rows[0]["request"])
                        {
                            return -1;
                        }
                    }

                    return -2;
                }
            }
        }

        public bool password_correct(string username, string password)
        {
            try
            {
                using(SqlConnection conn = new MyDB().Connection)
                {
                    conn.Open();
                    string getStr = $"SELECT password FROM [users] WHERE username = '{username}'";
                    using(SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (new PassHasher().VerifyPassword(password, dt.Rows[0]["password"].ToString()))
                        {
                            return true;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "USER", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public bool is_type(string username, string type)
        {
            using(SqlConnection conn = new MyDB().Connection)
            {
                string getStr = $"SELECT type FROM [users] WHERE username = '{username}'";
                using (SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0]["type"].ToString().Trim().Contains(type))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public string get_id(string username)
        {
            string id = "";
            using (SqlConnection conn = new MyDB().Connection)
            {
                string getStr = $"SELECT ID FROM [users] WHERE username = '{username}'";
                using (SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        id = dt.Rows[0]["ID"].ToString().Trim();
                    }
                }
            }

            return id;
        }

        public string get_type(int id)
        {
            string type = "";
            using (SqlConnection conn = new MyDB().Connection)
            {
                string getStr = $"SELECT type FROM [users] WHERE ID = {id}";
                using (SqlDataAdapter adapter = new SqlDataAdapter(getStr, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        type = dt.Rows[0]["type"].ToString().Trim();
                    }
                }
            }

            return type;
        }

        public bool AddUser(int ID = -1, string Fname = "", string LName = "", string Username = "", string Password = "", MemoryStream PFP = null, string Type = "")
        {
            if (ID >= 0 && Fname.Length > 0 && LName.Length > 0 && Username.Length > 0 && Password.Length > 0 && Type.Length > 0)
            {
                string addStr = "INSERT INTO [users](ID, Fname, Lname, username, password, pfp, type, request) VALUES (@id, @fname, @lname, @username, @pass, @pfp, @type, 1)";

                try
                {
                    if (PFP == null)
                    {
                        Image image = Properties.Resources.profileIcon;

                        if (image != null)
                        {
                            image.Save(PFP, image.RawFormat);
                        }
                    }

                    using (SqlConnection conn = new MyDB().Connection)
                    {
                        conn.Open();
                        using(SqlCommand cmd = new SqlCommand(addStr, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", ID);
                            cmd.Parameters.AddWithValue("@fname", Fname);
                            cmd.Parameters.AddWithValue("@lname", LName);
                            cmd.Parameters.AddWithValue("@username", Username);
                            cmd.Parameters.AddWithValue("@pass", Password);
                            cmd.Parameters.AddWithValue("@pfp", PFP.ToArray());
                            cmd.Parameters.AddWithValue("@type", Type);

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                return true;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "USER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }
    }
}



/* TODO:
 *
 * LoginUser()?
 * 
 */