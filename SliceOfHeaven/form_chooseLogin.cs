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
    public partial class form_chooseLogin : Form
    {
        public form_chooseLogin()
        {
            InitializeComponent();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_EmployeeLogin staff = new form_EmployeeLogin();
            staff.Show();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_AdminLogin admin = new form_AdminLogin();
            admin.Show();
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
