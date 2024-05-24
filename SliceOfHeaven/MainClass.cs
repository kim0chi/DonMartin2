using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Dynamic;
using System.Windows.Forms;
using ReaLTaiizor.Enum.Poison;
using System.Drawing;

namespace SliceOfHeaven
{
    class MainClass
    {
        public static readonly string conString = @"Data Source=DESKTOP-K6LHVL9\SQLEXPRESS;Initial Catalog=DonMartinDB;Integrated Security=True;";

        public static SqlConnection con = new SqlConnection(conString);

        // For User's Validity with Database
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string qry = @"SELECT * from userz where username = '"+user+"' and uPass = '"+pass+"' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["First_Name"].ToString();
            }

            return isValid;
        }

        // To Display Customer Name
        
        public static string user;
        public static string admin;
        public static string staff;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        public static string ADMIN
        {
            get { return admin; }
            private set { admin = value; }
        }

        public static string STAFF
        {
            get { return staff;  }
            private set { staff = value; }
        }

        // To Register New Users
        public static void Register(string username, string name, string lastname, string password, string phone, string email)
        {
            string qry = @"INSERT INTO [dbo].[userz] ([First_Name],[Last_Name],[username],[uPass],[uPhone],[uEmail])VALUES('" + name + "','" + lastname + "','" + username + "','"+ password+"','" + phone + "','" + email + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // To Check for Duplicate Users
        public static bool IsDuplicateUser(string username, string phone, string email)
        {
            string qry = @"SELECT COUNT(1) FROM userz WHERE username = @username OR uPhone = @uPhone OR uEmail = @uEmail";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@uPhone", phone);
                    cmd.Parameters.AddWithValue("@uEmail", email);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured");
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        // To Check for Duplicate Names
        public static bool IsDuplicateName(string name, string lastname)
        {
            string qry = @"SELECT COUNT(1) FROM userz WHERE First_Name = @First_Name AND Last_Name = @Last_Name";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@First_Name", name);
                    cmd.Parameters.AddWithValue("@Last_Name", lastname);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured");
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        // For Admin for Valid Credentials with Database
        public static bool IsValidAdmin(string user, string pass)
        {
            bool isValid = false;

            string qry = @"SELECT * from admin where username = '" + user + "' and apass = '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                ADMIN = dt.Rows[0]["aName"].ToString();
            }

            return isValid;
        }

        // For Staff checking valid credentials with database
        public static bool IsValidStaff(string user, string pass)
        {
            bool isValid = false;

            string qry = @"SELECT * from employee where username = '" + user + "' and spass = '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                STAFF = dt.Rows[0]["sName"].ToString();
            }

            return isValid;
        }


        // Method for CURD Operation
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);    
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                res = cmd.ExecuteNonQuery();

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            return res;
        }

        // For Loading Data from database
        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            // Serial Number
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(Gv_CellFormatting);

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();   
                }
                 
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private static void Gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            System.Windows.Forms.DataGridView gv = (System.Windows.Forms.DataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        // To Check For Duplicate Categories
        public static bool IsDuplicateCategoryName(string categoryName)
        {
            try
            {
                string checkDuplicateQuery = "SELECT COUNT(*) FROM category WHERE catName = @Name";
                Hashtable ht = new Hashtable();
                ht.Add("@Name", categoryName);

                int existingCount = (int)MainClass.ScalarSQL(checkDuplicateQuery, ht);
                return existingCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking for duplicate category name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Treat error as if duplicate exists to prevent unintended insertion
            }
        }

        public static bool IsDuplicateStaff(string categoryName)
        {
            try
            {
                string checkDuplicateQuery = "SELECT COUNT(*) FROM staff WHERE sName = @Name";
                Hashtable ht = new Hashtable();
                ht.Add("@Name", categoryName);

                int existingCount = (int)MainClass.ScalarSQL(checkDuplicateQuery, ht);
                return existingCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking for duplicate category name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Treat error as if duplicate exists to prevent unintended insertion
            }
        }

        public static bool IsDuplicateProduct(string categoryName)
        {
            try
            {
                string checkDuplicateQuery = "SELECT COUNT(*) FROM products WHERE pName = @Name";
                Hashtable ht = new Hashtable();
                ht.Add("@Name", categoryName);

                int existingCount = (int)MainClass.ScalarSQL(checkDuplicateQuery, ht);
                return existingCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking for duplicate category name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Treat error as if duplicate exists to prevent unintended insertion
            }
        }

        // For Scalar SQL connectivity
        public static object ScalarSQL(string qry, Hashtable ht)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.CommandType = CommandType.Text;
                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    }
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while executing SQL query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.CenterScreen;
                Background.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = form_Admin.Instance.Size;
                Background.Location = form_Admin.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }

        // For CB Fill

        public static void CBFIll(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand (qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }
    }
}
