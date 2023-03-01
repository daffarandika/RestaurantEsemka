using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r6
{
    internal class Helper
    {
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-GHNE639;Initial Catalog=r6;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public static void RunQuery(string query)
        {
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
        }

        public static string Hash(string input)
        {
            using (var hasher = SHA256.Create())
            {
                byte[] res = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder stringBuilder= new StringBuilder();
                foreach (byte b in res)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }

        public static DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            using(var conn = GetSqlConnection()) 
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText= query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
        }

        public static void ShowError(string message, string title = "Error")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);    
        }

        public static bool QueryHasRows(string query)
        {
            using (var conn = GetSqlConnection())
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                return reader.HasRows;
            }
        }

        public static void Clear(Control[] controls)
        {
            foreach (Control c in controls)
            {
                c.Text = string.Empty;
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                    ((DataGridView)c).Rows.Clear();
                }
                if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
            }
        }


        public static DialogResult AskForConfirmation(string message = "Are you sure")
        {
            return MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }


    }
}
