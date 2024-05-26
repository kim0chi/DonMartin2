using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SliceOfHeaven
{
    public partial class form_EmployeeLogin : Form
    {
        public form_EmployeeLogin()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_chooseLogin choose = new form_chooseLogin();
            choose.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtbox_Password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        MainClass main = new MainClass();
        public static class Session
        {
            public static string LoggedInUsername { get; set; }
        }

        public bool Login(string username, string password)
        {
            DataRow userDetails;
            if (main.IsValidStaff(username, password, out userDetails))
            {
                Session.LoggedInUsername = username;
                return true;
            }
            else
            {
                return false;
            }
        }


        private void cyberButton3_Click(object sender, EventArgs e)
        {
            string user = txtbox_Username.Text;
            string pass = txtbox_Password.Text;

            Session.LoggedInUsername = user;

            if (main.IsValidStaff(user, pass, out DataRow userDetails))
            {
                MessageBox.Show("Login successful!");

                string staffID = userDetails["staffID"].ToString();
                string sName = userDetails["sName"].ToString();
                

                this.Hide();
                form_Employee staff = new form_Employee();
                staff.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
