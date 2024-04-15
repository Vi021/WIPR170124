using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WIPR170124
{
    internal class MyDB
    {
        string connStr = @"Data Source=TTFE11\SQLEXPRESS;Initial Catalog=WIPR_170124;Integrated Security=True";      // ~ ..("Data Source=TTFE11\\SQLEXPRESS;Initial Catalog=WIPR_170124;Integrated Security=True;")

        public SqlConnection Connection
        {
            get {return new SqlConnection(connStr);}        //'cause of "using" in other classes
            set {connStr = value.ConnectionString;}
        }

        public void TestConnection()
        {
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                using (conn)
                {
                    conn.Open();
                    MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show("Could not connect to the database: " + msg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void openConnection()
        {
            SqlConnection conn = new SqlConnection(connStr);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            SqlConnection conn = new SqlConnection(connStr);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}