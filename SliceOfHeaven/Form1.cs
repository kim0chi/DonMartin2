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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cyberButton3_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(txtbox_Username.Text, txtbox_Password.Text) == false)
            {
                MessageBox.Show("Invalid Username or Password!");
                return;
            }
            else
            {
                this.Hide();
                form_Main main = new form_Main();
                main.Show();
            }
        }

        private void cyberButton2_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidAdmin(txtbox_Username.Text, txtbox_Password.Text) == false)
            {
                MessageBox.Show("Invalid Username or Password!");
                return;
            }
            else
            {
                this.Hide();
                form_Admin admin = new form_Admin();
                admin.Show();
            }
        }

        private void cyberButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_Signup signup = new form_Signup();
            signup.Show();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
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

        private void metroControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtbox_Password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
