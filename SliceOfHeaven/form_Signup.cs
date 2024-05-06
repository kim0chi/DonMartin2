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

namespace SliceOfHeaven
{
    public partial class form_Signup : Form
    {
        public form_Signup()
        {
            InitializeComponent();
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        public void btn_Signup_Click(object sender, EventArgs e)
        {
            MainClass.Register(txtbox_Username.Text , txtbox_Name.Text, txtbox_Password.Text, txtbox_Phone.Text, txtbox_Email.Text);
            MessageBox.Show("Registered Successfully!");
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

    }
}


