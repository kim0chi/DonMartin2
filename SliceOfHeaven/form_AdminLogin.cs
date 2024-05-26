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
    public partial class form_AdminLogin : Form
    {
        public string username = "";
        public string password = "";
        public string AdminName { get; set; }
        public int AdminID { get; set; } 

        public form_AdminLogin()
        {
            InitializeComponent();
            username = txtbox_Username.Text;
            password = txtbox_Password.Text;
        }
        public bool Login(string username, string password)
        {
            username = txtbox_Username.Text;
            password = txtbox_Password.Text;

            DataRow adminRow;

            if (MainClass.IsValidAdmin(username, password, out adminRow))
            {
                if (adminRow != null)
                {
                    this.AdminName = adminRow["aName"].ToString();
                    this.AdminID = (int)adminRow["adminID"];
                    return true;
                }
            }

            return false;
        }

        private void cyberButton3_Click(object sender, EventArgs e)
        {

            if (!Login(username, password))
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
