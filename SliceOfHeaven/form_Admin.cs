
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
    public partial class form_Admin : Form
    {
        public form_Admin()
        {
            InitializeComponent();
        }

        // To Access Form Admin
        static form_Admin _obj;

        public static form_Admin Instance
        {
            get { if (_obj == null) { _obj = new form_Admin(); } return _obj; }
        }

        form_CategoryView view = new form_CategoryView();

        private void form_Admin_Load(object sender, EventArgs e)
        {
            string DisplayAdmin = MainClass.ADMIN;
            lbl_User.Text = $"{DisplayAdmin}!";
            
            _obj = this;
        }

        public void AddControls(Form f)
        {
            panel_Center.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panel_Center.Controls.Add(f);
            f.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            AddControls(new form_Home());
        }

        private void lbl_User_Click(object sender, EventArgs e)
        {

        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            AddControls(new form_TableView());
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void metroControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void panel_Center_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddControls(new form_CategoryView());
        }

        private void btn_share_Click(object sender, EventArgs e)
        {
            AddControls(new form_StaffView());
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            AddControls(new form_ProductView());
        }

        form_POS pos = new form_POS();

        private void btn_customize_Click(object sender, EventArgs e)
        {
            form_POS.PreviousForm = this;
            form_POS pos = new form_POS();
            pos.Show();
            this.Hide();
        }
        form_KitchenView kitchen = new form_KitchenView();
        private void btn_account_Click(object sender, EventArgs e)
        {
            AddControls(kitchen);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
