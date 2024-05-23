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
    public partial class form_AdminLogin : Form
    {
        public form_AdminLogin()
        {
            InitializeComponent();
        }

        private void cyberButton3_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidAdmin(txtbox_Username.Text, txtbox_Password.Text) == false)
            {
                MessageBox.Show("Invalid Username or Password!");
                return;
            }
            if (DoesAnyTextBoxContainSpaces())
            {
                MessageBox.Show("Fields cannot contain spaces", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Hide();
                form_Admin admin = new form_Admin();
                admin.Show();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_chooseLogin choose = new form_chooseLogin();
            choose.Show();
        }

        private void form_AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtbox_Password.PasswordChar = checkBox1.Checked ? '\0' : '*';
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
