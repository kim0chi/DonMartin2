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

namespace SliceOfHeaven
{
    class MainClass
    {
        public static readonly string conString = @"Data Source=DESKTOP-K6LHVL9\SQLEXPRESS;Initial Catalog=DonMartinDB;Integrated Security=True;";

        public static SqlConnection con = new SqlConnection(conString);

        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string qry = @"SELECT * from users where username = '"+user+"' and upass = '"+pass+"' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["uName"].ToString();
            }

            return isValid;
        }

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

        public static void Register(string username, string name, string password, string phone, string email)
        {
            Random rnd = new Random();
            int x = rnd.Next(5, 100);
            string y = x.ToString();
            string qry = @"INSERT INTO [dbo].[users] ([userID],[username],[upass],[uName],[uPhone],[uMail])VALUES('"+y+"','" + username + "','" + password + "','" + name + "','" + phone + "','" + email + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

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
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                res = cmd.ExecuteNonQuery();
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
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string coldNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[coldNam1].DataPropertyName = dt.Columns[i].ToString();   
                }
                 
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }
    }

}
