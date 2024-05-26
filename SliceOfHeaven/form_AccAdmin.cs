using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliceOfHeaven
{
    public partial class form_AccAdmin : Form
    {
        public form_AccAdmin()
        {
            InitializeComponent();
        }

        private void form_AccAdmin_Load(object sender, EventArgs e)
        {
            form_AdminLogin admin = new form_AdminLogin();
            // Assuming you have a Login method in the form_AdminLogin class
            if (admin.Login("admin", "123"))
            {
                lbl_AdminName.Text = admin.AdminName;
                lbl_AdminID.Text = admin.AdminID.ToString();
            }
            else
            {
                // Handle invalid login
            }

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_SignUpEmployee emp = new form_SignUpEmployee();
            MainClass.BlurBackground(emp);
        }
    }
}
