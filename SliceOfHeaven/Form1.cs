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
            /*if (MainClass.IsValidUser(txtbox_Username.Text, txtbox_Password.Text) == false)
            {
                MessageBox.Show("Invalid Username or Password!","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsAnyTextBoxEmpty())
            {
                MessageBox.Show("All fields must be filled out", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Sign In successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }*/
            this.Hide();
            form_Main main = new form_Main();
            main.Show();
        }

        private void cyberButton2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Invalid Username or Password!");
                return;
            }
            else
            {
                
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
            string user = txtbox_Username.Text;
            string pass = txtbox_Password.Text;
            MainClass main = new MainClass();

            if (main.IsValidStaff(user, pass, out DataRow userDetails))
            {
                MessageBox.Show("Login successful!");

                string staffID = userDetails["staffID"].ToString();
                string staffName = userDetails["staffName"].ToString();
                this.Hide();
                form_Employee staff = new form_Employee();
                staff.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void metroControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtbox_Password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_chooseLogin choose = new form_chooseLogin();
            choose.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool IsAnyTextBoxEmpty()
        {
            var textBoxes = this.Controls.OfType<TextBox>();

            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
