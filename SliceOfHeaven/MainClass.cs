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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.Remoting.Messaging;
using System.Net;

namespace SliceOfHeaven
{
    class MainClass
    {
        public static readonly string conString = @"Data Source=DESKTOP-K6LHVL9\SQLEXPRESS;Initial Catalog=DonMartinDB;Integrated Security=True;";
        //public static readonly string conString = @"Data Source=DESKTOP-9C9HRD8\SQLEXPRESS;Initial Catalog=DonMartinDB;Integrated Security=True;";


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
        public static void Register(string username, string name, string password, string phone, string email)
        {
            string qry = @"INSERT INTO [dbo].[users] (username,upass,uName,uPhone,uEmail)VALUES('" + name + "','" + username + "','"+ password+"','" + phone + "','" + email + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void RegisterNewStaff(string name, string phone, string address, string username, string password)
        {
            // Open the connection before calling the methods
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    RegisterStaff(name, phone, address);
                    MessageBox.Show("Done Staff");
                    RegisterEmp(username, password, name);
                    MessageBox.Show("Done Employee");
                }
                if (con.State == ConnectionState.Open)
                {
                    RegisterStaff(name, phone, address);
                    MessageBox.Show("Done Staff");
                    RegisterEmp(username, password, name);
                    MessageBox.Show("Done Employee");
                    con.Close();
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public static int GetStaffID(string staffName)
        {
            string query = "SELECT staffID FROM staff WHERE sName = @sName";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@sName", staffName);

            con.Open();
            int staffID = Convert.ToInt32(command.ExecuteScalar());
            con.Close();

            return staffID;
        }
        public static void RegisterStaff(string name, string phone, string address)
        {
            try
            {
                string staffQuery = "UPDATE staff SET sName = @sName, sPhone = @sPhone, sAddress = @sAddress WHERE sName = @sName";
                SqlCommand staffCommand = new SqlCommand(staffQuery, con);
                staffCommand.Parameters.AddWithValue("@sName", name);
                staffCommand.Parameters.AddWithValue("@sPhone", phone);
                staffCommand.Parameters.AddWithValue("@sAddress", address);

                if (con.State == ConnectionState.Open)
                {
                    staffCommand.ExecuteNonQuery();
                    MessageBox.Show("Updated Staff");
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error Occurred");
            }
        }

        public static void RegisterEmp(string username, string password, string staffName)
        {
            try
            {
                int staffID = GetStaffID(staffName);

                string employeeQuery = "INSERT INTO employee (empID, username, pass, sName) VALUES (@empID, @username, @pass, @sName)";
                SqlCommand employeeCommand = new SqlCommand(employeeQuery, con);
                employeeCommand.Parameters.AddWithValue("@empID", staffID);
                employeeCommand.Parameters.AddWithValue("@username", username);
                employeeCommand.Parameters.AddWithValue("@pass", password);
                employeeCommand.Parameters.AddWithValue("@sName", staffName);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    employeeCommand.ExecuteNonQuery();
                    MessageBox.Show("Executed Query for employee");
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error Occurred");
            }
        }

        public static bool IsStaffNameExist(string staffName)
        {
            string query = "SELECT COUNT(*) FROM staff WHERE sName = @sName";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@sName", staffName);
                con.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
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
        public static bool IsDuplicateName(string name)
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
        public static bool IsValidAdmin(string username, string password, out DataRow admin)
        {
            admin = null;

            string qry = @"SELECT adminID, aName FROM admin WHERE username = @username AND apass = @password";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                admin = dt.Rows[0];
                return true;
            }
            else
            {
                return false;
            }
        }

        // For Staff checking valid credentials with database
        public bool IsValidStaff(string user, string pass, out DataRow userDetails)
        {
            userDetails = null;
            string qry = @"
        SELECT 
            e.username, 
            e.pass, 
            s.staffID, 
            s.sName, 
            s.sPhone, 
            s.sAddress, 
            s.sRole
        FROM 
            employee e
        INNER JOIN 
            staff s ON e.sName = s.sName
        WHERE 
            e.username = @username 
            AND e.pass = @pass;";

            SqlCommand cmd = new SqlCommand(qry, con);
                
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@pass", pass);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                userDetails = dt.Rows[0];
                return true;
            }
            else
            {
                return false;
            }    
        }


        public static DataRow GetStaffDetailsByUsername(string username)
        {
            string qry = @"
        SELECT 
            s.staffID, 
            s.sName, 
            s.sPhone, 
            s.sAddress, 
            s.sRole
        FROM 
            staff s
        INNER JOIN 
            employee e ON s.sName = e.sName
        WHERE 
            e.username = @username;";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@username", username);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
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

        public static void BlurBackgroundPOS(Form owner, Form model)
        {
            Form background = new Form();
            try
            {
                background.StartPosition = FormStartPosition.CenterScreen;
                background.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                background.Opacity = 0.5d;
                background.BackColor = Color.Black;
                background.Size = owner.Size;
                background.Location = owner.Location;
                background.ShowInTaskbar = false;
                background.Show();

                model.Owner = background;
                model.ShowDialog(background);
            }
            finally
            {
                background.Dispose();
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
