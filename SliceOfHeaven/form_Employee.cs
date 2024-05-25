using SliceOfHeaven.Model;
using SliceOfHeaven.View;
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
    public partial class form_Employee : Form
    {
        form_TableView table = new form_TableView();
        public form_Employee()
        {
            InitializeComponent();
        }

        private void form_Employee_Load(object sender, EventArgs e)
        {
            lbl_User.Text = MainClass.STAFF;
        }

        public void AddControls(Form f)
        {
            panel_CenterScreen.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panel_CenterScreen.Controls.Add(f);
            f.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            AddControls(new form_TableView());
        }

        private void lbl_User_Click(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            AddControls(new form_TableView());
        }
        form_POS pos = new form_POS();
        private void btn_customize_Click(object sender, EventArgs e)
        {
            form_POS.PreviousForm = this;
            form_POS pos = new form_POS();
            pos.Show();
            this.Hide();
        }
    }
}
