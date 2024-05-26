using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SliceOfHeaven
{
    public partial class form_SignUpEmployee : Form
    {
        public form_SignUpEmployee()
        {
            InitializeComponent();
        }
        private void form_SignUpEmployee_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            this.Close();
            form_Admin admin = new form_Admin();
            admin.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtbox_Password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            string staffName = txtbox_Name.Text;
            string username = txtbox_Username.Text;
            string password = txtbox_Password.Text;
            string phone = txtbox_Phone.Text;
            string address = txtbox_Address.Text;

            if (MainClass.IsStaffNameExist(staffName))
            {
                MainClass.RegisterNewStaff(staffName, phone, address, username, password);
                MessageBox.Show("Registration successful!");
            }
            else
            {
                MessageBox.Show("Staff name does not exist. Try Again.");
            }
        }
    }    
 }
