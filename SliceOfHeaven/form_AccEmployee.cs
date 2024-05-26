using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SliceOfHeaven.form_EmployeeLogin;

namespace SliceOfHeaven
{
    public partial class form_AccEmployee : Form
    {
        public form_AccEmployee()
        {
            InitializeComponent();
            LoadStaffDetails();
        }

        private void LoadStaffDetails()
        {
            string username = Session.LoggedInUsername;

            if (!string.IsNullOrEmpty(username))
            {
                DataRow staffDetails = MainClass.GetStaffDetailsByUsername(username);

                if (staffDetails != null)
                {
                    string id = staffDetails["staffID"].ToString();
                    lbl_staffID.Text = id;
                    lbl_Name.Text = staffDetails["sName"].ToString();
                    lbl_Phone.Text = staffDetails["sPhone"].ToString();
                    lbl_Address.Text = staffDetails["sAddress"].ToString();
                    lbl_Role.Text = staffDetails["sRole"].ToString();
                }
                else
                {
                    MessageBox.Show("Staff details not found.");
                }
            }
            else
            {
                MessageBox.Show("No logged-in user.");
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            
        }

        private void form_AccEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
