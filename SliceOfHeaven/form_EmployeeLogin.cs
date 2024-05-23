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

        private void cyberButton3_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidStaff(txtbox_Username.Text, txtbox_Password.Text) == false)
            {
                MessageBox.Show("Invalid Username or Password!");
                return;
            }
            else
            {
                this.Hide();
                form_Employee staff = new form_Employee();
                staff.Show();
            }
        }
    }
}
