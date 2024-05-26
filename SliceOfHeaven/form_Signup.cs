using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SliceOfHeaven
{
    public partial class form_Signup : Form
    {
        private const int MaxLengthForPhone = 11;
        public form_Signup()
        {
            InitializeComponent();
            txtbox_Name.KeyPress += new KeyPressEventHandler(txtbox_Name_KeyPress);
            txtbox_Phone.KeyPress += new KeyPressEventHandler(txtbox_Phone_KeyPress);
            txtbox_Password.KeyPress += new KeyPressEventHandler(txtbox_Password_KeyPress);
            txtbox_Email.Validating += new System.ComponentModel.CancelEventHandler(txtbox_Email_Validating);
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        public void btn_Signup_Click(object sender, EventArgs e)
        {
            /*if (IsEmailValid(txtbox_Email.Text))
            {
                MessageBox.Show("Please enter an email address from Gmail, Yahoo, Outlook, or Hotmail.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/
            if (MainClass.IsDuplicateName(txtbox_Name.Text))
            {
                MessageBox.Show("User already exists!");
                return;
            }
            if (MainClass.IsDuplicateUser(txtbox_Username.Text, txtbox_Phone.Text, txtbox_Email.Text))
            {
                MessageBox.Show("User already exists!");
                return;
            }
            if (IsAnyTextBoxEmpty())
            {
                MessageBox.Show("All fields must be filled out", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DoesAnyTextBoxContainSpaces())
            {
                MessageBox.Show("Fields cannot contain spaces", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            MainClass.Register(txtbox_Username.Text , txtbox_Name.Text, txtbox_Password.Text, txtbox_Phone.Text, txtbox_Email.Text);
            MessageBox.Show("Registered Successfully!");
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void form_Signup_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtbox_Password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private bool IsAnyTextBoxEmpty()
        {
            var textBoxes = this.Controls.OfType<System.Windows.Forms.TextBox>();

            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private void txtbox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Please enter only digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

        }
        private void txtbox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Please enter only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txtbox_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Please enter only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtbox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtbox_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private List<string> allowedDomains = new List<string>
        {
        "@gmail.com",
        "@yahoo.com",
        "@outlook.com",
        "@hotmail.com"
        };

        private void txtbox_Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsEmailValid(txtbox_Email.Text))
            {
                
            }
        }
        private bool IsEmailValid(string email)
        {
            return allowedDomains.Any(domain => email.EndsWith(domain, StringComparison.OrdinalIgnoreCase));
        }

        private bool DoesAnyTextBoxContainSpaces()
        {
            var textBoxes = this.Controls.OfType<System.Windows.Forms.TextBox>();

            foreach (var textBox in textBoxes)
            {
                if (textBox.Text.Contains(" "))
                {
                    return true;
                }
            }

            return false;
        }
    }
}


